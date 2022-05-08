using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsDb
{
    [Index(nameof(Camera.Manufactorer), nameof(Camera.Model), IsUnique = true)]
    public class Camera
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CameraID { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Manufactorer { get; set; }
        public float MinLight { get; set; }
        public int Matrix { get; set; }
        public int RecordSpeed { get; set; }
        public float Focus { get; set; }
        public float Angle { get; set; }
        [Required]
        public int MaintaincePeriod { get; set; }
        public List<InstalledCamera> InstalledCameras { get; set; }
    }
}
