using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class Game
    {
        public static int Scores;
        public static bool IsLost;

        private Font mainFont;
        private Text scoreText;
        private Text loseText;



        private SquaresList squares;

        private int MaxScore;
        public Game() {

            mainFont = new Font("comic.ttf");
            squares = new SquaresList();

            scoreText = new Text();
            scoreText.Font = mainFont;
            scoreText.FillColor = Color.Black;
            scoreText.CharacterSize = 16;
            scoreText.Position = new SFML.System.Vector2f(10, 10);

            loseText = new Text();
            loseText.Font = mainFont;
            loseText.FillColor = Color.Red;
            loseText.DisplayedString = "GAME IS LOST. HIT \"R\" TO RESTART";
            loseText.CharacterSize = 16;
            loseText.Position = new SFML.System.Vector2f(50, 450);
             
            Reset();            
        }

        private void Reset()
        {           
            squares.Reset();
            Scores = 0;
            IsLost = false;
            squares.SpawnPlayerSquare();
            squares.SpawnEnemySquare();
        }

        public void Update(RenderWindow window) {
            if (IsLost==true)
            {
                window.Draw(loseText);
                if(Scores>MaxScore)
                {
                    MaxScore = Scores;
                }


                if(Keyboard.IsKeyPressed(Keyboard.Key.R)==true)
                {
                    Reset();
                }
            }

            if (IsLost==false)
            {
                squares.Update(window);

                if (squares.SquareHasRemoved == true)
                {
                    if (squares.RemovedSquare is PlayerSquareBlack)
                    {
                        squares.SpawnPlayerSquare();
                    }

                    if (squares.RemovedSquare is EnemySquareRed)
                    {
                        squares.SpawnEnemySquare();
                    }
                }
            }

           scoreText.DisplayedString = "SCORE: "+Scores.ToString()+"\nMAX: "+ MaxScore.ToString();
           window.Draw(scoreText);
            
        }
    }
}
