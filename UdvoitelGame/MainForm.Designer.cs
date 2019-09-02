﻿namespace UdvoitelGame
{
    partial class MainForm
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnMultiply2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.CommandsCounter = new System.Windows.Forms.Label();
            this.btnShowForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VictoryNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(72, 80);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(27, 29);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "0";
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.SystemColors.Info;
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrement.Location = new System.Drawing.Point(200, 31);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(112, 40);
            this.btnIncrement.TabIndex = 1;
            this.btnIncrement.Text = "+1";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnMultiply2
            // 
            this.btnMultiply2.BackColor = System.Drawing.SystemColors.Info;
            this.btnMultiply2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply2.Location = new System.Drawing.Point(200, 91);
            this.btnMultiply2.Name = "btnMultiply2";
            this.btnMultiply2.Size = new System.Drawing.Size(111, 47);
            this.btnMultiply2.TabIndex = 2;
            this.btnMultiply2.Text = "x2";
            this.btnMultiply2.UseVisualStyleBackColor = false;
            this.btnMultiply2.Click += new System.EventHandler(this.btnMultiply2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Info;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(202, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 47);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(168, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 68);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Close App";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CommandsCounter
            // 
            this.CommandsCounter.AutoSize = true;
            this.CommandsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandsCounter.Location = new System.Drawing.Point(431, 80);
            this.CommandsCounter.Name = "CommandsCounter";
            this.CommandsCounter.Size = new System.Drawing.Size(27, 29);
            this.CommandsCounter.TabIndex = 6;
            this.CommandsCounter.Text = "0";
            // 
            // btnShowForm
            // 
            this.btnShowForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowForm.Location = new System.Drawing.Point(168, 231);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(188, 68);
            this.btnShowForm.TabIndex = 4;
            this.btnShowForm.Text = "Menu";
            this.btnShowForm.UseVisualStyleBackColor = false;
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Текущее число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(342, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество ходов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Победное число";
            // 
            // VictoryNumberLabel
            // 
            this.VictoryNumberLabel.AutoSize = true;
            this.VictoryNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VictoryNumberLabel.Location = new System.Drawing.Point(62, 218);
            this.VictoryNumberLabel.Name = "VictoryNumberLabel";
            this.VictoryNumberLabel.Size = new System.Drawing.Size(27, 29);
            this.VictoryNumberLabel.TabIndex = 10;
            this.VictoryNumberLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UdvoitelGame.Properties.Resources.Tetrad_list_2;
            this.ClientSize = new System.Drawing.Size(566, 421);
            this.Controls.Add(this.VictoryNumberLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandsCounter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowForm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply2);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.lblNumber);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnMultiply2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label CommandsCounter;
        private System.Windows.Forms.Button btnShowForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VictoryNumberLabel;
    }
}