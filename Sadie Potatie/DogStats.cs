using System;
using System.Collections.Generic;
using System.IO;
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
                Console.WriteLine("Select an option \n 1. Add Citizen \n 2. Expire Citizens \n 3. Save Data \n 4. Exit Program");
                input = Console.ReadLine();
                while (input != "1" && input != "2" && input != "3" && input != "4")
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
                    int n;
                    while (!int.TryParse(input, out n) || Int32.Parse(input) > 100 || Int32.Parse(input) < 0)
                    {
                        Console.WriteLine("Please Enter a Number Between 0 and 100");
                        input = Console.ReadLine();
                    };
                    Citizen.expireCitizens(n);
                }
                else if (input == "3")
                {
                    saveCitizenData(citizenList);
                }


            } while (input != "4");
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

        public static void saveCitizenData(List<Citizen> citizenList)
        {
            StreamWriter file = new StreamWriter("CitizenData.txt");
            foreach (Citizen uniqueCitizen in citizenList)
            {
                file.WriteLine(uniqueCitizen.getSSN() + ", " + uniqueCitizen.firstName + " " + uniqueCitizen.middleName + " " + uniqueCitizen.lastName);
            }
            file.Flush();
            file.Close();
        }



    }
}
