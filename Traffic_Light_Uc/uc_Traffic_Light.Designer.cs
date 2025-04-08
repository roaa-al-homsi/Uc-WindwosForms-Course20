namespace Traffic_Light_Uc
{
    partial class uc_Traffic_Light
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Traffic_Light));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labTimer = new System.Windows.Forms.Label();
            this.picTaffic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTaffic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTimer
            // 
            this.labTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimer.ForeColor = System.Drawing.Color.Maroon;
            this.labTimer.Location = new System.Drawing.Point(45, 273);
            this.labTimer.Name = "labTimer";
            this.labTimer.Size = new System.Drawing.Size(122, 42);
            this.labTimer.TabIndex = 3;
            this.labTimer.Text = "label1";
            // 
            // picTaffic
            // 
            this.picTaffic.Image = ((System.Drawing.Image)(resources.GetObject("picTaffic.Image")));
            this.picTaffic.Location = new System.Drawing.Point(32, 13);
            this.picTaffic.Name = "picTaffic";
            this.picTaffic.Size = new System.Drawing.Size(158, 257);
            this.picTaffic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTaffic.TabIndex = 2;
            this.picTaffic.TabStop = false;
            // 
            // uc_Traffic_Light
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labTimer);
            this.Controls.Add(this.picTaffic);
            this.Name = "uc_Traffic_Light";
            this.Size = new System.Drawing.Size(241, 346);
            ((System.ComponentModel.ISupportInitialize)(this.picTaffic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labTimer;
        private System.Windows.Forms.PictureBox picTaffic;
    }
}
