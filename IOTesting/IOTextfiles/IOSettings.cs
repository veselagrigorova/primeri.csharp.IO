using System;

namespace IOTextfiles
{
	public class IOSettings
	{

		private Stable _stable;
		public IOSettings (Stable stable)
		{
			_stable = stable;
		}
		public bool save()
		{
			try
			{
				string _temp ="";

				_temp = String.Join ("\r\n", _stable.stable);

				//Запис на текстов файл
				System.IO.File.WriteAllText( "C:\\aula\\test.txt", _temp);


					return true;

			}catch{
				
			}
			return false;
		}
	}
}

