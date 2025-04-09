namespace Pool_Club
{
    partial class uc_Table
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Table));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labPlayerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labTimeTable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labPlayerName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labTimeTable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbNameTable);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 253);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // labPlayerName
            // 
            this.labPlayerName.Location = new System.Drawing.Point(374, 184);
            this.labPlayerName.Name = "labPlayerName";
            this.labPlayerName.Size = new System.Drawing.Size(114, 23);
            this.labPlayerName.TabIndex = 8;
            this.labPlayerName.Text = " ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Player\'s Name : ";
            // 
            // labTimeTable
            // 
            this.labTimeTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimeTable.Location = new System.Drawing.Point(425, 88);
            this.labTimeTable.Name = "labTimeTable";
            this.labTimeTable.Size = new System.Drawing.Size(120, 24);
            this.labTimeTable.TabIndex = 6;
            this.labTimeTable.Text = "00:00";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time:";
            // 
            // lbNameTable
            // 
            this.lbNameTable.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.ForeColor = System.Drawing.Color.Olive;
            this.lbNameTable.Location = new System.Drawing.Point(358, 35);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(145, 30);
            this.lbNameTable.TabIndex = 4;
            this.lbNameTable.Text = "Table Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(218, 153);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(118, 54);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(218, 88);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(118, 54);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(218, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // uc_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_Table";
            this.Size = new System.Drawing.Size(566, 261);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labPlayerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labTimeTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNameTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
    }
}
