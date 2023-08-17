using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TabulationLibraryData.DataAccessLayer
{
    public class ScoresDataAccess
    {
        private string schoolLevel = "";
        private string candidateID = "";
        private string currentEvent = "";
        public ScoresDataAccess(string schoolLevel, string candidateID, string currentEvent)
        {
            this.schoolLevel = schoolLevel;
            this.candidateID = candidateID;
            this.currentEvent = currentEvent;
        }

        private TotalScoreModel GetScores()
        {
            TotalScoreModel scores = new TotalScoreModel();

            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $"SELECT * FROM [Scoring{currentEvent}-{schoolLevel}] WHERE [CandidateID] = @CnNumber ORDER BY [CandidateID] ASC";
                    command.Parameters.AddWithValue("@CnNumber", candidateID);
                    
                    OleDbDataReader reader = command.ExecuteReader();

                    if(reader.Read() == true)
                    {
                        scores.FirstJudgeScore = decimal.Parse(reader[2].ToString());
                        scores.SecondJudgeScore = decimal.Parse(reader[3].ToString());
                        scores.ThirdJudgeScore= decimal.Parse(reader[4].ToString());
                        scores.FourthJudgeScore = decimal.Parse(reader[5].ToString());
                        scores.FifthJudgeScore= decimal.Parse(reader[6].ToString());

                        scores.AverageScore = (scores.FirstJudgeScore + scores.SecondJudgeScore + scores.ThirdJudgeScore +
                                                scores.FourthJudgeScore + scores.FifthJudgeScore) / 5;

                        if(currentEvent == "EveningGown")
                        {
                            scores.PercentageScore = scores.AverageScore * .4M;
                        }

                        if (currentEvent == "FinalQA")
                        {
                            scores.PercentageScore = scores.AverageScore * .6M;
                        }
                    }
                }
            }

            return scores;
        }

        public void SaveTotalScores()
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"UPDATE [Scoring{currentEvent}-{schoolLevel}] SET [AverageScore] = @AverageScore, [PercentageScore] = @PercentageScore
                                            WHERE [CandidateID] = @CandidateID";

                    var score = GetScores();

                    command.Parameters.AddWithValue("@AverageScore", score.AverageScore);
                    command.Parameters.AddWithValue("@PercentageScore", score.PercentageScore);
                    command.Parameters.AddWithValue("@CandidateID", candidateID);

                    if (currentEvent == "EveningGown")
                    {
                        OverallResultDataAccess.SaveEveningGownScore(schoolLevel, score.PercentageScore.ToString(), candidateID);
                    }

                    if (currentEvent == "FinalQA")
                    {
                        OverallResultDataAccess.SaveFinalQAScore(schoolLevel, score.PercentageScore.ToString(), candidateID);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }



        public static void SaveTotalPoints(string schoolLevel, string pointsEveningGown, string pointsFinalQA, string candidateID)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"UPDATE [OverallResult-{schoolLevel}] SET [EveningGown] = @EveningGown, [FinalQA] = @FinalQA,
                                            [Total] = @Total WHERE [CandidateID] = @CandidateID";

                    decimal totalComputation = decimal.Parse(pointsEveningGown) + decimal.Parse(pointsFinalQA);
                    string total = totalComputation.ToString();

                    command.Parameters.AddWithValue("@EveningGown", pointsEveningGown);
                    command.Parameters.AddWithValue("@FinalQA", pointsFinalQA);
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@CandidateID", candidateID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
