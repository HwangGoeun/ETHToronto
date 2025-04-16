using System;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>();
        int menu = 1;

        while (menu != 0) {
            Console.Write("Select a menu (1. View users / 2. Add user / 3. Remove user / 0. Exit): ");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    if (users.Count == 0) {
                        Console.WriteLine("No users registered.");
                    } else {
                        foreach(User user in users) {
                            Console.WriteLine($"{user.Name} {user.Number}");
                        };
                    }
                    break;
                
                case 2:
                    Console.Write("Enter user's name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter user's phone number: ");
                    string number = Console.ReadLine();
                    users.Add(new User(name, number));
                    Console.WriteLine("User added!");
                    break;

                case 3:
                    Console.Write("Enter the name of the user to remove: ");
                    string inputName = Console.ReadLine();

                    User userToRemove = users.Find(p => p.Name == inputName);

                    if (userToRemove != null) {
                        users.Remove(userToRemove);
                        Console.WriteLine($"{inputName} has been removed.");
                    } else {
                        Console.WriteLine("User not found.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Program terminated.");
                    break;

                default:
                    Console.WriteLine("엉Invalid menu selection!");
                    Console.WriteLine();
                    break;
            }
        }
    }
}

class User {
    private string name;
    private string number;

    public User(string name, string number) {
        Name = name;
        Number = number;   
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string Number {
        get { return number; }
        set { number = value; }
    }
}