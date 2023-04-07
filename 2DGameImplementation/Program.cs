// See https://aka.ms/new-console-template for more information
using _2DGameLibrary;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

World world = new World(40,30);

world.Print2DArray();

Creature orc = new Creature(new Position(4, 4), 100, "maggot");
DefenseItem chest = new DefenseItem("basic chest", 5);
orc.PickUpItem(chest);
Creature elf = new Creature(new Position(5, 4), 150, "elf");
elf.Attack(orc, 10);
AttackItem sword = new AttackItem("basic sword", 10, 10);
elf.PickUpItem(sword);
elf.Attack(orc, 10);
Console.WriteLine(orc.HP);