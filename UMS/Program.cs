using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
using UMS.DL;
using UMS.UI;
namespace UMS
{
    class Program
    {


        static int flag1 = 1;
        static void Main(string[] args)
        {
            subjectDL.load();
            degreeprogramDL.load();
            studentDL.load();
            while (flag1 == 1)
            {
                Console.Clear();
                int option = MainMenu.menu();
                if (option == 1)
                {
                    student newstu = new student();
                    newstu = studentUI.getstudent();
                    studentDL.stu.Add(newstu);
                }
                if (option == 2)
                {
                    degreeprogram offer = new degreeprogram();
                    offer = degreeprogramUI.adddegree();
                    degreeprogramDL.offerddegreepro.Add(offer);
                }
                if (option == 3)
                {
                    studentDL.generatemerit();
                    Console.ReadKey();

                }
                if (option == 4)
                {
                    studentDL.registerdstudents();
                    Console.ReadKey();

                }
                if (option == 5)
                {
                    
                    String  degree = degreeprogramUI.getdegree();
                    studentDL.viewstudents(degree);
                }
                if (option == 6)
                {
                    string name = studentUI.GetName();
                    studentDL.registersubjects(name);
                }
                if (option == 7)
                {
                    int fee = studentDL.fee();
                    Console.WriteLine("Your Fee is : {0}", fee);
                    Console.ReadKey();
                }
                if (option == 8)
                {
                    studentDL.PassObjectToFile();
                    degreeprogramDL.store();
                    subjectDL.store();
                    flag1 = 0;

                    Console.Clear();
                }
            }
        }
    }
}
