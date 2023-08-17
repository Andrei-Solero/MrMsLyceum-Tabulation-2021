using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabulationLibraryData.DataAccessLayer;

namespace TabulationLibraryData.ApplicationLogicLayer
{
    public class Judges
    {
        private readonly IJudgesRepository repository;
        public string LoginCode { get; set; }
        public Judges(string LoginCode)
        {
            repository = new JudgesRepository(HelperClass.ConnectionString);
            this.LoginCode = LoginCode;
        }

        public bool Login(out string judgeNumber)
        {
            var judge = repository.GetData(LoginCode);
            if (judge == null)
            {
                judgeNumber = "";
                return false;
            }
            else
            {
                judgeNumber = judge.JudgeNumber;
                return true;
            }
            
        }
    }
}
