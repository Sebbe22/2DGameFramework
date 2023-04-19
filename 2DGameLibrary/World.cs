using _2DGameLibrary.Interface;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Xml;

namespace _2DGameLibrary
{
    public class World
    {
        public List<WorldEntety> WorldObjects = new List<WorldEntety>();
        public List<Creature> Creatures { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public char[,] Array {get; set;}
        protected const String CONFIG_FILE = "XMLFile1.xml";

        /// <summary>
        /// constructor for the world if you want to set the bounds when you create it
        /// </summary>
        /// <param name="x">the amount of characters in the x axis</param>
        /// <param name="y">the amount of characters in the y axis</param>
        public World(int x, int y)
        {
            
            MaxX = x;
            MaxY = y;

            Array = new char[x, y];

            SetArray(Array);
            SetObjectsInArray();
        }

        /// <summary>
        /// constructor where the measurements of the world is set by an XML document
        /// </summary>
        public World()
        {

            XmlDocument configDoc = new XmlDocument();
            configDoc.Load("XMLFile1.xml");

            XmlNode xNode = configDoc.DocumentElement.SelectSingleNode("x");
            if(xNode != null)
            {
                String str = xNode.InnerText.Trim();
                MaxX = Convert.ToInt32(str);
            }

            XmlNode yNode = configDoc.DocumentElement.SelectSingleNode("x");
            if (yNode != null)
            {
                String str = yNode.InnerText.Trim();
                MaxY = Convert.ToInt32(str);
            }

            Array = new char[MaxX, MaxY];

            SetArray(Array);
            SetObjectsInArray();

        }

        /// <summary>
        /// adds an object to the worldobjects list aswell as chancing its position in the array
        /// to the first char of its name.
        /// </summary>
        /// <param name="obj">the object you want to add to the world</param>
        public void AddObject(WorldEntety obj)
        {
            WorldObjects.Add(obj);
            SetObjectsInArray();
        }

        /// <summary>
        /// change spots in the array to the first letter of the creature which has that position
        /// </summary>
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

        /// <summary>
        /// sets the initial layout of the array so the borders are made to be x's and
        /// everything else is space ' '
        /// </summary>
        /// <param name="array">the array to format</param>
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

        /// <summary>
        /// prints the array out as a square
        /// </summary>
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