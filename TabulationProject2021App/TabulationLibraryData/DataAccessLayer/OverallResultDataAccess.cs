using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace TabulationLibraryData.DataAccessLayer
{
    public static class OverallResultDataAccess
    {
        public static decimal EveningGownPoints { get; set; }
        public static decimal FinalQA { get; set; }
        public static void SaveEveningGownScore(string schoolLevel, string points, string candidateID)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"UPDATE [OverallResult-{schoolLevel}] SET [EveningGown] = @EveningGown
                                            WHERE [CandidateID] = @CandidateID";

                    command.Parameters.AddWithValue("@EveningGown", points);
                    command.Parameters.AddWithValue("@CandidateID", candidateID);

                    EveningGownPoints = decimal.Parse(points);

                    ComputeTotal(schoolLevel, candidateID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void SaveFinalQAScore(string schoolLevel, string points, string candidateID)
        {
            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"UPDATE [OverallResult-{schoolLevel}] SET [FinalQA] = @FinalQA
                                            WHERE [CandidateID] = @CandidateID";

                    command.Parameters.AddWithValue("@FinalQA", points);
                    command.Parameters.AddWithValue("@CandidateID", candidateID);

                    FinalQA = decimal.Parse(points);

                    ComputeTotal(schoolLevel, candidateID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ComputeTotal(string schoolLevel, string candidateID)
        {
            decimal total = EveningGownPoints + FinalQA;

            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $@"UPDATE [OverallResult-{schoolLevel}] SET [Total] = @Total
                                            WHERE [CandidateID] = @CandidateID";

                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@CandidateID", candidateID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
