using System;

class Employee
{
    private string m_FirstName;
    private string m_LastName;
    private string m_Position;
    private int m_Experience;


    public Employee(string firstName, string lastName)
    {
        m_FirstName = firstName;
        m_LastName = lastName;
    }
    public void setPosition(string position) {m_Position = position;}
    public void setExperience(int experience) { m_Experience = experience; }

    public double calculateSalary()
    {
        double salary = 0.0;
        double baseSalary = 0.0;
        double experienceBonus = 0.0;

        if(m_Experience < 2) { experienceBonus = 0.0; }
        else if(m_Experience > 2 && m_Experience <5) { experienceBonus = 250.0; }
        else if (m_Experience > 5) { experienceBonus = 500.0; }

        switch(m_Position)
        {
            case "Full stack": baseSalary = 1000.0; break;
            case "Front end": baseSalary = 500.0; break;
            case "Back end": baseSalary = 750.0; break;
        }

        salary = baseSalary + experienceBonus;

        return salary;
    }

    public double calculateTax()
    {
        double tax = 0.0;
        double taxRate = 0.18;

        tax = calculateSalary() * taxRate;

        return tax;
    }

    public void displayEmployee()
    {
        double salary = calculateSalary();
        double tax = calculateTax();

        Console.WriteLine($"First name: {m_FirstName}");
        Console.WriteLine($"Last name: {m_LastName}");
        Console.WriteLine($"Position: {m_Position}");
        Console.WriteLine($"Experience: {m_Experience} year(s)");
        Console.WriteLine($"Salary: {salary} USD");
        Console.WriteLine($"Tax: {tax} USD, with tax rate of 18%");

    }

}
