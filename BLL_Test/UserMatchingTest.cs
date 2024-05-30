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
        var currentUserProfile = new ProfileInfo(
            1,
            "username1",
            "bio1",
            "Europe",
<<<<<<< Updated upstream
            "Germany",
=======
            "country1",
>>>>>>> Stashed changes
            "PC",
            3,
            2,
            4,
            5,
            1
        );

        var otherProfiles = new List<ProfileInfo>
        {
<<<<<<< Updated upstream
            new ProfileInfo(2, "username2", "bio2", "Europe", "Germany", "PC", 3, 2, 4, 5, 1),
            new ProfileInfo(3, "username3", "bio3", "Europe", "Germany", "PC", 3, 2, 4, 5, 2)
=======
            new ProfileInfo(2, "username2", "bio2", "Europe", "country2", "PC", 3, 2, 4, 5, 1),
            new ProfileInfo(3, "username3", "bio3", "Europe", "country3", "PC", 3, 2, 4, 5, 2)
>>>>>>> Stashed changes
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
        var currentUserProfile = new ProfileInfo(
            1,
            "username1",
            "bio1",
            "Europe",
<<<<<<< Updated upstream
            "Germany",
=======
            "country1",
>>>>>>> Stashed changes
            "PC",
            3,
            2,
            4,
            5,
            1
        );

        var otherProfiles = new List<ProfileInfo>
        {
<<<<<<< Updated upstream
            new ProfileInfo(2, "username2", "bio2", "Asia", "China", "Playstation", 5, 5, 5, 5, 5)
=======
            new ProfileInfo(2, "username2", "bio2", "Asia", "country2", "PlayStation", 5, 5, 5, 5, 5)
>>>>>>> Stashed changes
        };

        mockGTService.Setup(service => service.RetrieveProfile(1)).Returns(currentUserProfile);
        mockGTService.Setup(service => service.GetAllProfiles()).Returns(otherProfiles);

        var userMatching = new UserMatching(mockGTService.Object);

        var matches = userMatching.FindMatches(1);

        Assert.Empty(matches);
    }
}
