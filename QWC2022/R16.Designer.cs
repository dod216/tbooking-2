namespace QWC2022
{
    partial class R16
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R16));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidepanel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Sidepanel1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.hbutton);
            this.panel1.Location = new System.Drawing.Point(-6, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 559);
            this.panel1.TabIndex = 0;
            // 
            // Sidepanel1
            // 
            this.Sidepanel1.BackColor = System.Drawing.Color.White;
            this.Sidepanel1.Location = new System.Drawing.Point(0, 182);
            this.Sidepanel1.Name = "Sidepanel1";
            this.Sidepanel1.Size = new System.Drawing.Size(10, 49);
            this.Sidepanel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(6, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(3, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Semi Final";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hbutton
            // 
            this.hbutton.FlatAppearance.BorderSize = 0;
            this.hbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hbutton.Location = new System.Drawing.Point(3, 168);
            this.hbutton.Name = "hbutton";
            this.hbutton.Size = new System.Drawing.Size(227, 63);
            this.hbutton.TabIndex = 1;
            this.hbutton.Text = "Home ";
            this.hbutton.UseVisualStyleBackColor = true;
            this.hbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // R16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "R16";
            this.Size = new System.Drawing.Size(901, 551);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button hbutton;
        private Panel Sidepanel1;
    }
}
