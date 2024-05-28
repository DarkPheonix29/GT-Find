﻿using Xunit;
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
    public void SaveProfile_EmptyBio_ReturnsArgumentNullExceptionTest()
    {
        // Arrange
        mockProfileData.Setup(m => m.SaveProfile(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns(true);

        // Act
        var result = gtService.SaveProfile(1, "username", "bio", "region", "", "platform", 5, 4, 3, 2, 1);

        // Assert
        Assert.Throws<System.ArgumentNullException>(() => result);
    }

    [Fact]
    public void DeleteProfile_Test()
    {
        // Arrange
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

    [Fact]
    public void SaveUserGames_Test()
    {
        // Arrange
        mockGamesData.Setup(m => m.SaveUserGames(It.IsAny<int>(), It.IsAny<List<string>>())).Returns(true);

        // Act
        var result = gtService.SaveUserGames(1, new List<string> { "Game1", "Game2" });

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void RetrievePass_Test()
    {
        // Arrange
        var expectedPassword = "hashedPassword";
        mockAccountData.Setup(m => m.RetrievePass(It.IsAny<string>())).Returns(expectedPassword);

        // Act
        var result = gtService.RetrievePass("username");

        // Assert
        Assert.Equal(expectedPassword, result);
    }

    [Fact]
    public void RetrieveUserId_Test()
    {
        // Arrange
        var expectedUserId = 1;
        mockAccountData.Setup(m => m.RetrieveUserId(It.IsAny<string>())).Returns(expectedUserId);

        // Act
        var result = gtService.RetrieveUserId("username");

        // Assert
        Assert.Equal(expectedUserId, result);
    }

    [Fact]
    public void GetUserGames_Test()
    {
        // Arrange
        var expectedUserGames = new List<string> { "Game1", "Game2" };
        mockGamesData.Setup(m => m.GetUserGames(It.IsAny<int>())).Returns(expectedUserGames);

        // Act
        var result = gtService.GetUserGames(1);

        // Assert
        Assert.Equal(expectedUserGames, result);
    }

    [Fact]
    public void GetAllProfiles_Test()
    {
        // Arrange
        var expectedProfiles = new List<ProfileInfo>
        {
            new ProfileInfo { UserID = 1, Username = "user1", Bio = "bio1" },
            new ProfileInfo { UserID = 2, Username = "user2", Bio = "bio2" }
        };
        mockProfileData.Setup(m => m.GetAllProfiles()).Returns(expectedProfiles);

        // Act
        var result = gtService.GetAllProfiles();

        // Assert
        Assert.Equal(expectedProfiles, result);
    }

    [Fact]
    public void GetServiceDetails_Test()
    {
        // Act
        var result = gtService.GetServiceDetails();

        // Assert
        Assert.Equal("Service Details", result);
    }
}
