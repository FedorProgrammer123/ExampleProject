namespace WindowsFormsApp1
{
    partial class Admin_Cabinet
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Show_name = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowUserButton = new System.Windows.Forms.Button();
            this.dataUsersView = new System.Windows.Forms.DataGridView();
            this.EnterQueryBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsersView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 574);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 574);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Show_name);
            this.tabPage1.Controls.Add(this.Exit);
            this.tabPage1.Controls.Add(this.CloseApplication);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Show_name
            // 
            this.Show_name.AutoSize = true;
            this.Show_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_name.Location = new System.Drawing.Point(6, 18);
            this.Show_name.Name = "Show_name";
            this.Show_name.Size = new System.Drawing.Size(60, 24);
            this.Show_name.TabIndex = 1;
            this.Show_name.Text = "label1";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(37, 461);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(593, 58);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CloseApplication
            // 
            this.CloseApplication.Location = new System.Drawing.Point(703, 6);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(125, 27);
            this.CloseApplication.TabIndex = 2;
            this.CloseApplication.Text = "Закрыть приложение";
            this.CloseApplication.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EnterQueryBox);
            this.tabPage2.Controls.Add(this.dataUsersView);
            this.tabPage2.Controls.Add(this.ShowUserButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SELECT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Просмотр данных о пользователях";
            // 
            // ShowUserButton
            // 
            this.ShowUserButton.Location = new System.Drawing.Point(18, 419);
            this.ShowUserButton.Name = "ShowUserButton";
            this.ShowUserButton.Size = new System.Drawing.Size(250, 47);
            this.ShowUserButton.TabIndex = 2;
            this.ShowUserButton.Text = "Вывести список";
            this.ShowUserButton.UseVisualStyleBackColor = true;
            this.ShowUserButton.Click += new System.EventHandler(this.ShowUserButton_Click);
            // 
            // dataUsersView
            // 
            this.dataUsersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsersView.Location = new System.Drawing.Point(18, 98);
            this.dataUsersView.Name = "dataUsersView";
            this.dataUsersView.Size = new System.Drawing.Size(774, 212);
            this.dataUsersView.TabIndex = 3;
            // 
            // EnterQueryBox
            // 
            this.EnterQueryBox.Location = new System.Drawing.Point(275, 438);
            this.EnterQueryBox.Name = "EnterQueryBox";
            this.EnterQueryBox.Size = new System.Drawing.Size(332, 20);
            this.EnterQueryBox.TabIndex = 4;
            // 
            // Admin_Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 574);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Cabinet";
            this.Text = "Admin_Cabinet";
            this.Load += new System.EventHandler(this.Admin_Cabinet_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Label Show_name;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowUserButton;
        private System.Windows.Forms.DataGridView dataUsersView;
        private System.Windows.Forms.TextBox EnterQueryBox;
    }
}