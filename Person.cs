using System;

namespace OOP
{
    class Person
    {
        private string name;

        static public string bloodColor = "roja";
        public Person (string name) {
            this.name = name;

        }

        public void SayHello (){
            Console.WriteLine("Hola, mi nombre es " + this.name);  
        }
        static public void PrintRace () {
            Console.WriteLine("Humano");
        }
    }
}