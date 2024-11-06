using Shouldly;

namespace GissaTalet.Tests;

public class UnitTest1
{
    [Fact]
    public void TestValidnumbers()
    {
        // Arrange  
        var game = new Core.GissaTalet();

        int secretnumber = 50;

        //Act

        //Assert
        game.HandleGuess(50, secretnumber);

        game.isGameOver.ShouldBeTrue();
    }
}