using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallMethods
{
    class Program
    {

        int Product(int getal1, int getal2, int getal3)
        {
            /*
             * Deze methode moet het product van 3 getallen berekenen
             * 
             * Voorbeelden
             * Product(4, 3, 2) retourneert 24
             * Product(2, 2, 1) retourneert 4
             */
            return 0;
        }

        bool Passed(int resultaat, int maximum)
        {
            /*
             * Deze methode moet zeggen of een student geslaagd is of niet
             * Een student is geslaagd als het resultaat groter of gelijk aan het maximum is
             * 
             * Voorbeelden:
             * Passed(15, 20) retourneert true
             * Passed(3, 10) retourneert false
             */
            return false;
        }

        bool BothPassed(int student1, int student2, int maximum)
        {
            /*
             * Deze methode moet zeggen of beide studenten geslaag zijn of niet
             * Maak gebruik van de methode Passed hiervoor
             * 
             * Voorbeelden
             * Passed(14, 15, 20) retourneert true
             * Passed(6, 8, 14) retourneert false
             * Passed(3, 3, 10) retourneert false
             */
            return false;
        }

        List<string> Longest(List<string> eerste, List<string> tweede)
        {
            /*
             * Deze methode moet de lijst met het meeste element teruggeven
             * 
             * Voorbeelden:
             * List<string> namen = new List<string>() {"Alice", "Bob", "Carol", "Dave", "Eve"}
             * List<string> producten = new List<string>() {"appel", "banaan", "kiwi"};
             * List<string> kleuren = new List<string>() {"groen", "rood", "blauw", "geel"};
             * 
             * Longest(namen, producten) retourneert de lijst namen
             * Longest(kleuren, producten) retourneert de lijst producten
             * Longest(producten, kleuren) retourneert de lijst producten
             */
            return null;
        }

        string Repeat(string tekst, int aantalKeer)
        {
            /*
             * Deze methoden moet de string teruggeven die bestaat
             * uit de tekst een aantal keer achter elkaar geplakt
             * 
             * Voorbeelden:
             * Repeat("ab", 4) retourneert "abababab"
             * Repeat("a", 4) retourneert "aaaa"
             */

            return null;
        }

        string[] OddElements(string[] data)
        {
            /*
             * Deze methode moet alle elementen op een oneven index uit data
             * in een nieuwe array stoppen en deze array retourneren
             * 
             * Voorbeelden
             * string[] getallen = new string[6] {"nul", "een", "twee", "drie", "vier", "vijf"}
             * OddElements(getallen) retourneert {"een", "drie", "vijf"}
             * 
             * string[] letters = new string[5] {"a", "b", "c", "d", "e"}
             * OddElements(letters) retourneert {"b", "d"}
             */
            return null;
        }

        string[] EvenElements(string[] data)
        {
            /*
             * Deze methode moet alle elementen op een even index uit data
             * in een nieuwe array stoppen en deze array retourneren
             * 
             * Voorbeelden
             * string[] getallen = new string[6] {"nul", "een", "twee", "drie", "vier", "vijf"}
             * OddElements(getallen) retourneert {"nul", "twee", "vier"}
             * 
             * string[] letters = new string[5] {"a", "b", "c", "d", "e"}
             * OddElements(letters) retourneert {"a", "c", "e"}
             */
            return null;
        }

        int Count(List<string> data, string zoekwoord)
        {
            /*
             * Deze methode moet het aantal keer tellen dat zoekwoord voorkomt in data
             * 
             * Voorbeelden
             * List<string> vrienden = new List<string>() {"Alice", "Bob", "Dave", "Alice", "Alice", "Bob", "Alice"};
             * Count(vrienden, "Alice") retourneert 4
             * Count(vrienden, "Bob") retourneert 2
             * Count(vrienden, "Dave") retourneert 1
             * Count(vrienden, "Eve") retourneert 0
             */
            return 0;
        }

        int CountBoth(List<string> data, string zoekwoord1, string zoekwoord2)
        {
            /*
             * Deze methode berekent de som van het aantal keer dat zoekwoord1
             * en zoekwoord2 voorkomen in data. Maak handig gebruik van de Count methode.
             * 
             * Voorbeelden
             * List<string> vrienden = new List<string>() {"Alice", "Bob", "Dave", "Alice", "Alice", "Bob", "Alice"};
             * Count(vrienden, "Alice", "Bob") retourneert 6
             * Count(vrienden, "Bob", "Dave") retourneert 3
             * Count(vrienden, "Dave", "Eve") retourneert 1
             */
            return 0;
        }

        bool EnoughMoney(List<Decimal> productprijzen, decimal geldHoeveelheid)
        {
            /*
             * Deze methode moet berekenen of je genoeg geld hebt om alle producten te betalen
             * 
             * Voorbeelden
             * List<Decimal> productprijzen = new List<Decimal>() {1.5M, 2M, 0.66M, 3M, 5M}
             * EnoughMoney(productprijzen, 15M) retourneert true
             * EnoughMoney(productprijzen, 10M) retourneert false
             * 
             */
            return false;
        }

        bool IsAFriend(List<string> vrienden, string naam)
        {
            /* Deze methode moet zeggen of de naam in de lijst vrienden zit
             * 
             * Voorbeelden
             * List<string> mijnVrienden = new List<string>() {"Alice", "Bob", "Carol"}
             * IsAFriend(mijnVrienden, "Alice") moet true retourneren
             * IsAFriend(mijnVrienden, "Eve") moet false retourneren
             * 
             */
            return false;
        }


        void Run()
        {

        }

        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}
