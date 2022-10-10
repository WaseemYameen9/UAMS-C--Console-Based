using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
using System.IO;

namespace UMS.DL
{
    class subjectDL
    {
        private static  List<subject> tsubjects = new List<subject>();

        public List<subject> getSubjectsList()
        {
            return tsubjects;
        }

        public static subject addsub(int number)
        {
           
                Console.Write("Enter subject Code: ");
                int code = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject Type :");
                string Type = Console.ReadLine();
                Console.Write("Enter Subject Credit hours:");
                int credithours = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject fee:");
                int fee = int.Parse(Console.ReadLine());
                subject sub = new subject(code, Type, credithours, fee);
                tsubjects.Add(sub);
                return sub;

         
        }

        public static int getSubjectIdx(string subject)
        {
            for(int i = 0; i < tsubjects.Count; i++)
            {
                if(tsubjects[i].getSubjectType() == subject)
                {
                    return i;
                }
            }
            return 20;
        }

        public static List<subject> getTsubjects()
        {
            return tsubjects;
        } 

        public static void store()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\UMS\\UMS\\subjects.txt";
            StreamWriter f = new StreamWriter(path);
            for(int i = 0; i < tsubjects.Count; i++)
            {
                f.WriteLine("{0},{1},{2},{3}", tsubjects[i].getSubjectType(), tsubjects[i].getCode(), tsubjects[i].getCredithours(), tsubjects[i].getSubjectFee());
            }
            f.Flush();
            f.Close();
        }

        public static void load()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\UMS\\UMS\\subjects.txt";
            StreamReader f = new StreamReader(path);
            string record = "";
            while((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string Type = splittedrecord[0];
                int code = int.Parse(splittedrecord[1]);
                int credithours = int.Parse(splittedrecord[2]);
                int fee = int.Parse(splittedrecord[3]);
                subject s = new subject(code,Type,credithours,fee);
                tsubjects.Add(s);
            }
            f.Close();
        }

        public static int GetSubjectIndex(string name)
        {
            for(int i = 0; i < getTsubjects().Count; i++)
            {
                if(getTsubjects()[i].getSubjectType() == name)
                {
                    return i;
                }
            }
            return 0;
        }

        
    }
}
