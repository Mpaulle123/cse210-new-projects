using System;
using System.Security.Cryptography.X509Certificates;

partial class Program

{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear} - {job1._endYear}");

        //Console.WriteLine($"{job2._jobTitle} ({job2._company}) {job2._startYear} - {job2._endYear}");

        Resume myResume = new Resume();
        myResume._name = "Alisson Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();







    }


}


// The result must be:
// Software Engineer (Microsoft) 2019-2022
//Manager(Apple) 2022 - 2023