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
            //this is a list of citizens for the SS admin portal. Holds info for each individual citizen
            List<Citizen> citizenList = new List<Citizen>();
            //variable to store user input
            string input;

            //displays the line
            Console.WriteLine("Welcome to Social Security Administration Portal");
            
            do
            {
                Console.WriteLine("Select an option \n 1. Add Citizen \n 2. Expire Citizens \n 3. Save Data \n 4. Exit Program");
                input = Console.ReadLine();

                //this loop runs until a proper selection is made(1-4)
                while (input != "1" && input != "2" && input != "3" && input != "4")
                {
                    //if invalid selection is made, this message displays
                    Console.WriteLine("Please Enter a Valid Selection");
                    input = Console.ReadLine();
                };

                //if add citizen is selected, user is prompted to enter new citizen data through the promptNewCitizen constructor in an instantiation of the Citizen class
                if (input == "1")
                    citizenList.Add(promptNewCitizen());

                //if 2 is selected, user is asked how many citizens to expire
                else if (input == "2")
                {
                    Console.WriteLine("Expire How Many Citizens");
                    input = Console.ReadLine();
                    //n will be used to make sure user input(string) can be converted to an int
                    int n;
                    //runs until acceptable input is entered
                    //checks to see if conversion does not work or conversion yields an int > 100 or < 0
                    while (!int.TryParse(input, out n) || Int32.Parse(input) > 100 || Int32.Parse(input) < 0)
                    {
                        //if the input entered is either A. cannot be converted to an int B. greater than 100 or C. Less than 0 it will prompt user to enter an acceptable value
                        Console.WriteLine("Please Enter a Number Between 0 and 100");
                        input = Console.ReadLine();
                    };
                    //subtracts expiration total of citizens from current # of citizens by using the expireCitizens constructor
                    Citizen.expireCitizens(n);
                }
                else if (input == "3")
                {
                    //instantiates this class with saveCitizenData constructor
                    saveCitizenData(citizenList);
                }


            } while (input != "4");

        //prompts user for relevant data for new citizen using a string array
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
            //adds the created citizen to the citizenList List
            return new Citizen(names[0], names[1], names[2]);
        }
        //saves all citizen data and records it to a file
        public static void saveCitizenData(List<Citizen> citizenList)
        {
            StreamWriter file = new StreamWriter("CitizenData.txt");
            //gets the SSN and name of each unique Citizenin the List citizenList
            foreach (Citizen uniqueCitizen in citizenList)
            {
                file.WriteLine(uniqueCitizen.getSSN() + ", " + uniqueCitizen.firstName + " " + uniqueCitizen.middleName + " " + uniqueCitizen.lastName);
            }
            file.Flush();
            file.Close();
        }



    }
}
