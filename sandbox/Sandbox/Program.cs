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
        List<double> timeList = new List<double>{0, 45, 60, 359, 3600, 3661, 43285, 86399, 90061};

        foreach (double number in timeList)
        {
            double[] formattedTimeArray = GetFormattedTime(number);
            double length = number;
            double hours = formattedTimeArray[0];
            double minutes = formattedTimeArray[1];
            double seconds = formattedTimeArray[2];
            Console.WriteLine($"Total length: {length}\nHours: {hours}h, Minutes: {minutes}min, Seconds: {seconds}s");
        }
    }

    static double[] GetFormattedTime(double length)
    {
        double seconds, minutes, hours;
        seconds = 0;
        minutes = 0;
        hours = 0;
        if (length >= 60)
        {
            minutes = length / 60;
            
            if (minutes >= 60)
            {
                hours = minutes / 60;
                minutes = (hours - Math.Truncate(hours)) * 60;
                seconds = (minutes - Math.Truncate(minutes)) * 60;
                
                hours = (int)hours;
                minutes = (int)minutes;
                seconds = Math.Round(seconds);
            } else
            {
                seconds = (minutes - Math.Truncate(minutes)) * 60;

                minutes = (int)minutes;
                seconds = Math.Round(seconds);
            }
        } else
        {
            seconds = Math.Round(length);
        }

        return [hours, minutes, seconds];
    }

}