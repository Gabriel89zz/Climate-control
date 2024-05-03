namespace Climate_control
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
            lblTemperature = new Label();
            txtTemperature = new TextBox();
            btnSaveTemperature = new Button();
            btnAverageTemp = new Button();
            btnEmpty = new Button();
            SuspendLayout();
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperature.Location = new Point(102, 37);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(309, 28);
            lblTemperature.TabIndex = 0;
            lblTemperature.Text = "Record today's temperature";
            // 
            // txtTemperature
            // 
            txtTemperature.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTemperature.Location = new Point(196, 91);
            txtTemperature.Multiline = true;
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(100, 42);
            txtTemperature.TabIndex = 1;
            // 
            // btnSaveTemperature
            // 
            btnSaveTemperature.Location = new Point(314, 96);
            btnSaveTemperature.Name = "btnSaveTemperature";
            btnSaveTemperature.Size = new Size(80, 32);
            btnSaveTemperature.TabIndex = 2;
            btnSaveTemperature.Text = "Save";
            btnSaveTemperature.UseVisualStyleBackColor = true;
            btnSaveTemperature.Click += btnSaveTemperature_Click;
            // 
            // btnAverageTemp
            // 
            btnAverageTemp.Location = new Point(49, 175);
            btnAverageTemp.Name = "btnAverageTemp";
            btnAverageTemp.Size = new Size(109, 32);
            btnAverageTemp.TabIndex = 3;
            btnAverageTemp.Text = "Show Average";
            btnAverageTemp.UseVisualStyleBackColor = true;
            btnAverageTemp.Click += btnAverageTemp_Click;
            // 
            // btnEmpty
            // 
            btnEmpty.Location = new Point(49, 233);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Size = new Size(109, 45);
            btnEmpty.TabIndex = 4;
            btnEmpty.Text = "Empty Temperatures";
            btnEmpty.UseVisualStyleBackColor = true;
            btnEmpty.Click += btnEmpty_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 332);
            Controls.Add(btnEmpty);
            Controls.Add(btnAverageTemp);
            Controls.Add(btnSaveTemperature);
            Controls.Add(txtTemperature);
            Controls.Add(lblTemperature);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperature;
        private TextBox txtTemperature;
        private Button btnSaveTemperature;
        private Button btnAverageTemp;
        private Button btnEmpty;
    }
}
