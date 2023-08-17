using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulationLibraryData.DataAccessLayer
{
    public class TotalScoreModel
    {
        public decimal FirstJudgeScore { get; set; }
        public decimal SecondJudgeScore { get; set; }
        public decimal ThirdJudgeScore { get; set; }
        public decimal FourthJudgeScore { get; set; }
        public decimal FifthJudgeScore { get; set; }
        public decimal AverageScore { get; set; }
        public decimal PercentageScore { get; set; }
    }
}
