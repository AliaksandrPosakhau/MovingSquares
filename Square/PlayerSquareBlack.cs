using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class PlayerSquareBlack : Square
    {
         
        private static Color Color = new Color(50, 50, 50);
        private static float SizeStep = 10;
        private static float MinSize = 30;
        

        public PlayerSquareBlack(Vector2f position, float movementSpeed, IntRect movementBounds):base(position, movementSpeed, movementBounds)
        {
            shape.FillColor = Color;
        }

        protected override void OnClick()
        {
            Game.Scores++;

           shape.Size-= new Vector2f(SizeStep, SizeStep);

            if (shape.Size.X < MinSize)
            {
                isActive= false;
                return;
            }

            UpdateMovementTarget();
            shape.Position = movementTarget;
        }

    }
}
