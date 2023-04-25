using System;

namespace Caesar
{
    class CaesarCipher
    {
        public static void Main(string[] args)
        {
            string plainText = "";
            Console.WriteLine("Welcome to the Caesar Cipher creator!");
            Console.Write("Enter the text you would like to encrypt: ");
            plainText = Console.ReadLine();

            Console.Write("How many letters would you like to shift by: ");
            int shiftLetterAmount = Convert.ToInt32(Console.ReadLine());

            foreach (char c in plainText)
            {
                if (c == ' ')
                {
                    Console.Write(" ");
                }
                else
                {
                    char letter = c;
                    if (letter > ('Z' - shiftLetterAmount) && letter <= 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter > ('z' - shiftLetterAmount) && letter <= 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    //if (letter >= 'X' && letter <= 'Z')
                    //{
                    //    letter = (char)(letter - 26);
                    //}
                    //else if (letter >= 'x' && letter <= 'z')
                    //{
                    //    letter = (char)(letter - 26);
                    //}

                    Console.Write($"{(char)(letter + shiftLetterAmount)}");
                }
            }
        }
    }
}
