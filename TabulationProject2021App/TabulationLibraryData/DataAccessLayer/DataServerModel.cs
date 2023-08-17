using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulationLibraryData.DataAccessLayer
{
    public class DataServerModel
    {
        public string CandidateID { get; set; }
        public string CandidateNumber { get; set; }
        public string CandidateName { get; set; }
        public string Strand_Course { get; set; }
        public string Grades { get; set; }
        public string AverageScore { get; set; }
        public string PercentageScore { get; set; }
    }
}
