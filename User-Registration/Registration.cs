using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration
{
    
        public class Registration
        {
            //Creating method to check validation for first name
            public void FirstName()
            {
                Console.Write("\n1.Enter the name = ");
                string name = Console.ReadLine();
                string Pattern = "^[A-Z][a-zA-Z]{2,}$";
                try
                {
                    if (Validate(name, Pattern))
                    {
                        Console.WriteLine("The entered first name is valid!!");
                    }
                    else
                    {
                        throw new InvalidInputException("The entered first name is invalid..");

                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    FirstName();
                }
            }

            //Creating method to check validation for last name
            public void LastName()
            {
                Console.Write("\n2.Enter the last name = ");
                string name = Console.ReadLine();
                string pattern = "^[A-Z][a-zA-Z]{2,}$";
                try
                {
                    if (Validate(name, pattern))
                    {
                        Console.WriteLine("The entered last name is valid!!");
                    }
                    else
                    {
                        throw new InvalidInputException("The entered last name is invalid..");

                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    LastName();
                }

            }

            //Creating method to check validation for email id
            public void EmailId()
            {
                Console.Write("\n3.Enter the email id = ");
                string emailId = Console.ReadLine();
                string pattern = "^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";
                try
                {
                    if (Validate(emailId, pattern))
                    {
                        Console.WriteLine("The entered email id is valid!!");
                    }
                    else
                    {
                        throw new InvalidInputException("The entered email id is invalid..");

                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    EmailId();
                }

            }

            //Creating method to check validation for mobile number
            public void MobileNumber()
            {
                Console.WriteLine("\n4.Enter the mobile number = ");
                string mobileNumber = Console.ReadLine();
                string pattern = "^([0-9]{2}[ ]){0,1}[0-9]{10}$";
                try
                {
                    if (Validate(mobileNumber, pattern))
                    {
                        Console.WriteLine("The entered mobile number is valid!!");
                    }
                    else
                    {
                        throw new InvalidInputException("The entered mobile number is invalid..");

                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    MobileNumber();
                }

            }

            //Creating method to check validation for password
            public void Password()
            {
                Console.WriteLine("\n5.Enter the password = ");
                string password = Console.ReadLine();
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])(A-Za-z\d$!$%*?&]{8,}$";
                try
                {
                    if (Validate(password, pattern))
                    {
                        Console.WriteLine("The entered password is valid!!");
                    }
                    else
                    {
                        throw new InvalidInputException("The entered password is invalid..");

                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    Password();
                }

            }

            //Creating method to check validation
            public static bool Validate(string info, string Pattern)
            {
                return Regex.IsMatch(info, Pattern);
            }


        }
    
}