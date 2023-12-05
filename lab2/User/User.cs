using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    private static string filepath = "save.txt";
    public bool goBack = false;
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime DateCreation { get; set; }


    public char UserChoice()
    {
        char choice;


        Console.WriteLine('\n' +
                          "User Creation\n" +
                          "Choose what you want to do: \n" +
                          "1 - Create user\n" +
                          "2 - Delete user\n" +
                          "3 - User info\n" +
                          "4 - Exit");

        choice = Console.ReadKey().KeyChar;

        if (choice == '2')
        {
            Console.WriteLine();
            Console.Write("Are you sure that you want to delete this user? (Y/N) ");
            char choiceDelete = char.ToUpper(Console.ReadKey().KeyChar);
            if (choiceDelete == 'Y')
            {
                Console.WriteLine();
                return choice;
            }
        }

        return choice;
    }

    public void UserCreation()
    {
        Console.WriteLine();
        Console.Write("Enter your username: ");
        Username = Console.ReadLine();
        Console.Write("Enter your first name: ");
        FirstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        LastName = Console.ReadLine();
        Console.Write("Enter your age: ");
        Age = int.Parse(Console.ReadLine());
        DateCreation = DateTime.Now;
        using (StreamWriter streamwriter = new StreamWriter(filepath))
        {
            streamwriter.WriteLine($"\n" +
                                   $"Username: {Username}\n" +
                                   $"First Name: {FirstName}\n" +
                                   $"Last name: {LastName}\n" +
                                   $"Age: {Age}\n" +
                                   $"Date of Creation: {DateCreation}");
        }
    }

    public string UserInfo()
    {
        if (File.Exists(filepath))
        {
            using (StreamReader streamreader = new StreamReader(filepath)) { return streamreader.ReadToEnd(); }
        }
        else
        { return "File does not exist"; }
    }

    public void UserDel()
    {
        if (File.Exists(filepath))
        {
            File.Delete(filepath);
            Console.WriteLine("File deleted");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
