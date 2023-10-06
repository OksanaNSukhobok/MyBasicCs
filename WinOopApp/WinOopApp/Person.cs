using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOopApp
{
    /*
    public class Person
    {
        
        public string FirstName;
        public string MiddleName;
        public string LastName;
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName)
        { 
            FirstName= firstName;
            MiddleName= middleName;
            LastName= lastName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName= firstName;
            MiddleName = "";
            LastName= lastName;
        }
         

        public string GetFullName()
        {
            string fullName = FirstName;
            if (MiddleName.Length>0) fullName+=" " + MiddleName;
            fullName += " " + LastName;
            return fullName;
        }

        public string GetShortName()
        {
            string shortName= LastName;
            shortName += " " + FirstName + ".";
            if (MiddleName.Length > 0) shortName += MiddleName + ".";
            return shortName;
        }

        public virtual string GetInfo()
        {
            string info = GetShortName();
            return info;
        }
    }
    */
}
