using System;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100; // Starting health
        Score = 0;
    }

    public void Attack()
    {
        // Simulate an attack on the player
        Health -= 20; // 20 damage per attack
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Haunted Forest Adventure!");
        Console.Write("Enter your character's name: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName);

        Console.WriteLine($"You, {player.Name}, enter a dark and mysterious forest...");

        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You explore deeper into the forest...");

                    // Simulate an encounter with a creature
                    int randomEvent = new Random().Next(1, 5);

                    switch (randomEvent)
                    {
                        case 1:
                            Console.WriteLine("You encounter a friendly squirrel.");
                            Console.WriteLine("You gain 10 points.");
                            player.Score += 10;
                            break;
                        case 2:
                            Console.WriteLine("A spooky ghost appears and attacks!");
                            player.Attack();
                            Console.WriteLine($"Your health: {player.Health}");
                            break;
                        case 3:
                            Console.WriteLine("You find a treasure chest!");
                            Console.WriteLine("You gain 20 points.");
                            player.Score += 20;
                            break;
                        case 4:
                            Console.WriteLine("You stumble upon an ancient shrine.");
                            Console.WriteLine("Do you make an offering?");
                            Console.WriteLine("1. Make an offering");
                            Console.WriteLine("2. Continue without offering");
                            string shrineChoice = Console.ReadLine();
                            if (shrineChoice == "1")
                            {
                                Console.WriteLine("The shrine grants you a blessing.");
                                Console.WriteLine("You gain 30 points.");
                                player.Score += 30;
                            }
                            else
                            {
                                Console.WriteLine("You continue on your journey.");
                            }
                            break;
                    }

                    // Check player health
                    if (player.Health <= 0)
                    {
                        Console.WriteLine("Your health has fallen to 0. You lose!");
                        gameOver = true;
                    }

                    break;

                case "2":
                    Console.WriteLine($"Thank you for playing, {player.Name}.");
                    gameOver = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        // Display the player's score at the end of the game
        Console.WriteLine($"Your final score: {player.Score}");
    }
}
