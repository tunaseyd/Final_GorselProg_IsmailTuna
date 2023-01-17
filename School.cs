using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace GorselHW1_IsmailTunaSeydisehirli
{
    internal class SchoolStd
    {
        public int Sid { get; set; }

        public string Sname { get; set; }

        public string Sdateofregist { get; set; }

        public int Sno { get; set; }

        public string Sdateofbirth { get; set; }

        public string Smajor { get; set; }

       
    }
    internal class SchoolAdm 
    {
        public int Aid { get; set; }

        public string Aname { get; set; }

        public string Aduty { get; set; }

        public string Atype { get; set; }

    }

    internal class SchoolLesson 
    {
        internal string Aname { get; set; }

        public string Lname { get; set; }

        public int Lid { get; set; }

        public string Lcred { get; set; }

        public int LSid { get; set; }

    }


    internal class SchoolLS
    {
        internal int Lid { get; set; }

        public int LSid { get; set; }

        public int Sid { get; set; }

        public int Aid { get; set; }
    }
}