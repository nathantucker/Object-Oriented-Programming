using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Rectangle : Shape
	{
		private int _width, _height;

		public Rectangle (Color c, float x, float y, int width, int height) : base(c)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;

		}

		public Rectangle () : this (Color.Green, 0, 0, 100, 100)
		{
		}

		public int Width 
		{
			get {
				return _width;
			}
			set {
				_width = value;
			}
		}

		public int Height 
		{
			get {
				return _height;
			}
			set {
				_height = value;
			}
		}

		public override void Draw ()
		{
			SwinGame.FillRectangle (Color, X, Y, Width, Height);
			if (Selected) DrawOutline ();
		}

		public override void DrawOutline ()
		{
			SwinGame.DrawRectangle (Color.Black, X - 2, Y - 2, Width + 4, Height + 4);
		}

		public override bool IsAt (Point2D pt)
		{
			return SwinGame.PointInRect (pt, X, Y, Width, Height);
		}
	}
}
