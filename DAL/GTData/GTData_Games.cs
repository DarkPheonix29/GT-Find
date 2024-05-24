using BLL.IGTData;
using BLL.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace DAL
{
    public class GTData_Games : IGTGamesData
    {

        public List<string> RetrieveGames()
        {
            List<string> games = new List<string>();

            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT GameName FROM Games";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string gameName = reader.GetString("GameName");
                            games.Add(gameName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while retrieving games: {ex.Message}");
            }

            return games;
        }

        public bool SaveUserGames(int userId, List<string> selectedGames)
        {
            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();

                    // Verify the user exists in the account table
                    string verifyUserQuery = "SELECT COUNT(*) FROM account WHERE UserID = @UserId";
                    MySqlCommand verifyUserCommand = new MySqlCommand(verifyUserQuery, connection);
                    verifyUserCommand.Parameters.AddWithValue("@UserId", userId);
                    int userExists = Convert.ToInt32(verifyUserCommand.ExecuteScalar());

                    if (userExists == 0)
                    {
                        Debug.WriteLine("User does not exist in the account table.");
                        return false;
                    }

                    // Log the selected games
                    Debug.WriteLine("Selected Games:");
                    foreach (string game in selectedGames)
                    {
                        Debug.WriteLine(game);
                    }

                    // Delete existing user games outside of the loop
                    string deleteQuery = "DELETE FROM UserGames WHERE UserId = @UserId";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@UserId", userId);
                    deleteCommand.ExecuteNonQuery();

                    // Insert new user games
                    foreach (string game in selectedGames)
                    {
                        // Retrieve the GameID for the selected game
                        string gameIdQuery = "SELECT GameID FROM Games WHERE GameName = @gameName";
                        MySqlCommand gameIdCommand = new MySqlCommand(gameIdQuery, connection);
                        gameIdCommand.Parameters.AddWithValue("@gameName", game);
                        int gameId = Convert.ToInt32(gameIdCommand.ExecuteScalar());

                        // Insert the UserGame record with the retrieved GameID
                        string insertQuery = "INSERT INTO UserGames (UserId, GameID) VALUES (@UserId, @gameId)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@UserId", userId);
                        insertCommand.Parameters.AddWithValue("@gameId", gameId);
                        insertCommand.ExecuteNonQuery();
                    }

                    // Log successful saving of user games
                    Debug.WriteLine($"User games saved successfully for UserID: {userId}.");
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while saving user games: {ex.Message}");
                return false;
            }
        }


        public List<string> GetUserGames(int userId)
        {
            List<string> userGames = new List<string>();

            try
            {
                using (MySqlConnection connection = ConnectionString.GetConnection())
                {
                    connection.Open();
                    string query = @"
                        SELECT Games.GameName 
                        FROM UserGames
                        JOIN Games ON UserGames.GameID = Games.GameID
                        WHERE UserGames.UserID = @UserId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userGames.Add(reader.GetString("GameName"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while retrieving user games: {ex.Message}");
            }

            return userGames;
        }

    }
}

