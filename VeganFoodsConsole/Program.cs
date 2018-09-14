using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFoodsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            PrintTitle();
            PrintMainMenu();
            Console.ReadLine();
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("1. Se alle opskrifter" +
                "\n2. Opret ny opskrift" +
                "\n3. Redigér en opskrift" +
                "\n4. Afslut program");
        }

        private void PrintTitle()
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************* VEGAN FOODS **********************************");
            Console.WriteLine("********************************************************************************");
        }
    }
}
