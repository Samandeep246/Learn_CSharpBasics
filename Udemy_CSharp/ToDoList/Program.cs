// See https://aka.ms/new-console-template for more information
var todos = new List<string>();
Console.WriteLine("Hello!");
bool shallExit = false;
while(!shallExit)
{
    Console.WriteLine("What you want to do ?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":
            Console.WriteLine("Selected option: See all TODOS");
            SeeAllToDos();
            break;
        case "A":
        case "a":
            AddTodo();
            Console.WriteLine("Selected option: Add a TODO");
            break;
        case "R":
        case "r":
            RemoveToDos();
            Console.WriteLine("Selected option: Remove a TODO");
            break;
        case "E":
        case "e":
            shallExit = true;
            Console.WriteLine("Selected option: Exit");
            break;
        default:
            Console.WriteLine("Wrong option");
            break;
    }
}



Console.ReadKey();
void AddTodo()
{
    bool isValidDesc = false;
    while (!isValidDesc)
    {
        Console.WriteLine("Enter the Todo description");
        var desc = Console.ReadLine();
        if (desc == "")
            Console.WriteLine("The description can't be empty");
        else if (todos.Contains(desc))
            Console.WriteLine("The description must be unique");
        else
            isValidDesc = true;
            todos.Add(desc);
    } 
   
}
void SeeAllToDos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet");
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i+1}.{todos[i]}");
        }

    }
}
void RemoveToDos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet.");
        return;
    }
    bool isValidIndex = false;
    while (!isValidIndex)
    {
        Console.WriteLine("Select the index of the ToDo you want to remove");
        SeeAllToDos();
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("Selected index cannot be empty");
            continue;
        }
        if (int.TryParse(userInput, out int index) && 
            index >= 1 &&
            index <= todos.Count)
        {
            var indexOfTodo = index - 1;
            var todotobemoved = todos[indexOfTodo];
            todos.RemoveAt(index - 1);
            isValidIndex = true;
            Console.WriteLine("ToDo removed: " + todotobemoved);
        }
        else
        {
            Console.WriteLine("The given index is not valid.");

        }
    }
}