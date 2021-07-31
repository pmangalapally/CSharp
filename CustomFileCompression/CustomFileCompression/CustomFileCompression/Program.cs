using System;
using System.IO.Compression;
using System.IO;
namespace CustomFileCompression
{


    class Program
    {
        static void Main(string[] args)
        {

                    CompressFiles cf = new CompressFiles();


                    var SourcePath = "/Users/pavan/Desktop/GitHub/CSharp/CustomFileCompression/Input";
                    var DestinationPath = "/Users/pavan/Desktop/GitHub/CSharp/CustomFileCompression/Output";
              double AgeOfFile = 60;

            if (Directory.Exists(SourcePath) && Directory.Exists(DestinationPath))
            {
                cf.MoveCompressedFiles(SourcePath, DestinationPath, AgeOfFile);
                Console.WriteLine("Files moved");
            }
            else { Console.WriteLine("No dir found!"); }
        }
    }
}