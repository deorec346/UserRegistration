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
        Func<string, string, bool> lambdaValidation = (input, pattern) => { return Regex.IsMatch(input, pattern); };
        

    //Creating method to check validation for first name
        public void FirstName()
        {
            Console.Write("\n1.Enter the name = ");
            string firstName = Console.ReadLine();
          
            string Pattern = "^[A-Z][a-zA-Z]{2,}$";

            try
            {
               if ( lambdaValidation(firstName,Pattern))
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

       
