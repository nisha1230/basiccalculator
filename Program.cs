using System;
using System.Collections.Generic;
using System.Linq;

namespace basiccalculator
{
    class Program
    {
        
            static void Main(string[] args)
            {
            try { 
            
            
                Calculator obj = new Calculator();

                int flag = 1;
                int flag2 = 1;
                do
                {
                    Console.WriteLine("Main Menu:\n 0.Exit \n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide \n");
                    Console.Write("enter your choice from 1-4: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("enter first number:");
                       
                        int A = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("enter second number:");
                        int B = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter third number:");
                        float C = Convert.ToSingle(Console.ReadLine()); 


                        switch (choice)
                        {
                            case 1:

                                Console.WriteLine("A + B = {0}", obj.add(A, B));
                                Console.WriteLine("A + B + C = {0}", obj.add(A,B,C));

                                break;

                            case 2:
                                Console.WriteLine("A - B = {0}", obj.subtract(A, B));
                                
                                break;

                            case 3:

                                Console.WriteLine("A * B = {0}", obj.multiply(A, B));
                                break;

                            case 4:

                                Console.WriteLine("A / B = {0}", obj.divide(A, B));
                                break;

                            default:

                                Console.WriteLine("Enter valid input");
                                break;
                        }


                        Console.Write("Do you wish to continue? Press 1: Yes \t 0: No :");
                        flag2 = Convert.ToInt32(Console.ReadLine());
                    }
                    while (flag2 == 1);//end of operation "do"

                    Console.Write("Do you wish to continue Main Menu? Press 1: Yes \t 0: No :");
                    flag = Convert.ToInt32(Console.ReadLine());
                }
                while (flag == 1);//end of main "do"

            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, Please Try again");
            } 
    }
        class Calculator
        {
            public int add(int A , int B)
            {
                Console.WriteLine("Addition of two numbers:");;
                return A + B;
            }
            
             public int add(int A, int B, float C) ///overloading of different datatypes of arguments
            {
                Console.WriteLine("Addition of three numbers");
                return (int)(A + B + C); 
            }
            public int subtract(int A, int B)
            {
                return A - B;
            }
            public int multiply(int A, int B)
            {
                return A * B;
            }
            public int divide(int A, int B)
            {
                return A / B;
            }
           
        }
           
    }
}


