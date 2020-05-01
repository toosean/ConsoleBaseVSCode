using NStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terminal.Gui;

namespace ConsoleBaseVSCode
{
    public class TreeWindow : Window
    {
        private ListView ListView;

        public TreeWindow() : base("Explorer")
        {
            X = 11;
            Y = 1;
            Width = 18;
            Height = Dim.Fill();

            ListView = new ListView()
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Source = new ListWrapper(new List<string>
                {
                    "NO FOLDER OPENED"
                }),
            };
            Add(ListView);
        }

        public void OpenFile(ustring filePath)
        {
            var fileInfo = new System.IO.FileInfo(filePath.ToString());
            ListView.SetSource(fileInfo.Directory.GetFiles().Select(s => s.Name).ToList());
        }


    }
}
