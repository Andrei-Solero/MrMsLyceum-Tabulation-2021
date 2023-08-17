using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulationLibraryData.DataAccessLayer
{
    public class VoteModel
    {
        public int CandidateID { get; set; }
        public string JudgeNumber { get; set; }
        public decimal JudgeTotalScore { get; set; }
        public decimal AverageScore { get; set; }
        public decimal PercentageScore { get; set; }
    }
}
