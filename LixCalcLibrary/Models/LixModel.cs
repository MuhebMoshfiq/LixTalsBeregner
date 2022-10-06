using System;
using System.Collections.Generic;
using System.Text;

namespace LixCalcLibrary.Models
{
    public class LixModel
    {
        public List<String> AllWords = new List<string>();
        public int TotalWordCount { get; set; }
        public int LongWordCount { get; set; }
        public int StopCount { get; set; }
        public string LixDifficulty { get; set; }
        public double LixScore { get; set; }
    }
}
