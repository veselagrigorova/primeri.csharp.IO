using System;

namespace IOTextfiles
{
	public class Stable
	{
		public string[] stable = new string [4];
		public Stable ()
		{
			fillStable ();
		}
		private void fillStable ()
		{
			stable [0] = "1, 0 , 5, 1.342";
			stable [1] = "2, 5 , 10, 1.342";
			stable [2] = "3, 11 , 15, 1.342";
			stable [3] = "4, 10 , 25, 1.342";


		}
	}
}

