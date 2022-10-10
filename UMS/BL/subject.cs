using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.BL
{
    class subject
    {

        private int code;
        private int credithours;
        private string subjectType;
        private int subjectfee;

        public subject(int code, string subjectType, int credithours, int subjectfee)
        {
            this.code = code;
            this.credithours = credithours;
            this.subjectType = subjectType;
            this.subjectfee = subjectfee;


        }

        public int getCode()
        {
            return code;
        }

        public int getCredithours()
        {
            return credithours;
        }

        public string getSubjectType()
        {
            return subjectType;
        }

        public int getSubjectFee()
        {
            return subjectfee;
        }
        public void setCode(int code)
        {
            this.code = code;
        }

        public void setCredithours(int credithours)
        {
            this.credithours = credithours;
        }

        public void setSubjectType(string subjectType)
        {
            this.subjectType = subjectType;
        }

        public void setSubjectFee(int subjectfee)
        {
            this.subjectfee = subjectfee;
        }


    }
}

