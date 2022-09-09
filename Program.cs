namespace övningar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NationellaProv();

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
        }//hjälp med && och ||
    } // gjorde åt fel håll först, och svårt att veta om <>=
}



