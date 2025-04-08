namespace Traffic_Light_Uc
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
            this.uc_Traffic_Light1 = new Traffic_Light_Uc.uc_Traffic_Light();
            this.SuspendLayout();
            // 
            // uc_Traffic_Light1
            // 
            this.uc_Traffic_Light1.GreenTime = 3;
            this.uc_Traffic_Light1.Location = new System.Drawing.Point(0, 0);
            this.uc_Traffic_Light1.Name = "uc_Traffic_Light1";
            this.uc_Traffic_Light1.OrangeTime = 5;
            this.uc_Traffic_Light1.RedTime = 7;
            this.uc_Traffic_Light1.Size = new System.Drawing.Size(241, 346);
            this.uc_Traffic_Light1.TabIndex = 0;
            this.uc_Traffic_Light1.CurrentLight = Traffic_Light_Uc.uc_Traffic_Light.enTrafficColours.Red;
            this.uc_Traffic_Light1.OnRed += new System.EventHandler<Traffic_Light_Uc.TrafficLightEventArgs>(this.uc_Traffic_Light1_OnRed);
            this.uc_Traffic_Light1.OnOrange += new System.EventHandler<Traffic_Light_Uc.TrafficLightEventArgs>(this.uc_Traffic_Light1_OnOrange);
            this.uc_Traffic_Light1.OnGreen += new System.EventHandler<Traffic_Light_Uc.TrafficLightEventArgs>(this.uc_Traffic_Light1_OnGreen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uc_Traffic_Light1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uc_Traffic_Light uc_Traffic_Light1;
    }
}

