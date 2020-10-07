using System;
using System.IO.Compression;

namespace _6.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@".\toCopy.png", @"C:\Users\HP\Desktop\Demo\result.zip");
            ZipFile.ExtractToDirectory(@"C:\Users\HP\Desktop\Demo\result.zip", @"C:\Users\HP\Desktop\Demo\");
        }
    }
}
