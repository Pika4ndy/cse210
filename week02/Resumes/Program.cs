// Abstraction: using classes
/*  
Program Description:
    This program uses two classes: Job & Resume to display an hypothetic
    plain resume of someone which contain only the list of jobs she attended.
    This is only meant to learn and practice using classes.
*/

using System;
using System.Resources;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Allison Rosoe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}