// laploy course C# programming language
/*
A try statement can contain more than one catch block. 
The first catch statement that can handle the exception is executed; 
any following catch statements, even if they are compatible, are ignored. 
Therefore, catch blocks should always be ordered from most specific 
(or most-derived) to least specific. For example:
*/

using System;
using System.IO;

namespace _00110_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sw = new StreamWriter(@"C:\test\test.txt"))
                {
                    sw.WriteLine("Hello");
                }
            }
            // Put the more specific exceptions first.
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            // Put the least specific exception last.
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Done");
        }
    }
}

/*
System.IO.DirectoryNotFoundException: Could not find a part of the path 'C:\test\test.txt'.
   at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
   at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
   at System.IO.StreamWriter.CreateFile(String path, Boolean append, Boolean checkHost)
   at System.IO.StreamWriter..ctor(String path, Boolean append, Encoding encoding, Int32 bufferSize, Boolean checkHost)
   at System.IO.StreamWriter..ctor(String path)
   at _00110_Exception.Program.Main(String[] args) in D:\00110 Examples\00110 Exception\Program.cs:line 21
Done
 */
