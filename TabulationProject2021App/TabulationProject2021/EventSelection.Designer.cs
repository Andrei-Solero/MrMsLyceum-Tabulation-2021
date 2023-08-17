
namespace TabulationProject2021
{
    partial class EventSelection
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
            this.components = new System.ComponentModel.Container();
            this.btnEveningGown = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // btnEveningGown
            // 
            this.btnEveningGown.BackColor = System.Drawing.Color.Transparent;
            this.btnEveningGown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEveningGown.FlatAppearance.BorderSize = 0;
            this.btnEveningGown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEveningGown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEveningGown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveningGown.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEveningGown.ForeColor = System.Drawing.Color.White;
            this.btnEveningGown.Location = new System.Drawing.Point(204, 283);
            this.btnEveningGown.Name = "btnEveningGown";
            this.btnEveningGown.Size = new System.Drawing.Size(617, 133);
            this.btnEveningGown.TabIndex = 0;
            this.btnEveningGown.Text = "Evening Gown/Formal Wear";
            this.btnEveningGown.UseVisualStyleBackColor = false;
            this.btnEveningGown.Click += new System.EventHandler(this.btnEveningGown_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Location = new System.Drawing.Point(204, 476);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(617, 133);
            this.btnFinal.TabIndex = 3;
            this.btnFinal.Text = "Final Question && Answer";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinalQA_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.DisabledState.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Navy;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(361, 703);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(302, 53);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // EventSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TabulationProject2021.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnEveningGown);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEveningGown;
        private System.Windows.Forms.Button btnFinal;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}