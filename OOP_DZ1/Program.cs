using System;
using ClassLibraryOOP_DZ1;

namespace OOP_DZ1
{
    

    class Program
    {
        static float GenerateRandomScore()
    {
        Random rand = new Random();
        return (float)rand.NextDouble() * 10;
    }
    static void Main()
    {


        Episode ep1, ep2;
        ep1 = new Episode();
        ep2 = new Episode(10, 64.39, 8.70);
        int viewers = 10;
        for (int i = 0; i < viewers; i++)
        {
            ep1.AddView(GenerateRandomScore());
            Console.WriteLine(ep1.GetMaxScore());
        }
        if (ep1.GetAverageScore() > ep2.GetAverageScore())
        {
            Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
        }
        else
        {
            Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
        }

    }


}
}
