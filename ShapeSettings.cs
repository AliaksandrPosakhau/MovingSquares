using SFML.Graphics;
using SFML.Window;
using System;
using SFML.System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class ShapeSettings
    {
        private Font mainFont;
        private Text promptText;
        private Text squareText;
        private Text circleText;       
        public RenderWindow window;

        public ShapeSettings(RenderWindow window)
        {
            this.mainFont = new Font("comic.ttf");
            this.window = window;
            promptText = new Text();
            promptText.Font = mainFont;
            promptText.FillColor = Color.Black;
            promptText.DisplayedString = "PICK NUMBER TO SELECT FORM:";
            promptText.CharacterSize = 16;
            promptText.Position = new SFML.System.Vector2f(10, 10);


            squareText = new Text();
            squareText.Font = mainFont;
            squareText.FillColor = Color.Black;
            squareText.DisplayedString = "1 - SQUARE";
            squareText.CharacterSize = 16;
            squareText.Position = new SFML.System.Vector2f(10, 20);

            circleText = new Text();
            circleText.Font = mainFont;
            circleText.FillColor = Color.Black;
            circleText.DisplayedString = "2 - CIRCLE";
            circleText.CharacterSize = 16;
            circleText.Position = new SFML.System.Vector2f(10, 30);

            window.Draw(promptText);
            window.Draw(squareText);
            window.Draw(circleText);         

        }

        public int selectShape()
        {
            while (!Keyboard.IsKeyPressed(Keyboard.Key.Num1)|| !Keyboard.IsKeyPressed(Keyboard.Key.Num2) || !Keyboard.IsKeyPressed(Keyboard.Key.Num3))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Num1) == true)
                {
                    this.moveOff();
                    return 1;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Num2) == true)
                {
                    this.moveOff();
                    return 2;
                }             
            } 
            return 1;
        }

        public void moveOff()
        {
            promptText.Position = new SFML.System.Vector2f(10, GameWindowSettings.APPLICATION_WINDOW_WIDTH+100);
            squareText.Position = new SFML.System.Vector2f(10, GameWindowSettings.APPLICATION_WINDOW_WIDTH + 100);
            circleText.Position = new SFML.System.Vector2f(10, GameWindowSettings.APPLICATION_WINDOW_WIDTH + 100);            
        }
    }
}
