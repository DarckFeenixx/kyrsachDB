using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsDb
{
    public partial class EditInstalledCameras : Form
    {
        KyrsachContext _kyrsContext;
        int startRow;
        int ownerID = -1;
        public EditInstalledCameras(KyrsachContext kyrsContext, int row = -1, int owner = -1)
        {
            InitializeComponent();
            _kyrsContext = kyrsContext;
            startRow = row;
            ownerID = owner;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ownerIdTB.Text) != ownerID && ownerID != -1)
                {
                    outTB.Text = $"недостаточно прав";
                    return;
                }
                _kyrsContext.PlacedCameras.Remove((from ins in _kyrsContext.PlacedCameras where ins.Coordinates == coordinatesTB.Text select ins).First());
                _kyrsContext.SaveChanges();
                outTB.Text = "камера удалена";
            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";
            }
        }

        private void accbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (maintanceTB.Text == "") 
                {
                    maintanceTB.Text = datePlacedTB.Text;
                }
                if (Convert.ToInt32(ownerIdTB.Text) != ownerID && ownerID != -1) 
                {
                    outTB.Text = $"недостаточно прав";
                    return;
                }
                var cameras = from ins in _kyrsContext.PlacedCameras 
                              where ins.Coordinates == coordinatesTB.Text 
                              select ins;
                if (cameras.Any())
                {
                    var entity = cameras.First();
                    entity.CmCameraID = Convert.ToInt32(modelIdTB.Text);
                    entity.CoCameraOwnerID = Convert.ToInt32(ownerIdTB.Text);
                    entity.AdAddressID = Convert.ToInt32(addressIdTB.Text);
                    entity.Coordinates = coordinatesTB.Text;
                    entity.DateInstalled = DateTime.Parse(datePlacedTB.Text, new System.Globalization.CultureInfo("ru-RU"));
                    entity.DateLastMaintance = DateTime.Parse(maintanceTB.Text, new System.Globalization.CultureInfo("ru-RU"));
                    entity.Description = descriptionTB.Text;
                    entity.IP = ipTB.Text;
                    entity.MAC = macTB.Text;
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"камера изменена. ID: {entity.InstalledCameraID}";
                }
                else
                {
                    var entity = _kyrsContext.PlacedCameras.Add(new InstalledCamera()
                    {
                        CmCameraID = Convert.ToInt32(modelIdTB.Text),
                        CoCameraOwnerID = Convert.ToInt32(ownerIdTB.Text),
                        AdAddressID = Convert.ToInt32(addressIdTB.Text),
                        Coordinates = coordinatesTB.Text,
                        DateInstalled = DateTime.Parse(datePlacedTB.Text, new System.Globalization.CultureInfo("ru-RU")),
                        DateLastMaintance = DateTime.Parse(maintanceTB.Text, new System.Globalization.CultureInfo("ru-RU")),
                        Description = descriptionTB.Text,
                        IP = ipTB.Text,
                        MAC = macTB.Text
                    });
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"камера добавлена. ID: {entity.Entity.InstalledCameraID}";
                }

            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";
            }
        }

        private void EditInstalledCameras_Load(object sender, EventArgs e)
        {
            try
            {
                if (startRow == -1)
                {
                    return;
                }
                var getRow = from cam in _kyrsContext.PlacedCameras
                             where cam.InstalledCameraID == startRow
                             select cam;
                var entity = getRow.First();
                modelIdTB.Text = entity.CmCameraID.ToString();
                addressIdTB.Text = entity.AdAddressID.ToString();
                ownerIdTB.Text = entity.CoCameraOwnerID.ToString();
                coordinatesTB.Text = entity.Coordinates;
                datePlacedTB.Text = entity.DateInstalled.ToString();
                descriptionTB.Text = entity.Description;
                maintanceTB.Text = entity.DateLastMaintance.ToString();
                ipTB.Text = entity.IP;
                macTB.Text = entity.MAC;
            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";
            }
        }
    }
}
