using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class MethodRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            //1
            output.AppendFormat("TimesThree({0}) = {1}\n", num1, Methods.TimesThree(num1));
            AnswerChecker.Answer1Method = Methods.TimesThree(num1);

            //2
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2,num3, Methods.AddNumbers(num1,num2,num3));
            AnswerChecker.Answer2Method = Methods.AddNumbers(num1, num2, num3);

            //3
            output.AppendFormat("IsEven({0}) = {1}\n", num1, Methods.IsEven(num1));
            AnswerChecker.Answer3Method = Methods.IsEven(num1);

            //4
            output.AppendFormat("Num2String({0}) = {1}\n", num1, Methods.Num2String(num1));
            AnswerChecker.Answer4Method = Methods.Num2String(num1);

            //5
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, Methods.InBetween(num1,num2,num3));
            AnswerChecker.Answer5Method = Methods.InBetween(num1, num2, num3);

            //6
            Person p = new Person { Name = "Jan" };
            Methods.ResetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n",p.Name == null);
            AnswerChecker.Answer6Method = p.Name == null;

            //return
            return output.ToString();
        }

    }
}
