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
    public partial class EditOwners : Form
    {
        KyrsachContext _kyrsContext;
        int startRow;
        int ownerID = -1;
        public EditOwners(KyrsachContext kyrsContext, int row = -1, int owner = -1)
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
                var entity = (from own in _kyrsContext.CameraOwners
                              where own.Company == companyTB.Text
                              select own).First();
                if (entity.CameraOwnerID != ownerID && ownerID != -1)
                {
                    outTB.Text = $"недостаточно прав";
                    return;
                }
                _kyrsContext.CameraOwners.Remove(entity);
                _kyrsContext.SaveChanges();
                outTB.Text = "владелец удален";
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
                var owners = from own in _kyrsContext.CameraOwners
                              where own.Company == companyTB.Text
                              select own;
                var adres = from adr in _kyrsContext.Adresses
                          where adr.City == cityTB.Text && adr.Region == regionTB.Text
                          && adr.Street == streetTB.Text
                          && adr.House == Convert.ToInt32(houseTB.Text)
                          select adr;
                if (!adres.Any())
                {
                    _kyrsContext.Adresses.Add(new Address()
                    {
                        City = cityTB.Text,
                        Region = regionTB.Text,
                        Street = streetTB.Text,
                        House = Convert.ToInt32(houseTB.Text)
                    });
                    _kyrsContext.SaveChanges();
                    adres = from adr in _kyrsContext.Adresses
                            where adr.City == cityTB.Text && adr.Region == regionTB.Text
                            && adr.Street == streetTB.Text
                            && adr.House == Convert.ToInt32(houseTB.Text)
                            select adr;
                }
                if (owners.Any())
                {
                    
                    var entity = owners.First();
                    if (entity.CameraOwnerID != ownerID && ownerID != -1)
                    {
                        outTB.Text = $"недостаточно прав";
                        return;
                    }
                    entity.Address = adres.First();
                    entity.AddressAddressID = adres.First().AddressId;
                    entity.Company = companyTB.Text;
                    entity.ContactPerson = contactTB.Text;
                    entity.PhoneNumber = phoneTB.Text;
                    entity.INN = innTB.Text;
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"владелец изменен. ID: {entity.CameraOwnerID}";
                }
                else
                {
                    var entity = _kyrsContext.CameraOwners.Add(new CameraOwner()
                    {
                        Address = adres.First(),
                        AddressAddressID = adres.First().AddressId,
                        Company = companyTB.Text,
                        ContactPerson = contactTB.Text,
                        PhoneNumber = phoneTB.Text,
                        INN = innTB.Text
                    }) ;
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"владелец добавлен. ID: {entity.Entity.CameraOwnerID}";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                outTB.Text = "какая неудача";
            }
        }

        private void EditOwners_Load(object sender, EventArgs e)
        {
            try
            {
                if (startRow == -1)
                {
                    return;
                }
                var getRow = from own in _kyrsContext.CameraOwners
                             where own.CameraOwnerID == startRow
                             select own;
                var entity = getRow.First();
                companyTB.Text = entity.Company;
                contactTB.Text = entity.ContactPerson;
                phoneTB.Text = entity.PhoneNumber;
                innTB.Text = entity.INN;
                var adr = (from a in _kyrsContext.Adresses
                           where a.AddressId == entity.AddressAddressID
                           select a).First();
                cityTB.Text = adr.City;
                regionTB.Text = adr.Region;
                streetTB.Text = adr.Street;
                houseTB.Text = adr.House.ToString();
            }
            catch (Exception)
            {
                throw;
                outTB.Text = "какая неудача";
            }
        }

       
    }
}
