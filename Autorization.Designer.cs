namespace WindowsFormsApp1
{
    partial class Autorization
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
            this.CloseApp = new System.Windows.Forms.Button();
            this.RegistrationLink = new System.Windows.Forms.LinkLabel();
            this.AutorizationButton = new System.Windows.Forms.Button();
            this.EnterAutPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterAutLoginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseApp);
            this.panel1.Controls.Add(this.RegistrationLink);
            this.panel1.Controls.Add(this.AutorizationButton);
            this.panel1.Controls.Add(this.EnterAutPasswordBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EnterAutLoginBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // CloseApp
            // 
            this.CloseApp.Location = new System.Drawing.Point(638, 3);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(150, 37);
            this.CloseApp.TabIndex = 7;
            this.CloseApp.Text = "Закрыть приложение";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // RegistrationLink
            // 
            this.RegistrationLink.AutoSize = true;
            this.RegistrationLink.Location = new System.Drawing.Point(32, 282);
            this.RegistrationLink.Name = "RegistrationLink";
            this.RegistrationLink.Size = new System.Drawing.Size(113, 13);
            this.RegistrationLink.TabIndex = 6;
            this.RegistrationLink.TabStop = true;
            this.RegistrationLink.Text = "Зарегистрироваться";
            this.RegistrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationLink_LinkClicked);
            // 
            // AutorizationButton
            // 
            this.AutorizationButton.Location = new System.Drawing.Point(32, 202);
            this.AutorizationButton.Name = "AutorizationButton";
            this.AutorizationButton.Size = new System.Drawing.Size(286, 42);
            this.AutorizationButton.TabIndex = 5;
            this.AutorizationButton.Text = "Авторизоваться";
            this.AutorizationButton.UseVisualStyleBackColor = true;
            this.AutorizationButton.Click += new System.EventHandler(this.AutorizationButton_Click);
            // 
            // EnterAutPasswordBox
            // 
            this.EnterAutPasswordBox.Location = new System.Drawing.Point(104, 119);
            this.EnterAutPasswordBox.Name = "EnterAutPasswordBox";
            this.EnterAutPasswordBox.PasswordChar = '*';
            this.EnterAutPasswordBox.Size = new System.Drawing.Size(214, 20);
            this.EnterAutPasswordBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // EnterAutLoginBox
            // 
            this.EnterAutLoginBox.Location = new System.Drawing.Point(104, 64);
            this.EnterAutLoginBox.Name = "EnterAutLoginBox";
            this.EnterAutLoginBox.Size = new System.Drawing.Size(214, 20);
            this.EnterAutLoginBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Autorization";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterAutLoginBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterAutPasswordBox;
        private System.Windows.Forms.Button AutorizationButton;
        private System.Windows.Forms.LinkLabel RegistrationLink;
        private System.Windows.Forms.Button CloseApp;
    }
}