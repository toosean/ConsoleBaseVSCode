using NStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Terminal.Gui;

namespace ConsoleBaseVSCode
{
    public class MainWindow : Window
    {
        public string CurrentFile { get; set; }
        public TextView TextView { get; set; }

        public MainWindow() : base("Untitled-1")
        {
            X = 18+12-2;
            Y = 1;
            Width = Dim.Fill();
            Height = Dim.Fill();

            TextView = new TextView();
            TextView.Width = Dim.Fill();
            TextView.Height = Dim.Fill();
            TextView.Text = string.Empty;
            Add(TextView);
        }

        public void NewFile()
        {
            CurrentFile = null;
            TextView.Text = string.Empty;
            Title = "Untitled-1";
        }

        public void OpenFile(ustring file)
        {
            if (!System.IO.File.Exists(file.ToString()))
            {
                Application.Run(new AlertDialog("Alert","File not exists."));
            }
            else
            {
                var fileInfo = new FileInfo(file.ToString());
                CurrentFile = file.ToString();
                TextView.Text = System.IO.File.ReadAllText(CurrentFile);
                Title = fileInfo.Name;
            }
        }

    }
}
