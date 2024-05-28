using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Models;

namespace BLL
{
    public class UserMatching
    {
        private readonly IGTService _gtService;

        private Dictionary<string, double> PreferenceWeights = new Dictionary<string, double>
        {
            { "Fun", 1.0 },
            { "Competitive", 0.8 },
            { "Serious", 0.6 },
            { "Communication", 0.4 },
            { "Dedication", 0.2 }
        };

        public UserMatching(IGTService gtService)
        {
            _gtService = gtService;
        }

        public List<ProfileInfo> FindMatches(int currentUserId)
        {
            List<ProfileInfo> potentialMatches = new List<ProfileInfo>();


            ProfileInfo currentUserProfile = _gtService.RetrieveProfile(currentUserId);

            if (currentUserProfile == null)
            {
                return potentialMatches;
            }

            // Retrieve all profiles
            List<ProfileInfo> allProfiles = _gtService.GetAllProfiles();


            Dictionary<ProfileInfo, double> similarityScores = new Dictionary<ProfileInfo, double>();

            foreach (ProfileInfo profile in allProfiles)
            {
                if (profile.UserID == currentUserId)
                {
                    continue;
                }
                if (profile.Region != currentUserProfile.Region || profile.Platform != currentUserProfile.Platform)
                {
                    continue;
                }

                double similarityScore = CalculateSimilarity(currentUserProfile, profile);
                similarityScores.Add(profile, similarityScore);
            }

            var sortedProfiles = similarityScores.OrderByDescending(kv => kv.Value)
                                                 .ThenByDescending(kv => CalculateCategoryDifference(currentUserProfile, kv.Key));
            double similarityThreshold = 0.5;

  
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


                    if (value1 == value2)
                    {
                        matchingPreferences++;
                    }

                    totalPreferences++;
                }
            }


            return (double)matchingPreferences / totalPreferences;
        }

    }
}
