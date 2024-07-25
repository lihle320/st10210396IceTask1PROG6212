namespace st10210396IceTask1PROG6212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard harry = new Wizard("Harry Potter", "Gryffindor", "Holly, Phoenix Feather, 11 inches", 17, 100);
            
            Console.WriteLine(harry[0]); // Harry Potter
            Console.WriteLine(harry[1]); // Gryffindor
            Console.WriteLine(harry[2]); // Holly, Phoenix Feather, 11 inches
            Console.WriteLine(harry[3]); // 17
            Console.WriteLine(harry[4]); // 100
            Console.WriteLine();
          

            Console.WriteLine("Wizard Name: " + harry["name"]);
            Console.WriteLine("Wizard House: " + harry["house"]);
            Console.WriteLine("Wizard Wand: " + harry["wand"]);
            Console.WriteLine("Wizard Age: " + harry["age"]);
            Console.WriteLine("Wizard Magic Power: " + harry["magicPower"]);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            Wizard ron = new Wizard("Ron Weasley", "Gryffindor", "Willow, Unicorn Hair, 14 inches", 16, 90);
           
            Console.WriteLine(ron[0]); // Ron Weasley
            Console.WriteLine(ron[1]); // Gryffindor
            Console.WriteLine(ron[2]); // Willow, Unicorn Hair, 14 inches
            Console.WriteLine(ron[3]); // 16
            Console.WriteLine(ron[4]); // 90
            Console.WriteLine();
            
            Console.WriteLine("Wizard Name: " + ron["name"]);
            Console.WriteLine("Wizard House: " + ron["house"]);
            Console.WriteLine("Wizard Wand: " + ron["wand"]);
            Console.WriteLine("Wizard Age: " + ron["age"]);
            Console.WriteLine("Wizard Magic Power: " + ron["magicPower"]);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");


            Wizard hermione = new Wizard("Hermione Granger", "Gryffindor", "Vine, Dragon Heartstring, 10 3/4 inches", 17, 110);
            Console.WriteLine(hermione[0]); // Hermione Granger
            Console.WriteLine(hermione[1]); // Gryffindor
            Console.WriteLine(hermione[2]); // Vine, Dragon Heartstring, 10 3/4 inches
            Console.WriteLine(hermione[3]); // 17
            Console.WriteLine(hermione[4]); // 110
            Console.WriteLine();

            Console.WriteLine("Wizard Name: " + hermione["name"]);
            Console.WriteLine("Wizard House: " + hermione["house"]);
            Console.WriteLine("Wizard Wand: " + hermione["wand"]);
            Console.WriteLine("Wizard Age: " + hermione["age"]);
            Console.WriteLine("Wizard Magic Power: " + hermione["magicPower"]);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            Wizard dumbledore = new Wizard("Albus Dumbledore", "Gryffindor", "Elder, Thestral Hair, 15 inches", 115, 150);
            Console.WriteLine(dumbledore[0]); // Albus Dumbledore
            Console.WriteLine(dumbledore[1]); // Gryffindor
            Console.WriteLine(dumbledore[2]); // Elder, Thestral Hair, 15 inches
            Console.WriteLine(dumbledore[3]); // 115
            Console.WriteLine(dumbledore[4]); // 150
            Console.WriteLine();

            Console.WriteLine("Wizard Name: " + dumbledore["name"]);
            Console.WriteLine("Wizard House: " + dumbledore["house"]);
            Console.WriteLine("Wizard Wand: " + dumbledore["wand"]);
            Console.WriteLine("Wizard Age: " + dumbledore["age"]);
            Console.WriteLine("Wizard Magic Power: " + dumbledore["magicPower"]);
        }
    }
}
