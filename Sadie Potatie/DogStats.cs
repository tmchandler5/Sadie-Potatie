using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadie_Potatie
{
    class SSAdminPortal
    {
        static void Main(string[] args)
        {
            List<Citizen> citizenList = new List<Citizen>();
            string input;

            Console.WriteLine("Welcome to Social Security Administration Portal");
            do
            {
                Console.WriteLine("Select an option \n 1. Add Citizen \n 2. Expire Citizens \n 3. Exit Program");
                input = Console.ReadLine();
                while(input != "1" || input != "2" || input != "3")
                {
                    Console.WriteLine("Please Enter a Valid Selection");
                    input = Console.ReadLine();
                };

                if (input == "1")
                    citizenList.Add(promptNewCitizen());
                else if (input == "2")
                {
                    Console.WriteLine("Expire How Many Citizens");
                    input = Console.ReadLine();
                    Citizen.expireCitizens(Int32.Parse(input));
                } 
                   

            }while(input != "3");
        }
        public static Citizen promptNewCitizen()
        {
            string[] names = new string[3];

            Console.WriteLine("Enter First Name: ");
            names[0] = Console.ReadLine();
            Console.WriteLine("Enter Middle Name: ");
            names[1] = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            names[2] = Console.ReadLine();

            return new Citizen(names[0], names[1], names[2]);
        }

   

    }
}
