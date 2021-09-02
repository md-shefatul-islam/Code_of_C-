using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifier;  //to use all the class of that project
using AccessModifier.Test; //to use all the sub class of that project

namespace ClassLibrary
{
    //public class UniversityStudent : Student //for Accessmodifier
   // public class UniversityStudent : SchoolStudent //for sub folder or sub class
    public class UniversityStudent : AccessModifier.Test.SchoolStudent
    {
        public int a2;
        private int b2;
        protected int c2;
        internal int d2;
        protected internal int e2;
        public void m5()
        {
            this.e = 4;
            //all member of its own can be accessible from here 
            //a,c,e can be accessible
        }
    }
}
