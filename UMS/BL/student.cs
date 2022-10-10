using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.DL;
namespace UMS.BL
{
    class student
    {
        private string name;
        private int age;
        private int fscmarks;
        private int ecatmarks;
        private float merit;
        private List<degreeprogram> applied = new List<degreeprogram>();
        private degreeprogram registers = new degreeprogram();


        public student()
        {

        }
        public student(string name, int age, int fscmarks, int ecatmarks, float merit)
        {
            this.name = name;
            this.age = age;
            this.fscmarks = fscmarks;
            this.ecatmarks = ecatmarks;
            this.merit = merit;
        }
        public student(string name,int age,int fscmarks,int ecatmarks,int number,float merit)

        {
            this.name = name;
            this.age = age;
            this.fscmarks = fscmarks;
            this.ecatmarks = ecatmarks;
            this.merit = merit;

        }
        public void studentapplieddegrees(int number)
        {

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter you Degree in which you want to apply :");
                string degree = Console.ReadLine();
                int duration = 4;
                degreeprogram newdeg = new degreeprogram(degree, duration);
                getAppliedDegree().Add(newdeg);
            }
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }

        public int getFscMarks()
        {
            return fscmarks;
        }

        public int getEcatMarks()
        {
            return ecatmarks;
        }

        public float getMerit()
        {
            return merit;
        }

        public List<degreeprogram> getAppliedDegree()
        {
            return applied;
        }

        public degreeprogram getRegisteredDegree()
        {
            return registers;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

        public void getFscMarks(int fscmarks)
        {
            this.fscmarks = fscmarks;
        }

        public void getEcatMarks(int ecatmarks)
        {
            this.ecatmarks = ecatmarks;
        }

        public void getMerit(float merit)
        {
            this.merit = merit;
        }

        public void setRegisteredDegree(degreeprogram registers)
        {
            this.registers.setTitle(registers.getTitle());
            this.registers.setDuration(registers.getDuration());
            /* this.registers.getSubjects() */
        }

    }
}
