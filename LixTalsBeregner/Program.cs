using System;


namespace LixTalsBeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            LixCalcLibrary.Services.LixCalcService lixService = new LixCalcLibrary.Services.LixCalcService();
            var res = lixService.CalculateLixScore(@".\TxtFile.txt");

            Console.WriteLine("Lixtal: " + res.LixScore + "\n" +
                "Sværhedsgrad: " + res.LixDifficulty + "\n" +
                "Sætninger: " + res.StopCount + "\n" +
                "Ord: " + res.TotalWordCount + "\n" +
                "Lange ord: " + res.LongWordCount);
        }
    }
}
