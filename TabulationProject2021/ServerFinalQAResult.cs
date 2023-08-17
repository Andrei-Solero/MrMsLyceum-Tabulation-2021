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
    public partial class ServerFinalQAResult : UserControl
    {
        public ServerFinalQAResult()
        {
            InitializeComponent();
        }

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

        private void runtimeRefresh_Tick(object sender, EventArgs e)
        {
            LoadFullInformationFinalQA();
        }
    }
}
