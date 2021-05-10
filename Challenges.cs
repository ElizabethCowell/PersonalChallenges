using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalChallenges
{
    public class Challenges
    {
        public bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public int FindAverage(int x, int y, int z)
        {
            return (x + y + z) / 3;
        }

        public bool ContainsThe(string word)
        {
            return word.Contains("the");
        }

        public bool password(string password)
        {
            return (password.Length >= 8 &&
            password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsDigit));        
        }
        
        public string mealPlanning(string DayOfTheWeek)
        {
            switch (DayOfTheWeek)
            {
                case "Monday":
                        return "Meatless Monday";
                case "Tuesday":
                    return "Taco Tuesday";
                case "Wednesday":
                    return "Italian Wednesday";
                case "Thursday":
                    return "Curry Thursday";
                case "Friday":
                    return "Stir-Friday";
                default:
                    return "Leftovers";
            }
        }
    }
}
