﻿using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class EnemySquareRed : Square
    {
        private static float MaxMovementSpeed = 5;
        private static Color Color = new Color(230,50,50);
        private static float MovementStep = 0.1f;
        private static float MaxSize = 200;
        private static float SizeStep = 10;

        public EnemySquareRed(Vector2f position, float movementSpeed, IntRect movementBounds) : base(position, movementSpeed, movementBounds) { 
        shape.FillColor = Color;
        }

        protected override void OnClick()
        {
            
        }

        protected override void OnReachedTarget()
        {
            if (movementSpeed< MaxMovementSpeed) 
            { 
                movementSpeed += MovementStep;
            }

            if (shape.Size.X < MaxSize) 
            {
                shape.Size += new Vector2f(SizeStep, SizeStep);
            }
        }
    }


}
