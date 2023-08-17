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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void hiddenAdmin_Click(object sender, EventArgs e)
        {
            ServerUI server = new ServerUI();
            this.Hide();
            server.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginCode = txtCode.Text;
            string judgeNumber = "";
            Judges judge = new Judges(loginCode);
            var IsValid = judge.Login(out judgeNumber);

            if (IsValid == true)
            {
                MessageBox.Show("Welcome to Mr & Mrs Lyceum of Alabang 2021", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EventSelection eventSelction = new EventSelection(this, "Judge" + judgeNumber);
                eventSelction.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Code", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerUI server = new ServerUI();
            this.Hide();
            server.Show();
        }
    }
}
