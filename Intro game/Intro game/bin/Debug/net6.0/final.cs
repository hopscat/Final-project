
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class InroGame
{
    static public void Main(String[] args)
    {
         int deathTotal(int dth)
        {
            dth = 0;
            int total = 0;
            total = total + dth;
            // Lets provide a return statement  
            return total;
        }
        Random Rand = new Random();
        bool win = false; //Sets Win state
        bool game = true;  //Plays the game.
        bool death = false;   //Sets death state
        while (game == true)
        {
            if (death == true) //Checks for death state.
            {
                //Checks if the player wants to play again.
                Console.WriteLine("Do you want to play again type y for yes and n for no");
                string again2 = Console.ReadLine();

                //Ends the game when the anwser is no.
                if (again2 == "n")
                {
                    Console.WriteLine("its sad to see you go come back soon! okay?");
                    game = false;
                    win = false;
                }
                //Restarts the game when the anwser is yes.
                if (again2 == "y")
                {
                    Console.WriteLine("Yeah stay as long as you would like!");
                    game = true;
                    win = false;
                    deathTotal(+1);
                }
                //Handels when player types a bad expression
                else
                {
                    Console.WriteLine("Please only anwser in y for yes and n for no");
                }
                Console.WriteLine(deathTotal);

                Console.WriteLine("You start your shift a chilis... but its diffrent insted of the chilis its a maze.");
            Console.WriteLine("Ehh I get payed the same you think to your self and continue, press enter");
            Console.ReadLine();
            Console.Write("Theres something diffrent though its almost as the time of day changes... ");
            Console.WriteLine("You look back and wheres the entrence? you have no other choice but to push on till the end, press enter");
            Console.ReadLine();
            Console.WriteLine("You take a trun and see a enemy of some sort it seems to have a lot of mucle do you run or fight? type f for fight and r for run");
            string FightorRun = Console.ReadLine();
            if (FightorRun == "r")
            {
                Console.WriteLine("The entity was strong but not too fast so you manage to out run it and get away");
            }
            
            else
            {
                Console.WriteLine("You black out and never wake up its over");
                death = true;
            }

            Console.WriteLine("You see an entity that looks like the last one");
            string FightorRun2 = Console.ReadLine();
           
            if (FightorRun2 == "f")
            {
                Console.WriteLine("You hope to passout or something but that doesnt happen you have to endure untill you finaly die");
                death = true;
            }
           
            if (FightorRun2 == "r")
            {
                Console.WriteLine("You manange to run and get out of its reach before it can catch you");
            }
            Console.WriteLine("You see a limber looking entity");
            string FightorRun3 = Console.ReadLine();

            if (FightorRun3 == "f")
            {
                Console.WriteLine("the entity may be fast but its not strong and so you manage to over power it");
            }

            if (FightorRun3 == "r")
            {
                Console.WriteLine("the entiy is fast and you fail to out run it and well its history now");
                death = true;
            }
            Console.WriteLine("You see A entity with long limbs and hooved feet");
            string FightorRun4 = Console.ReadLine();

            if (FightorRun4 == "f")
            {
                Console.WriteLine("the entity was able to be overpowerd");
            }

            if (FightorRun4 == "r")
            {
                Console.WriteLine("Its all over of course my life would end at a chilli's");
                death = true;
            }
            Console.WriteLine("You see a limber looking entity ");
            string FightorRun5 = Console.ReadLine();

            if (FightorRun5 == "f")
            {
                Console.WriteLine("This entity has tremendous strength it easily overpowers you");
                death = true;
            }

            if (FightorRun5 == "r")
            {
                Console.WriteLine("Running was a good choice there is no way you could over power it did you see it through that light post like it was nothing?");
            }


            win = true;
            while (win == true) //Checks for win state.
            {
                Console.WriteLine("You manage to escape and once you get home you quit your job at chilli's");
                //Checks if the player wants to play again.
                Console.WriteLine("Do you want to play again type y for yes and n for no");
                string again = Console.ReadLine();


                //Ends the game when the anwser is no.
                if (again == "n")
                {
                    Console.WriteLine("its sad to see you go come back soon! okay?");
                    game = false;
                    win = false;
                }
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
}
