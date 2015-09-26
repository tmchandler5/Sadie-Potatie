using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadie_Potatie
{
    class DogStats
    {
        static void Main(string[] args)
        {
            bool isSadieStinky = true;
            short sadiesTongueLength = 2;
            string sadiesNickname = "dog";
            if (isSadieStinky == true)
                Console.Write(sadiesNickname + "\n");
            else
            {
                sadiesNickname = "Puppy";
                Console.WriteLine(sadiesNickname);
            }
            Random randomNum = new Random();
            long treatsInTheJar = randomNum.Next(10);
            for (int x = 0; x < treatsInTheJar; x++)
                sadiesTongueLength++;
            int treatsSadieHasEaten = 0;
            while (sadiesTongueLength > 2)
            { 
                treatsSadieHasEaten++;
                sadiesTongueLength--;
                Console.WriteLine(treatsSadieHasEaten);
            }
            Console.WriteLine(isSadieStinky+","+sadiesTongueLength+","+sadiesNickname+","+treatsInTheJar+","+treatsSadieHasEaten);
            Console.WriteLine("Sadie's Breath Index is " + calcBreathIndex(treatsSadieHasEaten)+" Calculated Without Turds");
            Console.WriteLine("Sadie's Breath Index is " + calcBreathIndex(treatsSadieHasEaten, 4)+ " Calculated With Turds");
            System.Threading.Thread.Sleep(99999);
        }
        public static int calcBreathIndex(int treatsEaten)
        {
            int BreathIndex = treatsEaten * 10;
            return BreathIndex;
        }

        public static int calcBreathIndex(int treatsEaten, int turdsEaten)
        {
            int BreathIndex = (treatsEaten * 10) + (turdsEaten * 100);
            return BreathIndex;
        }
    }
}
