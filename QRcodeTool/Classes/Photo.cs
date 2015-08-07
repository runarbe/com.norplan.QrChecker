using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace norplan.adm.qrtoolui
{
    public enum PhotoStatus
    {
        NotChecked = 1,
        Approved = 2,
        Rejected = 3
    }

    class Photo
    {
        public string Filename { get; set; }
        public string Name { get; set; }
        public PhotoStatus Status { get; set; }

        public Photo(string pFilename, PhotoStatus pStatus)
        {
            this.Name = Path.GetFileName(pFilename);
            this.Filename = pFilename;
            this.Status = pStatus;
        }

    }

    class Photos : SortableBindingList<Photo>
    {
        public void AddPhoto(string pFilename, PhotoStatus pStatus)
        {
            this.Add(new Photo(pFilename, pStatus));
        }
    }


}
