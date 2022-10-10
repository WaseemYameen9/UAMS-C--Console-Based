using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.BL
{
    class degreeprogram
    {
        private string title;
        private int duration;
        private List<subject> subjects = new List<subject>();

        public degreeprogram()
        {

        }
        public degreeprogram(string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }

        public string getTitle()
        {
            return title;
        }

        public int getDuration()
        {
            return duration;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setDuration(int duration)
        {
            this.duration = duration;
        }

        public List<subject> GetSubjects()
        {
            return subjects;
        }
    }
}
