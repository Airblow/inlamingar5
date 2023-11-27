using System;
namespace inlamning5._1AC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];
            words[0] = "Hej, jag bara undrar vad du gör på onsdag?";
            words[1] = "Inget speciellt, du då?";
            words[2] = "Jag tänkte gå på bio med några kompisar, hänger du med?";
            words[3] = "Jo visst det kan jag nog göra, när och vilken film?";
            words[4] = "Vi tänkte kolla på Star Wars, vid 19.00 tiden.";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine(words[i]);

            }

            Console.ReadKey();

        }

    }

}
