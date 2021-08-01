using System;
using System.IO.Compression;
using System.IO;
namespace CustomFileCompression
{
    class CompressFiles
    {
        public CompressFiles()
        {
        }

        static void DeleteDirectory (string directoryPath)
        {
            try
            {
                if(Directory.Exists(directoryPath))
                {
                    Directory.Delete(directoryPath);
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in deleting directory :" + ex.Message);
            }
        }

        static void DeleteFile (string srcFilePath)
        {
            try
            {
                if(File.Exists(srcFilePath))
                {
                    File.Delete(srcFilePath);
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in deleting file :" + ex.Message);
            }
        }

        public void MoveCompressedFiles(string srcPath, string destPath, double fileWaitTime)
        {
            string[] filePathinDir = Directory.GetFiles(srcPath, "*.*");

            foreach (string filePathName in filePathinDir)
            {
                if (((DateTime.Now - File.GetLastAccessTime(filePathName)).TotalSeconds) > fileWaitTime)
                {
                    string srcFileName = Path.GetFileName(filePathName);
                    //Console.WriteLine($"File name {filePathName}");
                    string compressedFileName = srcFileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".zip";
                    string destFileName = Path.Combine(destPath, compressedFileName);
                    string tempDir = Path.Combine(srcPath, "tempdirectory");
                    string MoveFileName = Path.Combine(tempDir, srcFileName);

                    DeleteDirectory(tempDir);
                    //Console.WriteLine($"Directory deleted");

                    Directory.CreateDirectory(tempDir);
                    File.Move(filePathName, MoveFileName);
                    ZipFile.CreateFromDirectory(tempDir, destFileName);

                    DeleteFile(MoveFileName);
                    DeleteDirectory(tempDir);
                }
            }
        }
    }
}