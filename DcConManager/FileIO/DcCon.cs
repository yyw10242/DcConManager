using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DcConManager.FileIO
{
    class DcCon
    {
        public Image image = null;
        //public int imageIndex = 0;
        public string[] keywords = null;

        public DcCon(string path)
        {
            FileInfo file = new FileInfo(path);
            image = Image.FromFile(path); //< -ImagePool 로 이동.
            //imageindex = ImagePool.AddImage(path);

            keywords = file.Name.Split('.')[0].Split(',');

            for (int i = 0; i < keywords.Length; i++)
            {
                keywords[i] = keywords[i].Trim();
            }
        }
    }
}
