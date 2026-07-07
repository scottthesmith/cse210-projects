using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // instantiating the Job class:
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // creating a new instance of the job class:
        Job job2 = new Job();
        job2._companyName ="Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
       
       Resume myResume = new Resume();
       myResume._employeeName = "Scott Smith";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.DisplayJobDetails();
        
        }
}