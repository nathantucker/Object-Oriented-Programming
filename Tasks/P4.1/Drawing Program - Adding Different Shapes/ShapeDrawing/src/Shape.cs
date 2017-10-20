﻿using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public abstract class Shape
	{
		private Color _color;
		private float _x, _y;
		private bool _selected;

		public Shape (Color c)
		{
			_color = c;
		}

		public Shape () : this (Color.Yellow)
		{
			_x = X;
			_y = Y;
		}

		public Color Color {
			get {
				return _color;
			}
			set {
				_color = value;
			}
		}

		public float X {
			get {
				return _x;
			}
			set {
				_x = value;
			}
		}

		public float Y {
			get {
				return _y;
			}
			set {
				_y = value;
			}
		}

		public bool Selected {
			get {
				return _selected;
			}
			set {
				_selected = value;
			}
		}

		public abstract void Draw ();

		public abstract bool IsAt (Point2D pt);

		public abstract void DrawOutline ();
	}
}
