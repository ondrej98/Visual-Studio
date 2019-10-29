using System;

namespace ConsoleApp1
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            string citanie = Console.ReadLine();
            string format = string.Format("{0}:{1}", "Výsledok", citanie);
            
            var poleStringov = format.Split(':')[0];

            Console.WriteLine(poleStringov);*/
            
            string[,] data_pole = new string[,] { { "Ahoj", "Mám sa dobre" } ,{ "Ok", "Povedzme"}, { "Col", "Los"} };
            string[] dt = new string[5];
            for(int i= 0; i<3; i++)
            {
                if (i < 2)
                    Console.WriteLine(data_pole.GetLength(i));
                else
                    Console.WriteLine(data_pole.Length);
            }




        }
    }
}
