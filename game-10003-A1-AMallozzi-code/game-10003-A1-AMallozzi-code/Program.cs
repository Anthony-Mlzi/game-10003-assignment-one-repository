//Assignment One interactive terminal project
//remove the patients organs

//Define Variables

int bodyCondition = 100;

string scalpel = ("scalpel");
string circsaw = ("circsaw");
string bonesaw = ("bonesaw");
string hammer = ("hammer");
string hands = ("hands");

bool perfectOperation = false;
bool goodOperation = false;
bool okayOperation = false;
bool badOperation = false;
bool failedOperation = false;

//start game

Console.WriteLine("As the best doctor in North West Burmingshire");
Console.WriteLine("it is no wonder the duke himself has called upon you to perform such a task!");
Console.WriteLine("The duke needs a Lung transplant, you must oblige.");
Console.WriteLine("First, you will announce your last name!");
//define user name
    String userName = Console.ReadLine();

Console.WriteLine($"Yes yes of course you are THE Dr.{userName}!");
Console.WriteLine("How old are you again? The years have not been kind to my memories.");

//define user age and years in the medical field
    int playerAge = int.Parse(Console.ReadLine());
    int doctorAge = playerAge / 2;

Console.WriteLine($"Ah yes of course you are {playerAge}, you've been studying medicine for {doctorAge} years!");

Console.WriteLine("Jolly good, The duke is on the operating table, and your tools laid out.");
Console.WriteLine("My scalpel!");
Console.WriteLine("My circsaw!");
Console.WriteLine("My bonesaw!");
Console.WriteLine("My hammer!");
Console.WriteLine("My hands!");
Console.WriteLine("Remember good Doctor, a good choice of tool and sharp mind is needed to maintain the body condition.");
Console.WriteLine("This is the Duke himself after all!");
Console.WriteLine("Right, first the skin of the torso must be opened, what tool shall you use?");

//Begin operating on the skin
//scalpel choice
string skinTool = Console.ReadLine();
if (skinTool.Contains(scalpel))
{
    Console.WriteLine($"excellent choice Doctor {userName}, a true surgeons tool!");
    Console.WriteLine($"you draw a good strong slice, but what shape was the cut supposed to be in again? Was it an x or y?");
    
        string skinKnow = Console.ReadLine();
    if (skinKnow.Contains("y"))
    {
        Console.WriteLine("Yes of course! The cut should be in the shape of a y.");
    }
    else if (skinKnow.Contains("x"))
    {
        Console.WriteLine("I'm not so sure that's right but you're the doctor!");
        bodyCondition -= 10;
    }
    else
    {
        Console.WriteLine("Well the medical field is full of mysteries, best just try something...");
        bodyCondition -= 10;
    }
        Console.WriteLine("you've opened the torso and revealed the ribs.");
}

//circsaw choice
if (skinTool.Contains(circsaw))
{
    Console.WriteLine($"Interesting choice Doctor {userName}, I suppose it is a blade after all.");
    Console.WriteLine($"you draw a shaky slice, but what shape was the cut supposed to be in again? Was it an x or y?");

    string skinKnow = Console.ReadLine();
    if (skinKnow.Contains("y"))
    {
        Console.WriteLine("Yes of course! The cut should be in the shape of a y.");
        bodyCondition -= 10;
    }
    else if (skinKnow.Contains("x"))
    {
        Console.WriteLine("I'm not so sure that's right but you're the doctor!");
        bodyCondition -= 15;
    }
    else
    {
        Console.WriteLine("Well the medical field is full of mysteries, best just try something...");
        bodyCondition -= 15;
    }
    Console.WriteLine("You bring the violent blade across the chest, blood paints your scrubs and ruins the decor.");
    Console.WriteLine("Not perfect but you have revealed the ribs.");
}

//boonesaw choice
if (skinTool.Contains(bonesaw))
{
    Console.WriteLine($"uhh... Doctor I am not too sure if that is a good idea...");
    Console.WriteLine("You begin the grisly process of flaying the skin in a motion like that of woodworking.");
    Console.WriteLine("But wait! What shape was the cut supposed to be in again? Was it an x or y?");

    string skinKnow = Console.ReadLine();
    if (skinKnow.Contains("y"))
    {
        Console.WriteLine("Yes of course! The cut should be in the shape of a y.");
        bodyCondition -= 10;
    }
    else if (skinKnow.Contains("x"))
    {
        Console.WriteLine("I'm not so sure that's right but you're the doctor!");
        bodyCondition -= 15;
    }
    else
    {
        Console.WriteLine("Well the medical field is full of mysteries, best just try something...");
        bodyCondition -= 15;
    }
    Console.WriteLine("It's a symphony of flesh! what a mess...");
    Console.WriteLine("Good Lord that'll leave a scar, but you are on to the ribs regardless.");
}

//hammer choice
if (skinTool.Contains(hammer))
{
    Console.WriteLine("Doctor no! How did that even get into the operating room!?");
    Console.WriteLine("You use the back of the hammer like a wrench, pulling and tearing the skin away!");
    Console.WriteLine("Hold on! What shape was the cut supposed to be in again? Was it an x or y?");

    string skinKnow = Console.ReadLine();
    if (skinKnow.Contains("y"))
    {
        Console.WriteLine("Yes of course! The cut should be in the shape of a y.");
        bodyCondition -= 20;
    }
    else if (skinKnow.Contains("x"))
    {
        Console.WriteLine("I'm not so sure that's right but you're the doctor!");
        bodyCondition -= 30;
    }
    else
    {
        Console.WriteLine("Well the medical field is full of mysteries, best just try something...");
        bodyCondition -= 30;
    }
    Console.WriteLine("You have shown your twisted mind upon this day...");
    Console.WriteLine("But you have revealed the ribs.");
}

//hands choice
if (skinTool.Contains(hands))
{
    Console.WriteLine("Dear God, what on earth are you doing!?");
    Console.WriteLine("You crack your knuckles and get to grabbing and pulling the torso apart.");
    Console.WriteLine("You have violated the medical process.");
    bodyCondition -= 30;
    Console.WriteLine("Yes, the ribs are revealed, but... at what cost?");
}

//operating on the skin is concluded
//begin operating on the ribs

Console.WriteLine("With the skin open, the ribs are next, perhaps a change of tool is in order?");
Console.WriteLine("My scalpel!");
Console.WriteLine("My circsaw!");
Console.WriteLine("My bonesaw!");
Console.WriteLine("My hammer!");
Console.WriteLine("My hands!");
Console.WriteLine("What shall you use?");

string ribTool = Console.ReadLine();

//scalpel choice
if (ribTool.Contains("scalpel"))
{
    Console.WriteLine("Doctor I admire your commitment to precision Doctor but...");
    Console.WriteLine("I don't know about this.");
    Console.WriteLine("Before you start, how many ribs do humans have again?");
    
    int ribKnow = int.Parse(Console.ReadLine());
    if (ribKnow == 24)
    {
        Console.WriteLine($"Ah yes that is correct, {ribKnow}");
        bodyCondition -= 10;
    }
    else
    {
        Console.WriteLine("Numbers were never your strong suit...");
        bodyCondition -= 10;
    }
    Console.WriteLine("It takes hours, and more than a couple scalpels,");
    Console.WriteLine("but by pure friction you have dismantled the ribcage.");
    Console.WriteLine("The ribs have been removed.");
}

//circsaw choice
if (ribTool.Contains("circsaw"))
{
    Console.WriteLine("A good choice Doctor, a tool of many uses.");
    Console.WriteLine("Before you start, how many ribs do humans have again?");

    int ribKnow = int.Parse(Console.ReadLine());
    if (ribKnow == 24)
    {
        Console.WriteLine($"Ah yes that is correct, {ribKnow}");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine("Numbers were never your strong suit...");
        bodyCondition -= 10;
    }
    Console.WriteLine("It takes quite some time but the work is relatively clean.");
    Console.WriteLine("The ribs have been removed.");
}

//bonesaw choice
if (ribTool.Contains("bonesaw"))
{
    Console.WriteLine("A perfect choice Doctor! The bane of marrow itself.");
    Console.WriteLine("Before you start, how many ribs do humans have again?");

    int ribKnow = int.Parse(Console.ReadLine());
    if (ribKnow == 24)
    {
        Console.WriteLine($"Ah yes that is correct, {ribKnow}");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine("Numbers were never your strong suit...");
        bodyCondition -= 5;
    }
    Console.WriteLine("You delicately saw each rib at the outer edge of the torso");
    Console.WriteLine("A magnificent job, good sir.");
    Console.WriteLine("The ribs have been removed.");
}

//hammer choice
if (ribTool.Contains("hammer"))
{
    Console.WriteLine("A bit unconventional and messy, but a tough job requires a tough tool I suppose.");
    Console.WriteLine("Before you start, how many ribs do humans have again?");

    int ribKnow = int.Parse(Console.ReadLine());
    if (ribKnow == 24)
    {
        Console.WriteLine($"Ah yes that is correct, {ribKnow}");
        bodyCondition -= 5;
    }
    else
    {
        Console.WriteLine("Numbers were never your strong suit...");
        bodyCondition -= 15;
    }
    Console.WriteLine("You raise the hammer high and bring it down harsh on the sternum.");
    Console.WriteLine("a series of consecutive hits loosens the cage enough for it to be pulled.");
    Console.WriteLine("The ribs have been removed.");
}

//hands choice
if (ribTool.Contains("hands"))
{
    Console.WriteLine("Jesus of Nazareth, your bare hands? Are you mad?");
    Console.WriteLine("Before you start, how many ribs do humans have again?");

    int ribKnow = int.Parse(Console.ReadLine());
    if (ribKnow == 24)
    {
        Console.WriteLine($"Ah yes that is correct, {ribKnow}");
        bodyCondition -= 10;
    }
    else
    {
        Console.WriteLine("Numbers were never your strong suit...");
        bodyCondition -= 10;
    }
    Console.WriteLine("You pull up your sleeves and wrap your fist around the first rib");
    Console.WriteLine("With a hard twist and yank, the rib is free with a disturbing pop.");
    Console.WriteLine("You continue on, repeating the process...");
    Console.WriteLine("The ribs have been removed.");
}
//operating on the ribs complete
//begin operating on the lungs

Console.WriteLine("Now that the ribs are removed, the lungs are next, perhaps a change of tool is in order?");
Console.WriteLine("Remember Doctor, the lungs must be removed at the trachea, a chamber of cartilage and bone.");
Console.WriteLine("My scalpel!");
Console.WriteLine("My circsaw!");
Console.WriteLine("My bonesaw!");
Console.WriteLine("My hammer!");
Console.WriteLine("My hands!");
Console.WriteLine("What shall you use?");

string lungtool = Console.ReadLine();

//scalpel
if (lungtool.Contains("scalpel"))
{
    Console.WriteLine("Interesting choice Doctor, you may have some ");
    Console.WriteLine("");

    string lungknow = Console.ReadLine();
    if (lungknow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
        {
        Console.WriteLine();
        bodyCondition -= 0;
        }
    Console.WriteLine("The Lungs have been removed.");
}
//circsaw
if (lungtool.Contains("circsaw"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string lungknow = Console.ReadLine();
    if (lungknow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The Lungs have been removed.");
}
//bonesaw
if (lungtool.Contains("bonesaw"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string lungknow = Console.ReadLine();
    if (lungknow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The Lungs have been removed.");
}
//hammer
if (lungtool.Contains("hammer"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string lungknow = Console.ReadLine();
    if (lungknow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The Lungs have been removed.");
}
//hands
if (lungtool.Contains("hands"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string lungknow = Console.ReadLine();
    if (lungknow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The Lungs have been removed.");
}

//Lung operation complete

Console.WriteLine("");
Console.WriteLine("Now that the lungs are removed, the heart is next, perhaps a change of tool is in order?");
Console.WriteLine("Remember Doctor, the heart is very delicate, be sure to take good care.");
Console.WriteLine("My scalpel!");
Console.WriteLine("My circsaw!");
Console.WriteLine("My bonesaw!");
Console.WriteLine("My hammer!");
Console.WriteLine("My hands!");
Console.WriteLine("What shall you use?");

string heartTool = Console.ReadLine();

//scalpel
if (heartTool.Contains("scalpel"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string heartKnow = Console.ReadLine();
    if (heartKnow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The heart has been removed.");
}
//circsaw
if (heartTool.Contains("circsaw"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string lungknow = Console.ReadLine();
    if (lungknow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The heart has been removed.");
}
//bonesaw
if (heartTool.Contains("bonesaw"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string heartKnow = Console.ReadLine();
    if (heartKnow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The heart has been removed.");
}
//hammer
if (heartTool.Contains("hammer"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string heartKnow = Console.ReadLine();
    if (heartKnow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The heart has been removed.");
}
//hands
if (heartTool.Contains("hands"))
{
    Console.WriteLine("");
    Console.WriteLine("");

    string heartKnow = Console.ReadLine();
    if (heartKnow.Contains(""))
    {
        Console.WriteLine("");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine();
        bodyCondition -= 0;
    }
    Console.WriteLine("The heart has been removed.");
}
