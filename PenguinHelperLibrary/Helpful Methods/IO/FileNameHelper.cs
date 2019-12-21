#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: FileNameHelper.cs
// 
// Current Data:
// 2019-12-21 7:22 PM
// 
// Creation Date:
// 2019-12-21 6:30 PM

#endregion

using System.IO;

namespace PenguinHelperLibrary.Helpful_Methods.IO
{
    /// <summary>
    ///     Methods to assist with file creation, management, etc.
    /// </summary>
    public class FileNameHelper
    {
        /// <summary>
        ///     Ensures a filename is unique by generating a unique filename if the specified file already exists.
        ///     If the provided filename exists this method generates a new name that contains a numerical suffix (starting at 1)
        ///     while ensuring the new filename also does not exist. This method does not create the file so applications should
        ///     take extra measures to ensure the returned filename is still unique before using it (the file may have since been
        ///     created by another process.
        /// </summary>
        /// <example>
        ///     And example of this code would be having a
        ///     <c><see cref="string" /> FileAddress = "C:\MyFiles\ExampleOutput.txt"</c>,
        ///     and then using <c>fileName = CreateUniqueFilename(FileAddress);</c>
        ///     <para />
        ///     Assuming the file location already contains ExampleOutput.txt, ExampleOutput1.txt, and ExampleOutput2.txt, then the
        ///     output will be ExampleOutput3.txt.
        /// </example>
        /// <param name="baseFilename">
        ///     The address to the file to create a unique filename
        /// </param>
        /// <returns>
        ///     Returns a unique filename
        /// </returns>
        public static string CreateUniqueFilename(string baseFilename)
        {
            if (!File.Exists(baseFilename))
            {
                return baseFilename;
            }

            string destFileName;
            var counter = 1;
            var dirPart = Path.GetDirectoryName(baseFilename);
            var filePart = Path.GetFileNameWithoutExtension(baseFilename);
            var extPart = Path.HasExtension(baseFilename) ? Path.GetExtension(baseFilename) : "";

            do
            {
                destFileName = Path.Combine(dirPart ?? "", $"{filePart}.{counter++}{extPart}");
            } while (File.Exists(destFileName));

            return destFileName;
        }
    }
}