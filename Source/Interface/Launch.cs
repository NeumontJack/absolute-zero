﻿using System;
using System.Windows.Forms;

namespace AbsoluteZero {

    /// <summary>
    /// Handles the application launch. 
    /// </summary>
    static class Launch {

        /// <summary>
        /// The main entry point for the application. 
        /// </summary>
        /// <param name="args">The command-line arugments</param>
        [STAThread]
        public static void Main(String[] args) {

            // Display Log window by default. We will hide it later if necessary. 
            Log.Initialize();

            // Run as GUI application if there are no command-line arguments. Display 
            // the Settings window, which will display the main board window as needed. 
            if (args.Length == 0) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Settings());
            }

            // Run as console application if there are command-line arguments. 
            else {

                // Get the subroutine arguments. 
                String[] subArgs = new String[args.Length - 1];
                Array.Copy(args, 1, subArgs, 0, subArgs.Length);

                switch (args[0]) {
                    default:
                        Log.WriteLine("Unrecognized command-line parameter. Valid parameters are:");
                        Log.WriteLine("-u    UCI/command-line mode");
                        Log.WriteLine("-t    Tournament mode");
                        Log.WriteLine("-s    Test suite mode");
                        Log.WriteLine("Press any key to continue . . . ");
                        Console.ReadKey();
                        break;
                    case "-u":
                        Universal.Run();
                        break;
                    case "-t":
                        new Tournament().Start(subArgs);
                        break;
                    case "-s":
                        TestSuite.Run(subArgs);
                        break;
                }
            }
        }
    }
}
