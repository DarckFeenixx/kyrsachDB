using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsDb
{
    [Index(nameof(InstalledCamera.Coordinates), IsUnique = true)]
    public class InstalledCamera
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstalledCameraID { get; set; }
        public int? CoCameraOwnerID { get; set; }
        public int? CmCameraID { get; set; }
        public int? AdAddressID { get; set; }
        [Required]
        public string Coordinates { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateInstalled { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateLastMaintance { get; set; }
        [Required]
        public string IP { get; set; }
        [Required]
        public string MAC { get; set; }
        public Address Ad { get; set; }
        public Camera Cm { get; set; }
        public CameraOwner Co { get; set; }
    }
}
