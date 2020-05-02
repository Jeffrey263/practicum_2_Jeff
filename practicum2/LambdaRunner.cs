using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            // 1
            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("x => 3 * x, met x={0} = {1}\n", num1, timesThree(num1));
            AnswerChecker.Answer1Lambda = timesThree(num1);

            //2
            Func<int, int, int, int> AddNumbers = (x,y,z) =>  x + y + z;
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2, num3, AddNumbers(num1, num2, num3));
            AnswerChecker.Answer2Lambda = AddNumbers(num1, num2, num3);

            //3
            Func<int, bool> IsEven = x => x % 2 == 0;
            output.AppendFormat("IsEven({0}) = {1}\n", num1, IsEven(num1));
            AnswerChecker.Answer3Lambda = IsEven(num1);

            //4
            Func<int, string> Num2String = x =>
            {
                switch (x)
                {
                    case 0:
                        return "zero"; break;
                    case 1:
                        return "one"; break;
                    case 2:
                        return "two"; break;
                    case 3:
                        return "three"; break;
                    case 4:
                        return "four"; break;
                    case 5:
                        return "five"; break;
                    case 6:
                        return "six"; break;
                    case 7:
                        return "seven"; break;
                    case 8:
                        return "eight"; break;
                    case 9:
                        return "nine"; break;
                    default:
                        return "undefined"; break;
                }
            };
            output.AppendFormat("Num2String({0}) = {1}\n", num1, Num2String(num1));
            AnswerChecker.Answer4Lambda = Num2String(num1);

            //5
            Func<int, int, int, bool> InBetween = (x, y, z) => (x < y && y < z) || (z < y && y < x);
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, InBetween(num1, num2, num3));
            AnswerChecker.Answer5Lambda = InBetween(num1, num2, num3);

            //6
            Person p = new Person { Name = "Jan" };
            Action<Person> ResetName = person => person.Name = null;
            ResetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n", p.Name == null);
            AnswerChecker.Answer6Lambda = p.Name == null;

            //return
            return output.ToString();
        }

    }
}
