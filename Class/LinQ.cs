using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoQuery.Class;

public class LinQ
{
    List<string> books = new List<string>()
    {
        "Vb.Net Tutorial",
        "C# Tutorial",
        "NetCore Tutorial",
        "TypeScript e-book"
    };

    public IEnumerable<string> BookListByName(string condition)
    {
        return books.Where(b => b.Contains(condition));
    }

    public IEnumerable<string> BookListByNameQuery(string condition)
    {
        return from b in books
               where b.Contains(condition)
               select b;
    }

    public void PrintData()
    {
        Console.WriteLine("Enter the Book Name: ");
        string bookName = Console.ReadLine();
        IEnumerable<string> data = BookListByNameQuery(bookName);

        foreach (string item in data)
        {
            Console.WriteLine($"Book Name: {item}");
        }
        Console.ReadKey();
    }

    public string ReadData()
    {
        Console.WriteLine("Enter the Book Name: ");
        return Console.ReadLine();
    }

    public IEnumerable<string> RunQuery(string condition, Int16 opcion)
    {

        return BookListByNameQuery(condition);
    }

    public void RepeatFunction()
    {
        bool checkResult = true;
        while (checkResult)
        {
            System.Console.WriteLine("Do you want to repeat Function, Y or N ?: ");
            Console.ReadLine();

        }
    }

}
