using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice
{
    public class Program
    {
        enum Color{
            Black,
            Green,
            Yellow
        }
        public static void Main(string[] args)
        {

            int a1 = 5;
            object ref_Obj = a1;
            int b = (int) ref_Obj;

            int a = 6;
            object refe = a;
            int v  = (int) refe;

            #region Point on lines
            //Console.WriteLine("Enter the point to be find.");
            //int f = Convert.ToInt32(Console.ReadLine());
            //int r = 5;
            //int x = 0;
            //int y = 0;
            //bool status1 = false;
            //bool status2 = false;
            //for (int i = x; i <= r; i++)
            //{
            //    if (f == i)
            //    {
            //        status1 = true;
            //    }

            //    for (int j = y; j <= (-r); j--)
            //    {
            //        if (f == j)
            //        {
            //            status2 = true;
            //        }
            //    }
            //} 

            //if (status1 == true || status2 == true)
            //{
            //    Console.WriteLine("Object is within the circle.");
            //}
            //else
            //{
            //    Console.WriteLine("Object is outside the circle.");
            //}
            #endregion

            //Dictionary<string, int> test = new Dictionary<string, int>();
            //test.Add("Maths", 5);
            //test.Add( "English", 5);

            Hashtable test = new Hashtable();
            test.Add(3, "Test");
            test.Add("Test", 8);

            foreach(var item in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine(item);
            }

        #region Circle Starts Here Quadrant

        //    int r, d, f1,f2;    
            
        //    Starthere:
        //    Console.WriteLine("Enter first point");
        //    f1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter second point");
        //    f2 = Convert.ToInt32(Console.ReadLine());

        //    r = 5;
        //    d = r * r;
        //    bool? status1 = null;
        //    bool? status2 = null;
        //    bool? status3 = null;
        //    bool? status4 = null;

        //    //+
        //    for (int i = 0; i <= r; i++)
        //    {
        //        //Quad = ++
        //        for (int j = 0; j <= r; j++)
        //        {
        //            if((f1 == i && f2 == i) || (f1 == i && f2 == j) || (f2 == j && f2 == i) || (f1==j && f2 == j))
        //            {
        //                status1 = true;
        //            }
        //        }
        //        //Quad = +-
        //        for (int k = 0; k >= -r; k--)
        //        {
        //            if ((f1 == i && f2 == i) || (f1 == i && f2 == k) || (f2 == k && f2 == i) || (f1 == k && f2 == k))
        //            {
        //                status2 = true;
        //            }
        //        }
        //    }

        //    //-
        //    for (int i = 0; i >= -r; i--)
        //    {
        //        //Quad = -+
        //        for (int j = 0; j <= r; j++)
        //        {
        //            if ((f1 == i && f2 == i) || (f1 == i && f2 == j) || (f2 == j && f2 == i) || (f1 == j && f2 == j))
        //            {
        //                status3 = true;
        //            }
        //        }
        //        //Quad = --
        //        for (int k = 0; k >= -r; k--)
        //        {
        //            if ((f1 == i && f2 == i) || (f1 == i && f2 == k) || (f2 == k && f2 == i) || (f1 == k && f2 == k))
        //            {
        //                status4 = true;
        //            }
        //        }
        //    }

        //    Console.WriteLine("\n");

        //    if ((status1 == true && status2 == true && status3 == true && status4 == true) || 
        //        (status1 == true && status2 == true) || (status3 == true && status4 == true) ||
        //        (status1 == true && status3 == true) || (status2 == true && status4 == true) || 
        //        (status2 == true && status3 == true) || (status1 == true && status4 == true) ||
        //        (status1 == false && status2 == false && status3 == false && status4 == true) ||
        //        (status1 == false && status2 == false && status3 == true && status4 == false) ||
        //        (status1 == false && status2 == true && status3 == true && status4 == false) ||
        //        (status1 == true && status2 == true && status3 == true && status4 == false))
        //    {
        //        Console.WriteLine("Point within the circle.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Point outside the circle.");
        //    }

        //    Console.WriteLine("\n");

        //    UserInput:
        //    Console.WriteLine("More Y / N\n");
        //    var input = Console.ReadLine();

        //    if (input == "y" || input == "y")
        //    {
        //        goto Starthere;
        //    }
        //    else if(input == "N" || input == "n")
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter valid input\n");
        //        goto UserInput;
        //    }

            #endregion Circle Ends Here


    //        int userInput = Convert.ToInt32(Console.ReadLine());
    //        int r = 5;
    //        if(userInput > (r))
    //        {
    //            Console.WriteLine("Outside the circle");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Inside the circle.");
    //        }
        }
    }

    public class Addition : Program
    {
        
    }

}
