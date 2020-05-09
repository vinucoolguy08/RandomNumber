using NUnit.Framework;
using Moq;


namespace RandomNumber.Test
{
    public class RandomNumberTest
    {
        [Test]
        public void RandomNumberGeneration_UserInput_Matches_SystemGeneratedNumber_ReturnScore10()
        {
            //Arrange
            Mock<IRandomNumber> mockedNumber = new Mock<IRandomNumber>();
            mockedNumber.Setup(x => x.GetRandomNumber()).Returns(7);
            UserScore scoreValue = new UserScore(mockedNumber.Object);

            //Act
            var userFinalScore = scoreValue.GetScore(7);

            //Assert
            Assert.AreEqual(userFinalScore, 10);
        }

        [Test]
        public void RandomNumberGeneration_UserInput_Doesnot_MatchesSystemGeneratedNumber_ReturnScore10()
        {
            //Arrange
            Mock<IRandomNumber> mockedNumber = new Mock<IRandomNumber>();
            mockedNumber.Setup(x => x.GetRandomNumber()).Returns(6);
            UserScore scoreValue = new UserScore(mockedNumber.Object);

            //Act
            var userFinalScore = scoreValue.GetScore(7);

            //Assert
            Assert.AreNotEqual(userFinalScore, 10);
            Assert.AreEqual(userFinalScore, 0);
        }


    }
}