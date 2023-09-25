﻿/*
 Vektorgrafikus rendszerekben lehetőség van négyzet rajzolására.  Az ilyen négyzetek méretét lehetséges változtatni. Az ilyen CAD rendszereknél fontos lehet a négyzet területének és kerületének meghatározása.  Készítsen olyan négyzet osztályt, amelynek adott az oldalhossza!  Az oldalhossz lekérhető és módosítható tulajdonsága legyen a négyzetnek!  A négyzet területe és kerülete legyen lekérdezhető tulajdonsága a négyzetnek!
Példányosítson egy ilyen négyzetet és a főprogramban mutassa be a tulajdonságok kezelését!
Az osztály a projekt model rétegében készítse el egy külön fájlba!
*/


using SquareProject.Models;

Square mySquare = new Square(2);
Console.WriteLine(mySquare);
Console.WriteLine("Kerülete: " + mySquare.Perimeter + " méter.");
Console.WriteLine("Területe: " + mySquare.Area + " négyzetméter.");

// A négyzet oldalát módosítani lehet
mySquare.Side = 5;

Console.WriteLine(mySquare);
Console.WriteLine("Kerülete: " + mySquare.Perimeter + " méter.");
Console.WriteLine("Területe: " + mySquare.Area + " négyzetméter.");

// A konyhába és a fürdőszobába szeretnénk padló csempét
Square myKitchen = new Square(4);
Square myBathroom = new Square(5);
// A négyzet oldalát módosítani lehet. Legyen nagyobb a konyha.
myKitchen.Side = 6;
double areaToBeTiled = myKitchen.Area + myBathroom.Area;

Console.WriteLine();
Console.WriteLine("Konyha, " + myKitchen);
Console.WriteLine("Konyha területe: " + myKitchen.Area + " négyzetméter.");
Console.WriteLine("Fürdőszoba, " + myBathroom);
Console.WriteLine("Fürdőszoba területe: " + myBathroom.Area + " négyzetméter.");
Console.WriteLine("Csempézve lesz: " + areaToBeTiled + " négyzetméter.");