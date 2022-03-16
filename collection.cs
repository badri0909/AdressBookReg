//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CollectionDemo
//{
//    class Program
//    {
//        /// <summary>
//        /// UC3-Compeleted AddressBook Program by Joy.
//        /// </summary>
//        /// <param name="args">The arguments.</param>

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to AddressBook Program");


//            Console.WriteLine("Enter your 1st Name:");
//            String Name = Console.ReadLine();
//            Console.WriteLine("Enter your last Name:");
//            String LastName = Console.ReadLine();
//            Console.WriteLine("Enter your Address:");
//            String Address = Console.ReadLine();
//            Console.WriteLine("Enter your City:");
//            String City = Console.ReadLine();
//            Console.WriteLine("Enter your Zip Code:");
//            String Code = Console.ReadLine();
//            Console.WriteLine("Enter your Phone Number:");
//            String PhNo = Console.ReadLine();
//            Console.WriteLine("Enter your Email:");
//            String Email = Console.ReadLine();

//            Console.WriteLine("My full name is :" + Name + "\nLast Name is: " + LastName + "\nMy Address is: " + Address + "\nMy City Name : " + City + "\nMy Postal Code is : " + Code + "\nMy Contact Number is : " + PhNo + "\nMy Email Address is : " + Email);

//            //doListDemo();

//            doStackDemo();
//            // doQueueDemo();
//            // doSetDemo();
//            //doDictonaryDemo();
//        }

//        //private static void doListDemo()
//        //{
//        //    Console.WriteLine("\n Add New Contact ");
//        //    List<string> list = new List<string>();

//        //    list.Add("My Name Is:Puja Bosu");

//        //    Console.WriteLine("Enter your Address:");
//        //    String Address = Console.ReadLine();
//        //    Console.WriteLine("Enter your City:");
//        //    String City = Console.ReadLine();
//        //    Console.WriteLine("Enter your Zip Code:");
//        //    String Code = Console.ReadLine();
//        //    Console.WriteLine("Enter your Phone Number:");
//        //    String PhNo = Console.ReadLine();
//        //    Console.WriteLine("Enter your Email:");
//        //    String Email = Console.ReadLine();

//        //    Console.WriteLine("\nMy Address is: " + Address + "\nMy City Name : " + City + "\nMy Postal Code is : " + Code + "\nMy Contact Number is : " + PhNo + "\nMy Email Address is : " + Email);
//        //    foreach (string item in list)
//        //    {
//        //        Console.WriteLine(item);
//        //    }

//        //}
//        private static void doStackDemo()
//        {
//            Console.WriteLine("\n Edit you Address Details*************************");
//            Stack<string> list = new Stack<string>();


//            Console.WriteLine("Enter your 1st Name:");
//            String Name = Console.ReadLine();
//            Console.WriteLine("Enter your last Name:");
//            String LastName = Console.ReadLine();
//            Console.WriteLine("Enter your Address:");
//            String Address = Console.ReadLine();
//            Console.WriteLine("Enter your City:");
//            String City = Console.ReadLine();
//            Console.WriteLine("Enter your Zip Code:");
//            String Code = Console.ReadLine();
//            Console.WriteLine("Enter your Phone Number:");
//            String PhNo = Console.ReadLine();
//            Console.WriteLine("Enter your Email:");
//            String Email = Console.ReadLine();
//            Console.WriteLine("After Edit ***********************");
//            Console.WriteLine("My full name is :" + Name + "\nLast Name is: " + LastName + "\nMy Address is: " + Address + "\nMy City Name : " + City + "\nMy Postal Code is : " + Code + "\nMy Contact Number is : " + PhNo + "\nMy Email Address is : " + Email);




//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }


//        }
//    }
//}
