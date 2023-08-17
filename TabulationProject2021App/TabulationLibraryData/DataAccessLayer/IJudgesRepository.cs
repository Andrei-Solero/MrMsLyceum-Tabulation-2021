using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulationLibraryData.DataAccessLayer
{
    public interface IJudgesRepository
    {
        JudgeModel GetData(string loginCode);
    }
}
