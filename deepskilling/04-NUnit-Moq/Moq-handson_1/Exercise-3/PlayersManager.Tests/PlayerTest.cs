using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayersManager.Tests;

[TestFixture]
public class PlayerTest
{
    private Mock<IPlayerMapper> mockPlayer;

    [OneTimeSetUp]
    public void Init()
    {
        mockPlayer = new Mock<IPlayerMapper>();
    }

    [Test]
    public void RegisterPlayerTest()
    {
        mockPlayer.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>()))
                  .Returns(false);

        Player player =
            Player.RegisterNewPlayer("Virat", mockPlayer.Object);

        Assert.That(player.Name, Is.EqualTo("Virat"));
        Assert.That(player.Age, Is.EqualTo(23));
        Assert.That(player.Country, Is.EqualTo("India"));
        Assert.That(player.NoOfMatches, Is.EqualTo(30));
    }
}