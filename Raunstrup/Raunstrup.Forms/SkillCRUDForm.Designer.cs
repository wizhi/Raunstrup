﻿namespace Raunstrup.Forms
{
    partial class SkillCRUDForm
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
            this._saveSkillButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._skillNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _saveSkillButton
            // 
            this._saveSkillButton.Location = new System.Drawing.Point(98, 36);
            this._saveSkillButton.Name = "_saveSkillButton";
            this._saveSkillButton.Size = new System.Drawing.Size(75, 23);
            this._saveSkillButton.TabIndex = 0;
            this._saveSkillButton.Text = "Gem";
            this._saveSkillButton.UseVisualStyleBackColor = true;
            this._saveSkillButton.Click += new System.EventHandler(this._saveSkillButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speciale: ";
            // 
            // _skillNameTextBox
            // 
            this._skillNameTextBox.Location = new System.Drawing.Point(73, 10);
            this._skillNameTextBox.Name = "_skillNameTextBox";
            this._skillNameTextBox.Size = new System.Drawing.Size(100, 20);
            this._skillNameTextBox.TabIndex = 2;
            // 
            // SkillCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 68);
            this.Controls.Add(this._skillNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._saveSkillButton);
            this.Name = "SkillCRUDForm";
            this.Text = "Speciale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _saveSkillButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _skillNameTextBox;
    }
}