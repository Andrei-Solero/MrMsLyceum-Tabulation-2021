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
    public partial class ServerEveningGownResult : UserControl
    {
        public ServerEveningGownResult()
        {
            InitializeComponent();

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

        private void runtimeRefresh_Tick(object sender, EventArgs e)
        {
            LoadFullInformationEveningGown();
        }
    }
}
