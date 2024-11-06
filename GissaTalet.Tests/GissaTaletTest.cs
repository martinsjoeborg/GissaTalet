using Shouldly;

using GissaTalet.Core;

namespace GissaTalet.Tests;

public class UnitTest1
{
    [Fact]
    public void TestWordSelection()
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