using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabulationLibraryData.DataAccessLayer;

namespace TabulationLibraryData.ApplicationLogicLayer
{
    public class HighSchools
    {

        private ICandidate candidate;
        private int candidateNumber = 0;
        private VoteModel vote;
        private string currentEvent = "";
        private string candidateID = "";

        public HighSchools(int candidateNumber = 0)
        {
            this.candidateNumber = candidateNumber;
        }

        public HighSchools(int candidateID, string judgeNumber, List<decimal> scores, string currentEvent)
        {
            this.currentEvent = currentEvent;
            this.candidateID = candidateID.ToString();
            decimal sum = 0;

            foreach (var score in scores)
            {
                sum = sum + score;
            }

            vote = new VoteModel
            {
                CandidateID = candidateID,
                JudgeNumber = judgeNumber,
                JudgeTotalScore = sum
            };
        }

        public string[] LoadPhoto(string candidateName)
        {
            var path = $@"{Environment.CurrentDirectory}\Images\SHS\";
            var images = new string[] { $"{path}{candidateName}.jpg", $"{path}{candidateName} - 2.jpg" };

            return images;
        }

        public HighSchool GetHighSchools()
        {
            candidate = new HighSchool();
            var IsFound = candidate.GetData(candidateNumber);

            if (IsFound == true)
            {
                return (HighSchool)candidate;
            }
            else
            {
                return null;
            }
        }

        public decimal[] ExistingScores(string Event, string judgeNumber)
        {
            decimal[] output = new decimal[4];
            bool IsValid = true;

            switch (Event)
            {
                case "EveningGown":
                    IsValid = candidate.GetExistingScoresEveningGown(candidateNumber, judgeNumber, Event, out output);
                    break;
                case "FinalQA":
                    IsValid = candidate.GetExistingScoresFinalQA(candidateNumber, judgeNumber, Event, out output);
                    break;
                default:
                    break;
            }

            if (IsValid == false)
            {
                output = new decimal[] { 75M, 75M, 75M, 75M };
                return output;
            }

            return output;
        }

        public void Vote(decimal[] points, string judgeNumber)
        {
            candidate = new HighSchool();
            candidate.Vote(vote, currentEvent);

            ScoresDataAccess score = new ScoresDataAccess("SHS", candidateID, currentEvent);
            score.SaveTotalScores();

            candidate = new HighSchool();
            switch (currentEvent)
            {
                case "EveningGown":
                    candidate.CriteriaGradesEveningGown(candidateID, judgeNumber, points);
                    break;
                case "FinalQA":
                    candidate.CriteriaGradesFinalQA(candidateID, judgeNumber, points);
                    break;
                default:
                    break;
            }
        }

    }
}
