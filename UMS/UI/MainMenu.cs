using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
using UMS.DL;
using UMS.UI;

namespace UMS.UI
{
    class MainMenu
    {

        public static int menu()
        {
            Console.WriteLine(">>Main Menu :");
            Console.WriteLine("_________________");
            Console.WriteLine("1-Add student");
            Console.WriteLine("2-Add degree program");
            Console.WriteLine("3-Generate Merit");
            Console.WriteLine("4-view Registered students");
            Console.WriteLine("5-View students of a specific program");
            Console.WriteLine("6-Register students for a specific subject");
            Console.WriteLine("7-Claculate fee for all registered students");
            Console.WriteLine("8-Exit");
            Console.Write("Enter Your Option :");
            int foption = int.Parse(Console.ReadLine());
            return foption;
        }
    }
}
