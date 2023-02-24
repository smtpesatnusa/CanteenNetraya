using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NetrayaCanteen
{
    public partial class DetailEmployee : MaterialForm
    {
        Helper help = new Helper();
        string idUser, dept;
        MySqlConnection myConn;

        string oriRfid;

        public DetailEmployee()
        {
            InitializeComponent();

            // to make corner image smooth 
            help.smoothImage(pictureBoxEmployee);
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            //get user id
            var userId = userdetail.Text.Split('|');
            idUser = userId[0].Trim();
            dept = userId[1].Trim();

            oriRfid = tbRFID.Text;

            string koneksi = ConnectionDB.strProvider;
            myConn = new MySqlConnection(koneksi);

            try
            {
                //menampilkan data combobox 
                help.displayCmbList("SELECT * FROM tbl_mastershift ORDER BY id ", "name", "name", cmbShift);
                help.displayCmbList("SELECT CONCAT(name, ' - ', description) AS names, name FROM tbl_masteremployeelevel ORDER BY id ", "names", "name", cmbLevel);
                help.displayCmbList("SELECT * FROM tbl_mastergender ORDER BY id ", "name", "name", cmbGender);
                help.displayCmbList("SELECT * FROM tbl_masterworkarea ORDER BY id ", "name", "name", cmbWorkarea);
                //get dept depend on user dept
                if (dept == "All")
                {
                    help.displayCmbList("SELECT * FROM tbl_masterdepartment ORDER BY id ", "name", "name", cmbDepartment);
                }
                else
                {
                    help.displayCmbList("SELECT * FROM tbl_masterdepartment where name = '" + dept + "' ORDER BY id ", "name", "name", cmbDepartment);
                }                
                
                string query = "SELECT id, name, level, dept, badgeID, rfidNo, doj, linecode, gender, shift, workarea, status FROM tbl_employee where rfidNo ='" + tbRFID.Text + "'";
                using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, myConn))
                {
                    DataTable dset = new DataTable();
                    adpt.Fill(dset);
                    if (dset.Rows.Count > 0)
                    {
                        string id = dset.Rows[0]["id"].ToString();
                        string name = dset.Rows[0]["name"].ToString();
                        string level = dset.Rows[0]["level"].ToString();
                        string dept = dset.Rows[0]["dept"].ToString();
                        string badgeID = dset.Rows[0]["badgeID"].ToString();
                        string doj = dset.Rows[0]["doj"].ToString();
                        string linecode = dset.Rows[0]["linecode"].ToString();
                        string gender = dset.Rows[0]["gender"].ToString();
                        string shift = dset.Rows[0]["shift"].ToString();
                        string workarea = dset.Rows[0]["workarea"].ToString();
                        string status = dset.Rows[0]["status"].ToString();

                        idEmployee.Text = id;
                        tbBadgeid.Text = badgeID;
                        tbName.Text = name;
                        dateTimePickerDOJ.Text = doj;
                        cmbShift.SelectedIndex = cmbShift.FindStringExact(shift);
                        cmbLevel.SelectedIndex = cmbLevel.FindString(level);
                        cmbDepartment.SelectedIndex = cmbDepartment.FindStringExact(dept);
                        cmbGender.SelectedIndex = cmbGender.FindStringExact(gender);
                        cmbWorkarea.SelectedIndex = cmbWorkarea.FindStringExact(workarea);

                        if (cmbDepartment.Text != "")
                        {
                            help.displayCmbList("SELECT * FROM tbl_masterlinecode WHERE dept = '" + cmbDepartment.Text + "' ORDER BY id ", "name", "id", cmbLineCode);
                        }
                        cmbLineCode.SelectedIndex = cmbLineCode.FindStringExact(linecode);

                        // Display picture image
                        if (File.Exists(@"\\192.168.192.254\SystemSupport\Netraya\EmplFoto\" + badgeID + ".jpg"))
                        {
                            pictureBoxEmployee.Image = Image.FromFile(@"\\192.168.192.254\SystemSupport\Netraya\EmplFoto\" + badgeID + ".jpg");
                        }
                        else
                        {
                            pictureBoxEmployee.Image = Image.FromFile(@"\\192.168.192.254\SystemSupport\Netraya\EmplFoto\default.png");
                        }

                        // select status
                        if (status == "1")
                        {
                            cmbStatus.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbStatus.SelectedIndex = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                myConn.Close();
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                myConn.Dispose();
            }
        }

        private void tbBadgeid_TextChanged(object sender, EventArgs e)
        {
            //if user type alphabet
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBadgeid.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                tbBadgeid.Text = tbBadgeid.Text.Remove(tbBadgeid.Text.Length - 1);
            }
        }

        private void tbRFID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbBadgeid.Focus();
            }
        }

        private void tbBadgeid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbBadgeid.Text != "")
            {
                if (tbBadgeid.Text.Length == 6)
                {
                    tbName.Focus();
                }
                else
                {
                    MessageBox.Show("Wrong Badge ID, please fill Badge ID Properly", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbBadgeid.Text = string.Empty;
                }
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbLevel.Focus();
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePickerDOJ.Focus();
        }

        private void editLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            enableField();
        }

        private void enableField()
        {
            tbRFID.Enabled = true;
            //tbBadgeid.Enabled = true;
            //tbName.Enabled = true;
            dateTimePickerDOJ.Enabled = true;
            cmbShift.Enabled = true;
            cmbLevel.Enabled = true;
            cmbDepartment.Enabled = true;
            cmbLineCode.Enabled = true;
            cmbGender.Enabled = true;
            cmbWorkarea.Enabled = true;
            cmbStatus.Enabled = true;

            saveBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            editEmployee();
        }

        private void editEmployee()
        {
            try
            {
                if (tbRFID.Text == "" || tbBadgeid.Text == "" || tbName.Text == "" || cmbGender.Text == "" || dateTimePickerDOJ.Text == ""
                || cmbLevel.Text == "" || cmbDepartment.Text == "" || cmbLineCode.Text == "" || cmbShift.Text == "" || cmbWorkarea.Text == "")
                {
                    MessageBox.Show(this, "Unable Edit Employee with let any field blank", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbBadgeid.Text != "" && tbBadgeid.Text.Length != 6)
                {
                    MessageBox.Show("Wrong Badge ID, please fill Badge ID Properly", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbBadgeid.Text = string.Empty;
                }
                else
                {
                    string koneksi = ConnectionDB.strProvider;
                    myConn = new MySqlConnection(koneksi);
                    var cmd = new MySqlCommand("", myConn);
                    string rfid = tbRFID.Text;
                    string badgeid = tbBadgeid.Text;
                    string name = tbName.Text;
                    string gender = cmbGender.Text;
                    string level = cmbLevel.SelectedValue.ToString();
                    string department = cmbDepartment.Text;
                    string linecode = cmbLineCode.Text;
                    string shift = cmbShift.Text;
                    string workarea = cmbWorkarea.Text;

                    string status;
                    if (cmbStatus.SelectedIndex == 0)
                    {
                        status = "1";
                    }
                    else
                    {
                        status = "0";
                    }

                    // date
                    string _Date = dateTimePickerDOJ.Text;
                    DateTime dt = Convert.ToDateTime(_Date);
                    string doj = dt.ToString("yyyy-MM-dd");

                    myConn.Open();

                    // insert schedule if employee is normal and update data tbl_employee
                    if (shift == "Normal" || shift == "normal")
                    {
                        // query update employee
                        string Query2 = "UPDATE tbl_employee SET rfidNo = '" + rfid + "', gender = '" + gender + "', doj = '" + doj + "', " +
                        "level = '" + level + "', dept = '" + department + "', linecode = '" + linecode + "', shift = '" + shift + "', workarea = '" + workarea + "', " +
                        "createDate = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', createBy = '" + idUser + "', status = '" + status + "' , workday = '5', offday = '2' WHERE id = '" + idEmployee.Text + "'; ";

                        string[] QueryExecute = { Query2 };
                        for (int j = 0; j < QueryExecute.Length; j++)
                        {
                            cmd.CommandText = QueryExecute[j];
                            //Masukkan perintah/query yang akan dijalankan ke dalam CommandText
                            cmd.ExecuteNonQuery();
                            //Jalankan perintah / query dalam CommandText pada database
                        }
                    }
                    else
                    {
                        // query update employee
                        string Query2 = "UPDATE tbl_employee SET rfidNo = '" + rfid + "', gender = '" + gender + "', doj = '" + doj + "', " +
                        "level = '" + level + "', dept = '" + department + "', linecode = '" + linecode + "', shift = '" + shift + "', workarea = '" + workarea + "', " +
                        "createDate = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', createBy = '" + idUser + "' , status = '" + status + "', workday = '6', offday = '1' WHERE id = '" + idEmployee.Text + "'; ";

                        cmd.CommandText = Query2;
                        cmd.ExecuteNonQuery();
                    }

                    // query update RFID di log
                    string QueryUpdateRFID = "UPDATE tbl_log SET rfidno = '"+tbRFID.Text+"' WHERE rfidno ='"+oriRfid+"'";
                    cmd.CommandText = QueryUpdateRFID;
                    cmd.ExecuteNonQuery();

                    myConn.Close();
                    MessageBox.Show(this, "Employee Successfully Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                myConn.Close();
                //MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                myConn.Dispose();
            }            
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLineCode.DataSource = null;

            if (cmbDepartment.Text != "")
            {
                help.displayCmbList("SELECT * FROM tbl_masterlinecode WHERE dept = '" + cmbDepartment.Text + "' ORDER BY id ", "name", "id", cmbLineCode);
            }
        }
    }
}
