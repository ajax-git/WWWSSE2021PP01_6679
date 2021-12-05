/*
    Napisz program, który pyta użytkownika o podanie liczby całkowitych i w wyniku wyświetla
    informacje o parzystości lub nieparzystości.
*/

Console.WriteLine("Podaj jakąś liczbę całkowitą: ");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("> Podana liczba jest parzysta.");
    else Console.WriteLine("> Podana liczba nie jest parzysta.");