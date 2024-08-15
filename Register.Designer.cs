namespace WindowsFormsApp1
{
    partial class Register
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AutorizationLink = new System.Windows.Forms.LinkLabel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.EnterconfirmBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EnterpasswordBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnterloginBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnteremailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterfemaleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnternameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseApplication);
            this.panel1.Controls.Add(this.AutorizationLink);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.EnterconfirmBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EnterpasswordBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EnterloginBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EnteremailBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EnterfemaleBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EnternameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 552);
            this.panel1.TabIndex = 0;
            // 
            // AutorizationLink
            // 
            this.AutorizationLink.AutoSize = true;
            this.AutorizationLink.Location = new System.Drawing.Point(34, 442);
            this.AutorizationLink.Name = "AutorizationLink";
            this.AutorizationLink.Size = new System.Drawing.Size(90, 13);
            this.AutorizationLink.TabIndex = 14;
            this.AutorizationLink.TabStop = true;
            this.AutorizationLink.Text = "Авторизоваться";
            this.AutorizationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AutorizationLink_LinkClicked);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(34, 355);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(468, 43);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // EnterconfirmBox
            // 
            this.EnterconfirmBox.Location = new System.Drawing.Point(244, 284);
            this.EnterconfirmBox.Name = "EnterconfirmBox";
            this.EnterconfirmBox.PasswordChar = '*';
            this.EnterconfirmBox.Size = new System.Drawing.Size(250, 20);
            this.EnterconfirmBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Подтвердите пароль:";
            // 
            // EnterpasswordBox
            // 
            this.EnterpasswordBox.Location = new System.Drawing.Point(114, 238);
            this.EnterpasswordBox.Name = "EnterpasswordBox";
            this.EnterpasswordBox.PasswordChar = '*';
            this.EnterpasswordBox.Size = new System.Drawing.Size(211, 20);
            this.EnterpasswordBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пароль:";
            // 
            // EnterloginBox
            // 
            this.EnterloginBox.Location = new System.Drawing.Point(97, 199);
            this.EnterloginBox.Name = "EnterloginBox";
            this.EnterloginBox.Size = new System.Drawing.Size(228, 20);
            this.EnterloginBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Логин:";
            // 
            // EnteremailBox
            // 
            this.EnteremailBox.Location = new System.Drawing.Point(87, 158);
            this.EnteremailBox.Name = "EnteremailBox";
            this.EnteremailBox.Size = new System.Drawing.Size(238, 20);
            this.EnteremailBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // EnterfemaleBox
            // 
            this.EnterfemaleBox.Location = new System.Drawing.Point(117, 110);
            this.EnterfemaleBox.Name = "EnterfemaleBox";
            this.EnterfemaleBox.Size = new System.Drawing.Size(208, 20);
            this.EnterfemaleBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия:";
            // 
            // EnternameBox
            // 
            this.EnternameBox.Location = new System.Drawing.Point(71, 66);
            this.EnternameBox.Name = "EnternameBox";
            this.EnternameBox.Size = new System.Drawing.Size(254, 20);
            this.EnternameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // CloseApplication
            // 
            this.CloseApplication.Location = new System.Drawing.Point(719, 3);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(156, 27);
            this.CloseApplication.TabIndex = 15;
            this.CloseApplication.Text = "Закрыть приложение";
            this.CloseApplication.UseVisualStyleBackColor = true;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 552);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnternameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterfemaleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnteremailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnterloginBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnterpasswordBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EnterconfirmBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.LinkLabel AutorizationLink;
        private System.Windows.Forms.Button CloseApplication;
    }
}

