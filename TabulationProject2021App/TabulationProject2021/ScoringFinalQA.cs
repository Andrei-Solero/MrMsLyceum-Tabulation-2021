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
using Transitions;

namespace TabulationProject2021
{
    public partial class ScoringFinalQA : Form
    {
        private int CandidateSequenceHighSchool = 1;
        private int CandidateSequenceCollege = 1;
        Colleges college;
        HighSchools highSchools;
        private EventSelection eventSelection;
        private string candidateName;
        private int candidateID = 0;

        public ScoringFinalQA(EventSelection eventSelection, string judgeNumber)
        {
            InitializeComponent();

            this.eventSelection = eventSelection;
            lblJudgeNumber.Text = judgeNumber;

            LoadSHS();
        }
        private void Num_Enter(object sender, EventArgs e)
        {
            var a = sender as NumericUpDown;
            a.Select(0, numConfidence.Value.ToString().Length + numConfidence.DecimalPlaces + 2);
        }

        private bool LoadSHS()
        {
            highSchools = new HighSchools(CandidateSequenceHighSchool);
            var highSchoolCandidates = highSchools.GetHighSchools();

            var highSchoolExistingGrades = highSchools.ExistingScores("FinalQA", lblJudgeNumber.Text);

            if (highSchoolCandidates == null)
            {
                return false;
            }
            else
            {
                this.candidateName = highSchoolCandidates.Name;
                this.candidateID = highSchoolCandidates.ID;

                Transition.run(lblCandidateName, "Text", "Candidate Name: &" + highSchoolCandidates.Name, new TransitionType_Linear(2000));
                Transition.run(lblCandidateID, "Text", "Candidate ID: &" + highSchoolCandidates.ID.ToString(), new TransitionType_Linear(2000));
                Transition.run(lblCandidateNumber, "Text", "Candidate Number: &" + highSchoolCandidates.CandidateNumber, new TransitionType_Linear(2000));
                Transition.run(lblCourse, "Text", "Strand: &" + highSchoolCandidates.Strand, new TransitionType_Linear(2000));
                Transition.run(lblGender, "Text", "Gender: &" + highSchoolCandidates.Gender, new TransitionType_Linear(2000));

                numIntelligence.Value = highSchoolExistingGrades[0];
                numConfidence.Value = highSchoolExistingGrades[1];

                return true;
            }
        }

        private bool LoadCollege()
        {
            college = new Colleges(CandidateSequenceCollege);
            var collegeCandidates = college.GetColleges();

            var collegeExistingGrades = college.ExistingScores("FinalQA", lblJudgeNumber.Text);

            if (collegeCandidates == null)
            {
                return false;
            }
            else
            {
                this.candidateName = collegeCandidates.Name;
                this.candidateID = collegeCandidates.ID;

                Transition.run(lblCandidateName, "Text", "Candidate Name: &" + collegeCandidates.Name, new TransitionType_Linear(2000));
                Transition.run(lblCandidateID, "Text", "Candidate ID: &" + collegeCandidates.ID.ToString(), new TransitionType_Linear(2000));
                Transition.run(lblCandidateNumber, "Text", "Candidate Number: &" + collegeCandidates.CandidateNumber, new TransitionType_Linear(2000));
                Transition.run(lblCourse, "Text", "Strand: &" + collegeCandidates.Course, new TransitionType_Linear(2000));
                Transition.run(lblGender, "Text", "Gender: &" + collegeCandidates.Gender, new TransitionType_Linear(2000));

                numIntelligence.Value = collegeExistingGrades[0];
                numConfidence.Value = collegeExistingGrades[1];

                return true;
            }
        }

        bool ActivateVoteForCollege = false;
        private void btnSubmitVote_Click(object sender, EventArgs e)
        {
            decimal confidence = numConfidence.Value * .5M;
            decimal intelligence = numIntelligence.Value * .5M;
            List<decimal> scores = new List<decimal> { confidence, intelligence };
            decimal[] points = { numIntelligence.Value, numConfidence.Value };

            highSchools = new HighSchools(candidateID, lblJudgeNumber.Text, scores, "FinalQA");
            highSchools.Vote(points, lblJudgeNumber.Text);
            CandidateSequenceHighSchool++;

            if (LoadSHS() == false)
            {
                imageTransitionSHS.Enabled = false;
                imageTransitionCollege.Enabled = true;

                if (LoadCollege() == false)
                {
                    MessageBox.Show("Voting for Evening Gown/Formal wear is done! Proceed to next Category", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (ActivateVoteForCollege == true)
                {
                    college = new Colleges(candidateID, lblJudgeNumber.Text, scores, "FinalQA");
                    college.Vote(points, lblJudgeNumber.Text);

                    if (lblCandidateID.Text == "Candidate ID: &6")
                    {
                        MessageBox.Show("Voting is now done! Thanks for your vote", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        eventSelection.Show();
                        this.Dispose();
                        this.Close();
                    }

                    CandidateSequenceCollege++;
                    LoadCollege();
                }

                ActivateVoteForCollege = true;
            }

            LoadSHS();

            List<NumericUpDown> nums = panel2.Controls.OfType<NumericUpDown>().ToList();
            foreach (var item in nums)
            {
                item.Value = item.Minimum;
            }
        }

        int counterCollege = 0;
        private void imageTransitionCollege_Tick(object sender, EventArgs e)
        {
            var collegeCandidate = new Colleges();
            var imagePath = collegeCandidate.LoadPhoto(candidateName);

            try
            {
                if (counterCollege < imagePath.Length)
                {
                    Transition.run(this.pictureBox1, "Left", 0, new TransitionType_EaseInEaseOut(1000));
                    this.pictureBox1.Image = Image.FromFile(imagePath[counterCollege]);

                    if (this.pictureBox1.Left == 0)
                    {
                        this.imageTransitionCollege.Interval = 2000;
                        Transition.run(this.pictureBox1, "Left", this.pictureBox1.Width, new TransitionType_EaseInEaseOut(800));
                        counterCollege++;
                    }
                    else
                    {
                        this.pictureBox1.Left = -320;
                        this.imageTransitionCollege.Interval = 5000;
                    }
                }
                else
                {
                    counterCollege = 0;
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        int counterSHS = 0;
        private void imageTransitionSHS_Tick(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(label1);
            guna2Transition1.ShowSync(label2);

            guna2Transition1.ShowSync(btnSubmitVote);
            guna2Transition1.ShowSync(btnPrevious);
            guna2Transition1.ShowSync(btnNext);

            var highSchoolCandidate = new HighSchools();
            var imagePath = highSchoolCandidate.LoadPhoto(candidateName);

            try
            {
                if (counterSHS < imagePath.Length)
                {
                    Transition.run(this.pictureBox1, "Left", 0, new TransitionType_EaseInEaseOut(1000));
                    this.pictureBox1.Image = Image.FromFile(imagePath[counterSHS]);

                    if (this.pictureBox1.Left == 0)
                    {
                        this.imageTransitionSHS.Interval = 2000;
                        Transition.run(this.pictureBox1, "Left", this.pictureBox1.Width, new TransitionType_EaseInEaseOut(800));
                        counterSHS++;
                    }
                    else
                    {
                        this.pictureBox1.Left = -320;
                        this.imageTransitionSHS.Interval = 5000;
                    }
                }
                else
                {
                    counterSHS = 0;
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            eventSelection.Show();

            this.Dispose();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CandidateSequenceHighSchool++;

            if (LoadSHS() == false)
            {
                imageTransitionSHS.Enabled = false;
                imageTransitionCollege.Enabled = true;

                if (LoadCollege() == false)
                {
                    MessageBox.Show("Finished Vote");
                }

                if (ActivateVoteForCollege == true)
                {
                    if (lblCandidateID.Text == "6")
                    {

                    }
                    else
                    {
                        CandidateSequenceCollege++;
                        LoadCollege();
                    }

                }

                ActivateVoteForCollege = true;
            }

            LoadSHS();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            CandidateSequenceHighSchool--;

            if (CandidateSequenceHighSchool == 6)
            {
                imageTransitionSHS.Enabled = true;
                imageTransitionCollege.Enabled = false;
                CandidateSequenceCollege = 1;
            }

            if (LoadSHS() == false)
            {
                imageTransitionSHS.Enabled = false;
                imageTransitionCollege.Enabled = true;

                if (LoadCollege() == false)
                {
                    MessageBox.Show("Finished Vote");
                }

                if (ActivateVoteForCollege == true)
                {
                    if (lblCandidateID.Text == "1")
                    {
                        ActivateVoteForCollege = false;
                    }

                    CandidateSequenceCollege--;
                    LoadCollege();
                }

                ActivateVoteForCollege = true;
            }

            LoadSHS();
        }
    }
}
