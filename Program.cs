﻿namespace övningar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreOrd();

        }

        static void Golf()
        {
            /*
            För att få delta i seniormästerskapen på en golfklubb måste man vara minst 50 år gammal. 
            Skapa ett program som frågar användaren hur gammal hen är och sedan berättar om användaren 
            får vara med i seniormästerskapen eller inte.
             */
            Console.WriteLine("Hej och välkommen till den mest exklusiva golfklubb som finns! Hur gammal är du? (Ange i heltal): ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 50)
            {
                Console.WriteLine("Du är välkommen att spela hos oss, för ett pris...");
            }
            else
            {
                Console.WriteLine("Du får inte vara med!");
            }
        }

        static void Världsmästerskapet()
        {
            /*
             Skapa ett program som frågar användaren vilket land som vann fotbolls-VM för damer år 2015. 
            Om användaren svarar USA ska programmet skriva ut att svaret var rätt, 
            annars ska programmet skriva ut att svaret var fel. 
            Det ska inte spela någon roll om användaren skriver svaret med stora eller små bokstäver.
             */

            Console.WriteLine("Vem vann fotbolls VM för kvinnor år 2015?");
            String winner = Console.ReadLine().ToUpper();

            if (winner == "USA")
            {
                Console.WriteLine("Du svarade rätt!");
            }
            else
            {
                Console.WriteLine("Svaret var fel");
            }

        }

        static void Namnsdag()
        {
            /*
            Skapa ett program som frågar användaren vad hen heter. 
            Om användaren heter Stig ska programmet säga att användaren har namnsdag idag. 
            Om användaren istället heter Abraham ska användaren få veta att hen har namnsdag imorgon, 
            men om användaren varken heter Stig eller Abraham 
            ska hen få veta att hen inte har namnsdag vare sig idag eller imorgon.
             */

            Console.WriteLine("Hej, vad heter du?");
            string name = Console.ReadLine();

            if (name == "Stig")
            {
                Console.WriteLine("Grattis! Du har namnsdag idag!");
            }
            else if (name == "Abraham")
            {
                Console.WriteLine("I morgon har du namnsdag! ");
            }
            else
            {
                Console.WriteLine("Din namnsdag kommer, be patient!");
            }
        }

        static void NationellaProv()
        {
            /*
            På det nationella provet i Matematik 4 våren 2013 så fanns följande poänggränser för olika provbetyg.

            Provbetyg	Poänggräns
                     A	55
                     B	46
                     C	35
                     D	27
                     E	18
            Skapa ett program som frågar användaren hur många poäng hen fick på detta prov.   
            Programmet ska säga vilket provbetyg användaren fick.
             */
            Console.WriteLine("Vad fick du för poäng på de nationella proven, från 0 till 100?");
            int rättSvar = int.Parse(Console.ReadLine());

            if (rättSvar < 18)
            {
                Console.WriteLine("F");

            }
            else if (rättSvar < 27)
            {
                Console.WriteLine("E");

            }
            else if (rättSvar < 35)
            {
                Console.WriteLine("D");

            }
            else if (rättSvar < 46)
            {
                Console.WriteLine("C");

            }
            else if (rättSvar < 55)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("Grattis! Du fick ett A!");
            }


        }

        static void ÅlderMånadselön()
        {
            /*
               Skapa ett program som frågar användaren efter hens ålder och månadslön. 
              Programmet ska sedan säga om användaren är lika gammal som, yngre eller äldre än medelpersonen i Göteborg. 
              Därefter ska programmet säga om användaren tjänar lika mycket som, 
              mindre eller mer än meddellönen i Sverige.

               Operator	    Hela uttrycket är sant om...
                x && y	    Både de booleska uttrycken är sanna.
                x || y	    Minst ett av de booleska uttrycken är sant.

               */

            Console.WriteLine("Hej! skriv in din ålder: ");
            int ålder = int.Parse(Console.ReadLine());
            //Console.WriteLine("Du är: " + ålder);

            Console.WriteLine("Hur mycket tjänar du i månaden? Skriv i kr: ");
            int inkomst = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dut tjänar: " + inkomst);

            if (inkomst == 33000)
            {
                Console.WriteLine("du tjänar samma som medelinkomsten i gbg");
            }
            else if (inkomst < 33000)
            {
                Console.WriteLine("du tjänar mindre än medel i gbg");
            }
            else
            {
                Console.WriteLine("du tjänar mer än medelinkomsten i gbg");
            }

            if (ålder == 45)
            {
                Console.WriteLine("Du är lika gammal som medelåldern i göteborg");
            }
            else if (ålder < 45)
            {
                Console.WriteLine("Du är yngre än medelåldern i götet, väx upp för fan");
            }
            else
            {
                Console.WriteLine("Du är äldre än medelåldern i göteborg, börjar bli gammal nu...");
            }
        }

        static void Flygplan()
        {
            /*
             Vi ska se hur flera booleska uttryck kan användas med hjälp av ett exempel. 
            Ett flygbolag ska släppa på passagera på ett flygplan 
            men har bestämt sig för att låta passagerarna stiga ombord på planet i en lite annorlunda ordning. 
            Detta är ordningen som flygbolaget har bestämt sig för:

            Alla som heter Felicia och Felix eftersom de har namnsdag.
            Alla som är äldre än 75 år.
            Alla som är från 18 t.o.m 25 år.
            Övriga passagerare.
             */

            Console.WriteLine("Vad heter du?: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?: ");
            int age = int.Parse(Console.ReadLine());

            if (name == "Felicia" || name == "Felix")
            {
                Console.WriteLine("Välkommen om bord i grupp ett, ni har namnsdag idag! ");
            }
            else if (age > 75)
            {
                Console.WriteLine("Seniorer välkomna ombord i grupp två");
            }
            else if (age >= 18 && age <= 25)
            {
                Console.WriteLine("Unga vuxna får gå ombord i grupp tre.");
            }
            else
            {
                Console.WriteLine("Du är välkommen ombord i grupp fyra.");
            }
        }

        static void Bergochdalbana()
        {
            /*
            För att få åka en viss berg-och-dalbana på en nöjespark 
            så måste man vara mellan 1,5 och 1,9 meter lång. 
            Skapa ett program som frågar användaren hur lång hen är och 
            sedan skriver ut om hen får åka berg-och-dalbanan eller inte.

            A    Op   B Resultat
         ----------------------------
            True  &&  True True
            True  &&  False False
            True  ||  True True
            True  ||  False True
            False &&  False True
            False &&  True False
            False ||  False False
            False ||  True True
         ----------------------------
             True ! False
            False ! True
         ----------------------------

             */

            Console.WriteLine("Välkommen till Balder, för att åka måste du vara mellan 150cm och 190cm lång");
            Console.WriteLine("Hur lång är du? (i cm)");
            int length = int.Parse(Console.ReadLine());

            if (length > 150 && length < 190)
            {
                Console.WriteLine("Varsågod att åka");
            }
            else
            {
                Console.WriteLine("du får inte vara med!");
            }

        }

        static void KafeÖvning()
        {
            /*
            Ett kafé utlyser en kampanj där personer äldre än 65 år 
            samt personer mellan 10 och 18 erbjuds att köpa kaffe till ett extra billigt pris. 
            Skriv ett program som innehåller endast en if-sats 
            som undersöker om användaren kan få köpa kaffe extra billigt.
             */

            Console.WriteLine("Välkommen till caféet.");
            Console.WriteLine("Hur gammal är du?: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 65 || (age >= 10 && age <= 18)) //varför inte &&
            {
                Console.WriteLine("ni får extrapris");
            }
            else
            {
                Console.WriteLine("Ni får köpa dyyyyrt");
            }
        } // hjälp med && och ||  // gjorde åt fel håll först, och svårt att veta om <>=
        
        static void SammaOrd() 
        {
            Console.WriteLine("Var vänlig och skriv in två ord.");
            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();

            // Finns det andra ordet i det första?
            if (ord1.Contains(ord2))
            {
                Console.WriteLine($"{ord1} innehåller ordet {ord2}");
            }
            else
            {
                Console.WriteLine($"{ord1} innehåller INTE ordet {ord2}");
            }
            
            // Vilket ord kommer först i bokstavsordning?
            if (ord1.CompareTo(ord2) < 0)
            {
                Console.WriteLine($"{ord1} kommer före {ord2} i bokstavsordning.");
            }
            else if (ord1.CompareTo(ord2) == 0)  
            {
                Console.WriteLine("Du skrev samma ord 2 gånger.");
            }
            else
            {
                Console.WriteLine($"{ord2} kommer före {ord1} i bokstavsordning.");
            }
        }//Contains CompareTo

        static void TreOrd() //Contains CompareTo
        {
            //Skapa ett program där användaren får skriva in tre olika ord på var sin rad.
            //Programmet ska berätta om det första ordet kommer först i bokstavsordning av alla de tre orden.

            Console.WriteLine("Skriv in tre ord: ");
            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();
            string ord3 = Console.ReadLine();


        }

    }
}
    


        



