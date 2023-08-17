
namespace TabulationProject2021
{
    partial class ServerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEveningGown = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.btnFinalQA = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEveningGown
            // 
            this.btnEveningGown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnEveningGown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveningGown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEveningGown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEveningGown.ForeColor = System.Drawing.Color.White;
            this.btnEveningGown.Location = new System.Drawing.Point(21, 2);
            this.btnEveningGown.Name = "btnEveningGown";
            this.btnEveningGown.Size = new System.Drawing.Size(394, 24);
            this.btnEveningGown.TabIndex = 0;
            this.btnEveningGown.Text = "Evening Gown/Formal Wear (40%)";
            this.btnEveningGown.UseVisualStyleBackColor = false;
            this.btnEveningGown.Click += new System.EventHandler(this.btnEveningGown_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.container.Location = new System.Drawing.Point(0, 30);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1237, 691);
            this.container.TabIndex = 3;
            // 
            // btnFinalQA
            // 
            this.btnFinalQA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnFinalQA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinalQA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalQA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalQA.ForeColor = System.Drawing.Color.White;
            this.btnFinalQA.Location = new System.Drawing.Point(421, 2);
            this.btnFinalQA.Name = "btnFinalQA";
            this.btnFinalQA.Size = new System.Drawing.Size(394, 24);
            this.btnFinalQA.TabIndex = 4;
            this.btnFinalQA.Text = "Final Question && Answer (60%)";
            this.btnFinalQA.UseVisualStyleBackColor = false;
            this.btnFinalQA.Click += new System.EventHandler(this.btnFinalQA_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(821, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(394, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Overall Result";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1237, 721);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFinalQA);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnEveningGown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEveningGown;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button btnFinalQA;
        private System.Windows.Forms.Button button3;
    }
}