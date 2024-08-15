namespace WindowsFormsApp1
{
    partial class User_Cabinet
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
            this.Show_login = new System.Windows.Forms.Label();
            this.Show_email = new System.Windows.Forms.Label();
            this.Show_female = new System.Windows.Forms.Label();
            this.Show_name = new System.Windows.Forms.Label();
            this.Close_App = new System.Windows.Forms.Button();
            this.GoToExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GoToExit);
            this.panel1.Controls.Add(this.Show_login);
            this.panel1.Controls.Add(this.Show_email);
            this.panel1.Controls.Add(this.Show_female);
            this.panel1.Controls.Add(this.Show_name);
            this.panel1.Controls.Add(this.Close_App);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // Show_login
            // 
            this.Show_login.AutoSize = true;
            this.Show_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_login.Location = new System.Drawing.Point(84, 164);
            this.Show_login.Name = "Show_login";
            this.Show_login.Size = new System.Drawing.Size(60, 24);
            this.Show_login.TabIndex = 4;
            this.Show_login.Text = "label1";
            // 
            // Show_email
            // 
            this.Show_email.AutoSize = true;
            this.Show_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_email.Location = new System.Drawing.Point(80, 123);
            this.Show_email.Name = "Show_email";
            this.Show_email.Size = new System.Drawing.Size(60, 24);
            this.Show_email.TabIndex = 3;
            this.Show_email.Text = "label1";
            // 
            // Show_female
            // 
            this.Show_female.AutoSize = true;
            this.Show_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_female.Location = new System.Drawing.Point(77, 83);
            this.Show_female.Name = "Show_female";
            this.Show_female.Size = new System.Drawing.Size(60, 24);
            this.Show_female.TabIndex = 2;
            this.Show_female.Text = "label1";
            // 
            // Show_name
            // 
            this.Show_name.AutoSize = true;
            this.Show_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_name.Location = new System.Drawing.Point(74, 46);
            this.Show_name.Name = "Show_name";
            this.Show_name.Size = new System.Drawing.Size(60, 24);
            this.Show_name.TabIndex = 1;
            this.Show_name.Text = "label1";
            // 
            // Close_App
            // 
            this.Close_App.Location = new System.Drawing.Point(660, 3);
            this.Close_App.Name = "Close_App";
            this.Close_App.Size = new System.Drawing.Size(137, 38);
            this.Close_App.TabIndex = 0;
            this.Close_App.Text = "Закрыть";
            this.Close_App.UseVisualStyleBackColor = true;
            this.Close_App.Click += new System.EventHandler(this.Close_App_Click);
            // 
            // GoToExit
            // 
            this.GoToExit.Location = new System.Drawing.Point(23, 348);
            this.GoToExit.Name = "GoToExit";
            this.GoToExit.Size = new System.Drawing.Size(651, 66);
            this.GoToExit.TabIndex = 5;
            this.GoToExit.Text = "Выйти";
            this.GoToExit.UseVisualStyleBackColor = true;
            this.GoToExit.Click += new System.EventHandler(this.GoToExit_Click);
            // 
            // User_Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "User_Cabinet";
            this.Text = "Кабинет пользователя";
            this.Load += new System.EventHandler(this.User_Cabinet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_App;
        private System.Windows.Forms.Label Show_name;
        private System.Windows.Forms.Label Show_female;
        private System.Windows.Forms.Label Show_email;
        private System.Windows.Forms.Label Show_login;
        private System.Windows.Forms.Button GoToExit;
    }
}