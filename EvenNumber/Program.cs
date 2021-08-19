using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 11, 9, 8, 2, 5, 12 };

            EvenNumber num = new EvenNumber();

            for (int i = 0; i < data.Length; i++)
            {
                if (num.SetEvenNumber(data[i]))
                {
                    Console.WriteLine("Update succeeded.");
                    Console.WriteLine("Value is now " + num.GetValue() + ".");
                }
                else
                {
                    Console.WriteLine("Update failed.");
                    Console.WriteLine(data[i] + " is not even.");
                }

                Console.WriteLine("");
            }
        }
    }
}
