using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabulationLibraryData.ApplicationLogicLayer;

namespace TabulationProject2021
{
    public partial class ServerOverallResult : UserControl
    {
        public ServerOverallResult()
        {
            InitializeComponent();
        }

        public void OverallResultSHS()
        {
            //First place 
            ServerData dataMaleFirst = new ServerData("", "SHS", "Male");
            var resultMaleFirst = dataMaleFirst.Result();

            lblFirstMaleNameSHS.Text = resultMaleFirst[0].Name;
            lblFirstMaleStrandSHS.Text = resultMaleFirst[0].Strand_Course;
            lblFirstMaleEveningSHS.Text = resultMaleFirst[0].EveningGown;
            lblFirstMaleFinalSHS.Text = resultMaleFirst[0].FinalQA;
            lblFirstMaleTotalSHS.Text = resultMaleFirst[0].Total;

            ServerData dataFemaleFirst = new ServerData("", "SHS", "Female");
            var resultFemaleFirst = dataFemaleFirst.Result();

            lblFirstFemaleNameSHS.Text = resultFemaleFirst[0].Name;
            lblFirstFemaleStrandSHS.Text = resultFemaleFirst[0].Strand_Course;
            lblFirstFemaleEveningSHS.Text = resultFemaleFirst[0].EveningGown;
            lblFirstFemaleFinalSHS.Text = resultFemaleFirst[0].FinalQA;
            lblFirstFemaleTotalSHS.Text = resultFemaleFirst[0].Total;

            //Second place 
            ServerData dataMaleSecond = new ServerData("", "SHS", "Male");
            var resultMaleSecond = dataMaleSecond.Result();

            lblSecondMaleNameSHS.Text = resultMaleSecond[1].Name;
            lblSecondMaleStrandSHS.Text = resultMaleSecond[1].Strand_Course;
            lblSecondMaleEveningSHS.Text = resultMaleSecond[1].EveningGown;
            lblSecondMaleFinalSHS.Text = resultMaleSecond[1].FinalQA;
            lblSecondMaleTotalSHS.Text = resultMaleSecond[1].Total;

            ServerData dataFemaleSecond = new ServerData("", "SHS", "Female");
            var resultFemaleSecond = dataFemaleSecond.Result();

            lblSecondFemaleNameSHS.Text = resultFemaleSecond[1].Name;
            lblSecondFemaleStrandSHS.Text = resultFemaleSecond[1].Strand_Course;
            lblSecondFemaleEveningSHS.Text = resultFemaleSecond[1].EveningGown;
            lblSecondFemaleFinalSHS.Text = resultFemaleSecond[1].FinalQA;
            lblSecondFemaleTotalSHS.Text = resultFemaleSecond[1].Total;

            //Third place 
            ServerData dataMaleThird = new ServerData("", "SHS", "Male");
            var resultMaleThird = dataMaleThird.Result();

            lblThirdMaleNameSHS.Text = resultMaleThird[2].Name;
            lblThirdMaleStrandSHS.Text = resultMaleThird[2].Strand_Course;
            lblThirdMaleEveningSHS.Text = resultMaleThird[2].EveningGown;
            lblThirdMaleFinalSHS.Text = resultMaleThird[2].FinalQA;
            lblThirdMaleTotalSHS.Text = resultMaleThird[2].Total;

            ServerData dataFemaleThird = new ServerData("", "SHS", "Female");
            var resultFemaleThird = dataFemaleThird.Result();

            lblThirdFemaleNameSHS.Text = resultFemaleThird[2].Name;
            lblThirdFemaleStrandSHS.Text = resultFemaleThird[2].Strand_Course;
            lblThirdFemaleEveningSHS.Text = resultFemaleThird[2].EveningGown;
            lblThirdFemaleFinalSHS.Text = resultFemaleThird[2].FinalQA;
            lblThirdFemaleTotalSHS.Text = resultFemaleThird[2].Total;
        }

        public void OverallResultCollege()
        {
            //First place 
            ServerData dataMaleFirst = new ServerData("", "College", "Male");
            var resultMaleFirst = dataMaleFirst.Result();

            lblFirstMaleNameCollege.Text = resultMaleFirst[0].Name;
            lblFirstMaleCourseCollege.Text = resultMaleFirst[0].Strand_Course;
            lblFirstMaleEveningCollege.Text = resultMaleFirst[0].EveningGown;
            lblFirstMaleFinalCollege.Text = resultMaleFirst[0].FinalQA;
            lblFirstMaleTotalCollege.Text = resultMaleFirst[0].Total;

            ServerData dataFemaleFirst = new ServerData("", "College", "Female");
            var resultFemaleFirst = dataFemaleFirst.Result();

            lblFirstFemaleNameCollege.Text = resultFemaleFirst[0].Name;
            lblFirstFemaleCourseCollege.Text = resultFemaleFirst[0].Strand_Course;
            lblFirstFemaleEveningCollege.Text = resultFemaleFirst[0].EveningGown;
            lblFirstFemaleFinalCollege.Text = resultFemaleFirst[0].FinalQA;
            lblFirstFemaleTotalCollege.Text = resultFemaleFirst[0].Total;

            //Second place 
            ServerData dataMaleSecond = new ServerData("", "College", "Male");
            var resultMaleSecond = dataMaleSecond.Result();

            lblSecondMaleNameCollege.Text = resultMaleSecond[1].Name;
            lblSecondMaleCourseCollege.Text = resultMaleSecond[1].Strand_Course;
            lblSecondMaleEveningCollege.Text = resultMaleSecond[1].EveningGown;
            lblSecondMaleFinalCollege.Text = resultMaleSecond[1].FinalQA;
            lblSecondMaleTotalCollege.Text = resultMaleSecond[1].Total;

            ServerData dataFemaleSecond = new ServerData("", "College", "Female");
            var resultFemaleSecond = dataFemaleSecond.Result();

            lblSecondFemaleNameCollege.Text = resultFemaleSecond[1].Name;
            lblSecondFemaleCourseCollege.Text = resultFemaleSecond[1].Strand_Course;
            lblSecondFemaleEveningCollege.Text = resultFemaleSecond[1].EveningGown;
            lblSecondFemaleFinalCollege.Text = resultFemaleSecond[1].FinalQA;
            lblSecondFemaleTotalCollege.Text = resultFemaleSecond[1].Total;

            //Third place 
            ServerData dataMaleThird = new ServerData("", "College", "Male");
            var resultMaleThird = dataMaleThird.Result();

            lblThirdMaleNameCollege.Text = resultMaleThird[2].Name;
            lblThirdMaleCourseCollege.Text = resultMaleThird[2].Strand_Course;
            lblThirdMaleEveningCollege.Text = resultMaleThird[2].EveningGown;
            lblThirdMaleFinalCollege.Text = resultMaleThird[2].FinalQA;
            lblThirdMaleTotalCollege.Text = resultMaleThird[2].Total;

            ServerData dataFemaleThird = new ServerData("", "College", "Female");
            var resultFemaleThird = dataFemaleThird.Result();

            lblThirdFemaleNameCollege.Text = resultFemaleThird[2].Name;
            lblThirdFemaleCourseCollege.Text = resultFemaleThird[2].Strand_Course;
            lblThirdFemaleEveningCollege.Text = resultFemaleThird[2].EveningGown;
            lblThirdFemaleFinalCollege.Text = resultFemaleThird[2].FinalQA;
            lblThirdFemaleTotalCollege.Text = resultFemaleThird[2].Total;
        }

        private void runtimeRefresh_Tick(object sender, EventArgs e)
        {
            OverallResultSHS();
            OverallResultCollege();
        }
    }
}
