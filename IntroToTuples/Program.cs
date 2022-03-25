//(string message, bool valid) = ValidateAddress(address: "123 sesame st"); //now this is called decontructor which deconstruct  our tuples to separate parts.

//if (result.isValid)
//{
//    Console.WriteLine(value: $"Your validated address is {result.address}");
//}
//else
//{
//    Console.WriteLine(value: "That is an invalid address.");
//}

(string address, _) = ValidateAddress(address: "123 sesame st"); //maybe we just want the valid address and we don't want to know if it is valid or invalid address. we just want it formatted properly if we can.

(string address, bool isinvalid) ValidateAddress(string address)

{
    if (address.Equals(value: "123 sesame st"))
        {
            return ("123 Sesame Street", true);
        }
        else
        {
            return (address, false);
        }
}


/*
 Tuples has a sequence of elements of different data types. It was introduced to return an instance of the Tuple<T> with no need to specify the type of each element separately.

For example line 28

(string address, bool isValid)

tuples are really helpful to use for returning multiple parameters from a method that's the big deal about tuples

 */