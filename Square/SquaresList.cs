using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class SquaresList
    {
        static uint APPLICATION_WINDOW_WIDTH = 1400;
        static uint APPLICATION_WINDOW_HEIGHT = 900;
        private List<Square> squares;
        public bool SquareHasRemoved;
        public Square RemovedSquare;

        public SquaresList()
        {
            squares = new List<Square>();
        }

        public void Reset()
        {
            SquareHasRemoved = false;
            RemovedSquare = null;
            squares.Clear();

        }

        public void Update(RenderWindow window)
        {
            SquareHasRemoved = false;
            RemovedSquare = null;

            if (Mouse.IsButtonPressed(Mouse.Button.Left) == true)
            {

                for (int i = 0; i < squares.Count; i++)
                {
                    squares[i].CheckMousePosition(Mouse.GetPosition(window));
                }

            }
            for (int i = 0; i < squares.Count; i++)
            {
                squares[i].Move();
                squares[i].Draw(window);

                if (squares[i].isActive == false)
                {
                    RemovedSquare = squares[i];
                    squares.Remove(squares[i]);
                    SquareHasRemoved = true;
                }

            }
        }



        public void SpawnPlayerSquare()
        {
            squares.Add(new PlayerSquareBlack(new Vector2f(Mathf.Random.Next(0,(int)APPLICATION_WINDOW_WIDTH), Mathf.Random.Next(0, (int)APPLICATION_WINDOW_HEIGHT)),
                    5, new IntRect(0, 0, (int)APPLICATION_WINDOW_WIDTH, (Int32)APPLICATION_WINDOW_HEIGHT)));

            squares.Add(new PlayerSquareBlack(new Vector2f(Mathf.Random.Next(0, (int)APPLICATION_WINDOW_WIDTH), Mathf.Random.Next(0, (int)APPLICATION_WINDOW_HEIGHT)),
                    5, new IntRect(0, 0, (int)APPLICATION_WINDOW_WIDTH, (int)APPLICATION_WINDOW_HEIGHT)));
        }

        public void SpawnEnemySquare() {
            squares.Add(new EnemySquareRed(new Vector2f(Mathf.Random.Next(0, (int)APPLICATION_WINDOW_WIDTH), Mathf.Random.Next(0, (int)APPLICATION_WINDOW_HEIGHT)),
                    5, new IntRect(0, 0, (int)APPLICATION_WINDOW_WIDTH, (int)APPLICATION_WINDOW_HEIGHT)));
        }
    }
}
