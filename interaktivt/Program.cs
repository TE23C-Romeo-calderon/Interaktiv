Console.WriteLine("Pekka is riding down the streets on his motorbike but stumbles upon two paths to take, the one on");
Console.WriteLine("the left leads in to a dark forest, the one on the right leads to a city that looks like it has");
Console.WriteLine("been abandoned for some reason. Which path should Pekka take? left or right.");
string path1 = Console.ReadLine();
path1 = path1.ToLower();


if (path1 == "left")

{
    Console.WriteLine("Pekka goes on the left path and rides his way into the dark forest, following the path. It goes");
    Console.WriteLine("deeper in and its getting darker, should Pekka go back or should he continue the path til the");
    Console.WriteLine("end?(pick between go back or continue)");
    string path2 = Console.ReadLine();
    path2 = path2.ToLower();

    if (path2 == "go back")
 {
    Console.WriteLine("Pekka goes back the way he came from, after a long time he's out of the forest. The sky becomes");
    Console.WriteLine("dark and thunders start thundering. The thunder strikes down on him making him fall off his bike,another thunder strikes making a tree fall. Which landed on him. Unpredicable ending");
 }
    else if (path2 == "continue")
 {
    Console.WriteLine("Pekka continues the path til the end and drives deeper in to the dark forest. Pekka sees");
    Console.WriteLine("something far ahead, someone has put a wire at neck level by tying it between two trees."); 
    Console.WriteLine("Pekka tries to stop from going to fast but can't stop it. Pekka got decapitated. Death ending");
 }

}

else if (path1 == "right")

{
    Console.WriteLine("Pekka goes on the right path, riding his way to the city. Upon closing by to it he sees that it");
    Console.WriteLine("is abandoned for some reason and see a few people looking unwell straight ahead. Should Pekka");
    Console.WriteLine("go check on those people or should he go back from where he came from?(pick between go check and go back)");
    string path2 = Console.ReadLine();
    path2 = path2.ToLower();
    if (path2 == "go check")
 {
    Console.WriteLine("Pekka goes closer to them just to check how they are but realize something horrendous,he sees them");
    Console.WriteLine("having blood in their mouth and also sees a corpse which could only mean one thing, he's next. Pekka");
    Console.WriteLine("tries to get back to his motorbike but get tackled by them and can't do anything now to save himself. Eaten up ending");
 }
    else if (path2 == "go back")
 {
    Console.WriteLine("Pekka decides to go back from where he came from but feel a strange sense of presence, he looks back");
    Console.WriteLine("and sees a group of people walking to him, now they have started running. Pekka goes full speed and");
    Console.WriteLine("succesfully got away from them. Escaped death ending");
 }

}

else

 {
    Console.WriteLine("Wrong, try again");
 }