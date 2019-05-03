using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBallsWithProperties
{
    class Ball
    {
        private static int ballCount;

        private float radius;
        private Color color;
        private int thrownCount;


        //Constructor
        static Ball()
        {
            ballCount = 0;
        }

        public Ball(float radius, Color color)
        {
            this.radius = radius;

            this.color = color;

            thrownCount = 0;

            ballCount++;
        }

        public int ThrownCount { get; private set; }

        //Methods
        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                ThrownCount++;
            }
        }
    }
}
