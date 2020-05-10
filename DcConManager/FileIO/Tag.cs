using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcConManager.FileIO
{
    public class Tag
    {
        DirectoryInfo directoryInfo;
        List<Tag> childTags = new List<Tag>();
        List<DcCon> dcCons = new List<DcCon>();

        public Tag(string path)
        {
            directoryInfo = new DirectoryInfo(path);
            
            foreach(DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                Tag childTag = new Tag(directory.FullName);
                childTags.Add(childTag);
            }

            foreach(FileInfo file in directoryInfo.GetFiles())
            {
                DcCon dcCon = new DcCon(file.FullName);
                dcCons.Add(dcCon);
            }
            
        }

    }
}
