using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadie_Potatie
{
    class Program
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
            uint treatsSadieHasEaten = 0;
            while (sadiesTongueLength > 2)
            { 
                treatsSadieHasEaten++;
                sadiesTongueLength--;
                Console.WriteLine(treatsSadieHasEaten);
            }
            Console.Write(isSadieStinky+","+sadiesTongueLength+","+sadiesNickname+","+treatsInTheJar+","+treatsSadieHasEaten);

            System.Threading.Thread.Sleep(99999);
        }
    }
}
