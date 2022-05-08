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
    [Index(nameof(CameraOwner.Company), IsUnique = true)]
    public class CameraOwner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CameraOwnerID { get; set; }
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [StringLength(12)]
        [Required]
        public string INN { get; set; }
        public int AddressAddressID { get; set; }
        public Address Address { get; set; }
        public List<InstalledCamera> InstalledCameras { get; set; }
    }
}
