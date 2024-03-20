using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Rock Paper Scissors
// - Kullanıcıyı karşıla, oyunun mantığını anlat.
// - Oyunu başlatmak için sorgu oluştur.
// - Oyuncunun belirli bir tuşa bastığında rock, paper veya scissors yapmasını sağla.
// - Oyuncu seçimini yaptıktan sonra bot rock paper veya scissorstan rastgele birini alsın.
// - Ekrana oyuncunun seçtiğini ve botun seçtiğini yazdır.
// - Duruma göre kazandın veya kaybettin yazısı getir.

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rock, paper scissors game!");
            Console.WriteLine("Please write your name for continue...");
            Console.WriteLine();
            string user = Console.ReadLine();
            int winstat = 0;
            int drawstat = 0;
            int losestat = 0;

            Console.WriteLine("Welcome to the game " + user + "!");
            while (true)
            {
                Console.WriteLine("Type `start` for start the game...");
                Console.WriteLine("Type `stats` for see your stats.");
                string choice = Console.ReadLine();
                if (choice == "start")
                {
                    Console.WriteLine("Choose your pick...(rock/paper/scissors)");
                    Console.WriteLine("");
                    string userchoice = Console.ReadLine();
                    string[] options = { "rock", "paper", "scissors" };
                    Random rastgele = new Random();
                    int randomIndex = rastgele.Next(options.Length);
                    string botchoice = options[randomIndex];
                    Console.WriteLine("[" + user + "]" + " " + userchoice);
                    Console.WriteLine("[Bot]" + " " + botchoice);
                    Console.WriteLine("");
                    Console.WriteLine("");

                    if (userchoice == "rock")
                    {
                        if (botchoice == "rock")
                        {
                            Console.WriteLine("Draw, try again.");
                            drawstat = drawstat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (botchoice == "scissors")
                        {
                            Console.WriteLine("You won, congratulations!");
                            winstat = winstat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (botchoice == "paper")
                        {
                            Console.WriteLine("You lost, dont give up and try again!");
                            losestat = losestat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                    if (userchoice == "scissors")
                    {
                        if (botchoice == "rock")
                        {
                            Console.WriteLine("You lost, dont give up and try again.");
                            losestat = losestat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (botchoice == "scissors")
                        {
                            Console.WriteLine("Draw, try again.");
                            drawstat = drawstat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (botchoice == "paper")
                        {
                            Console.WriteLine("You won, congratulations!");
                            winstat = winstat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                    if (userchoice == "paper")
                    {
                        if (botchoice == "rock")
                        {
                            Console.WriteLine("You won, congratulations!");
                            winstat = winstat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (botchoice == "scissors")
                        {
                            Console.WriteLine("You lost, dont give up and try again.");
                            losestat = losestat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (botchoice == "paper")
                        {
                            Console.WriteLine("Draw, try again.");
                            drawstat = drawstat + 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value, please try again.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (choice == "stats")
                {
                    float totalraund = winstat + losestat + drawstat;
                    float average = (float)winstat / totalraund;
                    Console.WriteLine(user + " " + "stats:");
                    Console.WriteLine("Win Stats: " + winstat);
                    Console.WriteLine("Lose Stats: " + losestat);
                    Console.WriteLine("Draw Stats:" + drawstat);
                    Console.WriteLine("Your Average: " + average);
                }
            }

        }
        }
}
