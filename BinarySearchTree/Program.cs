using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Console.WriteLine("Max: " + intTree.FindMax());

            //Console.WriteLine("Min: " + intTree.FindMin());

            //Console.WriteLine("Root: " + intTree.Root.Element);

            //Console.WriteLine("Trace: " + trace);

            //Console.WriteLine("Tree: " + intTree);

            //Console.ReadLine();
        }
    }
}
