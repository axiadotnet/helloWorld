﻿
using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // value Type

            int numeroIntero = 2;

            float numeroConLaVirgola32;

            double numeroConLaVirgola64;

            bool valoreLogico;

            char carattere;

            decimal valoreDecimale;


            int i = 10;
            int j = i;

            Console.WriteLine(i);
            Console.WriteLine(j);

            i = 5;

            Console.WriteLine(i);
            Console.WriteLine(j);

            // reference Type

            string insiemeCaratteri;

            string stringa1 = "la mia casa è bella";
            string stringa2 = stringa1;

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            stringa1 = "la mia casa è brutta";

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            object oggetto;

            Person luca = new Person("Luca","Lippi");
            luca.eta = 18;

            Console.WriteLine(luca.Anagrafica());


            Person giovanni = luca;

            giovanni.name = "Giovanni";

            Console.WriteLine(luca.Anagrafica());
            Console.WriteLine(giovanni.Anagrafica());

            Person luigi = new Person("luigi", "bianchi", 180, 70.2);
            Console.WriteLine(luigi.Anagrafica());

        }
    }
}
