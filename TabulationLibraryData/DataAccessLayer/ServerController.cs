using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TabulationLibraryData.DataAccessLayer
{
    public class ServerController
    {
        private string currentEvent = "";
        private string schoolLevel = "";
        private string gender = "";
        public ServerController(string currentEvent, string schoolLevel, string gender)
        {
            this.currentEvent = currentEvent;
            this.schoolLevel = schoolLevel;
            this.gender = gender;
        }

        public List<FinalResultModel> GetResults()
        {
            List<FinalResultModel> output = new List<FinalResultModel>();

            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $"SELECT * FROM [OverallScore-{schoolLevel}]WHERE [Gender] = @Gender ORDER BY [Total] DESC";
                    command.Parameters.AddWithValue("@Gender", gender);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read() == true)
                    {
                        output.Add(new FinalResultModel
                        {
                            CandidateID = reader[0].ToString(),
                            CandidateNumber = reader[1].ToString(),
                            Name = reader[2].ToString(),
                            Strand_Course = reader[3].ToString(),
                            Gender = reader[4].ToString(),
                            EveningGown = reader[5].ToString(),
                            FinalQA = reader[6].ToString(),
                            Total = reader[7].ToString()
                        });
                    }
                }
            }

            return output;
        }

        public List<DataServerModel> GetData()
        {
            List<DataServerModel> output = new List<DataServerModel>();

            using (OleDbConnection cn = new OleDbConnection(HelperClass.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $"SELECT * FROM [Scores{currentEvent}-{schoolLevel}] WHERE [Gender] = @Gender ORDER BY [PercentageScore] DESC";
                    command.Parameters.AddWithValue("@Gender", gender);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read() == true)
                    {
                        output.Add(new DataServerModel
                        {
                            CandidateID = reader[0].ToString(),
                            CandidateNumber = reader[1].ToString(),
                            CandidateName = reader[2].ToString(),
                            Strand_Course = reader[3].ToString(),
                            Grades = $"{reader[5].ToString()}, {reader[6].ToString()}, {reader[7].ToString()}, {reader[8].ToString()}, {reader[9].ToString()}",
                            AverageScore = reader[10].ToString(),
                            PercentageScore = reader[11].ToString()
                        });
                    }
                }
            }

            return output;
        }
    }
}
