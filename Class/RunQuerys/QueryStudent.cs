using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoQuery.Class.RunQuerys;

public class QueryStudent
{
    List<Student> StudentList = new List<Student>()
    {
        new Student(){Id = 1, Name = "William", Age = 30 },
        new Student(){Id = 2, Name = "Nathalia", Age = 24 },
        new Student(){Id = 3, Name = "Samir", Age = 27 },
        new Student(){Id = 4, Name = "Nancy", Age = 50 },
        new Student(){Id = 5, Name = "Wilson", Age = 56 }
    };

    public void PrintData()
    {
        var teenAgerStudent = StudentList.Where(s => s.Age > 12 && s.Age <= 30).ToList<Student>();
        teenAgerStudent.ForEach(tas => Console.WriteLine($"Nombre: {tas.Name} || Edad:{tas.Age}"));
    }
    public void PrintDataQuery()
    {
        var teenAgerStudent = (from s in StudentList
                               where s.Age > 12 && s.Age <= 30
                               select new { s.Id, s.Name });
        foreach (var item in teenAgerStudent)
        {
            System.Console.WriteLine($"Id: {item.Id}   -->  Name: {item.Name}");
        }
    }
}
