using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidht, int mapHeight)
        {
        wallList=new List<Figure>();
        HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
        HorizontalLine downLine = new HorizontalLine(0, 78, 22, '+');
        VerticalLine leftLine = new VerticalLine(0, 22, 0, '+');
        VerticalLine rightLine = new VerticalLine(0, 22, 78, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
        public void Drow ()
        {
            foreach (var wall in wallList)
                wall.Drow();
        }

}
}
