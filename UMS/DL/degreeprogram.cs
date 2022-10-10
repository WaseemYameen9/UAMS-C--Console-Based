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
    class degreeprogramDL
    {
        public static List<degreeprogram> offerddegreepro = new List<degreeprogram>();

        public static void store()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\UMS\\UMS\\degreeprogram.txt";
            StreamWriter f = new StreamWriter(path);
            string subjectNames = "";
            for (int i = 0; i < offerddegreepro.Count;  i++)
            {

                for (int j = 0; j < offerddegreepro[i].GetSubjects().Count - 1; j++)
                {
                    subjectNames = subjectNames + offerddegreepro[i].GetSubjects()[j].getSubjectType() + ";";
                }
                subjectNames = subjectNames + offerddegreepro[i].GetSubjects()[offerddegreepro[i].GetSubjects().Count - 1].getSubjectType();
                 f.WriteLine("{0},{1},{2}",offerddegreepro[i].getTitle(),offerddegreepro[i].getDuration(),subjectNames);
            }
            f.Flush();
            f.Close();
        }

        public static void load()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\UMS\\UMS\\degreeprogram.txt";
            StreamReader f = new StreamReader(path);
            string record = "";
            while((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string title = splittedrecord[0];
                int duration = int.Parse(splittedrecord[1]);
                degreeprogram d = new degreeprogram(title, duration);
                string[] splittedsubjects = splittedrecord[2].Split(';');
                for(int i = 0; i < splittedsubjects.Length; i++)
                {
                    int idx = subjectDL.GetSubjectIndex(splittedsubjects[i]);
                    d.GetSubjects().Add(subjectDL.getTsubjects()[idx]);
                }

            }
            f.Close();
        }

        public static int GetDegreeIDX(string title)
        {
            for(int i = 0; i < offerddegreepro.Count; i++)
            {
                if(offerddegreepro[i].getTitle() == title)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
