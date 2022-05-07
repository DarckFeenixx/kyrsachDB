using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsDb
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public List<CameraOwner> CameraOwners { get; set; }
        public List<InstalledCamera> InstalledCameras { get; set; }
    }
}
