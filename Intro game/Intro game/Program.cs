
using System;
using System.Security.Cryptography.X509Certificates;

class InroGame
{
    static public void Main(String[] args)
    {
        bool win = false; //Remeber to make this false when done testing win state.
        bool game = true;
        //Plays the game.
        while (game == true)
        {
            //Delete when testing is done
            Console.WriteLine("this is the start of the game"); 
            win = true;
            while (win == true) //Checks for win state.
            {
                //Checks if the player wants to play again.
                Console.WriteLine("Do you want to play again type y for yes and n for no");
                string again = Console.ReadLine();

                //Ends the game when the anwser is no.
                if (again == "n")
                {
                    Console.WriteLine("its sad to see you go come back soon! okay?");
                    game = false;
                    win = false;
                }s
                //Restarts the game when the anwser is yes.
                if (again == "y")
                {
                    Console.WriteLine("Yeah stay as long as you would like!");
                    game = true;
                    win = false;
                }
                //Handels when player types a bad expression
                else
                {
                    Console.WriteLine("Please only anwser in y for yes and n for no");
                }
            }
        }
    }
}
