using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsObjectModeling
{
    internal class Program
    {
        public static void Main()
        {
            //create the object of execution class 
            ExecutionClass executeClasses = new ExecutionClass();

            //call the method  which execute the 
            //executeClasses.CallingLibrary();


            //executeClasses.CallingBank();

            //executeClasses.CallingCompany();

            //executeClasses.CallingSchool();

            //executeClasses.CallingUniversity();

            //executeClasses.CallingPaitentHospital();

            executeClasses.CallingEcommerce();

        }

    }
}
