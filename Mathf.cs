﻿using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class Mathf
    {
        public static Random Random = new Random();

        public static Vector2f MoveTowards(Vector2f current, Vector2f target, float maxDistanceDelta)
        {
            Vector2f direction = target - current;
            float magnitude = ((float)Math.Sqrt(direction.X * direction.Y + direction.Y * direction.Y));

            if (magnitude <= maxDistanceDelta || magnitude ==0f)
            {
                return target;
            }
             
            return current += direction / magnitude * maxDistanceDelta;
             
        }
    }
}
