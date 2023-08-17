using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulationLibraryData.DataAccessLayer
{
    public interface ICandidate
    {
        bool GetData(int candidateNumber);
        void Vote(VoteModel vote, string Event);
        bool GetExistingScoresEveningGown(int candidateNumber, string judgeNumber, string Event, out decimal[] existingPoints);
        bool GetExistingScoresFinalQA(int candidateNumber, string judgeNumber, string Event, out decimal[] existingPoints);
        void CriteriaGradesEveningGown(string candidateNumber, string judgeNumber, decimal[] points);
        void CriteriaGradesFinalQA(string candidateNumber, string judgeNumber, decimal[] points);
    }
}
