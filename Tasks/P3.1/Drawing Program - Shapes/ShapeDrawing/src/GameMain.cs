using System;
using SwinGameSDK;

namespace MyGame
{
	public class GameMain
	{
		public static void Main ()
		{
			//Open the game window
			SwinGame.OpenGraphicsWindow ("GameMain", 800, 600);
			//SwinGame.ShowSwinGameSplashScreen ();

			Drawing drawing = new Drawing ();

			//Run the game loop
			while (false == SwinGame.WindowCloseRequested ()) {
				//Fetch the next batch of UI interaction
				SwinGame.ProcessEvents ();

				//Clear the screen and draw the framerate
				SwinGame.ClearScreen (Color.White);
				SwinGame.DrawFramerate (0, 0);

				if (SwinGame.MouseClicked (MouseButton.LeftButton)) 
				{
					Shape s = new Shape ();
					s.X = SwinGame.MouseX ();
					s.Y = SwinGame.MouseY ();
					drawing.AddShape (s);
				}

				if (SwinGame.MouseClicked (MouseButton.RightButton)) {
					drawing.SelectShapesAt (SwinGame.MousePosition ());
				}

				if (SwinGame.KeyTyped (KeyCode.SpaceKey)) 
				{
					drawing.Background = SwinGame.RandomRGBColor (255);
				}

				if (SwinGame.KeyTyped (KeyCode.BackspaceKey) || SwinGame.KeyTyped (KeyCode.DeleteKey)) {
					foreach (Shape s in drawing.SelectedShapes)
						drawing.DeleteShape (s);
				}

				drawing.Draw ();

				//Draw onto the screen
				SwinGame.RefreshScreen (60);
			}
		}
	}
}