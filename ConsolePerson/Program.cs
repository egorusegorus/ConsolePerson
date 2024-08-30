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
            Person person2 = new Person();
            Person person3 = new Person();
            person1.vorname = "Kristina";
            person1.name = "Walz";
            person1.geburtstag = new DateTime(2000, 8, 21);

            person2.vorname = "Michaela";
            person2.name = "Novak";
            person2.geburtstag = new DateTime(2000, 8, 22);

            person3.vorname = "Vera";
            person3.name = "Müller";
            person3.geburtstag = new DateTime(2000, 8, 23);

            Person person4 = new Person ("Haniball", "Lecter", new DateTime(1994, 3 ,13));

            //Personen Array anlegen
            Person [] ar= new Person [10] ;

            // PersonenArray füllen
            ar[0]= person1;
            ar[1]= person2;
            ar[2]= person3;
            ar[3]= person4;
            // Personen im Array anzeigen
            for (int i = 0; i < ar.Length; i++) { 
                // nur belegte Plätze anzeigen            
                if (ar[i]!=null) {   
                    
                    Console.WriteLine(ar[i]);
                    Console.WriteLine(i);
                }
            }
  
            // LISTE
            //Liste von Personen anlegen
            //Personen in Liste anzeigen

            List<Person> list = new List<Person>();
            list.Add(person1);
            list.Add(person2);  
            list.Add(person3);
            list.Add(person4);
            Console.WriteLine("\nListe\n");
            foreach (Person p in list) { Console.WriteLine(p); }



            //person1.show(person1.vorname, person1.name, person1.geburtstag);
            //person2.show(person2.vorname, person2.name, person2.geburtstag);
            //person3.show(person3.vorname, person3.name, person3.geburtstag);
            //Console.WriteLine(person1);
            //Console.WriteLine(person2);
            //Console.WriteLine(person3);
            // Console.WriteLine(person4);
            //Console.WriteLine(person1.vorname + " " + person1.name + " ist " + person1.alter() + " Jahren alt.");
            //Console.WriteLine(person2.vorname + " " + person2.name + " ist " + person2.alter() + " Jahren alt.");
            //Console.WriteLine(person2.vorname + " " + person3.name + " ist " + person3.alter() + " Jahren alt.");

            Console.ReadLine();
        }
    }
    //neue Klasse Person deklarieren
    //Struktur des neuen Typs Person festlegen 
    class Person
    {//Attribute: (Variablen, Eigenschaften)
        
        public string? name;
        public string? vorname;
        public DateTime geburtstag;

        // Konstruktor ist eine spezielle Methode die beim Erzeugen der Instanz aufgerufen wird
        //Name wie Klasse, kein Rückgabetyp 
        public Person() { 
        
        }
        // Konstruktor mit 3 Übergabe-Parametern
        public Person(string vorname1, string name1, DateTime dt1)
        {
            vorname= vorname1 ;
            name= name1 ;
            geburtstag= dt1 ;
        }

        // Methoden

        public int alter() {
            DateTime dtNow= DateTime.Now;
            DateTime dtGeb = geburtstag;
            // Alterberechnung nur mit Jahr
            // gilt für alle die dieses Jahr
            //schon Geburtstag hatten
            int nAlter = dtNow.Year - dtGeb.Year;
            // Korrektur um 1 für die Personen die noch nicht Geburtstag hatten
            if ((dtGeb.Month > dtNow.Month) || 
                ((dtGeb.Month == dtNow.Month) && (dtGeb.Day>dtNow.Day))) 
            { nAlter--; }


            return nAlter; }
       // Alle wichtigen Infos von Person in String schreiben
        
        public void show(string a, string b, DateTime geb) {
            Console.WriteLine(a + " " + b + " ist " + alter() + " Jahren alt.");
        }
        public override string ToString()
        {
            string str = "";
            str += "\nName: " + name;
            str += "\nVorname: " + vorname;
            str += "\nGeburtstag: " + geburtstag.ToShortDateString();
            str += "\nAlter: " + alter();

            return str;
        }
        


    }

}
