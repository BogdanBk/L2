using System;

class Employee
{
    private string firstName;
    private string lastName;
    private string position;
    private int experience;


    public Employee(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public void SetPosition(string position) { this.position = position; }
    public void SetExperience(int experience) { this.experience = experience; }

    public double CalculateSalary()
    {
        double salary = 0.0;
        double baseSalary = 0.0;
        double experienceBonus = 0.0;

        if (experience < 2) { experienceBonus = 0.0; }
        else if (experience > 2 && experience < 5) { experienceBonus = 250.0; }
        else if (experience > 5) { experienceBonus = 500.0; }

        switch (position)
        {
            case "Full stack": baseSalary = 1000.0; break;
            case "Front end": baseSalary = 500.0; break;
            case "Back end": baseSalary = 750.0; break;
        }

        salary = baseSalary + experienceBonus;

        return salary;
    }

    public double CalculateTax()
    {
        double tax = 0.0;
        double taxRate = 0.18;

        tax = CalculateSalary() * taxRate;

        return tax;
    }

    public void DisplayEmployee()
    {
        double salary = CalculateSalary();
        double tax = CalculateTax();

        Console.WriteLine($"First name: {firstName}\n" +
                          $"Last name: {lastName}\n" +
                          $"Position: {position}\n" +
                          $"Experience: {experience} \n" +
                          $"Salary: {salary} \n" +
                          $"Tax: {tax} USD, with tax rate of 18%");

    }

}
