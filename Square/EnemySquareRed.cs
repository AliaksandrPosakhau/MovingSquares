using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class EnemySquareRed : Square
    {
        private static float MaxMovementSpeed = 3;
        private static Color Color = new Color(230,50,50);
        private static float MovementStep = 0.05f;
        private static float MaxSize = 1000;
        private static float SizeStep = 5;
        

        public EnemySquareRed(Vector2f position, float movementSpeed, IntRect movementBounds) : base(position, movementSpeed, movementBounds) { 
        shape.FillColor = Color;
        }

        protected override void OnClick()
        {
            Game.IsLost = true;
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
                Console.WriteLine(shape.Size);                 
            }

            if (EnemySquareListener.trackBlackShapesSuperiority()==true) {
                shape.Size += new Vector2f(SizeStep*3, SizeStep*3);
            }
            EnemySquareListener.tick();
        }
    }


}
