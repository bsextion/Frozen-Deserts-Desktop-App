namespace Ice_Cream_Desktop_Application
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.specialBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.customControl11 = new Ice_Cream_Desktop_Application.CustomControl1();
            this.customControl21 = new Ice_Cream_Desktop_Application.CustomControl2();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 24);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.menuBtn);
            this.panel2.Controls.Add(this.specialBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 561);
            this.panel2.TabIndex = 1;
            // 
            // menuBtn
            // 
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBtn.Location = new System.Drawing.Point(0, 131);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(202, 50);
            this.menuBtn.TabIndex = 6;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // specialBtn
            // 
            this.specialBtn.FlatAppearance.BorderSize = 0;
            this.specialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.specialBtn.Location = new System.Drawing.Point(0, 86);
            this.specialBtn.Name = "specialBtn";
            this.specialBtn.Size = new System.Drawing.Size(202, 50);
            this.specialBtn.TabIndex = 5;
            this.specialBtn.Text = "Specials";
            this.specialBtn.UseVisualStyleBackColor = true;
            this.specialBtn.Click += new System.EventHandler(this.specialBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeBtn.Location = new System.Drawing.Point(-2, 42);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(202, 50);
            this.homeBtn.TabIndex = 4;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(653, 110);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 25);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // customControl11
            // 
            this.customControl11.Location = new System.Drawing.Point(208, 101);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(838, 382);
            this.customControl11.TabIndex = 5;
            this.customControl11.Load += new System.EventHandler(this.customControl11_Load);
            // 
            // customControl21
            // 
            this.customControl21.Location = new System.Drawing.Point(208, 110);
            this.customControl21.Name = "customControl21";
            this.customControl21.Size = new System.Drawing.Size(853, 406);
            this.customControl21.TabIndex = 6;
            this.customControl21.Load += new System.EventHandler(this.customControl21_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 585);
            this.Controls.Add(this.customControl21);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button specialBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private CustomControl1 customControl11;
        private System.Windows.Forms.Button menuBtn;
        private CustomControl2 customControl21;
    }
}

