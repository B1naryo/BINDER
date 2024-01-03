using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;

namespace Binder
{
    static class Program
    {
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string path = Path.Combine(Path.GetTempPath(), "file1.exe");
            File.WriteAllBytes(path, Binder.Properties.Resources.file1);

            string path = Path.Combine(Path.GetTempPath(), "file2.exe");
            File.WriteAllBytes(path, Binder.Properties.Resources.file2);
                
            
            System.Diagnostics.Process.Start(path);
            System.Diagnostics.Process.Start(pat);

        }
    }
}
