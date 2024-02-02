using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_1_degree_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomMinNumber = 1;
            int randomMaxNumber = 100;
            int randomNumber = random.Next(randomMinNumber, randomMaxNumber);
            int minDegree = 0;
            int resultDegree = 1;
            int baseDegree = 2;
            
            while (resultDegree <= randomNumber)
            {
                resultDegree *= baseDegree;
                minDegree++;
            }
            
            Console.WriteLine("Число: " + randomNumber);
            Console.WriteLine("Минимальная степень двойки, превышающая это число: " + minDegree);
            Console.WriteLine($"{baseDegree} в степени {minDegree}  равно {resultDegree}");
            Console.ReadLine();
        }
    }
}
