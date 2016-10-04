//-----------------------------------------------------------------------
// <copyright file="SearchGUI.cs" company="JJS Computers Ltd">
//     Copyright (c) JJS Computers Ltd. All rights reserved.
// </copyright>
// <author>John Sijs</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Lab_3
{
    /// <summary>
    /// SearchGUI class
    /// </summary>
    public partial class SearchGUI : Form
    {
        public event Action<string> StartOp;
        public event Action StopOp;

        /// <summary>
        /// SearchGUI constructor
        /// </summary>
        public SearchGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// exitToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// call stopOP
            //// cancel thread
            if (StopOp != null)
            {
                StopOp();
            }

            UpdateCursor(false);
            //// wait for thread to complete 
            //// task is usually better idia 
            //// try a join on the thread 
            //// implement a timeout or just call thread join 
            Close();
        }

        /// <summary>
        /// btnStart_Click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
     
            if (StartOp != null)
            {
                btnCancel.Visible = true;
                myProgress.Visible = true;
                
                textBoxResult.Visible = true;
                lblCurrentDirectory.Visible = true;
                textBoxCurDir.Visible = true;
                UpdateCursor(true);
                StartOp(input);
            }
        }

        /// <summary>
        /// btnCancel_Click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
           //// cancel thread
           if (StopOp != null)
            {
                StopOp();
            }

            UpdateCursor(false);
        }

        /// <summary>
        /// UpdateProgress
        /// </summary>
        /// <param name="i">i</param>
        public void UpdateProgress(int i)
        {
            myProgress.Value = i;
        }

        /// <summary>
        /// UpdateResult
        /// </summary>
        /// <param name="update">updateparam>
        public void UpdateResult(string update)
        {
            textBoxResult.AppendText(update + "\n");
        }

        /// <summary>
        /// UpdateCursor
        /// </summary>
        /// <param name="wait">wait</param>
        public void UpdateCursor(bool wait)
        {
            if (wait)
            {
                this.Cursor = Cursors.WaitCursor;
            }
            else { this.Cursor = Cursors.Default; }
        }

        /// <summary>
        /// UpdateCurrentDirectory
        /// </summary>
        /// <param name="currDir">currDir</param>
        public void UpdateCurrentDirectory(string currDir)
        {
            textBoxCurDir.Text = currDir;
        }

    }
}