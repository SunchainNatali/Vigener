using System;
using System.Collections.Generic;

namespace Vijener_DZ
{
    class Lists_Vigener
    {
        public static Dictionary<int, char> listVigener = new Dictionary<int, char>
        {
            {0, 'a' },
            {1, 'b' },
            {2, 'c' },
            {3, 'd' },
            {4, 'e' },
            {5, 'f' },
            {6, 'g' },
            {7, 'h' },
            {8, 'i' },
            {9, 'j' },
            {10, 'k' },
            {11, 'l' },
            {12, 'm' },
            {13, 'n' },
            {14, 'o' },
            {15, 'p' },
            {16, 'q' },
            {17, 'r' },
            {18, 's' },
            {19, 't' },
            {20, 'u' },
            {21, 'v' },
            {22, 'w' },
            {23, 'x' },
            {24, 'y' },
            {25, 'z' }
        };

        public static Dictionary<char, int> revers_listVigener = new Dictionary<char, int>
        {
            {'a',  0 },
            {'b',  1 },
            {'c',  2 },
            {'d',  3 },
            {'e',  4 },
            {'f',  5 },
            {'g',  6 },
            {'h',  7 },
            {'i',  8 },
            { 'j', 9 },
            { 'k', 10},
            { 'l', 11},
            { 'm', 12},
            { 'n', 13},
            { 'o', 14},
            { 'p', 15},
            { 'q', 16},
            { 'r', 17},
            { 's', 18},
            { 't', 19},
            { 'u', 20},
            { 'v', 21},
            { 'w', 22},
            { 'x', 23},
            { 'y', 24},
            { 'z', 25}
        };

        public static string Check_Phrase(string phrase)
        {
            int counter_Error;
            do
            {
                counter_Error = 0;
                foreach (char charic in phrase)
                {
                    if (!Char.IsLetter(charic))
                    {
                        counter_Error++;
                    }
                }
                if (counter_Error > 0)
                {
                    Console.WriteLine("The string only accepts letters, enter again please: ");
                    phrase = Console.ReadLine();
                }
            } while (counter_Error > 0);
            return phrase.ToLower();

        }


        public static string Coder_Vigener(string item, string key)
        {

            string outcome = "";

            for (int i = 0; i < item.Length; i++)
            {
                int code_key = Lists_Vigener.revers_listVigener[item[i]] + Lists_Vigener.revers_listVigener[key[i]];
                if (code_key > 25)
                {
                    code_key -= 26;
                }
                outcome += Lists_Vigener.listVigener[code_key];
            }
            return outcome;
        }


        public static string Decoder_Vigenere(string item, string key)
        {

            string outcome = "";
            for (int i = 0; i < item.Length; i++)
            {

                int decoder_number = (Lists_Vigener.revers_listVigener[item[i]] - Lists_Vigener.revers_listVigener[key[i]]) + 26;
                if (decoder_number > 25)
                {
                    decoder_number -= 26;
                }
                outcome += Lists_Vigener.listVigener[decoder_number];

            }
            return outcome;
        }


    }
}
