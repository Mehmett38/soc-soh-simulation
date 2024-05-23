namespace _001_cellSimulatorV1._1
{
    partial class BatteryConfig
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSoh = new System.Windows.Forms.TextBox();
            this.Voltage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDownDod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUpDod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidtdrawnCurrent = new System.Windows.Forms.TextBox();
            this.textBoxVoltage = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(86, 340);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 28);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSoh
            // 
            this.textBoxSoh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoh.Location = new System.Drawing.Point(142, 235);
            this.textBoxSoh.Name = "textBoxSoh";
            this.textBoxSoh.Size = new System.Drawing.Size(133, 22);
            this.textBoxSoh.TabIndex = 14;
            this.textBoxSoh.Text = "100";
            // 
            // Voltage
            // 
            this.Voltage.AutoSize = true;
            this.Voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Voltage.Location = new System.Drawing.Point(28, 238);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(36, 16);
            this.Voltage.TabIndex = 9;
            this.Voltage.Text = "SOH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Battery Voltage";
            // 
            // textBoxDownDod
            // 
            this.textBoxDownDod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDownDod.Location = new System.Drawing.Point(142, 179);
            this.textBoxDownDod.Name = "textBoxDownDod";
            this.textBoxDownDod.Size = new System.Drawing.Size(133, 22);
            this.textBoxDownDod.TabIndex = 13;
            this.textBoxDownDod.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Down DOD Ratio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_001_cellSimulatorV1._1.Properties.Resources.moli;
            this.pictureBox1.Location = new System.Drawing.Point(86, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Up DOD Ratio";
            // 
            // textBoxUpDod
            // 
            this.textBoxUpDod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUpDod.Location = new System.Drawing.Point(142, 207);
            this.textBoxUpDod.Name = "textBoxUpDod";
            this.textBoxUpDod.Size = new System.Drawing.Size(133, 22);
            this.textBoxUpDod.TabIndex = 13;
            this.textBoxUpDod.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max Widtdrawn \r\nCurrent (mAh)";
            // 
            // textBoxWidtdrawnCurrent
            // 
            this.textBoxWidtdrawnCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxWidtdrawnCurrent.Location = new System.Drawing.Point(142, 289);
            this.textBoxWidtdrawnCurrent.Name = "textBoxWidtdrawnCurrent";
            this.textBoxWidtdrawnCurrent.Size = new System.Drawing.Size(133, 22);
            this.textBoxWidtdrawnCurrent.TabIndex = 14;
            this.textBoxWidtdrawnCurrent.Text = "50000";
            // 
            // textBoxVoltage
            // 
            this.textBoxVoltage.Location = new System.Drawing.Point(142, 263);
            this.textBoxVoltage.Mask = "0.00";
            this.textBoxVoltage.Name = "textBoxVoltage";
            this.textBoxVoltage.Size = new System.Drawing.Size(133, 20);
            this.textBoxVoltage.TabIndex = 16;
            // 
            // BatteryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 378);
            this.Controls.Add(this.textBoxVoltage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxWidtdrawnCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSoh);
            this.Controls.Add(this.Voltage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUpDod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDownDod);
            this.Controls.Add(this.label3);
            this.Name = "BatteryConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatteryConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSoh;
        private System.Windows.Forms.Label Voltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDownDod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUpDod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidtdrawnCurrent;
        private System.Windows.Forms.MaskedTextBox textBoxVoltage;
    }
}