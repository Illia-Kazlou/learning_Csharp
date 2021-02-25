using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CourseHunter_69_Constructors
{
    class LocalFileSystemStorage
    {
        private string nameOwnerDirectory;

        public LocalFileSystemStorage(string nameOwner)
        {
            nameOwnerDirectory = ($@"{Directory.GetCurrentDirectory()}\{nameOwner}");
        }

        public LocalFileSystemStorage(int nameOwner)
        {
            nameOwnerDirectory = ($@"{Directory.GetCurrentDirectory()}\{nameOwner}");
        }

        public string IsFileExistInStorage(string fileName)
        {
            if (File.Exists($"{nameOwnerDirectory}\\{fileName}"))
            {
                return "good";
            }
            return "true";
        }

    }
}
