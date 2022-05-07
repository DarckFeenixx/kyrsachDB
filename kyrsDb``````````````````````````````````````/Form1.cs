using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class Form1 : Form
    {
        KyrsachContext _KyrsachContext;
        int pageNum = 1;
        int rowsPerPage = 30;
        int tableRowCount = 0;
        User appUser;
        bool tableShown = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoginGb.Parent = this;
            mainGB.Parent = this;
            var options = new DbContextOptions<KyrsachContext>();
            _KyrsachContext = new KyrsachContext(options);
            _KyrsachContext.Database.EnsureCreated();
            appUser = new User();
            if (!_KyrsachContext.DbUsers.Any())
            {
                _KyrsachContext.DbUsers.Add(new DatabaseUser()
                {
                    Login = "sa",
                    Password = User.Hash("1pq0!PQ)"),
                    CameraOwnerID = -1
                });
                _KyrsachContext.SaveChanges();
            }
            paginCB.SelectedItem = paginCB.Items[2];
            tableSelectCB.SelectedItem = tableSelectCB.Items[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rowsPerPage = Convert.ToInt32(paginCB.Text);
            }
            catch (Exception)
            {
                rowsPerPage = -1;
            }
        }
        private void pagination<T>(List<T> ds) 
        {
            outInfoTb.Text = $"Всего строк: {ds.Count}, показано строк: ";
            if (rowsPerPage < 0)
            {
                tableOutDgv.DataSource = ds;
            }
            else
            {
                ds =  ds.Skip((pageNum - 1) * rowsPerPage).Take(rowsPerPage).ToList();
                tableOutDgv.DataSource = ds;
            }
            outInfoTb.Text += ds.Count.ToString();
        }
        private void ShowQuery() 
        {
            tableShown = true;
            if (tableSelectCB.Text == "Камеры")
            {
                var ds = (from cam in _KyrsachContext.PlacedCameras
                                          join model in _KyrsachContext.Cameras on cam.CmCameraID equals model.CameraID
                                          join Adres in _KyrsachContext.Adresses on cam.AdAddressID equals Adres.AddressId
                                          join owner in _KyrsachContext.CameraOwners on cam.CoCameraOwnerID equals owner.CameraOwnerID
                                          where(owner.Company.Contains(filtOwnerTB.Text)) 
                                          where(model.Model.Contains(filtModelTB.Text))
                                          where(model.Manufactorer.Contains(filtManufactorerTB.Text))
                                          where(Adres.City.Contains(filtCityTB.Text))
                                          where(Adres.Region.Contains(filtRegionTB.Text))
                                          where(Adres.Street.Contains(filtStreetTB.Text))
                                          where(Adres.House.ToString().Contains(filtHouseTB.Text))
                                          where(string.Compare(cam.DateInstalled, filtDatePlacedTB.Text) >= 0) //thats a joke but i dont care
                                          where(cam.IP.Contains(filtIpTB.Text))
                                          where(cam.MAC.Contains(filtMacTB.Text))
                                          select new
                                          {
                                              ID = cam.InstalledCameraID,
                                              Модель = model.Model,
                                              Производитель = model.Manufactorer,
                                              Владелец = owner.Company,
                                              Дата_установки = cam.DateInstalled,
                                              Последнее_техобслуживание = cam.DateLastMaintance,
                                              Координаты = cam.Coordinates,
                                              cam.IP,
                                              cam.MAC,
                                              Описание = cam.Description,
                                              Адрес = $"Город: {Adres.City}, Район: {Adres.Region}, Улица: {Adres.Street}, Дом: {Adres.House}"
                                          }).ToList();
                pagination(ds);
            }
            else if (tableSelectCB.Text == "Модели")
            {
                var ds = (from model in _KyrsachContext.Cameras
                          where (model.Model.Contains(filtModelTB.Text))
                          where (model.Manufactorer.Contains(filtManufactorerTB.Text))
                          select new
                          {
                              ID = model.CameraID,
                              Модель = model.Model,
                              Производитель = model.Manufactorer,
                              Минимальная_освященность = model.MinLight,
                              Разрешение_матрицы = model.Matrix,
                              Период_обслуживания = model.MaintaincePeriod,
                              Скорость_записи = model.RecordSpeed,
                              Фокусное_расстояние = model.Focus,
                              Угол_обзора = model.Angle
                          }).ToList();
                pagination(ds);
            }
            else if (tableSelectCB.Text == "Адреса")
            {
                var ds = (from adres in _KyrsachContext.Adresses
                          where (adres.City.Contains(filtCityTB.Text))
                          where (adres.Region.Contains(filtRegionTB.Text))
                          where (adres.Street.Contains(filtStreetTB.Text))
                          where (adres.House.ToString().Contains(filtHouseTB.Text))
                          select new
                          {
                              ID = adres.AddressId,
                              Город = adres.City, 
                              Район = adres.Region,
                              Улица = adres.Street,
                              Дом = adres.House
                          }).ToList();
                pagination(ds);
            }
            else if (tableSelectCB.Text == "Владельцы")
            {
                var ds = (from cam in _KyrsachContext.CameraOwners
                          join Adres in _KyrsachContext.Adresses on cam.AddressAddressID equals Adres.AddressId
                          where (cam.Company.Contains(filtOwnerTB.Text))
                          where (Adres.City.Contains(filtCityTB.Text))
                          where (Adres.Region.Contains(filtRegionTB.Text))
                          where (Adres.Street.Contains(filtStreetTB.Text))
                          where (Adres.House.ToString().Contains(filtHouseTB.Text))
                          select new
                          {
                              ID = cam.CameraOwnerID,
                              Организация = cam.Company,
                              ФИО = cam.ContactPerson,
                              Телефон = cam.PhoneNumber,
                              ИНН = cam.INN,
                              АдресID = cam.AddressAddressID,
                              Адрес = $"Город: {Adres.City}, Район: {Adres.Region}, Улица: {Adres.Street}, Дом: {Adres.House}"
                          }).ToList();
                pagination(ds);
            }
            else
            {
                var ds = (from user in _KyrsachContext.DbUsers
                          select new
                          {
                              ID = user.DatabaseUserID,
                              логин = user.Login,
                              пароль = user.Password,
                              организация = user.CameraOwnerID
                          }).ToList();
                pagination(ds);
            }
        }
        private void ManageFilters(List<string> filters) 
        {
            if (filters.Contains(filtCityTB.Name)) 
            {
                filtCityTB.Enabled = true; 
            }
            else 
            {
                filtCityTB.Enabled = false; 
            }
            if (filters.Contains(filtDatePlacedTB.Name))
            {
                filtDatePlacedTB.Enabled = true;
            }
            else
            {
                filtDatePlacedTB.Enabled = false;
            }
            if (filters.Contains(filtHouseTB.Name))
            {
                filtHouseTB.Enabled = true;
            }
            else
            {
                filtHouseTB.Enabled = false;
            }
            if (filters.Contains(filtIpTB.Name))
            {
                filtIpTB.Enabled = true;
            }
            else
            {
                filtIpTB.Enabled = false;
            }
            if (filters.Contains(filtMacTB.Name))
            {
                filtMacTB.Enabled = true;
            }
            else
            {
                filtMacTB.Enabled = false;
            }
            if (filters.Contains(filtManufactorerTB.Name))
            {
                filtManufactorerTB.Enabled = true;
            }
            else
            {
                filtManufactorerTB.Enabled = false;
            }
            if (filters.Contains(filtModelTB.Name))
            {
                filtModelTB.Enabled = true;
            }
            else
            {
                filtModelTB.Enabled = false;
            }
            if (filters.Contains(filtOwnerTB.Name))
            {
                filtOwnerTB.Enabled = true;
            }
            else
            {
                filtOwnerTB.Enabled = false;
            }
            if (filters.Contains(filtRegionTB.Name))
            {
                filtRegionTB.Enabled = true;
            }
            else
            {
                filtRegionTB.Enabled = false;
            }
            if (filters.Contains(filtStreetTB.Name))
            {
                filtStreetTB.Enabled = true;
            }
            else
            {
                filtStreetTB.Enabled = false;
            }

        }
        private List<string> GetFilterList(string table) 
        {
            if (table == "Камеры") 
            {
                return StaticHelpers.filtersInstalledCameras;
            }
            else if (table == "Модели")
            {
                return StaticHelpers.filtersCameras;
            }
            else if (table == "Адреса")
            {
                return StaticHelpers.filtersAddress;
            }
            else if (table == "Владельцы")
            {
                return StaticHelpers.filtersOwners;
            }
            else return new List<string>();
        }
        private void tableSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQuery();
            ManageFilters(GetFilterList(tableSelectCB.Text));
        }

        private void prevPagebtn_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum--;
            }
            ShowQuery();
        }

        private void nextPagebtn_Click(object sender, EventArgs e)
        {
            if (pageNum < tableRowCount / rowsPerPage + 1)
            {
                pageNum++;
            }
            ShowQuery();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            appUser.login = loginTB.Text;
            appUser.LogIn(passTB.Text, _KyrsachContext);
            if (appUser.IsLoggedIn)
            {
                LoginGb.Visible = false;
                mainGB.Visible = true;
                var options = new DbContextOptions<KyrsachContext>();
                _KyrsachContext = new KyrsachContext(options, $"Server=localhost;Database=kyrsachDb;User Id={appUser.login};Password={passTB.Text}");
                ShowQuery();
            }
            else 
            {
                appUser.login = "";
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }
        private void OpenEditForm()
        {
            int rowid = -1;
            if (tableOutDgv.SelectedCells.Count != 0 && tableShown) 
            {
                rowid = Convert.ToInt32(tableOutDgv.Rows[tableOutDgv.SelectedCells[0].RowIndex].Cells[0].Value);
            }
            if (tableSelectCB.Text == "Камеры")
            {
                EditInstalledCameras editform = new(_KyrsachContext, rowid, appUser.IsAdmin);
                editform.Show();
            }
            else if (tableSelectCB.Text == "Модели")
            {
                if (appUser.IsAdmin != -1) return;
                EditCameras editform = new(_KyrsachContext, rowid);
                editform.Show();
            }
            else if (tableSelectCB.Text == "Адреса")
            {
                if (appUser.IsAdmin != -1) return;
                EditAddress editform = new(_KyrsachContext, rowid);
                editform.Show();
            }
            else if (tableSelectCB.Text == "Владельцы")
            {
                EditOwners editform = new(_KyrsachContext, rowid, appUser.IsAdmin);
                editform.Show();
            }
            else 
            {
                if(appUser.IsAdmin != -1) return;
                EditUsers editform = new(_KyrsachContext, rowid);
                editform.Show();
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void openEditFormsBtn_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            ShowQuery();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tableOutDgv.SelectedRows.Count == 0 || !tableShown) 
            {
                return;
            }
            if (tableSelectCB.Text == "Камеры")
            {
                if (Convert.ToInt32(tableOutDgv.SelectedRows[0].Cells[2].Value) != appUser.IsAdmin) 
                {
                    return; 
                }
                _KyrsachContext.PlacedCameras.Remove((from cam in _KyrsachContext.PlacedCameras
                                                      where cam.InstalledCameraID == Convert.ToInt32(tableOutDgv.SelectedRows[0].Cells[0].Value)
                                                      select cam).First());
            }
            else if (tableSelectCB.Text == "Модели")
            {
                if (appUser.IsAdmin == -1) return;
                _KyrsachContext.Cameras.Remove((from cam in _KyrsachContext.Cameras
                                                      where cam.CameraID == Convert.ToInt32(tableOutDgv.SelectedRows[0].Cells[0].Value)
                                                      select cam).First());
            }
            else if (tableSelectCB.Text == "Адреса")
            {
                if (appUser.IsAdmin == -1) return;
                _KyrsachContext.Cameras.Remove((from cam in _KyrsachContext.Cameras
                                                where cam.CameraID == Convert.ToInt32(tableOutDgv.SelectedRows[0].Cells[0].Value)
                                                select cam).First());

            }
            else if (tableSelectCB.Text == "Владельцы")
            {
                if (appUser.IsAdmin == -1)
                {
                    return; 
                }
                if (Convert.ToInt32(tableOutDgv.SelectedRows[0].Cells[0].Value) == appUser.IsAdmin)
                {
                    _KyrsachContext.CameraOwners.Remove((from owner in _KyrsachContext.CameraOwners
                                                         where Convert.ToInt32(tableOutDgv.SelectedRows[0].Cells[0].Value) == owner.CameraOwnerID
                                                         select owner).First());
                }
            }
            else
            {
                if (appUser.IsAdmin == -1) return;
                MessageBox.Show("Для удаления пользователей используйте редактор");
            }
        }

        private void GetLongMaintanceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tableShown = false;
                var ds = (from cam in _KyrsachContext.PlacedCameras
                          join model in _KyrsachContext.Cameras on cam.CmCameraID equals model.CameraID
                          join Adres in _KyrsachContext.Adresses on cam.AdAddressID equals Adres.AddressId
                          join owner in _KyrsachContext.CameraOwners on cam.CoCameraOwnerID equals owner.CameraOwnerID
                          where (owner.Company.Contains(filtOwnerTB.Text))
                          where (model.Model.Contains(filtModelTB.Text))
                          where (model.Manufactorer.Contains(filtManufactorerTB.Text))
                          where (Adres.City.Contains(filtCityTB.Text))
                          where (Adres.Region.Contains(filtRegionTB.Text))
                          where (Adres.Street.Contains(filtStreetTB.Text))
                          where (Adres.House.ToString().Contains(filtHouseTB.Text))
                          where (cam.IP.Contains(filtIpTB.Text))
                          where (cam.MAC.Contains(filtMacTB.Text))
                          select new
                          {
                              ID = cam.InstalledCameraID,
                              Модель = model.Model,
                              Владелец = owner.Company,
                              Дата_установки = cam.DateInstalled,
                              Последнее_техобслуживание = cam.DateLastMaintance,
                              Координаты = cam.Coordinates,
                              cam.IP,
                              cam.MAC,
                              Описание = cam.Description,
                              период_техобслуживания = model.MaintaincePeriod,
                              Адрес = $"Город: {Adres.City}, Район: {Adres.Region}, Улица: {Adres.Street}, Дом: {Adres.House}"
                          }).ToList();
                ds = (from a in ds
                     where (DateTime.Compare(DateTime.Now, DateTime.Parse(a.Последнее_техобслуживание, new System.Globalization.CultureInfo("ru-RU"))
                     .AddDays(a.период_техобслуживания)) >= 0)
                     select a).ToList();
                tableOutDgv.DataSource = ds;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CamNumPerRegionBtn_Click(object sender, EventArgs e)
        {
            tableShown = false;
            //var groups = from p in db.Phones
            //             group p by p.Company.Name;
            var ds = (from cam in _KyrsachContext.PlacedCameras
                     group cam by cam.Ad.Region into g
                     select new { Район = g.Key, количество = g.Count() }).ToList();
            tableOutDgv.DataSource = ds;
            pagination(ds);
        }

        private void NumCamPerOwnerBtn_Click(object sender, EventArgs e)
        {
            tableShown = false;
            var ds = (from cam in _KyrsachContext.PlacedCameras
                      group cam by cam.Co.Company into g
                      select new { Владелец = g.Key, количество = g.Count() }).ToList();
            tableOutDgv.DataSource = ds;
            pagination(ds);
        }
    }
}
