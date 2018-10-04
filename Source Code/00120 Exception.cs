// laploy course C# programming language
/*
 * Test Finally
 * 
Before the catch block is executed, the runtime checks for finally blocks. 
Finally blocks enable the programmer to clean up any ambiguous state that 
could be left over from an aborted try block, or to release any external resources 
(such as graphics handles, database connections or file streams) 
without waiting for the garbage collector in the runtime to finalize the objects.
*/

namespace _00120_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileStream file = null;
            //Change the path to something that works on your machine.
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(@"C:\file.txt");

            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
                if (file != null)
                {
                    file.Close();
                }
            }

            try
            {
                file = fileInfo.OpenWrite();
                System.Console.WriteLine("OpenWrite() succeeded");
            }
            catch (System.IO.IOException)
            {
                System.Console.WriteLine("OpenWrite() failed");
            }
        }
    }
}

/*
Unhandled Exception: System.UnauthorizedAccessException: Access to the path 'C:\file.txt' is denied.
   at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
   at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share)
   at System.IO.FileInfo.OpenWrite()
   at _00120_Exception.Program.Main(String[] args) in D:\\00110 Examples\00120 Exception\Program.cs:line 30
 */
