//Enrick De Munter 5ITN nr4
/*analyse
 * vraag de eerste 2 letters van de famillienaam
 * vraag de zonenummer van het telefoonnummer zonder de 0
 * het eerste cijfer van de postcode
 * 
 * bereken wachtwoord
 * famillienaam(de eerste twee letters en die dan omwisselen
 * zonenummer(de zone nummer zonder nul)
 * het eerste cijfer van de postcode en dat in het kwadraat
 * 
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wachtwoord
{
    class Program
    {
        static void Main(string[] args)
        {   //declaraties
            string lettersfamillienaam;
            int zonenummer;
            int postcodenummer;
            string wachtwoord;

            //input
            //vraag de eerste 2 letters van de famillienaam
            Console.WriteLine("wat zijn de eerste 2 letters van u voornaam?: ");
            lettersfamillienaam = Console.ReadLine();

            //vraag de zonenummer van het telefoonnummer zonder de 0
            Console.WriteLine("wat is het zonenummer van het telefoonnummer zonder 0 ?: ");
            zonenummer = int.Parse(Console.ReadLine());

            //vraag het eerste cijfer van de postcode en dat in het kwadraat
            Console.WriteLine(" wat is het eerste cijfer van de uw postcode?: ");
            postcodenummer = int.Parse(Console.ReadLine());

            //bereken
            wachtwoord = (string)(lettersfamillienaam + zonenummer + (postcodenummer * postcodenummer));

            //toon
            Console.WriteLine(wachtwoord);

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten: ");
            Console.ReadKey();
        }
    }
}
