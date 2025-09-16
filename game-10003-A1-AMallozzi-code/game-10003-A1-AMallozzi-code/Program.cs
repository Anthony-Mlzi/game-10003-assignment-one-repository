//Assignment One interactive terminal project
//Escape the Alchemist's chambers

//introduction
    Console.WriteLine("You wake on a worn leather stretcher.");
    Console.WriteLine("Staring up at the dimly lit ceiling, your head pounding, you try to recall recent memories.");
    Console.WriteLine("Where are you? Why am I on a stretcher? What time is it? Who put you here? Who are you?");
    Console.WriteLine("A sharp pain as you shift interrupts your thoughts, you look down");
    Console.WriteLine("to find a deep cut along your side, slowly bleeding.");
    Console.WriteLine("you need to stand up, and get out before the bloodloss takes you...");

    //defining user input, first choices, items and blood

    string userInput = Console.ReadLine();

    bool actionStand = userInput.Contains("stand");

    bool actionLook = userInput.Contains("look");

    bool actionSitUp = userInput.Contains("sit");

    int blood = 1000;


            if (actionStand == true)
            {
                Console.WriteLine("you stand up from the stretcher, the floor is old hardwood and creaks with your weight");
                Console.WriteLine("the room around you contains several curiousities.");
                Console.WriteLine("> a stretcher");
                Console.WriteLine("> a door");
                Console.WriteLine("> a torch");
                Console.WriteLine("> a desk");
                Console.WriteLine("> a short sword");
                Console.WriteLine("Perhaps you should look for a way out.");
    blood -= 100;
    Console.WriteLine($"you only have {blood} blood left.");
    userInput = Console.ReadLine();
}

            else if (actionLook == true)
            {
                Console.WriteLine("You Look around the room.");
                Console.WriteLine("the room around you contains several curiousities.");
                Console.WriteLine("> a stretcher");
                Console.WriteLine("> a door");
                Console.WriteLine("> a torch");
                Console.WriteLine("> a desk");
                Console.WriteLine("> a short sword");
                Console.WriteLine("Perhaps you should look for a way out.");
    blood -= 100;
    Console.WriteLine($"you only have {blood} blood left.");
    userInput = Console.ReadLine();
}

            else if (actionSitUp == true)
            {
                Console.WriteLine("You sit up.");
                Console.WriteLine("the room around you contains several curiousities.");
                Console.WriteLine("> a stretcher");
                Console.WriteLine("> a door");
                Console.WriteLine("> a torch");
                Console.WriteLine("> a desk");
                Console.WriteLine("> a short sword");
                Console.WriteLine("Perhaps you should take a closer look at something...");
    blood -= 100;
    Console.WriteLine($"you only have {blood} blood left.");
    userInput = Console.ReadLine();   
            }

            else
            {
                Console.WriteLine("Please enter a valid command.");
                userInput = Console.ReadLine();
            }



if (userInput.Contains("stretcher"))
{
    Console.WriteLine("you inspect the stretcher you woke up on.");
    Console.WriteLine("a rusty brass frame holds the torn leather bed atop.");
    Console.WriteLine("it smells metallic and a hint of something sour.");
    Console.WriteLine("Doesn't look like there's anything of value here, maybe somewhere else?");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInput = Console.ReadLine();
}
else if (userInput.Contains("door")) 
{
    Console.WriteLine("you approach the door");
    Console.WriteLine("It's made of some kind of dark stained wood and fixed with a large metal frame.");
    Console.WriteLine("the doorknob is intricately engraved, just below it is a large metal box with a keyhole.");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInput = Console.ReadLine();
}
else if (userInput.Contains("torch")) 
{
    Console.WriteLine("The torch mounted on the wall illuminates the stone brick room.");
    Console.WriteLine("The dancing flames warm your blood and bring you comfort.");
    Console.WriteLine("it's not locked in place and could be removed from its mount if necessary.");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInput = Console.ReadLine();
}
else if (userInput.Contains("desk"))
{
    Console.WriteLine("The old desk is covered in clutter.");
    Console.WriteLine("Scrolls, bottles, and quills cover the scarred surface.");
    Console.WriteLine("There is a single drawer, closed.");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInput = Console.ReadLine();
}
else if (userInput.Contains("sword"))
{
    Console.WriteLine("a short sword hangs on the wall opposite the desk.");
    Console.WriteLine("The blade is thin and sharp, the hilt secured to the wall with a knotted rope");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInput = Console.ReadLine();
}
else
{
    Console.WriteLine("Please enter a valid response");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInput = Console.ReadLine();
}
//first user input complete
//define second user input


/*

string userInputTwo = Console.ReadLine();

if (userInputTwo.Contains("stretcher"))
{
    Console.WriteLine("you inspect the stretcher you woke up on.");
    Console.WriteLine("a rusty brass frame holds the torn leather bed atop.");
    Console.WriteLine("it smells metallic and a hint of something sour.");
    Console.WriteLine("Doesn't look like there's anything of value here, maybe somewhere else?");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
}

else if (userInputTwo.Contains("door"))
{
    Console.WriteLine("you approach the door");
    Console.WriteLine("It's made of some kind of dark stained wood and fixed with a large metal frame.");
    Console.WriteLine("the doorknob is intricately engraved, just below it is a large metal box with a keyhole.");
    String userDoor = Console.ReadLine();

    if (userDoor.Contains("open"))
    {
        Console.WriteLine("You reach for the doorknob and turn but it doesn't budge");
        Console.WriteLine("must be locked, maybe the key is somewhere in the room?");
    }
}

else if (userInputTwo.Contains("window"))
{
    Console.WriteLine("The window sits close to the ceiling just above the stretcher.");
    Console.WriteLine("On the other side of the three hefty iron bars of the slit");
    Console.WriteLine("You can see the darkness of the infinite night");
    Console.WriteLine("If there's a way out, this isn't it...");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
}

else if (userInputTwo.Contains("torch"))
{
    Console.WriteLine("The torch mounted on the wall illuminates the stone brick room.");
    Console.WriteLine("The dancing flames warm your blood and bring you comfort.");
    Console.WriteLine("it's not locked in place and could be removed from its mount if necessary.");
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
    userInputTwo = Console.ReadLine();

    string actionTorch = Console.ReadLine();
}
if (actionTor.Contains("take")) ;
{
    Console.WriteLine("you lift the torch from its rusted metal frame.");
    Console.WriteLine("You now have a torch.");
    itemTorch = true;
    blood -= 150;
    Console.WriteLine($"you only have {blood} blood left");
}
userInputTwo = Console.ReadLine();
}
*/