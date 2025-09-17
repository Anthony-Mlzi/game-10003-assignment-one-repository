//Assignment One interactive terminal project
//remove the patients organs

//Define Variables

int bodyCondition = 100;

string scalpel = ("scalpel");
string circsaw = ("circsaw");
string bonesaw = ("bonesaw");
string hammer = ("hammer");
string hands = ("hands");

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
        bodyCondition -= 20;
    }
    else
    {
        Console.WriteLine("Well the medical field is full of mysteries, best just try something...");
        bodyCondition -= 20;
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
    Console.WriteLine("It's a symphony of flesh! what a mess...");
    Console.WriteLine("Good Lord that'll leave a scar, but you are on to the ribs regardless.");
}
//hands choice
if (skinTool.Contains(hands))
{
    Console.WriteLine("Dear God, what on earth are you doing!?");
    Console.WriteLine("You crack your knuckles and get to grabbing and pulling the torso apart.");
    Console.WriteLine("You have violated the medical process.");
    bodyCondition -= 40;
    Console.WriteLine("Yes, the ribs are revealed, but... at what cost?");
}

//operating on the skin is concluded
//begin operating on the ribs

Console.WriteLine("With the skin open, the ribs are next, perhaps a change of tool is in order?");
Console.WriteLine("My scalpel!");
Console.WriteLine("My circsaw!");
Console.WriteLine("My bonesaw!");
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
        bodyCondition -= 5;
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
        bodyCondition -= 5;
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
//hands choice
if (ribTool.Contains("hands"))
{
    Console.WriteLine("Jesus of Nazareth, your bare hands? Are you mad?");
    Console.WriteLine("Before you start, how many ribs do humans have again?");

    int ribKnow = int.Parse(Console.ReadLine());
    if (ribKnow == 24)
    {
        Console.WriteLine($"Ah yes that is correct, {ribKnow}");
        bodyCondition -= 20;
    }
    else
    {
        Console.WriteLine("Numbers were never your strong suit...");
        bodyCondition -= 30;
    }
    Console.WriteLine("You pull up your sleeves and wrap your fist around the first rib");
    Console.WriteLine("With a hard twist and yank, the rib is free with a disturbing pop.");
    Console.WriteLine("You continue on, repeating the process...");
    Console.WriteLine("The ribs have been removed.");
}
//operating on the ribs complete
//begin operating on the lungs

Console.WriteLine("Now that the ribs are removed, the heart is next, perhaps a change of tool is in order?");
Console.WriteLine("Remember Doctor, the heart has tough arteries, they will not be easy to seperate!");
Console.WriteLine("My scalpel!");
Console.WriteLine("My circsaw!");
Console.WriteLine("My bonesaw!");
Console.WriteLine("My hands!");
Console.WriteLine("What shall you use?");

string heartTool = Console.ReadLine();

//scalpel
if (heartTool.Contains("scalpel"))
{
    Console.WriteLine("Interesting choice doctor, it won't be easy with such a thin");
    Console.WriteLine("tool but things could be worse I suppose!");
    Console.WriteLine("But just one minute! How many chambers does the heart have again?");

    int heartKnow = int.Parse(Console.ReadLine());
    if (heartKnow == 4)
    {
        Console.WriteLine("Bloody well done Doctor, that is correct!");
        bodyCondition -= 10;
    }
    else
    {
        Console.WriteLine("Caution to the wind I suppose, best just get on with it...");
        bodyCondition -= 20;
    }
    Console.WriteLine("You work up a sweat sawing at the tough tissue but manage to get through");
    Console.WriteLine("The heart has been removed.");
}
//circsaw
if (heartTool.Contains("circsaw"))
{
    Console.WriteLine("Perfect choice doctor! The circsaw will go through arteries like butter!");
    Console.WriteLine("But just one minute! How many chambers does the heart have again?");

    int heartKnow = int.Parse(Console.ReadLine());
    if (heartKnow == 4)
    {
        Console.WriteLine("Bloody well done Doctor, that is correct!");
        bodyCondition -= 0;
    }
    else
    {
        Console.WriteLine("Caution to the wind I suppose, best just get on with it...");
        bodyCondition -= 10;
    }
    Console.WriteLine("With the gentle motion of a composer, you seperate the arteries from the heart.");
    Console.WriteLine("The heart has been removed.");
}
//bonesaw
if (heartTool.Contains("bonesaw"))
{
    Console.WriteLine("Doctor I know I said the arteries were tough but that may be overkill...");
    Console.WriteLine("But just one minute! How many chambers does the heart have again?");

    int heartKnow = int.Parse(Console.ReadLine());
    if (heartKnow == 4)
    {
        Console.WriteLine("Bloody well done Doctor, that is correct!");
        bodyCondition -= 10;
    }
    else
    {
        Console.WriteLine("Caution to the wind I suppose, best just get on with it...");
        bodyCondition -= 20;
    }
    Console.WriteLine("You begin sawing, blood paints the walls and your gown as you");
    Console.WriteLine("push the blade back and forth.");
    Console.WriteLine("The heart has been removed.");
}
//hands
if (heartTool.Contains("hands"))
{
    Console.WriteLine("Dear Christ in Heaven! What demon has possessed you!");
    Console.WriteLine("You're bloody hands! You daft maniac.");
    Console.WriteLine("But just one minute! How many chambers does the heart have again?");

    int heartKnow = int.Parse(Console.ReadLine());
    if (heartKnow == 4)
    {
        Console.WriteLine("Bloody well done Doctor, that is correct!");
        bodyCondition -= 30;
    }
    else
    {
        Console.WriteLine("Caution to the wind I suppose, best just get on with it...");
        bodyCondition -= 40;
    }
    Console.WriteLine("With both hands you firmly grip the heart...");
    Console.WriteLine("Yoou bring your heels to the edge of the table and assume a crouched position as you tug");
    Console.WriteLine("with all of your weight.");
    Console.WriteLine("A grotesque pop and you fly back onto your bottom, the bloody mass in your lap.");
    Console.WriteLine("The heart has been removed.");
}

bool surgeryZero = bodyCondition < 0;
bool surgeryAbove = bodyCondition > 50;
bool surgeryBelow = bodyCondition <= 50;
bool surgeryFailure = surgeryBelow && surgeryZero;

Console.WriteLine($"Well that was something Dr.{userName}.");

if (surgeryAbove == true)
{
    Console.WriteLine("Well done, the Duke is saved and Burmingshire is in your gratitude!");
}
else if (surgeryAbove == false)
{
    if (surgeryBelow == true)
    {
        if (surgeryFailure == false)
        {
            Console.WriteLine("It would seem you've mauled the Duke, such a failure is astonding.");
        }
        else
        {
            Console.WriteLine("The poor Duke is unrecognizable, is this mass of blood and bone even human?");
        }
    }
}
