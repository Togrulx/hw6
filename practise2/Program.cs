using practise2.Services;
using practise.Core;

BookService BookService = new BookService();

Console.WriteLine("0. Close App");
Console.WriteLine("1. Show Books");
Console.WriteLine("2. Create Book");

string Num = Console.ReadLine();

while (Num != "0")
{
    switch (Num)
    {
        case "1":
            BookService.ShowBooks();
            break;
        case "2":
            BookService.CreateBook();
            break;

        default:
            Console.WriteLine("Duzgun secin");
            break;

    }

    Console.WriteLine("0. Close App");
    Console.WriteLine("1. Show Books");
    Console.WriteLine("2. Create Book");

    Num = Console.ReadLine();


}