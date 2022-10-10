using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
using UMS.UI;
using System.IO;
namespace UMS.DL
{
    class studentDL
    {
        public static List<student> stu = new List<student>();
        public static void viewstudents(string degree)
        {
            Console.Clear();
            Console.WriteLine("Names of students Registered in {0}", degree);
            Console.WriteLine("NAME                FSC                 ECAT");
            for (int i = 0; i < stu.Count; i++)
            {
                if (stu[i].getRegisteredDegree().getTitle() == degree)
                {
                    studentUI.PrintStudents(stu[i].getName(), stu[i].getFscMarks(), stu[i].getEcatMarks());
                }
            }
            Console.ReadKey();
        }

        public static void generatemerit()
        {

            Console.WriteLine("Name                     Applied Degree                     Merit");
            Console.WriteLine("_________________________________________________________________");
            for (int i = 0; i < stu.Count; i++)
            {
                if (stu[i].getMerit() > 75)
                {
                    stu[i].setRegisteredDegree(stu[i].getAppliedDegree()[0]);
                }
                else
                {
                    stu[i].getRegisteredDegree().setTitle(null);
                }
                string status = "GOT ADMISSION";
                if (stu[i].getRegisteredDegree().getTitle() == null)
                {
                    status = "DOES NOT GET ADMISSION";
                }


                studentUI.PrintGeneratedMerit(stu[i].getName(), status);


            }
        }

        public static void registerdstudents()
        {
            Console.WriteLine("Name                      Degrees");
            for (int i = 0; i < stu.Count; i++)
            {
                if (stu[i].getRegisteredDegree().getTitle() == null)
                {
                    continue;
                }
                studentUI.PrintRegisteredStudents(stu[i].getName(), stu[i].getRegisteredDegree().getTitle());

            }
            Console.ReadKey();
        }

        public static int fee()
        {
            Console.Clear();
            int fee = 0;
            string name = studentUI.GetName(); ;
            for (int i = 0; i < stu.Count; i++)
            {
                if (stu[i].getName() == name)
                {
                    for (int j = 0; j < stu[i].getRegisteredDegree().GetSubjects().Count; j++)
                    {
                        fee = fee + stu[i].getRegisteredDegree().GetSubjects()[j].getSubjectFee();
                    }

                }
            }
            return fee;

        }

        public static void PassObjectToFile()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\UMS\\UMS\\data.txt";
            for (int i = 0; i < studentDL.stu.Count; i++)
            {
                store(path, stu[i]);
            } 
        }
        public static void store(string path,student s)
        {
          
            StreamWriter f = new StreamWriter(path,true);
            string degreenames = "";
            for(int i = 0; i < s.getAppliedDegree().Count - 1 ; i++)
            {
                degreenames = degreenames + s.getAppliedDegree()[i].getTitle() + ";";
            }
            degreenames = degreenames + s.getAppliedDegree()[s.getAppliedDegree().Count - 1].getTitle();
            
            f.WriteLine("{0},{1},{2},{3},{4},{5}", s.getName(), s.getAge(),s.getFscMarks(),s.getEcatMarks(),s.getMerit(),degreenames);
           
            f.Flush();
            f.Close();
        }

        public static void load()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\UMS\\UMS\\data.txt";
            StreamReader d = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = d.ReadLine()) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    string name = SplittedRecord[0];
                    int age = int.Parse(SplittedRecord[1]);
                    int fscmarks = int.Parse(SplittedRecord[2]);
                    int ecatmarks = int.Parse(SplittedRecord[3]);
                    float merit = float.Parse(SplittedRecord[4]);
                    student st = new student(name, age, fscmarks, ecatmarks, merit);
                    string[] splitteddegree = SplittedRecord[5].Split(';');
                    string register = splitteddegree[0];
                    int idx = degreeprogramDL.GetDegreeIDX(register);
                    st.getAppliedDegree().Add(degreeprogramDL.offerddegreepro[idx]);
                }
            }
            else
            {
                Console.WriteLine("File Does not Exists");
            }
            d.Close();
        }

         public static void registersubjects(string name)
            {

              for(int i = 0; i < stu.Count; i++)
              {
                if(stu[i].getName() == name)
                {

                    string sub = subjectUI.GetsubjectName();
                    int idx = subjectDL.getSubjectIdx(sub);
                    subject s = new subject(subjectDL.getTsubjects()[idx].getCredithours(), subjectDL.getTsubjects()[idx].getSubjectType(), subjectDL.getTsubjects()[idx].getCredithours(), subjectDL.getTsubjects()[idx].getSubjectFee());
                    stu[i].getRegisteredDegree().GetSubjects().Add(s);
                }
                else
                {
                    Console.Write("No Student Found");
                }

              }


         }
       

    }
}
