using System;
using SwinGameSDK;

namespace MyGame
{
	public class GameMain
	{
		private enum ShapeKind
		{
			Rectangle,
			Circle,
			Line
		}

		public static void Main ()
		{
			//Open the game window
			SwinGame.OpenGraphicsWindow ("GameMain", 800, 600);
			//SwinGame.ShowSwinGameSplashScreen ();

			Drawing drawing = new Drawing ();
			ShapeKind kindToAdd = ShapeKind.Circle;

			//Run the game loop
			while (false == SwinGame.WindowCloseRequested ()) {
				//Fetch the next batch of UI interaction
				SwinGame.ProcessEvents ();

				//Clear the screen and draw the framerate
				SwinGame.ClearScreen (Color.White);
				SwinGame.DrawFramerate (0, 0);

				if (SwinGame.MouseClicked (MouseButton.LeftButton)) 
				{
					Shape newShape;

					if (kindToAdd == ShapeKind.Circle) {
						Circle newCircle = new Circle ();
						newShape = newCircle;
					} else if (kindToAdd == ShapeKind.Rectangle) {
						Rectangle newRect = new Rectangle ();
						newShape = newRect;
					} else {
						Line newLine = new Line ();
						newShape = newLine;
					}

					newShape.X = SwinGame.MouseX ();
					newShape.Y = SwinGame.MouseY ();
					drawing.AddShape (newShape);
				}

				if (SwinGame.MouseClicked (MouseButton.RightButton))
					drawing.SelectShapesAt (SwinGame.MousePosition ());

				if (SwinGame.KeyTyped (KeyCode.SpaceKey)) 
					drawing.Background = SwinGame.RandomRGBColor (255);

				if (SwinGame.KeyTyped (KeyCode.BackspaceKey) || SwinGame.KeyTyped (KeyCode.DeleteKey))
					foreach (Shape s in drawing.SelectedShapes)
						drawing.DeleteShape (s);

				if (SwinGame.KeyTyped (KeyCode.RKey))
					kindToAdd = ShapeKind.Rectangle;

				if (SwinGame.KeyTyped (KeyCode.CKey))
					kindToAdd = ShapeKind.Circle;

				if (SwinGame.KeyTyped (KeyCode.LKey))
					kindToAdd = ShapeKind.Line;

				drawing.Draw ();

				//Draw onto the screen
				SwinGame.RefreshScreen (60);
			}
		}
	}
}