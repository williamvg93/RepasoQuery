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

    List<StudentStandart> StudentListClases = new List<StudentStandart>()
    {
        new StudentStandart(){Id = 1, Name = "William", Age = 30, FkIdStand = 1 },
        new StudentStandart(){Id = 2, Name = "Nathalia", Age = 24, FkIdStand = 2 },
        new StudentStandart(){Id = 3, Name = "Samir", Age = 27, FkIdStand = 2 },
        new StudentStandart(){Id = 4, Name = "Nancy", Age = 50, FkIdStand = 2 },
        new StudentStandart(){Id = 5, Name = "Wilson", Age = 56, FkIdStand = 3 }
    };

    List<Standart> StandartList = new List<Standart>()
    {
        new Standart(){Id = 1, Name = "Standart1"},
        new Standart(){Id = 2, Name = "Standart2"},
        new Standart(){Id = 3, Name = "Standart3"}
    };
    public void PrintData()
    {
        var teenAgerStudent = StudentList.Where(s => s.Age > 12 && s.Age <= 30).ToList<Student>();
        teenAgerStudent.ForEach(tas => Console.WriteLine($"Nombre: {tas.Name} || Edad:{tas.Age}"));
    }

    public void Pares()
    {
        var listaPares = StudentList.Where((s, i) =>
        {
            if (i % 2 == 0)
            {
                return true;
            }
            return false;
        }).ToList();

        /* Forma convirtiendo a una lista */
        listaPares.ForEach(name => Console.WriteLine($"name: {name.Name}"));
        System.Console.WriteLine();

        foreach (var stu in listaPares)
        {
            System.Console.WriteLine(stu.Name);
        }
    }

    public void InnerJoinStudent()
    {
        var innerStudent = StudentListClases.Join(
            StandartList,
            student => student.FkIdStand,
            standart => standart.Id,
            (student, standart) => new
            {
                Name = student.Name,
                Edad = student.Age,
                Standart = standart.Name
            }
        ).ToList();

        innerStudent.ForEach(student => Console.WriteLine($"Name: {student.Name}  -- Standart: {student.Standart}"));
    }



    public void OrdenarStudents()
    {
        bool continueWhi = true;
        var newList = new List<Student>();

        while (continueWhi)
        {
            System.Console.WriteLine("Desea Ordenar Ascendente(1) o Descendente(0) ?: ");
            string rtaOrden = Console.ReadLine();
            switch (rtaOrden)
            {
                case "0":
                    newList = (from sl in StudentList
                               orderby sl.Name descending
                               select sl).ToList();
                    continueWhi = false;
                    break;
                case "1":
                    newList = StudentList.OrderBy(n => n.Name).ToList();
                    continueWhi = false;
                    break;
                default:
                    System.Console.WriteLine("Ingrese una Opcion Valida !!!");
                    break;
            }
        }
        System.Console.Clear();
        newList.ForEach(n => Console.WriteLine($"Name: {n.Name}"));
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
