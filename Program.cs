using RepasoQuery.Class;
using RepasoQuery.Class.RunQuerys;

internal class Program
{
    private static void Main(string[] args)
    {
        /*         LinQ query = new LinQ();
                query.PrintData();
                Console.ReadLine(); */

        QueryStudent qStudent = new QueryStudent();
        qStudent.PrintData();
        System.Console.WriteLine();
        qStudent.PrintDataQuery();
        System.Console.WriteLine();
        qStudent.Pares();
        System.Console.WriteLine();
        /* qStudent.OrdenarStudents(); */
        qStudent.InnerJoinStudent();

    }
}