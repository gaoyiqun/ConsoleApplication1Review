using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lesson15
{
    class Program
    {
        /**
        static void Main(string[] args)
        {
            try
            {
                File.OpenRead("NonExistentFile");
            }
            catch(FileNotFoundException fnfex)
            {
                Console.WriteLine(fnfex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            
            Console.ReadLine();
        }
        **/

        //An exception can leave your program in an inconsistent state 
        //by not releasing resources or doing some other type of cleanup.
        //Sometimes you need to perform clean up actions whether or not your program succeeds. 
        //These situations are good candidates for using a finally block.

        static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;

            try
            {
                outStream = File.OpenWrite("DestinationFile.txt");
                inStream = File.OpenRead("BogusInputFile.txt");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("outStream closed.");
                }
                if (inStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("inStream closed.");
                }

            }

            Console.ReadLine();
        }
    }
}
