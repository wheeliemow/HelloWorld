using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace HelloWorld
{
	public class HelloView :UIView
	{
		public UITextView txtHello;


		public HelloView ()
		{



			txtHello = new UITextView (new RectangleF (60, 20, 100, 50));
			//txtHello.BackgroundColor = UIColor.Brown;
			txtHello.TextColor = UIColor.Black;
			txtHello.Text = "Hello World";

			this.AddSubview (txtHello);


		}
	}
}

