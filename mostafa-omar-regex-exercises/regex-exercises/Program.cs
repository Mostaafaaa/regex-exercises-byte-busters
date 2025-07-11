using System;

namespace regex_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter your phone number: ");
            //string UserInput = Console.ReadLine();

            //Console.WriteLine(RegecFunctions.MatchAllPhoneNumberInLocalFormat(UserInput));

            //Console.Write("Enter your Email Address: ");
            //string UserInput = Console.ReadLine();

            //Console.WriteLine(RegecFunctions.MatchAllEmailAddress(UserInput));

            //Console.Write("Enter words: ");
            //string UserInput = Console.ReadLine();
            //RegecFunctions.MatchAnyWordStartWithCapitalLetter(UserInput);

            ;
            string UserInput = "I have 2 cats and 10 chickens.";
            RegecFunctions.MatchAllNumbers(UserInput);

            UserInput = "#blessed #codingLife";
            RegecFunctions.MatchAllHashtags(UserInput);

        }

}
}

