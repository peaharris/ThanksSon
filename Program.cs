using System;

namespace SwitchDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What should I do today?");
            Console.WriteLine(" 1. Clean My Room");
            Console.WriteLine(" 2. Feed The Dog");
            Console.WriteLine(" 3. Take Out The Trash");
            Console.Write("Choice: ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("My room isn't thaaat messy");
                    break; //break statement comes from C
                case 2:
                    Console.WriteLine("It's Sarah's turn to feed the dog");
                    break;
                case 3:
                    Console.WriteLine("I don't want to get germs");
                    break;
                default:
                    Console.WriteLine("That wasn't a choice");
                    break;
            }
            Console.WriteLine("Thanks son");


            ////You shouldn’t use a switch with double or float because CPU math is imprecise:
            //double d1 = 1.1;
            //double d2 = 2.2;
            //double d3 = d1 + d2;
            //switch (d3)
            //{
            //    case 3.3:
            //        Console.WriteLine("three point three");
            //        break;
            //    default:
            //        Console.WriteLine("unknown");
            //        break;
            //}

            ////You shouldn’t use a switch with bool.
            //bool b = true;
            //switch (b)
            //{
            //    case true:
            //        Console.WriteLine("true");
            //        break;
            //    case false:
            //        Console.WriteLine("false");
            //        break;
            //    default:
            //        Console.WriteLine("unknown");
            //        break;
            //}

            ////use an it statement instead
            //if (!b)//use to be this if (b == true), however, one used is better //Unary operator - Not
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}


        }
    }
}
