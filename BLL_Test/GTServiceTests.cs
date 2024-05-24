using Xunit;
using Moq;
using BLL;
using BLL.IGTData;
using BLL.Models;
using System.Collections.Generic;

public class GTServiceTests
{
    private readonly Mock<IGTAccountData> mockAccountData;
    private readonly Mock<IGTProfileData> mockProfileData;
    private readonly Mock<IGTGamesData> mockGamesData;
    private readonly GTService gtService;

    public GTServiceTests()
    {
        mockAccountData = new Mock<IGTAccountData>();
        mockProfileData = new Mock<IGTProfileData>();
        mockGamesData = new Mock<IGTGamesData>();
        gtService = new GTService(mockAccountData.Object, mockProfileData.Object, mockGamesData.Object);
    }

    [Fact]
    public void CreateAccount_Test()
    {
        // Arrange
        mockAccountData.Setup(m => m.CreateAccount(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

        // Act
        var result = gtService.CreateAccount("email@example.com", "hashedPassword", "username");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void RetrieveProfile_Test()
    {
        // Arrange
        var expectedProfile = new ProfileInfo { UserID = 1, Username = "username", Bio = "bio" };
        mockProfileData.Setup(m => m.RetrieveProfile(It.IsAny<int>())).Returns(expectedProfile);

        // Act
        var result = gtService.RetrieveProfile(1);

        // Assert
        Assert.Equal(expectedProfile, result);
    }

    [Fact]
    public void SaveProfile_Test()
    {
        // Arrange
        mockProfileData.Setup(m => m.SaveProfile(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns(true);

        // Act
        var result = gtService.SaveProfile(1, "username", "bio", "region", "country", "platform", 5, 4, 3, 2, 1);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void DeleteProfile_Test()
    {
        // Arrange
        // Assuming you have a DeleteProfile method in IGTProfileData and GTService

        mockProfileData.Setup(m => m.DeleteProfile(It.IsAny<int>())).Returns(true);

        // Act
        var result = gtService.DeleteProfile(1);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void RetrieveGames_Test()
    {
        // Arrange
        var expectedGames = new List<string> { "Game1", "Game2" };
        mockGamesData.Setup(m => m.RetrieveGames()).Returns(expectedGames);

        // Act
        var result = gtService.RetrieveGames();

        // Assert
        Assert.Equal(expectedGames, result);
    }

    // Add more tests as needed for other CRUD operations and scenarios
}
