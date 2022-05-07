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
    public partial class EditCameras : Form
    {
        KyrsachContext _kyrsContext; 
        int startRow;
        public EditCameras(KyrsachContext kyrsContext, int rowid = -1)
        {
            InitializeComponent();
            _kyrsContext = kyrsContext;
            startRow = rowid;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                _kyrsContext.Cameras.Remove((from cam in _kyrsContext.Cameras where cam.Model == modelTB.Text && cam.Manufactorer == manufactorerTB.Text select cam).First());
                _kyrsContext.SaveChanges();
                outTB.Text = "камера удалена";
            }
            catch (Exception)
            {
                throw;
                outTB.Text = "какая неудача";
            }
        }

        private void accbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var cameras = from cam in _kyrsContext.Cameras 
                        where cam.Model == modelTB.Text && cam.Manufactorer == manufactorerTB.Text 
                        select cam;
                if (cameras.Any())
                {
                    var entity = cameras.First();
                    entity.Model = modelTB.Text;
                    entity.Manufactorer = manufactorerTB.Text;
                    entity.MinLight = Convert.ToSingle(minLiTB.Text);
                    entity.Matrix = Convert.ToInt32(matrixTB.Text);
                    entity.Focus = Convert.ToSingle(focusTB.Text);
                    entity.RecordSpeed = Convert.ToInt32(recspeedTB.Text);
                    entity.Angle = Convert.ToInt32(angleTB.Text);
                    entity.MaintaincePeriod = Convert.ToInt32(maintanceTB.Text);
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"камера изменена. ID: {entity.CameraID}";
                }
                else
                {
                    var entity = _kyrsContext.Cameras.Add(new Camera()
                    {
                        Model = modelTB.Text,
                        Manufactorer = manufactorerTB.Text,
                        MinLight = Convert.ToSingle(minLiTB.Text),
                        Matrix = Convert.ToInt32(matrixTB.Text),
                        Focus = Convert.ToSingle(focusTB.Text),
                        RecordSpeed = Convert.ToInt32(recspeedTB.Text),
                        Angle = Convert.ToInt32(angleTB.Text),
                        MaintaincePeriod = Convert.ToInt32(maintanceTB.Text)
                    });
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"камера добавлена. ID: {entity.Entity.CameraID}";
                }
                
            }
            catch (Exception)
            {
                throw;
                outTB.Text = "какая неудача";
            }
        }

        private void EditCameras_Load(object sender, EventArgs e)
        {
            try
            {
                if (startRow == -1)
                {
                    return;
                }
                var getRow = from cam in _kyrsContext.Cameras
                             where cam.CameraID == startRow
                             select cam;
                var entity = getRow.First();
                modelTB.Text = entity.Model;
                manufactorerTB.Text = entity.Manufactorer;
                minLiTB.Text = entity.MinLight.ToString();
                matrixTB.Text = entity.Matrix.ToString();
                focusTB.Text = entity.Focus.ToString();
                recspeedTB.Text = entity.RecordSpeed.ToString();
                angleTB.Text = entity.Angle.ToString();
                maintanceTB.Text = entity.MaintaincePeriod.ToString();
            }
            catch (Exception)
            {
                throw;
                outTB.Text = "какая неудача";
            }
        }
    }
}
