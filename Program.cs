using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace MovingSquares
{
    public class Program
    {   
        static uint APPLICATION_WINDOW_WIDTH = 1400;
        static uint APPLICATION_WINDOW_HEIGHT = 900;
        static string GAME_TITLE = "Moving Squares 1.0";
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(APPLICATION_WINDOW_WIDTH, APPLICATION_WINDOW_HEIGHT), GAME_TITLE);
            window.Closed += Window_Closed;
            window.SetFramerateLimit(60);

            /*Square square = new Square(new Vector2f(100,100),10,new IntRect(0,0,1400,900));*/

            while (window.IsOpen==true) {

                window.Clear(new Color(230, 230, 230));

               /* square.Move();
                square.Draw(window);*/

                window.DispatchEvents();
                window.Display();
            }
        }

        static void Window_Closed(object sender, EventArgs e)
        {
            ((RenderWindow)sender).Close();
        }
    }
}
