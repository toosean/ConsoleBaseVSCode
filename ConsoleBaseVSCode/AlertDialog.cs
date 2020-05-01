using NStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace ConsoleBaseVSCode
{
    public class AlertDialog : Dialog
    {
        public AlertDialog(ustring title, string message) : base(title, 40, 10, new Button[0])
        {


            Add(new Label(message));

            AddButton(new Button("OK")
            {
                Clicked = Ok
            });
        }

        private void Ok()
        {
            this.Running = false;
        }
    }
}
