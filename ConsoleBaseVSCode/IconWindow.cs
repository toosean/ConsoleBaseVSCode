using NStack;
using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;

namespace ConsoleBaseVSCode
{
    internal class IconWindow : Window
    {
        public IconWindow() : base(null)
        {
            X = 0;
            Y = 1;
            Width = 12;
            Height = Dim.Fill();

            Add(new Button("Expl") { Y = 0 } );
            Add(new Button("Search") { Y = 1 });
            Add(new Button("Source") { Y = 2 });
            Add(new Button("Run") { Y = 3 });
            Add(new Button("Extens") { Y = 4 });
            Add(new Button("Test") { Y = 5 });
        }
    }
}
