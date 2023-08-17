using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulationLibraryData.DataAccessLayer
{
    public class FinalResultModel
    {
        public string CandidateID { get; set; }
        public string CandidateNumber { get; set; }
        public string Name { get; set; }
        public string Strand_Course { get; set; }
        public string Gender { get; set; }
        public string EveningGown { get; set; }
        public string FinalQA { get; set; }
        public string Total { get; set; }
    }
}
