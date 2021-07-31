using System;
using System.IO.Compression;
using System.IO;
namespace CustomFileCompression
{


    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
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
                {
                    string [] fileNamesinDir = Directory.GetFiles(srcPath, "*.txt");
                    foreach(string filename in fileNamesinDir)
                    {
                        string JustFileName = Path.GetFileName(filename);
                        Console.WriteLine($"File name {filename}");
                        string newFileName = filename + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".zip";
                        string tempDir = Path.Combine(srcPath, "tempdirectory");
                        string MoveFileName = Path.Combine(tempDir, JustFileName);
                        if (Directory.Exists(tempDir))
                        {
                            Directory.Delete(tempDir);
                        }
                        Console.WriteLine($"Directory deleted");

                        Directory.CreateDirectory(tempDir);
                        File.Move(filename, MoveFileName);
                        ZipFile.CreateFromDirectory(tempDir, newFileName);
                        
                        if (File.Exists(MoveFileName))
                        {
                            File.Delete(MoveFileName);
                        }
                        if (Directory.Exists(tempDir))
                        {
                            Directory.Delete(tempDir);
                        }

                    }

                }
            }
        }
    }
}


