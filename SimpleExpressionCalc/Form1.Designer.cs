namespace SimpleExpressionCalc
{
    partial class Программа
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputX = new System.Windows.Forms.TextBox();
            this.resultY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(103, 92);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(134, 29);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Введите X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(182, 153);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(55, 29);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y = ";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(168, 217);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(160, 44);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Вычислить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputX
            // 
            this.inputX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputX.Location = new System.Drawing.Point(249, 89);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(129, 34);
            this.inputX.TabIndex = 3;
            // 
            // resultY
            // 
            this.resultY.AutoSize = true;
            this.resultY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultY.Location = new System.Drawing.Point(244, 153);
            this.resultY.Name = "resultY";
            this.resultY.Size = new System.Drawing.Size(0, 29);
            this.resultY.TabIndex = 4;
            // 
            // Программа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 358);
            this.Controls.Add(this.resultY);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "Программа";
            this.Text = "Программа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.Label resultY;
    }
}

