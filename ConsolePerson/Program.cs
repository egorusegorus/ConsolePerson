namespace ConsolePerson
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("ConsolePerson");
            Person person1 = new Person();
            
            Console.ReadLine();
        }
    }
    //neue Klasse Person deklarieren
    //Struktur des neuen Typs Person festlegen 
    class Person
    {//Attribute: (Variablen, Eigenschaften)
        
        public string name;
        public string vorname;
        public DateTime Geburtstag;

        // Konstruktor ist eine spezielle Methode die beim Erzeugen der Instanz aufgerufen wird
        //Name wie Klasse, kein Rückgabetyp 
        public Person() { 
        
        }

        // Methoden



    }

}
