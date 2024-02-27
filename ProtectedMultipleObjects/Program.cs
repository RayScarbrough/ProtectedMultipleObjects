using System;

namespace PrivateMultipleObjects
{
    class Player
    {
        protected string name;
        protected int age;
        protected string position;

        public Player()
        {
            name = "Unknown";
            age = 0;
            position = "Undefined";
        }

        public Player(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
        }

        public void SetName(string name) => this.name = name;
        public void SetAge(int age) => this.age = age;
        public void SetPosition(string position) => this.position = position;

        public string GetName() => name;
        public int GetAge() => age;
        public string GetPosition() => position;

        public virtual void AddChangeInfo()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Position: ");
            position = Console.ReadLine();
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Position: {position}");
        }
    }

    class RunningBack : Player
    {
        protected double rushingYards;
        protected int touchdowns;

        public RunningBack() : base()
        {
            rushingYards = 0;
            touchdowns = 0;
        }

        public RunningBack(string name, int age, string position, double rushingYards, int touchdowns)
            : base(name, age, position)
        {
            this.rushingYards = rushingYards;
            this.touchdowns = touchdowns;
        }

        public void SetRushingYards(double rushingYards) => this.rushingYards = rushingYards;
        public void SetTouchdowns(int touchdowns) => this.touchdowns = touchdowns;

        public double GetRushingYards() => rushingYards;
        public int GetTouchdowns() => touchdowns;

        public override void AddChangeInfo()
        {
            base.AddChangeInfo();
            Console.Write("Enter Rushing Yards: ");
            rushingYards = double.Parse(Console.ReadLine());
            Console.Write("Enter Touchdowns: ");
            touchdowns = int.Parse(Console.ReadLine());
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Rushing Yards: {rushingYards}, Touchdowns: {touchdowns}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];
            players[0] = new Player();
            players[1] = new RunningBack();

            string choice;
            do
            {
                Console.WriteLine("\n1. Add/Change Player Info\n2. Add/Change RunningBack Info\n3. Display Player Info\n4. Display RunningBack Info\n5. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        players[0].AddChangeInfo();
                        break;
                    case "2":
                        players[1].AddChangeInfo();
                        break;
                    case "3":
                        players[0].DisplayInfo();
                        break;
                    case "4":
                        players[1].DisplayInfo();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != "5");
        }
    }
}
