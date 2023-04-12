using _2DGameLibrary.Interface;

namespace _2DGameLibrary
{
    public class World
    {
        public List<WorldEntety> WorldObjects = new List<WorldEntety>();
        public List<Creature> Creatures { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public char[,] Array {get; set;} 

        public World(int x, int y)
        {
            MaxX = x;
            MaxY = y;

            Array = new char[x, y];

            SetArray(Array);
            SetObjectsInArray();
        }
        public void AddObject(WorldEntety obj)
        {
            WorldObjects.Add(obj);
            SetObjectsInArray();
        }

        private void SetObjectsInArray()
        {
            if(WorldObjects is not null && WorldObjects.Count() > 0)
            {
                foreach(var obj in WorldObjects)
                {
                    if(obj is Creature)
                    {
                        char symbol = obj.Name[0];
                        Array[obj.Position.X, obj.Position.Y] = symbol;
                    }
                }
            }
        }

        private void SetArray(char[,] array)
        {
            for (int i = 0; i < MaxX; i++)
            {
                for (int j = 0; j < MaxY; j++)
                {
                    array[i, j] = ' ';
                }
            }
            for (int i = 0; i < MaxX; i++)
            {
                array[i, 0] = 'x';
                array[i, MaxY - 1] = 'x';
            }
            for (int i = 0; i < MaxY; i++)
            {
                array[0, i] = 'x';
                array[MaxX - 1, i] = 'x';
            }
        }

        public void Print2DArray()
        {
            Console.Clear();
            for (int i = 0; i < MaxY; i++)
            {
                for (int j = 0; j < MaxX; j++)
                {
                    Console.Write(Array[j, i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


    }
}