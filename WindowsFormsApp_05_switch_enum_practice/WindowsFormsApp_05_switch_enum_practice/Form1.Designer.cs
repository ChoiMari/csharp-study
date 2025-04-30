namespace WindowsFormsApp_05_switch_enum_practice
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_click = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_input.Location = new System.Drawing.Point(53, 48);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(172, 36);
            this.textBox_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "요일 입력 :";
            // 
            // button_click
            // 
            this.button_click.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_click.Location = new System.Drawing.Point(277, 48);
            this.button_click.Name = "button_click";
            this.button_click.Size = new System.Drawing.Size(127, 38);
            this.button_click.TabIndex = 2;
            this.button_click.Text = "Click";
            this.button_click.UseVisualStyleBackColor = true;
            this.button_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(53, 103);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(351, 87);
            this.textBox_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 212);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_click;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

