using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class Square
    {
        public bool isActive = true;

        protected RectangleShape shape;
        protected float movementSpeed;
        protected Vector2f movementTarget;
        protected IntRect movementBounds;

        public Square(Vector2f position, float movementSpeed, IntRect movementBounds) {
            shape = new RectangleShape(new Vector2f(100,100));
            shape.Position = position;
            this.movementSpeed = movementSpeed;
            this.movementBounds = movementBounds;
            UpdateMovementTarget();
        }

        public void Move() {

            shape.Position = Mathf.MoveTowards(shape.Position, movementTarget, movementSpeed);
            
            if (shape.Position == movementTarget)
            {
                OnReachedTarget();
                UpdateMovementTarget();
            }
        }
        public void Draw(RenderWindow window) { 
            if (isActive==false) {
                return;
            }
            window.Draw(shape);
        }

        public void CheckMousePosition (Vector2i mousePos)
        {
            if (isActive == false) { return; }

            if (mousePos.X > shape.Position.X && mousePos.X < shape.Position.X + shape.Size.X &&
                mousePos.Y > shape.Position.Y && mousePos.Y < shape.Position.Y + shape.Size.Y)
            {
                OnClick();
            }
        }

        public void UpdateMovementTarget() {
         
            movementTarget.X = Program.Random.Next(movementBounds.Left, movementBounds.Left + movementBounds.Width);
            movementTarget.Y = Program.Random.Next(movementBounds.Top, movementBounds.Top + movementBounds.Height);
        }

        protected virtual void OnClick() { }
        protected virtual void OnReachedTarget() { }
    }
}
