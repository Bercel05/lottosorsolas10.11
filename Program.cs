using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottosorsolas_10._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        {
            {
                Random random = new Random();
                HashSet<int> lottoNumbers = new HashSet<int>(); 

                while (lottoNumbers.Count < 6)
                {
                    lottoNumbers.Add(random.Next(1, 50)); 
                }

               
                Console.WriteLine("A generált lottó számok: " + string.Join(", ", lottoNumbers));
            }
        }

    }
}
}
