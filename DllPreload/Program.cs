using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DllPreload
{
  static class Program
  {
    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetDllDirectory(string lpPathName);

    /// <summary>
    /// Here is the main entry point of the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

      SetDllDirectory("");

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }

}
