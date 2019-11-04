using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string nome;
        public string cognome;
        public int eta;
        public string sesso;
        public int altezza;
        public double peso;
        public Person(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = "sconosciuto";
        }

        public Person(string nome)
        {
        }

        public string Anagrafica()
        {
            string anagrafica = this.nome + " " + this.cognome + " ha il BMI del valore: " + calculateBMI();

            return anagrafica;
        }
        public Person(string name, string surname, int height, double weight)
        {
            this.nome = name;
            this.cognome = surname;
            this.altezza = height;
            this.peso = weight;

        }

        public double calculateBMI()
        {
            double heightInMeters = (double)this.altezza / 100;
            Console.WriteLine(heightInMeters);
            double bMI = this.peso / (heightInMeters * heightInMeters);

            return bMI;
        }

    }
}
