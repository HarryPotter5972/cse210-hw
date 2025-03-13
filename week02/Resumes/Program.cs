using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobFirst = new Job();
        jobFirst._jobName = "Food court server";
        jobFirst._buisness = "Megaplex";
        jobFirst._yearStart = "2017";
        jobFirst._yearEnd = "2019";

        Job jobSecond = new Job();
        jobSecond._jobName = "Theater Team Member";
        jobSecond._buisness = "Cinemark";
        jobSecond._yearStart = "2021";
        jobSecond._yearEnd = "2023";

        Resume resumeMine = new Resume();
        resumeMine._name = "Brandon Baggaley";

        resumeMine._jobs.Add(jobFirst);
        resumeMine._jobs.Add(jobSecond);

        resumeMine.DisplayDetails();


    }
}