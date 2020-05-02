using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class AnswerChecker
    {
        //1
        public static int Answer1Method { private get;  set; }
        public static int Answer1Lambda { private get; set; }

        //2
        public static int Answer2Method { private get; set; }
        public static int Answer2Lambda { private get; set; }

        //3
        public static bool Answer3Method { private get; set; }
        public static bool Answer3Lambda { private get; set; }

        //4
        public static string Answer4Method { private get; set; }
        public static string Answer4Lambda { private get; set; }

        //5
        public static bool Answer5Method { private get; set; }
        public static bool Answer5Lambda { private get; set; }

        //6
        public static bool Answer6Method { private get; set; }
        public static bool Answer6Lambda { private get; set; }

        public static String CheckAnswers()
        {
            bool answersValid = true;

            if (!Answer1Method.Equals(Answer1Lambda))
            {
                answersValid = false;
            }

            if (!Answer2Method.Equals(Answer2Lambda))
            {
                answersValid = false;
            }

            if (!Answer3Method.Equals(Answer3Lambda))
            {
                answersValid = false;
            }

            if (!Answer4Method.Equals(Answer4Lambda))
            {
                answersValid = false;
            }

            if (!Answer5Method.Equals(Answer5Lambda))
            {
                answersValid = false;
            }

            if (!Answer6Method.Equals(Answer6Lambda))
            {
                answersValid = false;
            }

            string result = "Alle expressies werken naar behoren.";

            if (!answersValid)
            {
                result = "Alle expressies werken NIET naar behoren!";
            }

            return result;
        }
    }
}
