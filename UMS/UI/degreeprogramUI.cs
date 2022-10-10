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
    class degreeprogramUI
    {

        public static degreeprogram adddegree()
        {
            Console.Clear();
            Console.WriteLine(">>>Sub-Menu");
            Console.WriteLine("_______________________");
            Console.Write("Enter degree name:");
            string title = Console.ReadLine();
            Console.Write("Enter Degree Duration:");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("How many subjects do you want to enter:");
            int number = int.Parse(Console.ReadLine());
            degreeprogram offer = new degreeprogram(title, duration);
            for (int i = 0; i < number; i++)
            {
                subject sub = subjectDL.addsub(number);
                offer.GetSubjects().Add(sub);
                
            }
            return offer;
        }

        public static string GetLine(string line)
        {
            Console.Write("Enter " + line);
            string statement = Console.ReadLine();
            return statement;
        }

        public static string getdegree()
        {
            Console.WriteLine("Enter the name of degree program :");
            string degree = Console.ReadLine();
            return degree;
        }
    }
}
