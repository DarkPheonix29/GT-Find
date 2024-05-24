using System.Collections.Generic;
using BLL;
using BLL.Models;
using Moq;
using Xunit;

public class UserMatchingTests
{
    private readonly Mock<GTService> _mockGTService;
    private readonly UserMatching _userMatching;

    public UserMatchingTests()
    {
        _mockGTService = new Mock<GTService>();
        _userMatching = new UserMatching(_mockGTService.Object);
    }

    [Fact]
    public void FindMatches()
    {
        // Arrange
        var currentUserProfile = new ProfileInfo
        {
            UserID = 1,
            Region = "Europe",
            Platform = "PC",
            Fun = 3,
            Competitive = 4,
            Serious = 5,
            Communication = 2,
            Dedication = 1
        };

        var allProfiles = new List<ProfileInfo>
        {
            new ProfileInfo
            {
                UserID = 2,
                Region = "Europe",
                Platform = "PC",
                Fun = 3,
                Competitive = 4,
                Serious = 5,
                Communication = 2,
                Dedication = 1
            },
            new ProfileInfo
            {
                UserID = 3,
                Region = "Europe",
                Platform = "PC",
                Fun = 4,
                Competitive = 3,
                Serious = 5,
                Communication = 2,
                Dedication = 1
            },
            new ProfileInfo
            {
                UserID = 4,
                Region = "North America",
                Platform = "Xbox",
                Fun = 3,
                Competitive = 4,
                Serious = 5,
                Communication = 2,
                Dedication = 1
            }
        };

        _mockGTService.Setup(s => s.RetrieveProfile(It.IsAny<int>())).Returns(currentUserProfile);
        _mockGTService.Setup(s => s.GetAllProfiles()).Returns(allProfiles);


        var matches = _userMatching.FindMatches(1);


        Assert.Equal(2, matches.Count); 
        Assert.Contains(matches, p => p.UserID == 2);
        Assert.Contains(matches, p => p.UserID == 3);
    }

    [Fact]
    public void FindMatch()
    {
        // based on region and platform
        var currentUserProfile = new ProfileInfo
        {
            UserID = 1,
            Region = "Europe",
            Platform = "PC"
        };

        var allProfiles = new List<ProfileInfo>
        {
            currentUserProfile,
            new ProfileInfo
            {
                UserID = 2,
                Region = "Europe",
                Platform = "PC"
            }
        };

        _mockGTService.Setup(s => s.RetrieveProfile(It.IsAny<int>())).Returns(currentUserProfile);
        _mockGTService.Setup(s => s.GetAllProfiles()).Returns(allProfiles);

        // Act
        var matches = _userMatching.FindMatches(1);

        // Assert
        Assert.Single(matches); // Should return 1 matching profile
        Assert.DoesNotContain(matches, p => p.UserID == 1);
    }

    [Fact]
    public void ReturnsNoMatch()
    {
        // because of different platform or region
        var currentUserProfile = new ProfileInfo
        {
            UserID = 1,
            Region = "Europe",
            Platform = "PC"
        };

        var allProfiles = new List<ProfileInfo>
        {
            new ProfileInfo
            {
                UserID = 2,
                Region = "North America",
                Platform = "PC"
            },
            new ProfileInfo
            {
                UserID = 3,
                Region = "Europe",
                Platform = "Xbox"
            }
        };

        _mockGTService.Setup(s => s.RetrieveProfile(It.IsAny<int>())).Returns(currentUserProfile);
        _mockGTService.Setup(s => s.GetAllProfiles()).Returns(allProfiles);

        // Act
        var matches = _userMatching.FindMatches(1);

        // Assert
        Assert.Empty(matches); // Should return no matching profiles
    }
}
