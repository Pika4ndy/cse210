using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<string> USNames = new List<string>{"USA", "US", "United States of America", "United States"};
        if (USNames.Contains("USA"))
        {
            Console.WriteLine("True");
        } else
        {
            Console.WriteLine("False");
        }
    }


    public void Foo()
    {
        if (true)
        {
            List<string> USNames = new List<string> { "USA", "US", "United States of America", "United States" };
            if (USNames.Contains("USA"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}