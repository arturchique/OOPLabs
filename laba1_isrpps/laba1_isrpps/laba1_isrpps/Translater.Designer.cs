namespace laba1_isrpps
{
    partial class Translater
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SubmitInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(12, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(379, 303);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(409, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(379, 303);
            this.OutputTextBox.TabIndex = 2;
            // 
            // SubmitInputButton
            // 
            this.SubmitInputButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitInputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitInputButton.Location = new System.Drawing.Point(12, 330);
            this.SubmitInputButton.Name = "SubmitInputButton";
            this.SubmitInputButton.Size = new System.Drawing.Size(379, 30);
            this.SubmitInputButton.TabIndex = 3;
            this.SubmitInputButton.Text = "Перевести";
            this.SubmitInputButton.UseVisualStyleBackColor = false;
            this.SubmitInputButton.Click += new System.EventHandler(this.SubmitInputButton_Click);
            // 
            // Translater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitInputButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Name = "Translater";
            this.Text = "Translater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button SubmitInputButton;
    }
}