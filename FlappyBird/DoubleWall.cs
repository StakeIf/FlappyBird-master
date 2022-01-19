using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class DoubleWall
    {
        private int y;
        TheWall LowerWall = new TheWall(650, -200);
        TheWall UpperWall = new TheWall(650, 400, true);
    }
}
