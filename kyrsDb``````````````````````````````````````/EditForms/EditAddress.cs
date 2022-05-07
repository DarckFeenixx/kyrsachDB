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
    public partial class EditAddress : Form
    {
        KyrsachContext _kyrsContext;
        int startRow;
        public EditAddress(KyrsachContext kyrsContext, int row = -1)
        {
            InitializeComponent();
            _kyrsContext = kyrsContext;
            startRow = row;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                _kyrsContext.Adresses.Remove((from adr in _kyrsContext.Adresses
                                              where adr.City == cityTB.Text && adr.Region == regionTB.Text
                                              && adr.Street == streetTB.Text
                                              && adr.House == Convert.ToInt32(houseTB.Text)
                                              select adr).First());
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
                var adresses = from adr in _kyrsContext.Adresses
                              where adr.City == cityTB.Text && adr.Region == regionTB.Text 
                              && adr.Street == streetTB.Text 
                              && adr.House == Convert.ToInt32(houseTB.Text)
                              select adr;
                if (adresses.Any())
                {
                    var entity = adresses.First();
                    entity.City = cityTB.Text;
                    entity.Region = regionTB.Text;
                    entity.Street = streetTB.Text;
                    entity.House = Convert.ToInt32(houseTB.Text);
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"адрес изменен. ID: {entity.AddressId}";
                }
                else
                {
                    var entity = _kyrsContext.Adresses.Add(new Address()
                    {
                        City = cityTB.Text,
                        Region = regionTB.Text,
                        Street = streetTB.Text,
                        House = Convert.ToInt32(houseTB.Text)
                });
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"адрес добавлен. ID: {entity.Entity.AddressId}";
                }

            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";
            }
        }

        private void EditAddress_Load(object sender, EventArgs e)
        {
            try
            {
                if (startRow == -1)
                {
                    return;
                }
                var getRow = from adr in _kyrsContext.Adresses
                             where adr.AddressId == startRow
                             select adr;
                var entity = getRow.First();
                cityTB.Text = entity.City;
                regionTB.Text = entity.Region;
                streetTB.Text = entity.Street;
                houseTB.Text = entity.House.ToString();
            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";
            }
        }
    }
}
