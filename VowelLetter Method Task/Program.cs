using System;

namespace VowelLetter_Method_Task
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write a sentence ");
            string text = Console.ReadLine();
            Console.WriteLine("{1} sentence contains {0} VowelLetter..", VowelLetter(text),text);
            Console.ReadLine();
        }

        static int VowelLetter(string text)
        {
            int count = 0;
            char[] VowelLetter = { 'a', 'ə', 'e', 'o', 'ö', 'u', 'ü', 'ı', 'i','A', 'E','Ə','O', 'Ö', 'U', 'Ü', 'I', 'İ',};
            foreach (char c in text)
            {
                foreach (char letter in VowelLetter)
                {
                    if (c == letter) 
                        count++;
                }
            }
            return count;
        }
    }
}
