using System;

class Program
{
    public static void Main()
    {
        Employee employee = new Employee("Edward", "Steward");
        employee.SetPosition("Back end");
        employee.SetExperience(3);
        employee.DisplayEmployee();
    }
}