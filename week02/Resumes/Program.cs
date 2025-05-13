using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Tip Trillio Pictures";
        job1._jobTitle = "Photo Editor/Photographer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Cleverminds";
        job2._jobTitle = "STEM Teacher";
        job2._startYear = 2024;
        job2._endYear = 2025;


        Resume myResume = new Resume();

        myResume._name = "Levi Omagbemi";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}