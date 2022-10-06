using LixCalcLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LixCalcLibrary.Services
{
   public class LixCalcService
    {
        public LixModel CalculateLixScore(string filePath)
        {
            string content = File.ReadAllText(filePath);
            LixModel model = new LixModel();
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            model.AllWords = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            model.TotalWordCount = model.AllWords.Count();
            model.LongWordCount = model.AllWords.Where(x => x.Length > 6).Count();
            char dot = '.';
            var stops = content.Count(f => (f == dot));
            model.StopCount = stops;

            model.LixScore = Math.Round(((double)model.TotalWordCount / stops) + ((double)model.LongWordCount * 100 / model.TotalWordCount));

            switch (model.LixScore)
            {
                case var n when (n >= 55):
                    model.LixDifficulty = "Meget svær, faglitteratur på akademisk niveau, lovtekster.";
                    break;
                case var n when (n >= 45 && n <= 54):
                    model.LixDifficulty = "Svær, saglige bøger, populærvidenskabelige værker, akademiske udgivelser.";
                    break;
                case var n when (n >= 35 && n <= 44):
                    model.LixDifficulty = "Middel, dagblade og tidsskrifter.";
                    break;
                case var n when (n >= 25 && n <= 34):
                    model.LixDifficulty = "Let for øvede læsere, ugebladslitteratur og let skønlitteratur for voksne";
                    break;
                case var n when (n <= 24):
                    model.LixDifficulty = "Svær, saglige bøger, populærvidenskabelige værker, akademiske udgivelser.";
                    break;
                default:
                    Console.WriteLine("The number is not within the given range.");
                    break;
            }

            return model;
        }
    }
}
