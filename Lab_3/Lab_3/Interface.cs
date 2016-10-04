//-----------------------------------------------------------------------
// <copyright file="Interface.cs" company="">
//     Copyright (c) John Sijs. All rights reserved.
// </copyright>
// <author>John Sijs</author>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Lab_3
{
    /// <summary>
    /// Interface class.
    /// </summary>
    static class Interface
    {
        private static SearchGUI myForm;
        private static Search startSearch;

        //// <summary>
        //// The main entry point for the application.
        //// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myForm = new SearchGUI();
            //// start up hooks for Search GUI
            myForm.StartOp += MyForm_StartOp;
            myForm.StopOp += MyForm_StopOp; 
            Application.Run(myForm);
            //// create hook to Complete
        }

        //// Search Class Handlers
        /// <summary>
        /// StartSearch_UpdateProgress
        /// </summary>
        /// <param name="progress">progress</param>
        /// <param name="currentDirectory">currentDirectory</param>
        private static void StartSearch_UpdateProgress(int progress, string currentDirectory)
        {
            myForm.BeginInvoke((Action)(() =>
            {
                myForm.UpdateProgress(progress);
                myForm.UpdateCurrentDirectory(currentDirectory);
            }));
        }

        /// <summary>
        /// StartSearch_UpdateResult
        /// </summary>
        /// <param name="resultFound">resultFound</param>
        private static void StartSearch_UpdateResult(string resultFound)
        {
            myForm.BeginInvoke((Action)(() =>
                myForm.UpdateResult(resultFound)));
        }

        /// <summary>
        /// StartSearch_Complete
        /// </summary>
        private static void StartSearch_Complete()
        {
            myForm.BeginInvoke((Action)(() =>
                myForm.UpdateCursor(false)));
        }

        //// Search GUI Handlers
        /// <summary>
        /// MyForm_StopOp
        /// </summary>
        private static void MyForm_StopOp()
        {
            startSearch.StopOP();
        }

        /// <summary>
        /// MyForm_StartOp
        /// </summary>
        /// <param name="inputSearch">inputSearch</param>
        private static void MyForm_StartOp(string inputSearch)
        {
            startSearch = new Search(inputSearch);
            //// Startup hooks for Search Class
            startSearch.Complete += StartSearch_Complete;
            startSearch.UpdateResult += StartSearch_UpdateResult;
            startSearch.UpdateProgress += StartSearch_UpdateProgress;
            startSearch.StartOp();
        }
    }
}