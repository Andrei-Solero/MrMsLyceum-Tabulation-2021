using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabulationProject2021
{
    public partial class ServerUI : Form
    {
        public ServerUI()
        {
            InitializeComponent();
        }

        private void btnEveningGown_Click(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            ServerEveningGownResult eveningGown = new ServerEveningGownResult();
            this.container.Controls.Add(eveningGown);
        }

        private void btnFinalQA_Click(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            ServerFinalQAResult finalQA = new ServerFinalQAResult();
            this.container.Controls.Add(finalQA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            ServerOverallResult overAll = new ServerOverallResult();
            this.container.Controls.Add(overAll);
        }
    }
}
