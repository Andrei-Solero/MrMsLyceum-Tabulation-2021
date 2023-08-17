using System;
using System.Data.OleDb;

namespace TabulationLibraryData.DataAccessLayer
{
    public class HighSchool : CandidateModel, ICandidate
    {
        public string Strand { get; set; }

        public void CriteriaGradesEveningGown(string candidateID, string judgeNumber, decimal[] points)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"INSERT INTO [CriteriaGradeEveningGown]([CandidateID], [JudgeNumber], [SchoolLevel], [PoiseBearing],
                                            [CatWalk], [Confidence], [StageAppeal])VALUES(@CandidateID, @JudgeNumber, @SchoolLevel, @PoiseBearing, 
                                            @CatWalk, @Confidence, @StageAppeal)";

                    command.Parameters.AddWithValue("@CandidateID", candidateID);
                    command.Parameters.AddWithValue("@JudgeNumber", judgeNumber);
                    command.Parameters.AddWithValue("@SchoolLevel", "SHS");
                    command.Parameters.AddWithValue("@PoiseBearing", points[0]);
                    command.Parameters.AddWithValue("@CatWalk", points[1]);
                    command.Parameters.AddWithValue("@Confidence", points[2]);
                    command.Parameters.AddWithValue("@StageAppeal", points[3]);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CriteriaGradesFinalQA(string candidateID, string judgeNumber, decimal[] points)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"INSERT INTO [CriteriaGradeFinalQA]([CandidateID], [JudgeNumber], [SchoolLevel], [Intelligence],
                                            [Confidence])VALUES(@CandidateID, @JudgeNumber, @SchoolLevel, @Intelligence, @Confidence)";

                    command.Parameters.AddWithValue("@CandidateID", candidateID);
                    command.Parameters.AddWithValue("@JudgeNumber", judgeNumber);
                    command.Parameters.AddWithValue("@SchoolLevel", "SHS");
                    command.Parameters.AddWithValue("@Intelligence", points[0]);
                    command.Parameters.AddWithValue("@Confidence", points[1]);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool GetData(int candidateNumber)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM [CandidatesSHS] WHERE [CandidateID] = @CnNumber ORDER BY [CandidateID] ASC";
                    command.Parameters.AddWithValue("@CnNumber", candidateNumber);
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        this.ID = Convert.ToInt32(reader[0]);
                        this.CandidateNumber = reader[1].ToString();
                        this.Name = reader[2].ToString();
                        this.Strand = reader[3].ToString();
                        this.Gender = reader[4].ToString();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool GetExistingScoresEveningGown(int candidateNumber, string judgeNumber, string Event, out decimal[] existingPoints)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"SELECT * FROM [CriteriaGrade{Event}] WHERE [CandidateID] = @CnNumber AND 
                                            [JudgeNumber] = @JudgeNumber AND [SchoolLevel] = @SchoolLevel ORDER BY [ID] DESC";

                    command.Parameters.AddWithValue("@CnNumber", candidateNumber);
                    command.Parameters.AddWithValue("@JudgeNumber", judgeNumber);
                    command.Parameters.AddWithValue("@SchoolLevel", "SHS");

                    OleDbDataReader reader = command.ExecuteReader();

                    existingPoints = new decimal[4];

                    if (reader.Read() == true)
                    {
                        existingPoints[0] = decimal.Parse(reader[4].ToString());
                        existingPoints[1] = decimal.Parse(reader[5].ToString());
                        existingPoints[2] = decimal.Parse(reader[6].ToString());
                        existingPoints[3] = decimal.Parse(reader[7].ToString());

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool GetExistingScoresFinalQA(int candidateNumber, string judgeNumber, string Event, out decimal[] existingPoints)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"SELECT * FROM [CriteriaGrade{Event}] WHERE [CandidateID] = @CnNumber AND 
                                            [JudgeNumber] = @JudgeNumber AND [SchoolLevel] = @SchoolLevel ORDER BY [ID] DESC";

                    command.Parameters.AddWithValue("@CnNumber", candidateNumber);
                    command.Parameters.AddWithValue("@JudgeNumber", judgeNumber);
                    command.Parameters.AddWithValue("@SchoolLevel", "SHS");

                    OleDbDataReader reader = command.ExecuteReader();

                    existingPoints = new decimal[2];

                    if (reader.Read() == true)
                    {
                        existingPoints[0] = decimal.Parse(reader[4].ToString());
                        existingPoints[1] = decimal.Parse(reader[5].ToString());

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        public void Vote(VoteModel vote, string Event)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"UPDATE [Scoring{Event}-SHS] SET [{vote.JudgeNumber}] = @JudgeNumber
                                            WHERE [CandidateID] = @CandidateID";

                    command.Parameters.AddWithValue("@JudgeNumber", vote.JudgeTotalScore);
                    command.Parameters.AddWithValue("@CandidateID", vote.CandidateID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}