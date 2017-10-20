using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Line : Shape
	{
		private float _endX, _endY;

		public Line (Color c, Point2D pt) : base (c)
		{
			EndX = pt.X + 100;
			EndY = pt.Y;
		}

		public Line () : this (Color.Yellow, SwinGame.MousePosition ())
		{
		}

		public float EndX {
			get {
				return _endX;
			}
			set {
				_endX = value;
			}
		}

		public float EndY {
			get {
				return _endY;
			}
			set {
				_endY = value;
			}
		}

		public override void Draw ()
		{
			if (Selected)
				DrawOutline ();
			SwinGame.DrawLine (Color, X, Y, _endX, _endY);
		}

		public override void DrawOutline ()
		{
			SwinGame.DrawCircle (Color.Black, X, Y, 10);
			SwinGame.DrawCircle (Color.Black, _endX, _endY, 10);
		}

		public override bool IsAt (Point2D pt)
		{
			return SwinGame.PointOnLine (pt, X, Y, _endX, _endY);
		}
	}
}
