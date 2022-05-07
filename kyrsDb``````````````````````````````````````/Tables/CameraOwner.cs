using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsDb
{
    public class CameraOwner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CameraOwnerID { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string ContactPerson { get; set; }
        [StringLength(12)]
        public string INN { get; set; }
        public int AddressAddressID { get; set; }
        public Address Address { get; set; }
        public List<InstalledCamera> InstalledCameras { get; set; }
    }
}
