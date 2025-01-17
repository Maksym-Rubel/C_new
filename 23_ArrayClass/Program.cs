using _23_ArrayClass;

internal class Program
{
    private static void Main(string[] args)
    {
        

        EmpList empList = new EmpList();
        empList.AddEmp();
        empList.AddEmp();
    
        empList.PrintAllEmployees();
        Console.WriteLine();
        empList.Search();
        Console.WriteLine();
        empList.PopEmp();
        empList.PrintAllEmployees();
    }
}