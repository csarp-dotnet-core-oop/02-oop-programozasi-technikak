/*
 Vektorgrafikus rendszerekben lehetőség van négyzet rajzolására.  Az ilyen négyzetek méretét lehetséges változtatni. Az ilyen CAD rendszereknél fontos lehet a négyzet területének és kerületének meghatározása.  Készítsen olyan négyzet osztályt, amelynek adott az oldalhossza!  Az oldalhossz lekérhető és módosítható tulajdonsága legyen a négyzetnek!  A négyzet területe és kerülete legyen lekérdezhető tulajdonsága a négyzetnek!
Példányosítson egy ilyen négyzetet és a főprogramban mutassa be a tulajdonságok kezelését!
Az osztály a projekt model rétegében készítse el egy külön fájlba!
*/


using SquareProject.Models;

int wrongSide = -2;
try
{
    Square mySquare = new Square(wrongSide);
    Console.WriteLine(mySquare);
    Console.WriteLine("Kerülete: " + mySquare.Perimeter + " méter.");
    Console.WriteLine("Területe: " + mySquare.Area + " négyzetméter.");
}
catch (SqueraSideCannotBeNagativOrZero negativeOrZeroException)
{
    Console.WriteLine(negativeOrZeroException.Message);
}
catch (Exception anyException)
{
    Console.WriteLine(anyException.Message);
}

