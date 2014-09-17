using System;

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

class CompanyManagerInfo
	{
	static void Main()
		{
			Console.Write("Enter the company's name: ");
			string company = Console.ReadLine();
			Console.Write("Enter company's address: ");
			string address = Console.ReadLine();
			Console.Write("Enter the company's phone number: ");
			string phoneCompany = Console.ReadLine();
			Console.Write("Enter the company's fax number: ");
			string fax = Console.ReadLine();
			Console.Write("Enter the company's web site: ");
			string web = Console.ReadLine();
			Console.Write("Enter the first name of the company's manager: ");
			string firstName = Console.ReadLine();  
			Console.Write("Enter the last name of the company's manager: ");
			string lastName = Console.ReadLine();
			Console.Write("Enter the age of the company's manager: ");
			string age = Console.ReadLine();
			Console.Write("Enter the phone number of the company's manager: ");
			string phoneManager = Console.ReadLine();
			Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4} \n{5} \n{6} \n{7} \n{8}", 
			company, address, phoneCompany, fax, web, firstName, lastName, age, phoneManager);
		}
	}

