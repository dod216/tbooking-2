namespace QWC2022
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.spanal1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SFbutton = new System.Windows.Forms.Button();
            this.hbutton = new System.Windows.Forms.Button();
            this.sf1 = new QWC2022.SF();
            this.home1 = new QWC2022.home();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.spanal1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SFbutton);
            this.panel1.Controls.Add(this.hbutton);
            this.panel1.Location = new System.Drawing.Point(-13, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 533);
            this.panel1.TabIndex = 1;
            // 
            // spanal1
            // 
            this.spanal1.BackColor = System.Drawing.Color.White;
            this.spanal1.Location = new System.Drawing.Point(6, 173);
            this.spanal1.Name = "spanal1";
            this.spanal1.Size = new System.Drawing.Size(10, 49);
            this.spanal1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(6, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SFbutton
            // 
            this.SFbutton.FlatAppearance.BorderSize = 0;
            this.SFbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SFbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SFbutton.Location = new System.Drawing.Point(3, 228);
            this.SFbutton.Name = "SFbutton";
            this.SFbutton.Size = new System.Drawing.Size(179, 63);
            this.SFbutton.TabIndex = 2;
            this.SFbutton.Text = "Semi Final";
            this.SFbutton.UseVisualStyleBackColor = true;
            this.SFbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // hbutton
            // 
            this.hbutton.FlatAppearance.BorderSize = 0;
            this.hbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hbutton.Location = new System.Drawing.Point(0, 168);
            this.hbutton.Name = "hbutton";
            this.hbutton.Size = new System.Drawing.Size(182, 63);
            this.hbutton.TabIndex = 1;
            this.hbutton.Text = "Home ";
            this.hbutton.UseVisualStyleBackColor = true;
            this.hbutton.Click += new System.EventHandler(this.hbutton_Click);
            // 
            // sf1
            // 
            this.sf1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sf1.BackgroundImage")));
            this.sf1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sf1.Location = new System.Drawing.Point(167, 1);
            this.sf1.Name = "sf1";
            this.sf1.Size = new System.Drawing.Size(717, 505);
            this.sf1.TabIndex = 4;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home1.Location = new System.Drawing.Point(167, 1);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(717, 505);
            this.home1.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QWC2022.Properties.Resources.d7b20c142069201_625ffbdb35502;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.sf1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel spanal1;
        private Button button3;
        private Button SFbutton;
        private Button hbutton;
        private SF sf1;
        private home home1;
    }
}