using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Basic_Core_Programs
{
    public class VowelConsonants
    {
        public static void getVowelConsonents()
        {
            //variable
            char ch;
            //int i;

            Console.WriteLine("---check whether the input alphabet is a vowel or not---");
            Console.WriteLine("--------------------------------------------------------");

            //Taking Input as Alphabet
            Console.Write("Enter an Alphabet (A-Z or a-z) :- ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            //i = ch;

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;

                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }


        }
    }
}
