using System;

namespace IOTextfiles
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			Stable _Stable = new Stable ();
			IOSettings _io = new IOSettings(_Stable);

			Console.WriteLine (_Stable.stable[0]);
			if (_io.save ()) {
				Console.WriteLine ("Таблицата е запаметена успешно");
			} else {
				Console.WriteLine ("Таблицата НЕ е запаметена успешно");
			}

		}
	}
}
