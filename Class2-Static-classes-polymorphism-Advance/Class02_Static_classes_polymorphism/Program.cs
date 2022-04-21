using Class02_Static_classes_polymorphism.Helper;

while (true)
{
    Console.WriteLine("Enter 1 to register user and 2 to print users");
    string choice = Console.ReadLine();

    if (choice == MenuOptions.REGISTER_USER)
    {
        Console.WriteLine("Input username");
        User user = new User(Console.ReadLine());
        UserDB.USERS.Add(user);
    }
    else if (choice == MenuOptions.SHOW_ALL_USERS)
    {
        foreach (var user in UserDB.USERS)
        {
            Console.WriteLine(user.Username);
        }
    }
}