using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Pages
{
    public partial class BladSteenSchaar
    {
        private Random random = new Random();
        private static int ScoreUser { get; set; }
        private static int ScoreComputer { get; set; }
        private string RoundInfo { get; set; }

        private void Speel(string choice)
        {
            string computerChoice = ComputerChoice();
            if (Win(computerChoice,choice) == null)
            {
                RoundInfo = $"You draw this round: you played {choice} and computer played {computerChoice}";
            }
            else if (Win(computerChoice, choice) == true)
            {
                RoundInfo = $"You won this round: you played {choice} and computer played {computerChoice}";
                ScoreUser++;
            }
            else
            {
                RoundInfo = $"You lost this round: you played {choice} and computer played {computerChoice}";
                ScoreComputer++;
            }

        }

        private string ComputerChoice()
        {
            int choice = random.Next(5);
            switch (choice)
            {
                case 0:
                    return "blad";
                   
                case 1:
                    return "schaar";
                case 2:
                    return "lizard";

                case 3:
                    return "spok";

                default:
                    return "steen";
                   
            }
        }
        private bool? Win(string computerChoice, string choice)
        {
            if (computerChoice == choice)
            {
                return null;
            }
            if (computerChoice == "blad")
            {
                switch (choice)
                {

                    case "steen":
                        return false;
                    case "lizard":
                        return true;
                    case "spok":
                        return false;

                    default:
                        return true;

                }
            }
            if (computerChoice == "steen")
            {
                switch (choice)
                {

                    case "schaar":
                        return false;
                    case "lizard":
                        return false;
                    case "spok":
                        return true;

                    default:
                        return true;

                }
            }
            if (computerChoice == "schaar")
            {
                switch (choice)
                {

                    case "blad":
                        return false;
                    case "lizard":
                        return false;
                    case "spok":
                        return true;

                    default:
                        return true;

                }
            }
            if (computerChoice == "lizard")
            {
                switch (choice)
                {

                    case "blad":
                        return false;
                    case "schaar":
                        return true;
                    case "spok":
                        return false;

                    default:
                        return true;

                }
            }
            if (computerChoice == "spok")
            {
                switch (choice)
                {

                    case "blad":
                        return true;
                    case "lizard":
                        return true;
                    case "schaar":
                        return false;
                    default:
                        return false;

                }
            }
            return null;
        }
    }
}
