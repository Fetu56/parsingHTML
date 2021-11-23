
namespace HtmlPar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelZone = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tempLarge = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZone.Location = new System.Drawing.Point(13, 9);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(65, 28);
            this.labelZone.TabIndex = 0;
            this.labelZone.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(13, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 20);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label1";
            // 
            // tempLarge
            // 
            this.tempLarge.AutoSize = true;
            this.tempLarge.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempLarge.Location = new System.Drawing.Point(13, 93);
            this.tempLarge.Name = "tempLarge";
            this.tempLarge.Size = new System.Drawing.Size(71, 30);
            this.tempLarge.TabIndex = 2;
            this.tempLarge.Text = "label1";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelState.Location = new System.Drawing.Point(158, 93);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 19);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "label1";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(13, 156);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(38, 15);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "label1";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(219, 317);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCity.TabIndex = 6;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 347);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.tempLarge);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelZone);
            this.Name = "Form1";
            this.Text = "Погода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label tempLarge;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboBoxCity;
    }
}

