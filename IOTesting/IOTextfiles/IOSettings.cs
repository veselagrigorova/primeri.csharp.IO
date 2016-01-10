﻿using System;

namespace IOTextfiles
{
	public class IOSettings
	{

		private Stable _stable;
		public IOSettings (Stable stable)
		{
			_stable = stable;
		}

		public string getPath ()
		{
			string _path = System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test1.txt");

			//други видове директории

			string _user = Environment.GetFolderPath (Environment.SpecialFolder.LocalApplicationData); Console.WriteLine ( _user);
			string _desktop = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);            Console.WriteLine ( _desktop);

			return _path;
		}
		public bool save()
		{
			try
			{
				string _temp ="";

				_temp = String.Join ("\r\n", _stable.stable);

				//Запис на текстов файл
				System.IO.File.WriteAllText( getPath(), _temp);


					return true;

			}catch{
				
			}
			return false;
		}
		public bool open ()
		{
			try {
				
				string _temp = "", _filePath = getPath();

				if (System.IO.File.Exists(_filePath))  //проверка дали пътят е валиден
					
					{	
					System.IO.File.ReadAllText (_filePath);

					string[] _table = _temp.Replace ("\r", "").Split ('\n');

					for ( int i = 0; i < _table.Length; i++)
					{
						_stable.stable[i] = _table[i];
					}

					}else{
						Console.WriteLine("Не е намерен такъв път");

						return false;
						}


						return true;

			}catch{
				
			}

			return false;
		}
	}
}


