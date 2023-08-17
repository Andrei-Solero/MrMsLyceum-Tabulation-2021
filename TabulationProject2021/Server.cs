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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();

            LoadFullInformationEveningGown(); 
            LoadFullInformationFinalQA();

            OverallResultSHS();
        }

        #region EveningGown

        private void LoadFullInformationEveningGown()
        {
            string[] maleDetailsSHS;
            LoadDataSHS("Male", listSHSMale, out maleDetailsSHS);

            lblNameMaleSHS.Text = "Name: " + maleDetailsSHS[0];
            lblStrandMaleSHS.Text = "Strand: " + maleDetailsSHS[1];
            lblAverageMaleSHS.Text = "Average Points: " + maleDetailsSHS[2];
            lblPercentageMaleSHS.Text = "Percentage Points: " + maleDetailsSHS[3];

            string[] femaleDetailsSHS;
            LoadDataSHS("Female", listSHSFemale, out femaleDetailsSHS);

            lblNameFemaleSHS.Text = "Name: " + femaleDetailsSHS[0];
            lblStrandFemaleSHS.Text = "Strand: " + femaleDetailsSHS[1];
            lblAverageFemaleSHS.Text = "Average Points: " + femaleDetailsSHS[2];
            lblPercentageFemaleSHS.Text = "Percentage Points: " + femaleDetailsSHS[3];

            string[] maleDetailsCollege;
            LoadDataCollege("Male", listCollegeMale, out maleDetailsCollege);

            lblNameMaleCollege.Text = "Name: " + maleDetailsCollege[0];
            lblCourseMaleCollege.Text = "Strand: " + maleDetailsCollege[1];
            lblAverageMaleCollege.Text = "Average Points: " + maleDetailsCollege[2];
            lblPercentageMaleCollege.Text = "Percentage Points: " + maleDetailsCollege[3];

            string[] femaleDetailsCollege;
            LoadDataCollege("Female", listCollegeFemale, out femaleDetailsCollege);

            lblNameFemaleCollege.Text = "Name: " + femaleDetailsCollege[0];
            lblCourseFemaleCollege.Text = "Strand: " + femaleDetailsCollege[1];
            lblAverageFemaleCollege.Text = "Average Points: " + femaleDetailsCollege[2];
            lblPercentageFemaleCollege.Text = "Percentage Points: " + femaleDetailsCollege[3];

        }

        private void LoadDataSHS(string gender, ListView list, out string[] highest)
        {
            ServerData highSchoolData = new ServerData("EveningGown", "SHS", gender);
            var datas = highSchoolData.Scores();
            list.Items.Clear();

            foreach (var score in datas)
            {
                ListViewItem lv = new ListViewItem();
                lv = list.Items.Add(score.CandidateNumber);
                lv.SubItems.Add(score.CandidateName);
                lv.SubItems.Add(score.Grades);
                lv.SubItems.Add(score.AverageScore);
                lv.SubItems.Add(score.PercentageScore);
            }

            highest = new string[] { datas[0].CandidateName, datas[0].Strand_Course, datas[0].AverageScore, datas[0].PercentageScore };
        }

        private void LoadDataCollege(string gender, ListView list, out string[] highest)
        {
            ServerData highSchoolData = new ServerData("EveningGown", "College", gender);
            var datas = highSchoolData.Scores();
            list.Items.Clear();

            foreach (var score in datas)
            {
                ListViewItem lv = new ListViewItem();
                lv = list.Items.Add(score.CandidateNumber);
                lv.SubItems.Add(score.CandidateName);
                lv.SubItems.Add(score.Grades);
                lv.SubItems.Add(score.AverageScore);
                lv.SubItems.Add(score.PercentageScore);
            }

            highest = new string[] { datas[0].CandidateName, datas[0].Strand_Course, datas[0].AverageScore, datas[0].PercentageScore };
        }

        #endregion

        #region FinalQA
        private void LoadFullInformationFinalQA()
        {

            string[] maleDetailsSHS;
            LoadDataSHSFinal("Male", listSHSMaleFinal, out maleDetailsSHS);

            lblSHSNameFinalMale.Text = "Name: " + maleDetailsSHS[0];
            lblSHSStrandFinalMale.Text = "Strand: " + maleDetailsSHS[1];
            lblSHSAverageFinalMale.Text = "Average Points: " + maleDetailsSHS[2];
            lblSHSPercentageFinalMale.Text = "Percentage Points: " + maleDetailsSHS[3];

            string[] femaleDetailsSHS;
            LoadDataSHSFinal("Female", listSHSFemaleFinal, out femaleDetailsSHS);

            lblSHSNameFinalFemale.Text = "Name: " + femaleDetailsSHS[0];
            lblSHSStrandFinalFemale.Text = "Strand: " + femaleDetailsSHS[1];
            lblSHSAverageFinalFemale.Text = "Average Points: " + femaleDetailsSHS[2];
            lblSHSPercentageFinalFemale.Text = "Percentage Points: " + femaleDetailsSHS[3];

            string[] maleDetailsCollege;
            LoadDataCollegeFinal("Male", listCollegeMaleFinal, out maleDetailsCollege);

            lblCollegeNameFinalMale.Text = "Name: " + maleDetailsCollege[0];
            lblCollegeCourseFinalMale.Text = "Course: " + maleDetailsCollege[1];
            lblCollegeAverageFinalMale.Text = "Average Points: " + maleDetailsCollege[2];
            lblCollegePercentageFinalMale.Text = "Percentage Points: " + maleDetailsCollege[3];

            string[] femaleDetailsCollege;
            LoadDataCollegeFinal("Female", listCollegeFemaleFinal, out femaleDetailsCollege);

            lblCollegeNameFinalFemale.Text = "Name: " + femaleDetailsCollege[0];
            lblCollegeCourseFinalFemale.Text = "Course: " + femaleDetailsCollege[1];
            lblCollegeAverageFinalFemale.Text = "Average Points: " + femaleDetailsCollege[2];
            lblCollegePercentageFinalFemale.Text = "Percentage Points: " + femaleDetailsCollege[3];

        }

        private void LoadDataSHSFinal(string gender, ListView list, out string[] highest)
        {
            ServerData highSchoolData = new ServerData("FinalQA", "SHS", gender);
            var datas = highSchoolData.Scores();
            list.Items.Clear();

            foreach (var score in datas)
            {
                ListViewItem lv = new ListViewItem();
                lv = list.Items.Add(score.CandidateNumber);
                lv.SubItems.Add(score.CandidateName);
                lv.SubItems.Add(score.Grades);
                lv.SubItems.Add(score.AverageScore);
                lv.SubItems.Add(score.PercentageScore);
            }

            highest = new string[] { datas[0].CandidateName, datas[0].Strand_Course, datas[0].AverageScore, datas[0].PercentageScore };
        }

        private void LoadDataCollegeFinal(string gender, ListView list, out string[] highest)
        {
            ServerData highSchoolData = new ServerData("FinalQA", "College", gender);
            var datas = highSchoolData.Scores();
            list.Items.Clear();

            foreach (var score in datas)
            {
                ListViewItem lv = new ListViewItem();
                lv = list.Items.Add(score.CandidateNumber);
                lv.SubItems.Add(score.CandidateName);
                lv.SubItems.Add(score.Grades);
                lv.SubItems.Add(score.AverageScore);
                lv.SubItems.Add(score.PercentageScore);
            }

            highest = new string[] { datas[0].CandidateName, datas[0].Strand_Course, datas[0].AverageScore, datas[0].PercentageScore };
        }

        #endregion

        public void OverallResultSHS()
        {
            ServerData dataMaleFirst = new ServerData("", "SHS", "Male");
            var resultMaleFirst = dataMaleFirst.Result();

            lblFirstMaleNameSHS.Text = resultMaleFirst[0].Name;
            lblFirstMaleStrandSHS.Text = resultMaleFirst[0].Strand_Course;
            lblFirstMaleEveningSHS.Text = resultMaleFirst[0].EveningGown;
            lblFirstMaleFinalSHS.Text = resultMaleFirst[0].FinalQA;
            lblFirstMaleTotalSHS.Text = resultMaleFirst[0].Total;

            ServerData dataFemaleFirst = new ServerData("", "SHS", "Male");
            var resultFemaleFirst = dataFemaleFirst.Result();

            lblFirstMaleNameSHS.Text = resultFemaleFirst[0].Name;
            lblFirstMaleStrandSHS.Text = resultFemaleFirst[0].Strand_Course;
            lblFirstMaleEveningSHS.Text = resultFemaleFirst[0].EveningGown;
            lblFirstMaleFinalSHS.Text = resultFemaleFirst[0].FinalQA;
            lblFirstMaleTotalSHS.Text = resultFemaleFirst[0].Total;
        }

        private void runtimeRefresh_Tick(object sender, EventArgs e)
        {
            LoadFullInformationEveningGown();
            LoadFullInformationFinalQA();
            OverallResultSHS();
        }
    }
}
