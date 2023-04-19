// See https://aka.ms/new-console-template for more information
using _2DGameImplementation;
using _2DGameLibrary;
using _2DGameLibrary.Moveing;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

World world = new World();

world.Print2DArray();
StateMachineMove Move = new StateMachineMove();
world.AddObject(new Orc(new Position(4, 4), 100, "maggot", 10));
Orc orc = new Orc(new Position(4, 4), 100, "maggot", 10);
DefenseItem chest = new DefenseItem("basic chest", 5);
orc.PickUpItem(chest);
Creature elf = new Orc(new Position(5, 4), 150, "elf", 10);
elf.Attack(orc);
elf.PickUpItem(orc.Loot());
AttackItem sword = new AttackItem("basic sword", 10);
elf.PickUpItem(sword);
elf.Attack(orc);
Console.WriteLine(orc.HP);
orc.Attack(elf);
Position tempPosition = new Position(1, 1);
bool runGame = true;
while (runGame)
{
    if (Console.KeyAvailable)
    {
        char input = Console.ReadKey().KeyChar;
        if (input == 'q')
        {
            Console.WriteLine();
            Console.WriteLine("===you quit the game!===");
            Console.WriteLine();
            runGame = false;
            return;
        }
        world.Array[elf.Position.X, elf.Position.Y] = ' ';
        tempPosition = Move.MoveTrigger(input);
        elf.Position.X = elf.Position.X + tempPosition.X;
        elf.Position.Y = elf.Position.Y + tempPosition.Y;
    }
    world.Array[elf.Position.X, elf.Position.Y] = 'E';
    world.Print2DArray();
    Thread.Sleep(1000);
}