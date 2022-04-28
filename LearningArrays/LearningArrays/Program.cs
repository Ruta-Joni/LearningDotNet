using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = new string[] { "Jonas", "Petras", "Juozas", "Tomas", "Benas" };

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.WriteLine(vardai[i]);
            }

            int[] metai = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20 };

            for (int i = metai.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(metai[i]);
            }
            Console.ReadLine();
        }
    }
}
