//Assignment One interactive terminal project
//Escape the Alchemist's chambers




Console.WriteLine("You wake on a worn leather stretcher.");
Console.WriteLine("Staring up at the dimly lit ceiling, your head pounding, you try to recall recent memories.");
Console.WriteLine("Where are you? Why am I on a stretcher? What time is it? Who put you here? Who are you?");
Console.WriteLine("Thinking is fool's game in your state, you need to do something, anything.");

int playerScore = 0;
    //First, lets define the user input
string userInputOne = Console.ReadLine();
        //then some actions for the player to take
    bool actionStand = userInputOne.Contains("stand");

    bool actionLook = userInputOne.Contains("look");

    bool actionSitUp = userInputOne.Contains("sit");

    bool actionInvalid = false;

if (actionStand == true)
{
    Console.WriteLine("you stand up from the stretcher, the floor is old hardwood and creaks with your weight");
    Console.WriteLine("the room around you contains several curiousities.");
    Console.WriteLine("> a stretcher");
    Console.WriteLine("> a door");
    Console.WriteLine("> a window");
    Console.WriteLine("> a torch");
    Console.WriteLine("> a rug");
    Console.WriteLine("> a fireplace");
    Console.WriteLine("> a desk");
    Console.WriteLine("> a shield");
    Console.WriteLine("Perhaps you should look for a way out.");
    playerScore ++;
}
else if (actionLook == true)
{
    Console.WriteLine("You Look around the room.");
    Console.WriteLine("the room around you contains several curiousities.");
    Console.WriteLine("> a stretcher");
    Console.WriteLine("> a door");
    Console.WriteLine("> a window");
    Console.WriteLine("> a torch");
    Console.WriteLine("> a rug");
    Console.WriteLine("> a fireplace");
    Console.WriteLine("> a desk");
    Console.WriteLine("> a shield");
    Console.WriteLine("Perhaps you should look for a way out.");
}
else if (actionSitUp == true)
{
    Console.WriteLine("You sit up.");
    Console.WriteLine("the room around you contains several curiousities.");
    Console.WriteLine("> a stretcher");
    Console.WriteLine("> a door");
    Console.WriteLine("> a window");
    Console.WriteLine("> a torch");
    Console.WriteLine("> a rug");
    Console.WriteLine("> a fireplace");
    Console.WriteLine("> a desk");
    Console.WriteLine("> a shield");
    Console.WriteLine("Perhaps you should look for a way out.");
}
else {
    Console.WriteLine("Please enter a valid command.");
}

string userInputTwo = Console.ReadLine();

bool = userInputTwo.Contains("");