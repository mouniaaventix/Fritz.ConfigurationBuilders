﻿using Humanizer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Ini
{
	class Program
	{
		static void Main(string[] args)
		{

			var keys = ConfigurationManager.AppSettings.AllKeys;

			Console.WriteLine($"Here are my current {"AppSettings".ToQuantity(keys.Length)}:");

			foreach (var item in keys)
			{

				Console.WriteLine($"{item}: {ConfigurationManager.AppSettings[item]}");

			}

			Console.ReadLine();


		}
	}
}
