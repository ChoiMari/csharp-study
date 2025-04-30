namespace WindowsFormsApp_05_user_input_practice
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.trueButton = new System.Windows.Forms.RadioButton();
            this.falseButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(30, 30);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(194, 25);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_result.Location = new System.Drawing.Point(30, 104);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(321, 188);
            this.textBox_result.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_input.Location = new System.Drawing.Point(254, 30);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(97, 60);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // trueButton
            // 
            this.trueButton.AutoSize = true;
            this.trueButton.Location = new System.Drawing.Point(30, 71);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(56, 19);
            this.trueButton.TabIndex = 3;
            this.trueButton.TabStop = true;
            this.trueButton.Text = "True";
            this.trueButton.UseVisualStyleBackColor = true;
            // 
            // falseButton
            // 
            this.falseButton.AutoSize = true;
            this.falseButton.Location = new System.Drawing.Point(102, 71);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(63, 19);
            this.falseButton.TabIndex = 3;
            this.falseButton.TabStop = true;
            this.falseButton.Text = "False";
            this.falseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 319);
            this.Controls.Add(this.falseButton);
            this.Controls.Add(this.trueButton);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.RadioButton trueButton;
        private System.Windows.Forms.RadioButton falseButton;
    }
}

