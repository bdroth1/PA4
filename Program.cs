using System;
using ConsoleApp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game!");

            Console.Write("Enter player 1 name: ");
            string player1Name = Console.ReadLine();

            Console.WriteLine("Select your character:");
            Character player1Character = SelectCharacter();

            Console.Write("Enter player 2 name: ");
            string player2Name = Console.ReadLine();

            Console.WriteLine("Select your character:");
            Character player2Character = SelectCharacter();

            Console.WriteLine("\nLet the game begin!");

            Random random = new Random();
            Character currentAttacker = random.Next(2) == 0 ? player1Character : player2Character;
            Character currentDefender = currentAttacker == player1Character ? player2Character : player1Character;

            while (player1Character.IsAlive() && player2Character.IsAlive())
            {
                Console.WriteLine($"{currentAttacker.Name}'s turn");

                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                bool isActionSelected = false;
                while (!isActionSelected)
                {
                    Console.Write("Enter action number: ");
                    string action = Console.ReadLine();

                    if (action == "1")
                    {
                        Console.WriteLine($"{currentAttacker.Name} attacks {currentDefender.Name}!");
                        currentAttacker.Attack(currentDefender);
                        Console.WriteLine($"{currentDefender.Name} health: {currentDefender.Health}");
                        isActionSelected = true;
                    }
                    else if (action == "2")
                    {
                        Console.WriteLine($"{currentAttacker.Name} defends against {currentDefender.Name}'s attack.");
                         int damage = currentDefender.Attack(currentDefender);
                        currentAttacker.Defend(damage);
                        isActionSelected = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid action number. Please enter 1 or 2.");
                    }
                }

                // Switch roles between attacker and defender
                Character temp = currentAttacker;
                currentAttacker = currentDefender;
                currentDefender = temp;
            }
            
            Console.WriteLine($"Game over!");
            Console.WriteLine($"{currentDefender.Name} has won the game!");
        }

        

        static Character SelectCharacter()
        {
            Console.WriteLine("1. Jack Sparrow");
            Console.WriteLine("2. Will Turner");
            Console.WriteLine("3. Davy Jones");

            bool isCharacterSelected = false;
            Character character = null;
            while (!isCharacterSelected)
            {
                Console.Write("Enter character number: ");
                string characterNumber = Console.ReadLine();

                if (characterNumber == "1")
                {
                    character = new JackSparrow();
                    isCharacterSelected = true;
                }
                else if (characterNumber == "2")
                {
                    character = new WillTurner();
                    isCharacterSelected = true;
                }
                else if (characterNumber == "3")
                {
                    character = new DaveyJones();
                    isCharacterSelected = true;
                }
                else
                {
                    Console.WriteLine("Invalid character number. Please enter 1, 2, or 3.");
                }
                Console.Clear();
            }

            Console.WriteLine($"{character.Name} stats:");
            Console.WriteLine($"Max Power: {character.MaxPower}");
            Console.WriteLine($"Health: {character.Health}");
            Console.WriteLine($"Attack Strength: {character.AttackStrength}");
            Console.WriteLine($"Defensive Power: {character.DefensivePower}");

            return character;
        }
    }
}
