using System;

namespace OOP
{
    class Program {

       static void Main(string[] args)
       {
           Person Pormi = new Person("Por mi nombre");
           Pormi.SayHello();

           Person Lallama = new Person("La llama");
           Lallama.SayHello();

           //Console.WriteLine(Pormi);
           Console.WriteLine(Person.bloodColor);

           Person.PrintRace();  
       } 
    }
}
