using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace DataParsing
{
    public class ZipAndUnzip
    {
        public void Zip()
        {
            string folder = @"C:\Users\avinash.bobba\Directory";
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");
            byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();
            using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }

            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
                }
            }

            FileInfo uncompressedFile = new FileInfo(uncompressedFilePath); 
            FileInfo compressedFile = new FileInfo(compressedFilePath);

            Console.WriteLine(uncompressedFile.Length); // Displays 1048576 
            Console.WriteLine(compressedFile.Length); // Displays 1052


        }
    }
}
