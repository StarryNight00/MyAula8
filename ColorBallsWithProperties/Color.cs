using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBallsWithProperties
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;


        private static int colorCount;

        //Construtor
        static Color()
        {
            colorCount = 0;
        }


        /// <summary>
        /// All parameter Color constructor. Receives 4 values.
        /// All RGB color values are positive, usually in between 0 and 255.
        /// </summary>
        /// <param name="red"> uInt value for red.</param>
        /// <param name="green"> uInt value for green.</param>
        /// <param name="blue"> uInt value for blue.</param>
        /// <param name="alpha">uInt value for alpha, or transparency.</param>
        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;

            colorCount++;
        }

        /// <summary>
        /// Three parameter Color constructor. Receives 3 values. Alpha is set to opaque.
        /// All RGB color values are positive, usually in between 0 and 255.
        /// </summary>
        /// <param name="red"> uInt value for red.</param>
        /// <param name="green"> uInt value for green.</param>
        /// <param name="blue"> uInt value for blue.</param>
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;

            colorCount++;
        }


        //Properties
        public int Grayscale => (int)((Red + Green + Blue) / 3);

        //public int Red {get; set;}

        public int Red
        {
            get => red;
            set
            {
                if (red > 255)
                {
                    red = value;
                }

                if (red < 0)
                {
                    red = 0;
                }
            }
        }

        public int Green
        {
            get => green;
            set
            {
                if (green > 255)
                {
                    green = value;
                }

                if (green < 0)
                {
                    green = 0;
                }
            }
        }

        public int Blue
        {
            get => blue;
            set
            {
                if (blue > 255)
                {
                    blue = value;
                }

                if (blue < 0)
                {
                    blue = 0;
                }
            }
        }

        public int Alpha
        {
            get => alpha;
            set
            {
                if (alpha > 255)
                {
                    alpha = value;
                }

                if (alpha < 0)
                {
                    alpha = 0;
                }
            }
        }


    }
}
