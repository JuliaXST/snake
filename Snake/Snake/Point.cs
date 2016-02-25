using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()

        {
        } 
        public Point (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }      
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);

            Console.ReadLine();
        }
    }
}
