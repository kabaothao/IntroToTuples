using System;

namespace IntroToTuples
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = ValidateAddress(address: "123 sesame st");
            if (result.isValid)
            {
                Console.WriteLine(value: $"Your validated address is {result.address}");
            }
            else
            {
                Console.WriteLine(value: "That is an invalid address.");
            }
        }
        (string address, bool isValid) ValidateAddress(string address)
        {
            if(address.Equals(value: "123 sesame st"))
                {
                    return ("123 Sesame Street", true);   
                }
                else
                {
                    return (address, false);
                }
        }
    }
}



/*
 Tuples has a sequence of elements of different data types. It was introduced to return an instance of the Tuple<T> with no need to specify the type of each element separately.

For example line 28

(string address, bool isValid)

 */