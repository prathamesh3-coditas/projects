using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2807
{


     public static class StringOp
    {

        public static void SpecialChars (this String str)
        {
            String chars = " abcdefghijklmnopqrstuvwxyz1234567890";
            String temp = str.ToLower();

           int count = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (!chars.Contains(temp[i].ToString()))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of special chars are:");
            Console.WriteLine(count);

        }

        public static void UpperCase(this String str)
        {
            String[] str1 = str.Split(' ');

            String sample;
            foreach (String s in str1)
            {
                sample = String.Empty;

                if (Char.IsLetter(s[0]) && (int)s[0] >= 97 && (int)s[0] <= 122)
                {
                    int a = s[0] - 32;
                    char c = (char)a;

                    sample = sample + c;

                    for (int i = 1; i < s.Length; i++)
                    {
                        sample = sample + s[i];
                    }
                    sample += " ";
                }
                else
                {
                    sample = s + " ";
                }

                Console.Write(sample);

            }
        }

        public static void Words(this String str)
        {
            int count = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && Char.IsLetter(str[i + 1]))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of words:");
            Console.WriteLine(count);
        }

        public static void BlankSpaces(this String str){
           int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Blank spaces are:");
            Console.WriteLine(count);
        }

        public static void Sentences(this String str)
        {
            int count = 1;
            for (int i = 0; i < str.Length - 2; i++)
            {

                if (str[i] == '.' && str[i + 1] == ' ' && Char.IsLetter(str[i + 2]))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of senteces:");
            Console.WriteLine(count);
        }

        public static void DigitIndex(this String str)
        {
            String temp1 = "0123456789";
            Console.WriteLine("indexes of digits are:");
            for (int i = 0; i < str.Length; i++)
            {
                if (temp1.Contains(str[i]))
                {
                    Console.Write($"{str[i]} is at {i} \n");
                }
            }
        }
    }
}
