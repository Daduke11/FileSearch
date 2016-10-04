//-----------------------------------------------------------------------
// <copyright file="Search.cs" company="">
//     Copyright (c) John Sijs. All rights reserved.
// </copyright>
// <author>John Sijs</author>
//-----------------------------------------------------------------------

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Lab_3
{
    /// <summary>
    /// Search Class
    /// </summary>
    public class Search
    {
        private string input;
        //// Volatile is used as hint to the compiler that this data
        //// member will be accessed by multiple threads.
        public volatile bool _shouldStop;
        private Thread t;
        private double progress = 0;
        private string currentDir;
        System.Timers.Timer timer;

        public event Action<int, string> UpdateProgress;
        public event Action<string> UpdateResult;
        public event Action Complete;

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="input">input</param>
        public Search(string input)
        {
            this.input = input;
        }

        /// <summary>
        /// StartOp
        /// </summary>
        public void StartOp()
        {
            //// Application.Run will return when the form is closed 
            //// message pump quits when form is closed
            t = new Thread(this.Callback)
            {
                Name = "StartOperation"
            };
            this.t.Start();
            //// t.IsBackground = true;
            timer = new System.Timers.Timer(100);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        /// <summary>
        /// Timer_Elapsed
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.UpdateProgress != null)
            {
                UpdateProgress((int)this.progress, this.currentDir);
            }
        }

        /// <summary>
        /// StopOp
        /// </summary>
        public void StopOP()
        {
            this._shouldStop = true;
            timer.Stop();
            this.t.Join();
        }

        /// <summary>
        /// Callback
        /// </summary>
        private void Callback()
        {
            //// this is now a worker thread
            //// double size;
            //// double i = 0;
            this.progress = 0;

            //// change cursor icon 
            while (!_shouldStop)
            {
                RecurseFind(1, 0, @"C:\Program Files"); // @"C:\flex_sdk_4.6
                break;
            }

            timer.Stop();
            //// change icon back to default
            //// myForm.Invoke((Action)(() => myForm.UpdateCursor(0)));
            if (Complete != null)
            {
                Complete();
            }
        }

        //// https://// support.microsoft.com/en-us/kb/303974

        /// <summary>
        /// RecurseFind function
        /// </summary>
        /// <param name="weight">weight</param>
        /// <param name="prog">prog</param>
        /// <param name="path">path</param>
        private void RecurseFind(double weight, double prog, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                for (int j = 0; j < dirs.Length; j++)
                {
                    currentDir = dirs[j];
                    string[] paths = Directory.GetFiles(dirs[j], input);
                    for (int i = 0; i < paths.Length; i++)
                    {
                        if (UpdateResult != null)
                        {
                            UpdateResult(paths[i]);
                        }
                    }
                    double weightUpdate = (weight / dirs.Length);
                    double updateProg = prog +( (j * weight)) / dirs.Length;
                    //RecurseFind(weight / paths.Length, (prog + (i * weight)) / paths.Length, dirs[i]);

                    if (this.UpdateProgress != null)
                    {
                        UpdateProgress((int)this.progress, this.currentDir);
                    }
                    RecurseFind(weightUpdate, updateProg, dirs[j]);
                }
            }
            catch (System.UnauthorizedAccessException)
            { }
            catch (System.Exception e)
            {
                //// need to update and swallow exception
                MessageBox.Show("The process failed: " + e.ToString(), "Search Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DirSearch - old Recursive directory search function
        /// </summary>
        /// <param name="sDir">sDir</param>
        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    //// display current directory
                    currentDir = d;
                    Thread.Sleep(50);
                    //// scan for files from seach parameter input
                    foreach (string f in Directory.GetFiles(d, input))
                    {
                        //// add results to text box
                        if (UpdateResult != null)
                        {
                            UpdateResult(f);
                        }
                    }
                    DirSearch(d);
                }
            }
            catch (System.UnauthorizedAccessException)
            { }
            catch (System.Exception e)
            {
                //// need to update and swallow exception
                MessageBox.Show("The process failed: " + e.ToString(), "Search Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}