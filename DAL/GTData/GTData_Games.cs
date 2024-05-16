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

                    // Log the selected games
                    Debug.WriteLine("Selected Games:");
                    foreach (string game in selectedGames)
                    {
                        Debug.WriteLine(game);
                    }

                    // Delete existing user games outside of the loop
                    string deleteQuery = "DELETE FROM UserGames WHERE UserId = @userId";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@userId", userId);
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
                        string insertQuery = "INSERT INTO UserGames (UserId, GameID) VALUES (@userId, @gameId)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@userId", userId);
                        insertCommand.Parameters.AddWithValue("@gameId", gameId);
                        insertCommand.ExecuteNonQuery();
                    }

                    // Log successful saving of user games
                    Debug.WriteLine("User games saved successfully.");
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred while saving user games: {ex.Message}");
                return false;
            }
        }

    }
}

