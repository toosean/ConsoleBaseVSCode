using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;

namespace ConsoleBaseVSCode
{
    public class AppTopLevel : Toplevel
    {
        public MainWindow MainWindow { get; set; }
        public TreeWindow TreeWindow { get; set; }

        public AppTopLevel()
        {
            Console.Title = "Visual Studio Code";

            MainWindow = new MainWindow();
            TreeWindow = new TreeWindow();

            Add(new MainMenu(this));
            Add(new IconWindow());
            Add(TreeWindow);
            Add(MainWindow);
            
        }
    }
}
