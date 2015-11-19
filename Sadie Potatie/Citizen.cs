using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadie_Potatie
{
    public class Citizen
    {
        public string firstName, middleName, lastName;
        private readonly int SSN;
        static int SSNSeed = 0;
        static public int livingCitizenCount = 0;

        public Citizen(string FirstName, string MiddleName, string LastName)
        {
            this.firstName = FirstName;
            this.middleName = MiddleName;
            this.lastName = LastName;
            this.SSN = SSNSeed++;
            livingCitizenCount++;
        }

        public static int expireCitizens(int expirationTotal)
        {
            livingCitizenCount = livingCitizenCount - expirationTotal;
            return livingCitizenCount;
        }
        

    }
}
