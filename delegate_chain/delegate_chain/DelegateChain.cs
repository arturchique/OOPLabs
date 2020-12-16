using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace delegate_chain
{
    public class DelegateChain
    {
        public delegate void Handler(char letter);
        public static event Handler ChainWorks;

        public static void ReadText(string text)
        {
            char[] chArray = text.ToCharArray();

            foreach (var letter in chArray)
            {
                DelegateChain.ChainWorks(letter);
            }
        }

    } 

    public class Handlers
    {
        public static void RusCharHandler(char letter)
        {
            if (Regex.IsMatch(letter.ToString(), @"\p{IsCyrillic}"))
            {
                Console.WriteLine("Русский");
                return;
            }
            else
            {
                return;
            }
        }

        public static void EngCharHandler(char letter)
        {
            if (Regex.IsMatch(letter.ToString(), @"\p{IsBasicLatin}"))
            {
                Console.WriteLine("Латиница");
                return;
            }
            else
            {
                return;
            }
        }

        public static void IntCharHandler(char letter)
        {
            if (Char.IsDigit(letter))
            {
                Console.WriteLine("Цифра");
                return;
            }
            else
            {
                return;
            }
        }
    }
}
