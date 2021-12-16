using System;
using System.Collections.Generic;



namespace Vijener_DZ
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your phrase please: ");
            Console.WriteLine();
            string you_phrase = Lists_Vigener.Check_Phrase(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter your key please: ");
            Console.WriteLine();
            string key = Lists_Vigener.Check_Phrase(Console.ReadLine());
            int count = 0;
            if (key.Length < you_phrase.Length)
            {
                for (int i = key.Length; i < you_phrase.Length; i++)
                {

                    key += key[count];
                    count++;
                }
            }
            if (key.Length > you_phrase.Length)
            {
                key = key.Substring(0, you_phrase.Length);
            }
            string outcome_phrase =Lists_Vigener.Coder_Vigener(you_phrase, key);
            Console.WriteLine();
            Console.WriteLine($"Your coder phrase is:\t {outcome_phrase}\n ");
            Console.WriteLine($"Your decoder phrase is:\t {Lists_Vigener.Decoder_Vigenere(outcome_phrase, key)}\n");
            
        }

    }
}
