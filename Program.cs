using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_ScissorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            bool playagain = true;
            string player;
            string computer;
            while(playagain )
            {
                player = "";
                computer = "";
                while(player != "ROCK" && player!="PAPER" && player !="SCISSOR" ) {
                    Console.Write("ENTER 'ROCK','PAPER','SCISSOR':");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                switch (random.Next(1, 4)){
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;

                }
                Console.WriteLine("player:" + player);
                Console.WriteLine("Computer:" + computer);
                switch (player)
                {
                    case "ROCK":
                        if (computer=="ROCK")
                        {
                            Console.WriteLine("its a DRAW");
                        }
                        else if (computer=="PAPER")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("you LOOSE!");
                        }
                        
                        else
                        {
                            Console.WriteLine("you win!");
                        }
                        break;

                    case "SCISSOR":
                        if (computer=="SCISSOR")
                        {
                            Console.WriteLine("draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("you loose!");
                        }
                        else
                        {
                            Console.WriteLine("you win!");
                        }
                        break;
                }
                Console.Write("you want to play again y/n: ");
                string answer= Console.ReadLine();
                answer=answer.ToUpper();
                if (answer == "Y")
                {
                    playagain= true;
                }
                else
                {
                    playagain= false;
                    Console.WriteLine("THANKS FOR PLAYING....!");
                }
            }
        }
    }
}
