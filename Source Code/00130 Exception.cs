// laploy course C# programming language

/*
 * How to: Execute Cleanup Code Using finally
 * 
The purpose of a finally statement is to ensure that the necessary cleanup of objects, 
usually objects that are holding external resources, occurs immediately, 
even if an exception is thrown. 

One example of such cleanup is calling Close on a FileStream immediately after use 
instead of waiting for the object to be garbage collected by the common language runtime:
*/

namespace _00130_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void CodeWithoutCleanup()
        {
            System.IO.FileStream file = null;
            System.IO.FileInfo fileInfo = new System.IO.FileInfo("C:\\file.txt");

            file = fileInfo.OpenWrite();
            file.WriteByte(0xF);

            file.Close();
        }

        static void CodeWithCleanup()
        {
            /*
            To turn the previous code into a try-catch-finally statement, 
            the cleanup code is separated from the working code, as follows.
            */

            System.IO.FileStream file = null;
            System.IO.FileInfo fileInfo = null;

            try
            {
                fileInfo = new System.IO.FileInfo("C:\\file.txt");

                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch (System.UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}
