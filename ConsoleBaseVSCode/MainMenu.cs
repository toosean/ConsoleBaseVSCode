using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;

namespace ConsoleBaseVSCode
{
    class MainMenu : MenuBar
    {
        public AppTopLevel AppTopLevel { get; }

        public void New()
        {
            AppTopLevel.MainWindow.NewFile();
        }

        public void Open()
        {

            var fileDialog = new OpenDialog("Open File", "Open File");
            Application.Run(fileDialog);

            if (!fileDialog.Canceled)
            {
                var file = fileDialog.FilePath;
                AppTopLevel.MainWindow.OpenFile(file);
                AppTopLevel.TreeWindow.OpenFile(file);
            }
        }

        public MenuBarItem[] Init()
        {
            return new MenuBarItem[]{
                new MenuBarItem("_File",new MenuItem[]
                {
                    new MenuItem("_New File","Ctrl + N",New) { ShortCut = Key.ControlN } ,
                    new MenuItem("_Open File...","Ctrl + O",Open){ ShortCut = Key.ControlO },
                    new MenuItem("_Save","Ctrl + S",null){ ShortCut = Key.ControlS},
                    new MenuItem("Save _As...",null,null),
                    new MenuItem("_Close",null,null),
                    new MenuItem("_Exit",null,null),
                }),
                new MenuBarItem("_Edit",new MenuItem[]
                {
                    new MenuItem("Undo","Ctrl + Z",null) { ShortCut = Key.ControlZ } ,
                    new MenuItem("Redo","Ctrl + Y",null){ ShortCut = Key.ControlY },
                    new MenuItem("Cut","Ctrl + X",null){ ShortCut = Key.ControlX},
                    new MenuItem("Copy","Ctrl + C",null){ ShortCut = Key.ControlC},
                    new MenuItem("Paste","Ctrl + V",null){ ShortCut = Key.ControlV},
                    new MenuItem("Find...","Ctrl + F",null){ ShortCut = Key.ControlF},
                    new MenuItem("Replace...","Ctrl + H",null){ ShortCut = Key.ControlH},
                }),
                new MenuBarItem("_Selection",new MenuItem[0]),
                new MenuBarItem("_View",new MenuItem[0]),
                new MenuBarItem("_Go",new MenuItem[0]),
                new MenuBarItem("_Run",new MenuItem[0]),
                new MenuBarItem("_Terminal",new MenuItem[0]),
                new MenuBarItem("_Help",new MenuItem[0]),
            };
        }

        public MainMenu(AppTopLevel appTopLevel) : base(new MenuBarItem[0])
        {
            AppTopLevel = appTopLevel ?? throw new ArgumentNullException(nameof(appTopLevel));

            Menus = Init();
        }
    }
}
