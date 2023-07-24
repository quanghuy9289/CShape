using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.System.IO
{
    class FileAndFolderHandler
    {
        public void CreateFile(string filePath)
        {
            try
            {
                FileInfo fi = new FileInfo(filePath);
                if (!fi.Exists)
                {
                    fi.Create();
                    Console.WriteLine("File is created Successfuly");
                }
            } catch(IOException ex)
            {
                Console.WriteLine("Something went wrong: " + ex);
            }
        }

        public void WriteTextToFile(string filePath)
        {
            try
            {
                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists)
                {
                    StreamWriter writer = fi.CreateText();
                    writer.WriteLine("This text is written to the file by using StreamWriter class.");
                    writer.Close();
                }
            } catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }

        public void ReadDataFromFile(string filePath)
        {
            try
            {
                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists)
                {
                    StreamReader reader = fi.OpenText();
                    string data = reader.ReadLine();
                    while (data != null)
                    {
                        Console.WriteLine(data);
                        data = reader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }

        public void ScanDirectory(string directoryPath)
        {
            DirectoryInfo di = new DirectoryInfo(directoryPath);
            Console.WriteLine("Directory full path: " + di.FullName);
            // scan files
            foreach(var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
        }

        public void ScanDriverInSystem()
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            // scan driver
            foreach(var driver in drivers)
            {
                Console.WriteLine("Driver name:  " + driver.Name + " - Driver type: " + driver.DriveType.ToString());
            }
        }

        public void WorkWithPath(string filePath)
        {
            Console.WriteLine("File path: " + filePath);
            Console.WriteLine("Ext {0}", Path.GetExtension(filePath));
            Console.WriteLine("Change ext - new file: {0}", Path.ChangeExtension(filePath, "bak"));
        }

        // giám sát việc tạo và xóa tập tin, thư mục
        public void watcher_Change(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory change ({0} - {1}", e.ChangeType, e.FullPath);
        }

        // giám sát việc sửa đổi tên tập tin và thư mục
        public void watcher_Rename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Rename from {0} to {1}", e.OldFullPath, e.FullPath);
        }

        public void TrackingFileAndFolder(string folderPath)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(folderPath);

            //Chỉ định phương thức xử lý cho sự kiện
            watcher.Created += new FileSystemEventHandler(watcher_Change);
            watcher.Deleted += new FileSystemEventHandler(watcher_Change);

            watcher.Renamed += new RenamedEventHandler(watcher_Rename);

            // start watching
            watcher.EnableRaisingEvents = true;
        }
    }
}
