using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string name;
        public string surname;
        public int eta;
        public string sesso;
        public int altezza;
        public double peso;
        public Person(string nome, string cognome)
        {
            this.name = nome;
            this.surname = cognome;
            this.sesso = "sconosciuto";
        }

        public Person(string nome)
        {
        }

        public string Anagrafica()
        {
            string anagrafica;
            
            if (calculateBMI() < 0)
            {
                anagrafica = this.name + " " + this.surname + " non ha il bmi" ;

            }
            else
            {
                anagrafica = this.name + " " + this.surname + " ha il BMI del valore: " + calculateBMI();

                return anagrafica;
            }
            return anagrafica;
        }
        public Person(string name, string surname, int height, double weight)
        {
            this.name = name;
            this.surname = surname;
            this.altezza = height;
            this.peso = weight;

        }

        public double calculateBMI()
        {
            if (altezza>0 && peso>0)
            {
                double heightInMeters = (double)this.altezza / 100;
  
                double bMI = this.peso / (heightInMeters * heightInMeters);
                return bMI;
            } else
            {
                return -1;
            }
            

            
        }

    }
}
