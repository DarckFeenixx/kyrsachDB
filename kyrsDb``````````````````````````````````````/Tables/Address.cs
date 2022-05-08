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
    [Index(nameof(Address.City), nameof(Address.Region), nameof(Address.Street), nameof(Address.House), IsUnique = true)]
    public class Address
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int House { get; set; }
        public List<CameraOwner> CameraOwners { get; set; }
        public List<InstalledCamera> InstalledCameras { get; set; }
    }
}
