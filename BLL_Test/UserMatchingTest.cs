using System.Collections.Generic;
using BLL;
using BLL.Models;
using Moq;
using Xunit;

public class UserMatchingTests
{
    [Fact]
    public void FindMatches()
    {
        var mockGTService = new Mock<IGTService>();
        var currentUserProfile = new ProfileInfo
        {
            UserID = 1,
            Region = "Europe",
            Platform = "PC",
            Fun = 3,
            Competitive = 2,
            Serious = 4,
            Communication = 5,
            Dedication = 1
        };

        var otherProfiles = new List<ProfileInfo>
        {
            new ProfileInfo { UserID = 2, Region = "Europe", Platform = "PC", Fun = 3, Competitive = 2, Serious = 4, Communication = 5, Dedication = 1 },
            new ProfileInfo { UserID = 3, Region = "Europe", Platform = "PC", Fun = 3, Competitive = 2, Serious = 4, Communication = 5, Dedication = 2 }
        };

        mockGTService.Setup(service => service.RetrieveProfile(1)).Returns(currentUserProfile);
        mockGTService.Setup(service => service.GetAllProfiles()).Returns(otherProfiles);

        var userMatching = new UserMatching(mockGTService.Object);

        var matches = userMatching.FindMatches(1);

        Assert.Equal(2, matches.Count);
        Assert.Equal(2, matches[0].UserID); // Best match should come first
    }

    [Fact]
    public void ReturnsNoMatches()
    {
        var mockGTService = new Mock<IGTService>();
        var currentUserProfile = new ProfileInfo
        {
            UserID = 1,
            Region = "Europe",
            Platform = "PC",
            Fun = 3,
            Competitive = 2,
            Serious = 4,
            Communication = 5,
            Dedication = 1
        };

        var otherProfiles = new List<ProfileInfo>
        {
            new ProfileInfo { UserID = 2, Region = "Asia", Platform = "PlayStation", Fun = 5, Competitive = 5, Serious = 5, Communication = 5, Dedication = 5 }
        };

        mockGTService.Setup(service => service.RetrieveProfile(1)).Returns(currentUserProfile);
        mockGTService.Setup(service => service.GetAllProfiles()).Returns(otherProfiles);

        var userMatching = new UserMatching(mockGTService.Object);

        var matches = userMatching.FindMatches(1);

        Assert.Empty(matches);
    }
}
