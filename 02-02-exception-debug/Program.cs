using System;

using _02_02_exception_debug.model;

namespace _02_02_exception_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            // S2.01 Negatív oldalú négyzetet is példányosítani lehet!
            // Square mySquare = new Square(-2);
            // Console.WriteLine(mySquare);
            // Console.WriteLine("Kerülete: "+mySquare.District+" méter.");
            // Console.WriteLine("Területe: "+mySquare.Area+" négyzetméter.");

            // S2.06 Ha negatív oldalú négyzetet példaányosítunk akkor elkapjuk a kivételt.
            //       A kivételkezelés egy programozási mechanizmus, melynek célja a program futását szándékosan
            //       vagy nem szándékolt módon megszakító esemény (hiba) vagy utasítás kezelése.
            //       https://hu.wikipedia.org/wiki/Kivételkezelés
            //       Kivételkezelő blokk
            //       A try blokk tartalmazza a kivételkezeléssel védett utasításokat.
            //       https://csharptutorial.hu/docs/hellovilag-hellocsharp/4-vezerlesi-szerkezetek-es-blokkok/try-catch/
            int wrongSide = -2;
            try
            {
                Square myBadSquare = new Square(wrongSide);
            }
            // S2.07 Elkapjuk a saját kivételünket
            //       Ha a program végrehajtása közben valami hiba lép fel,
            //       akkor a try blokkhoz rendelt catch hibakezelőbe akkor kerül a vezérlés,
            //       ha a catch feltételben meghatározott típusú hiba lép fel.
            //       Ha nem kapjuk el a kivételt, a program végrehajtása megszakad.
            catch (SqueraSideCannotBeNagativOrZero negativeOrZeroException)
            {
                // S2.08 A kivétel szövegét megjeleníthetjük a képernyőn.
                Console.WriteLine(negativeOrZeroException.Message);
            }
        }
    }
}
