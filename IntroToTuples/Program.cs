// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine(value: "Your validated address is {}");
            }
            else
            {
                Console.WriteLine(value: "That is an invalid address.");
            }


        }

        void ValidateAddress(string address)
        {
            if(address.Equals((value: "123 sesame st"))
                {
                    //return "123 Sesame Street"
                }
                else
                {
                  //return false
                }

        }
    }
}



/*
 Tuples has a sequence of elements of different data types. It was introduced to return an instance of the Tuple<T> with no need to specify the type of each element separately.

 */