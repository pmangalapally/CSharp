using System;
using System.IO.Compression;
using System.IO;
namespace CustomFileCompression
{


    class Program
    {
        static void Main(string[] args)
        {
            /*if (args.Length == 0)
            {
                Console.WriteLine("No arguments found");
            }
            else
            {
                var srcPath = args[0];
                if (!Directory.Exists(srcPath))
                {
                    Console.WriteLine($"Argument {srcPath} is not a directory");
                }
                else
                {*/
                    CompressFiles cf = new CompressFiles();


                    var SourcePath = "/Users/pavan/Desktop/GitHub/CSharp/CustomFileCompression/Input";
                    var DestinationPath = "/Users/pavan/Desktop/GitHub/CSharp/CustomFileCompression/Output";
                    double AgeOfFile = 60;

                    if (Directory.Exists(SourcePath) && Directory.Exists(DestinationPath))
                    {
                        cf.moveCompressedFiles(SourcePath, DestinationPath, AgeOfFile);
                    }

              //  }
            //}
        }
    }
}


