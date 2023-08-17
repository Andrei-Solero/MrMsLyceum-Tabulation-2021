using TabulationLibraryData;

namespace TabulationLibraryData.DataAccessLayer
{
    public abstract class CandidateModel
    {
        public int ID { get; set; }
        public string CandidateNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
