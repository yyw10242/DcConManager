#region Using
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion
namespace DcConManager.FileIO
{
    class Files
    {
        #region Declaration

        string path = "\\Images\\";

        Tag tagRoot;
        /* tagRoot 를 이용해서
         * 1. Tag Control 생성
         * 2. DcCon Control 생성
        */
        /* 이후 필요한 작업
         * 
         * 
         */

        #endregion

        #region Methods

        /// <summary>
        /// Initializes "tagRoot"
        /// </summary>
        public void GetAll()
        {
            tagRoot = new Tag(path);
        } 


        public void AddImage(string path)
        {
            
        }

        #endregion
    }
}
