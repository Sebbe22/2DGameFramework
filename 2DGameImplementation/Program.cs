// See https://aka.ms/new-console-template for more information
using _2DGameLibrary;
using _2DGameLibrary.Moveing;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

World world = new World(22,22);

world.Print2DArray();
StateMachineMove Move = new StateMachineMove();
Creature orc = new Creature(new Position(4, 4), 100, "maggot");
DefenseItem chest = new DefenseItem("basic chest", 5);
orc.PickUpItem(chest);
Creature elf = new Creature(new Position(5, 4), 150, "elf");
elf.Attack(orc, 10);
AttackItem sword = new AttackItem("basic sword", 10, 10);
elf.PickUpItem(sword);
elf.Attack(orc, 10);
Console.WriteLine(orc.HP);

int x;
int y;
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

        world.Array[elf.Position.X, elf.Position.Y] = 'E';

    }
    world.Print2DArray();
    Console.WriteLine($"X: {elf.Position.X}");
    Console.WriteLine($"Y: {elf.Position.Y}");
    Thread.Sleep(1000);
}