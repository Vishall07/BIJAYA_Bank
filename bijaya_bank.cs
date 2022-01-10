/*
 * Created by SharpDevelop.
 * User: Vishal
 * Date: 10-01-2022
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Bank_proj
{
	class Program
	{
		string name;
		int age;
		string acnum;
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			askUser();
			
			//Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void askUser()
		{
			Console.WriteLine("Welcome To BIJAYA BANK");
			Console.WriteLine("1.Login \n2.About \n3.Exit");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch(choice){
				case 1:
					Console.WriteLine("Login");
					break;
				case 2:
					Console.WriteLine("About");
					break;
				case 3:
					Console.WriteLine("Thanks");
					break;
				default :
					Console.WriteLine("Invalid Input");
					askUser();
					break;
			}
			
			
			
			
		}
		
	}
}