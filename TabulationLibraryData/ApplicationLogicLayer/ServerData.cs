using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabulationLibraryData.DataAccessLayer;

namespace TabulationLibraryData.ApplicationLogicLayer
{
    public class ServerData
    {
        private string currentEvent = "";
        private string schoolLevel = "";
        private string gender = "";
        public ServerData(string currentEvent, string schoolLevel, string gender)
        {
            this.currentEvent = currentEvent;
            this.schoolLevel = schoolLevel;
            this.gender = gender;
        }

        public List<DataServerModel> Scores()
        {
            ServerController server = new ServerController(currentEvent, schoolLevel, gender);
            var datas = server.GetData();

            return datas;
        }

        public List<FinalResultModel> Result()
        {
            ServerController server = new ServerController(currentEvent, schoolLevel, gender);
            var datas = server.GetResults();

            return datas;
        }

    }
}
