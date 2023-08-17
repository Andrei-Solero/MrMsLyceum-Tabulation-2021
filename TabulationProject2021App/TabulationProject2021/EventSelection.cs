using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace TabulationProject2021
{
    public partial class EventSelection : Form
    {
        private string judgeNumber = "";
        private Login login;
        public EventSelection(Login login, string judgeNumber)
        {
            InitializeComponent();

            this.login = login;
            this.judgeNumber = judgeNumber;

            this.btnEveningGown.Left = this.Width;
            this.btnFinal.Left = -this.Width;           

            Transition t = new Transition(new TransitionType_EaseInEaseOut(1000));
            t.add(btnEveningGown, "Left", 204);
            t.add(btnFinal, "Left", 204);
            t.run();

        }

        private void btnEveningGown_Click(object sender, EventArgs e)
        {
            ScoringEveningGown eveningGown = new ScoringEveningGown(this, judgeNumber);
            this.Hide();
            eveningGown.Show();
        }

        private void btnFinalQA_Click(object sender, EventArgs e)
        {
            ScoringFinalQA finalQA = new ScoringFinalQA(this, judgeNumber);
            this.Hide();
            finalQA.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.Show();

            this.Dispose();
            this.Close();
        }
    }
}
