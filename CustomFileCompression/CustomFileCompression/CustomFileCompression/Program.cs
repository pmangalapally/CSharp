using System;
using System.IO;
using CustomFileCompression.CustomConfiguration;
using System.Configuration;

namespace CustomFileCompression
{


    class Program
    {
        static void Main(string[] args)
        {

            CompressFiles cf = new ();

            // Get the custom Configuration Section using its name
            var customConfig = (DirMapConfig)ConfigurationManager.GetSection("DirectoryConfiguration");

            // Loop through each instance in the CustomConfigurationCollection
            foreach (CustomConfigurationElement DirectoryMappingInstance in customConfig.DirectoryMapping)
            {

                string SourcePath = DirectoryMappingInstance.SourceDirname;
                string DestinationPath = DirectoryMappingInstance.DestinationDirname;
                double AgeOfFile = Convert.ToDouble(DirectoryMappingInstance.FileStabilityTimeInSeconds);

                if (Directory.Exists(SourcePath) && Directory.Exists(DestinationPath))
                {
                    cf.MoveCompressedFiles(SourcePath, DestinationPath, AgeOfFile);
                    Console.WriteLine("Files moved");
                }
                else { Console.WriteLine("No dir found!"); }

            }

            // Prevent the Console from closing immediately afterwards
            //Console.ReadKey();

        }
    }
}