using System;

class Program
{
    // Define the NumberToString method
    static string num_string(int num)
    {
        // Convert the number to a string and return it
        return num.ToString();
    }

    // Main method to test the NumberToString method
    static void Main()
    {
        // Call the NumberToString method with an example number
        string str_r = num_string(123);

        // Output the result
        Console.WriteLine(str_r);  // Output: "123"
    }
}
