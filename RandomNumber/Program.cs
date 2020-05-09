using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            UserScore scoreValue = new UserScore(new RandomNumberGeneartor());
            int userFinalScore = scoreValue.GetScore(7);
        }
    }

    public class UserScore
    {
        public IRandomNumber randomNum;


        public UserScore(IRandomNumber randumNum)
        {
            this.randomNum = randumNum;
        }
        public int GetScore(int userInput)
        {
            int userScore = 0;
            if(userInput > 0 && userInput < 9)
            {
                int randomValue = randomNum.GetRandomNumber();
                if(userInput == randomValue)
                {
                    userScore = 10;
                }
                else
                {
                    userScore = 0;
                }
            }
            return userScore;
        }
    }

    public interface IRandomNumber
    {
        int GetRandomNumber();
    }

    public class RandomNumberGeneartor : IRandomNumber
    {
        public int GetRandomNumber()
        {
            int randomNumber = new Random().Next(0,9);
            return randomNumber;
        }
    }
}
