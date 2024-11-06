using Shouldly;

using GissaTalet.Core;

namespace GissaTalet.Tests;

public class UnitTest1
{
    [Fact]
    public void TestWordSelection()
    {
<<<<<<< HEAD
        // Arrange
=======
        // Arrange  
        var game = new Core.GissaTalet();
>>>>>>> b6056be8c95df169e770b035c1a13da7c59f83ec

        int secretnumber = 50;

        //Act

<<<<<<< HEAD
        // Assert
=======
        //Assert
        game.HandleGuess(50, secretnumber);

        game.isGameOver.ShouldBeTrue();
>>>>>>> b6056be8c95df169e770b035c1a13da7c59f83ec
        
    }

}