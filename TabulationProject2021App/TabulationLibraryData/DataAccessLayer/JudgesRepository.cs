using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TabulationLibraryData.DataAccessLayer
{
    public class JudgesRepository : IJudgesRepository
    {
        private string ConnectionString = "";
        public JudgesRepository(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public JudgeModel GetData(string loginCode)
        {
            JudgeModel output = new JudgeModel();

            using (OleDbConnection cn = new OleDbConnection(ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    cn.Open();
                    command.Connection = cn;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM [JudgeData] WHERE [LoginCode] = @LoginCode";
                    command.Parameters.AddWithValue("@LoginCode", loginCode);
                    OleDbDataReader reader = command.ExecuteReader();
                    
                    if(reader.Read() == true)
                    {
                        output.JudgeNumber = reader["JudgeNumber"].ToString();
                    }
                    else
                    {
                        output = null;
                    }
                }
            }

            return output;
        }
    }
}
