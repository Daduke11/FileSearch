//-----------------------------------------------------------------------
// <copyright file="SearchGUI.Designer.cs" company="">
//     Copyright (c) John Sijs. All rights reserved.
// </copyright>
// <author>John Sijs</author>
//-----------------------------------------------------------------------

namespace Lab_3
{
    /// <summary>
    /// Partial SearchGUI class
    /// </summary>
    partial class SearchGUI
    {
        ///// <summary>
        ///// Required designer variable.
        ///// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGUI));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.myProgress = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.lblCurrentDirectory = new System.Windows.Forms.Label();
            this.textBoxCurDir = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //// 
            //// contextMenuStrip1
            //// 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 30);
            //// 
            //// toolStripMenuItem1
            //// 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            //// 
            //// menuStrip1
            //// 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            //// 
            //// menuToolStripMenuItem
            //// 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            //// 
            //// exitToolStripMenuItem
            //// 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //// 
            //// helpToolStripMenuItem
            //// 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            //// 
            //// aboutToolStripMenuItem
            //// 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            //// 
            //// lblInput
            //// 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(244, 60);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(165, 17);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Search for a file pattern: ";
            //// 
            //// textBoxInput
            //// 
            this.textBoxInput.Location = new System.Drawing.Point(202, 91);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(231, 22);
            this.textBoxInput.TabIndex = 3;
            //// 
            //// btnStart
            //// 
            this.btnStart.Location = new System.Drawing.Point(277, 132);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            //// 
            //// myProgress
            //// 
            this.myProgress.Location = new System.Drawing.Point(78, 191);
            this.myProgress.Name = "myProgress";
            this.myProgress.Size = new System.Drawing.Size(465, 23);
            this.myProgress.TabIndex = 5;
            this.myProgress.Visible = false;
            //// 
            //// btnCancel
            //// 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(277, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //// 
            //// textBoxResult
            //// 
            this.textBoxResult.Location = new System.Drawing.Point(12, 220);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(600, 180);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.Visible = false;
            //// 
            //// lblCurrentDirectory
            //// 
            this.lblCurrentDirectory.AutoSize = true;
            this.lblCurrentDirectory.Location = new System.Drawing.Point(75, 169);
            this.lblCurrentDirectory.Name = "lblCurrentDirectory";
            this.lblCurrentDirectory.Size = new System.Drawing.Size(116, 17);
            this.lblCurrentDirectory.TabIndex = 8;
            this.lblCurrentDirectory.Text = "Current Directory";
            this.lblCurrentDirectory.Visible = false;
            //// 
            //// textBoxCurDir
            //// 
            this.textBoxCurDir.Location = new System.Drawing.Point(188, 166);
            this.textBoxCurDir.Name = "textBoxCurDir";
            this.textBoxCurDir.Size = new System.Drawing.Size(355, 22);
            this.textBoxCurDir.TabIndex = 9;
            this.textBoxCurDir.Visible = false;
            //// 
            //// SearchGUI
            //// 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.textBoxCurDir);
            this.Controls.Add(this.lblCurrentDirectory);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.myProgress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchGUI";
            this.Text = "Lab 3";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar myProgress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label lblCurrentDirectory;
        private System.Windows.Forms.TextBox textBoxCurDir;
    }
}