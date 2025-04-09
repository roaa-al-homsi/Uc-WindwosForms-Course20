namespace Pool_Club
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
            this.components = new System.ComponentModel.Container();
            this.labDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_Table1 = new Pool_Club.uc_Table();
            this.uc_Table2 = new Pool_Club.uc_Table();
            this.uc_Table3 = new Pool_Club.uc_Table();
            this.uc_Table4 = new Pool_Club.uc_Table();
            this.uc_Table5 = new Pool_Club.uc_Table();
            this.uc_Table6 = new Pool_Club.uc_Table();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labDate
            // 
            this.labDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(73, 61);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(235, 34);
            this.labDate.TabIndex = 27;
            this.labDate.Text = "label7";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 747);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price Per Minute";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(829, 747);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(206, 32);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1055, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(829, 88);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(195, 22);
            this.txtPlayerName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Player\'s Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Billiards  Club";
            // 
            // uc_Table1
            // 
            this.uc_Table1.Location = new System.Drawing.Point(12, 145);
            this.uc_Table1.Name = "uc_Table1";
            this.uc_Table1.NameTable = null;
            this.uc_Table1.PlayerName = null;
            this.uc_Table1.RatePerMinute = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uc_Table1.Size = new System.Drawing.Size(566, 261);
            this.uc_Table1.TabIndex = 28;
            this.uc_Table1.GameOverForSpecificTable += new System.EventHandler<Pool_Club.uc_Table.GameCompletedEventArgs>(this.uc_Table_GameOverForSpecificTable);
            // 
            // uc_Table2
            // 
            this.uc_Table2.Location = new System.Drawing.Point(12, 440);
            this.uc_Table2.Name = "uc_Table2";
            this.uc_Table2.NameTable = null;
            this.uc_Table2.PlayerName = null;
            this.uc_Table2.RatePerMinute = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uc_Table2.Size = new System.Drawing.Size(566, 261);
            this.uc_Table2.TabIndex = 29;
            this.uc_Table2.GameOverForSpecificTable += new System.EventHandler<Pool_Club.uc_Table.GameCompletedEventArgs>(this.uc_Table_GameOverForSpecificTable);
            // 
            // uc_Table3
            // 
            this.uc_Table3.Location = new System.Drawing.Point(613, 145);
            this.uc_Table3.Name = "uc_Table3";
            this.uc_Table3.NameTable = null;
            this.uc_Table3.PlayerName = null;
            this.uc_Table3.RatePerMinute = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uc_Table3.Size = new System.Drawing.Size(566, 261);
            this.uc_Table3.TabIndex = 30;
            this.uc_Table3.GameOverForSpecificTable += new System.EventHandler<Pool_Club.uc_Table.GameCompletedEventArgs>(this.uc_Table_GameOverForSpecificTable);
            // 
            // uc_Table4
            // 
            this.uc_Table4.Location = new System.Drawing.Point(1185, 145);
            this.uc_Table4.Name = "uc_Table4";
            this.uc_Table4.NameTable = null;
            this.uc_Table4.PlayerName = null;
            this.uc_Table4.RatePerMinute = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uc_Table4.Size = new System.Drawing.Size(566, 261);
            this.uc_Table4.TabIndex = 31;
            this.uc_Table4.GameOverForSpecificTable += new System.EventHandler<Pool_Club.uc_Table.GameCompletedEventArgs>(this.uc_Table_GameOverForSpecificTable);
            // 
            // uc_Table5
            // 
            this.uc_Table5.Location = new System.Drawing.Point(613, 440);
            this.uc_Table5.Name = "uc_Table5";
            this.uc_Table5.NameTable = null;
            this.uc_Table5.PlayerName = null;
            this.uc_Table5.RatePerMinute = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uc_Table5.Size = new System.Drawing.Size(566, 261);
            this.uc_Table5.TabIndex = 32;
            this.uc_Table5.GameOverForSpecificTable += new System.EventHandler<Pool_Club.uc_Table.GameCompletedEventArgs>(this.uc_Table_GameOverForSpecificTable);
            // 
            // uc_Table6
            // 
            this.uc_Table6.Location = new System.Drawing.Point(1185, 440);
            this.uc_Table6.Name = "uc_Table6";
            this.uc_Table6.NameTable = null;
            this.uc_Table6.PlayerName = null;
            this.uc_Table6.RatePerMinute = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uc_Table6.Size = new System.Drawing.Size(566, 261);
            this.uc_Table6.TabIndex = 33;
            this.uc_Table6.GameOverForSpecificTable += new System.EventHandler<Pool_Club.uc_Table.GameCompletedEventArgs>(this.uc_Table_GameOverForSpecificTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1791, 816);
            this.Controls.Add(this.uc_Table6);
            this.Controls.Add(this.uc_Table5);
            this.Controls.Add(this.uc_Table4);
            this.Controls.Add(this.uc_Table3);
            this.Controls.Add(this.uc_Table2);
            this.Controls.Add(this.uc_Table1);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private uc_Table uc_Table1;
        private uc_Table uc_Table2;
        private uc_Table uc_Table3;
        private uc_Table uc_Table4;
        private uc_Table uc_Table5;
        private uc_Table uc_Table6;
    }
}

