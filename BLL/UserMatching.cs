using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Models;

namespace BLL
{
    public class UserMatching
    {
        private readonly GTService _gtService;

        private Dictionary<string, double> PreferenceWeights = new Dictionary<string, double>
        {
            { "Fun", 1.0 },
            { "Competitive", 0.8 },
            { "Serious", 0.6 },
            { "Communication", 0.4 },
            { "Dedication", 0.2 }
        };

        public UserMatching(GTService gtService)
        {
            _gtService = gtService;
        }

        public List<ProfileInfo> FindMatches(int currentUserId)
        {
            List<ProfileInfo> potentialMatches = new List<ProfileInfo>();

            // Retrieve the profile of the current user
            ProfileInfo currentUserProfile = _gtService.RetrieveProfile(currentUserId);

            if (currentUserProfile == null)
            {
                // Handle the case where the current user's profile is not found
                // You may want to display an error message or take appropriate action
                return potentialMatches;
            }

            // Retrieve all profiles
            List<ProfileInfo> allProfiles = _gtService.GetAllProfiles(); // You need to implement this method in GTService or elsewhere

            // Calculate similarity scores for all profiles
            Dictionary<ProfileInfo, double> similarityScores = new Dictionary<ProfileInfo, double>();

            foreach (ProfileInfo profile in allProfiles)
            {
                // Skip the current user's profile
                if (profile.UserID == currentUserId)
                {
                    continue;
                }

                // Check if region and platform match
                if (profile.Region != currentUserProfile.Region || profile.Platform != currentUserProfile.Platform)
                {
                    continue;
                }

                double similarityScore = CalculateSimilarity(currentUserProfile, profile);
                similarityScores.Add(profile, similarityScore);
            }

            // Sort profiles by similarity score and category difference in descending order
            var sortedProfiles = similarityScores.OrderByDescending(kv => kv.Value)
                                                 .ThenByDescending(kv => CalculateCategoryDifference(currentUserProfile, kv.Key));
            // Adjust the threshold as needed (lower values mean more profiles will be included)
            double similarityThreshold = 0.5;

            // Add profiles with similarity score above the threshold to potential matches
            foreach (var kvp in sortedProfiles)
            {
                if (kvp.Value > similarityThreshold)
                {
                    potentialMatches.Add(kvp.Key);
                }
            }


            return potentialMatches;
        }

        private double CalculateCategoryDifference(ProfileInfo profile1, ProfileInfo profile2)
        {
            double categoryDifference = 0;

            foreach (var preference in profile1.GetType().GetProperties())
            {
                if (preference.PropertyType == typeof(int) && PreferenceWeights.ContainsKey(preference.Name))
                {
                    int value1 = (int)preference.GetValue(profile1);
                    int value2 = (int)preference.GetValue(profile2);

                    // Check if the preferences differ by one
                    if (Math.Abs(value1 - value2) == 1)
                    {
                        categoryDifference += PreferenceWeights[preference.Name];
                    }
                }
            }

            return categoryDifference;
        }


        private double CalculateSimilarity(ProfileInfo profile1, ProfileInfo profile2)
        {
            int matchingPreferences = 0;
            int totalPreferences = 0;

            foreach (var preference in profile1.GetType().GetProperties())
            {
                if (preference.PropertyType == typeof(int) && PreferenceWeights.ContainsKey(preference.Name))
                {
                    int value1 = (int)preference.GetValue(profile1);
                    int value2 = (int)preference.GetValue(profile2);

                    // Check if the preferences match
                    if (value1 == value2)
                    {
                        matchingPreferences++;
                    }

                    totalPreferences++;
                }
            }

            // Calculate similarity based on the number of matching preferences
            return (double)matchingPreferences / totalPreferences;
        }

    }
}
