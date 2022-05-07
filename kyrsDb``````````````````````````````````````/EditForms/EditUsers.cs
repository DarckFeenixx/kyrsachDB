using Microsoft.Data.SqlClient;
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
    public partial class EditUsers : Form
    {
        KyrsachContext _kyrsContext;
        int startRow;
        public EditUsers(KyrsachContext kyrsContext, int row = -1)
        {
            InitializeComponent(); 
            _kyrsContext = kyrsContext;
            startRow = row;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = $"DROP LOGIN {loginTB.Text} DROP USER {loginTB.Text}_u";
                string connectionString = StaticHelpers.baseConnectionString;

                using (SqlConnection connection = new(connectionString))
                {
                    SqlCommand command = new(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                _kyrsContext.DbUsers.Remove((from user in _kyrsContext.DbUsers
                                              where loginTB.Text == user.Login
                                              select user).First());
                _kyrsContext.SaveChanges();
                outTB.Text = "пользователь удален";
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
                var users = from usr in _kyrsContext.DbUsers
                               where usr.Login == loginTB.Text
                               select usr;
                if (users.Any())
                {
                    var entity = users.First();
                    entity.Login = loginTB.Text;
                    if (passTB.Text != "") 
                    {
                        entity.Password = User.Hash(passTB.Text);
                    }
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"пользователь изменен. ID: {entity.DatabaseUserID}";
                }
                else
                {
                    if (passTB.Text == "") 
                    {
                        throw new Exception("invalid password");
                    }
                    var entity = _kyrsContext.DbUsers.Add(new DatabaseUser()
                    {
                        Login = loginTB.Text,
                        Password = User.Hash(passTB.Text),
                    });
                    if (companyTB.Text != "" && companyTB.Text.ToLower() != "администратор")
                    {
                        entity.Entity.CameraOwnerID = (from owners in _kyrsContext.CameraOwners
                                                       where owners.Company == companyTB.Text
                                                       select owners.CameraOwnerID).First();
                    }
                    else 
                    {
                        entity.Entity.CameraOwnerID = -1;
                    }
                    string queryString = $"CREATE LOGIN {loginTB.Text} WITH PASSWORD = '{passTB.Text}'" +
                        $" CREATE USER {loginTB.Text}_u FROM LOGIN {loginTB.Text} ALTER ROLE db_datareader ADD MEMBER {loginTB.Text}_u" +
                        $" ALTER ROLE db_datawriter ADD MEMBER {loginTB.Text}_u";
                    string connectionString = StaticHelpers.baseConnectionString;

                    using (SqlConnection connection = new(connectionString))
                    {
                        SqlCommand command = new(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    _kyrsContext.SaveChanges();
                    outTB.Text = $"пользователь добавлен. ID: {entity.Entity.DatabaseUserID}";
                }

            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";

            }
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            try
            {
                if (startRow == -1)
                {
                    return;
                }
                var getRow = from usr in _kyrsContext.DbUsers
                             where usr.DatabaseUserID == startRow
                             select usr;
                var entity = getRow.First();
                loginTB.Text = entity.Login;
                //companyTB.Text 
                if (entity.CameraOwnerID != -1)
                {
                    var userCompany = (from own in _kyrsContext.CameraOwners
                                       where own.CameraOwnerID == entity.CameraOwnerID
                                       select own.Company);
                    companyTB.Text = userCompany.First();
                }
                else
                {
                    companyTB.Text = "Администратор";
                }
            }
            catch (Exception)
            {
                outTB.Text = "какая неудача";

            }
        }
    }
}
