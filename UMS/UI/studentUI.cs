using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.DL;
using UMS.BL;
namespace UMS.UI
{
    class studentUI
    {

        public static student getstudent()
        {
            string name;
            int fscmarks, ecatmarks, age;
            Console.Clear();
            Console.WriteLine(">>Sub-Menu:");
            Console.WriteLine("___________________");
            Console.Write("Enter student name:");
            name = Console.ReadLine();
            Console.Write("Enter Your age:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter you Fsc Marks:");
            fscmarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Your ecat marks:");
            ecatmarks = int.Parse(Console.ReadLine());
            float merit = ((fscmarks / 1100f) * 60f + (ecatmarks / 400f) * 40f);
            Console.WriteLine("Available Degree Programs");
            Console.WriteLine("___________________");
            for (int i = 0; i < degreeprogramDL.offerddegreepro.Count; i++)
            {
                Console.WriteLine(degreeprogramDL.offerddegreepro[i].getTitle());
            }
            Console.Write("How many preferences you want to enter :");
            int number = int.Parse(Console.ReadLine());
            student newstu = new student(name, age, fscmarks, ecatmarks, number, merit);
            newstu.studentapplieddegrees(number);
            return newstu;



        }

        public static string GetName()
        {
            Console.Write("Enter Your Name :");
            string name = Console.ReadLine();
            return name;
        }

        public static void PrintGeneratedMerit(string name, string status)
        {
            Console.WriteLine("{0}              {1}", name, status);
        }

        public static void PrintRegisteredStudents(string name, string registereddegree)
        {
            Console.WriteLine("{0}                         {1}", name,registereddegree);
        }

        public static void PrintStudents(string name,int fsc,int ecat)
        {
            Console.WriteLine("{0}                {1}                 {2}",name,fsc,ecat);
        }
    }
}
