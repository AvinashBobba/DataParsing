using System;
using System.IO;

namespace DataParsing
{
    public class DriverInfomation
    {
        public void GetDriveInfo()
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine("Drive {0}", driveInfo.Name);
                Console.WriteLine("  File type: {0}", driveInfo.DriveType);

                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", driveInfo.VolumeLabel);
                    Console.WriteLine("  File system: {0}", driveInfo.DriveFormat);
                    Console.WriteLine("  Available space to current {0}", driveInfo.AvailableFreeSpace);

                    Console.WriteLine("  Total available space:          {0} bytes", driveInfo.TotalFreeSpace);

                    Console.WriteLine("  Total size of drive:            {0} bytes ", driveInfo.TotalSize);
                }
            }

            #region DirectoryStaticClass
            //var directory = Directory.CreateDirectory(@"C:\Users\avinash.bobba\Directory");
            if (Directory.Exists(@"C:\Users\avinash.bobba\Directory"))
            { 
                Directory.Delete(@"C:\Users\avinash.bobba\Directory"); 
            }
            #endregion

            #region DirectoryInfo
            ////var directoryInfo = new DirectoryInfo(@"C:\Users\avinash.bobba\DirectoryInfo");
            //////if(directoryInfo.Exists)
            //////    directoryInfo.Delete();
            //////else
            //////    directoryInfo.Create();

            ////Console.WriteLine("Root Portion of the Directory {0}", directoryInfo.Root);
            ////Console.WriteLine("Get the directory Full Name: {0}", directoryInfo.FullName);
            ////Console.WriteLine(directoryInfo.Name);
            ////Console.WriteLine(directoryInfo.Parent);
            DirectoryInfo directoryInfo = new DirectoryInfo("TestDirectory");
            Console.WriteLine("Get the directory Full Name: {0}", directoryInfo.FullName);
            //directoryInfo.Create();
            //DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            //directorySecurity.AddAccessRule(
            //    new FileSystemAccessRule("everyone"
            //    , FileSystemRights.ReadAndExecute
            //    , AccessControlType.Allow)
            //    );
            //directoryInfo.SetAccessControl(directorySecurity);

            #endregion
        }
    }
}
