using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_cellSimulatorV1._1.formSizeClasses
{
    public class FormSizeOperation
    {
        public static void formCloseClick(Form1 form)
        {
            form.Close();
        }

        public static void formResizeClick(Form1 form) 
        {
            if(form.WindowState == FormWindowState.Maximized) 
            {
                form.WindowState = FormWindowState.Normal;
                //form.Location = new Point(100, 50);
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        public static void formMinimize(Form1 form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
