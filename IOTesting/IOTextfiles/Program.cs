using System;

namespace IOTextfiles
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			Stable _Stable = new Stable ();
			IOSettings _io = new IOSettings(_Stable);

		
			if ( _io.open()){
				//_io.save ()) {
				Console.WriteLine ("Таблицата е прочетено успешно");
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");
			}
			Console.WriteLine (_Stable.stable [2]);
		}
	}
}
