using System;

class CompanyInfo
{
    static void Main()
    {
        /// A company has name, address, phone number, fax number, web site and manager.
        /// The manager has first name, last name, age and a phone number. 
        /// Write a program that reads the information about a company and its manager and prints them on the console.

        //Company info
        Console.WriteLine("Enter company name");
        string companyName = Console.ReadLine();

        Console.WriteLine("Enter company address");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Enter company phone number");
        int companyPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter company fax number");
        int companyFaxNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter company web site");
        string companyWebSite = Console.ReadLine();

        // Manager info
        Console.WriteLine("Enter manager first name");
        string managerFirtsName = Console.ReadLine();
        
        Console.WriteLine("Enter manager last name");
        string managerLastName = Console.ReadLine();
        
        Console.WriteLine("Enter manager age");
        int managerAge = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter manager phone number");
        int managerPhoneNumber = int.Parse(Console.ReadLine());

        // Consol output
        Console.WriteLine("A company name is {0},it's address is {1}, phone number {2}, fax number {3}, web site {4}" +
                          "A company manager name is {5} {6}, age {7} and phone number {8}",
                            companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, 
                            managerFirtsName, managerLastName, managerAge, managerPhoneNumber);
    }
}