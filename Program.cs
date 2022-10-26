// John Magpantay
// 10-22-22
// Mini Challange 1 "Hello World!" github
// Peer Review.  

int numOne = 0;
bool validName = true;
bool newName = true;

while (validName == true)
{

    Console.WriteLine("Hello, What is your name?");

    string anothaName = Console.ReadLine();

    newName = Int32.TryParse(anothaName, out numOne);

    if (newName == true)
    {
        Console.WriteLine("Invalid answer! try not using digits :p");


    }
    else
    {

        Console.WriteLine(" Hello neighbor , " + anothaName + ", would you like some tea or coffee? ");
    }

}

