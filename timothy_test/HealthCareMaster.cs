using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace timothy_test
{
    public partial class HealthCareMaster : Form
    {
        BusinessLayer bl = new BusinessLayer();
        DataTable dt;
        SqlConnection connection;
        string connectionString;
        int id,ans1;
       
        string text,result;
        int cnt = 0, llcnt = 0, ID = 0, mainmenueupdateid = 0;      
        string ans, status = "new",value1, itemofdata;
        List<string> list = new List<string>();
        List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
        public HealthCareMaster()
        {
            InitializeComponent();
            MessageBox.Show("new repository");
            

            connectionString = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string imgpath = Path.GetDirectoryName(Application.StartupPath).Replace("\\bin", "\\Resources") + "\\search.jpg";
            pictureBox1.ImageLocation = imgpath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;          
            bind_list();
            MainWindow();
            status = "NEW";
            btn_new.BackColor = Color.LightBlue;
            txt_name.Select();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            function_clear();
            status = "NEW";
            txt_name.Focus();
        }       
        private void btn_showall_Click(object sender, EventArgs e)
        {
            function_clear();
            bind_list();
        }
        protected void function_clear()
        {
            //finction for making all textboxes blank
            txt_description.Text = "";
            txt_name.Text = "";
            txtSearch.Text = "";
            txt_mainmenuname.Text = "";
            lst_grid.DataSource = null;
            data_grid.DataSource = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //searching function on text change of text search
            if (txtSearch.Text == "")
            {
                bind_list();
            }
            if (String.IsNullOrEmpty(txtSearch.Text.Trim()) == false)
            {
                lst_disease.Items.Clear();
                foreach (string str in list)
                {
                    if (str.ToLower().StartsWith(txtSearch.Text.ToLower().Trim()))
                    {
                        lst_disease.Items.Add(str);
                    }
                }
            }
        }
        private void lst_disease_Click(object sender, EventArgs e)
        {
            btn_new.BackColor = SystemColors.Control;
            if (status == "NEW")
            {
                status = "";
            }
            if (txt_description.Text != "")
            {
                txt_description.Text = "";
                txt_description.Controls.Clear();
            }            
            try
            {
                //function for getting value of key in textbox txt_name
                string keys = lst_disease.GetItemText(lst_disease.SelectedItem);
                if (keys != "")
                {
                    txt_name.Text = keys;
                    DataTable decsreption = (bl.getvalue(keys));
                    mainmenueupdateid = (Int32)decsreption.Rows[0]["Id"];
                    Bind_firstgrid();

                    DataTable submenulist = bl.fillsubmenulist(mainmenueupdateid);

                    if (data.Count > 0)
                    {
                        data.Clear();
                    }
                    if (submenulist != null && submenulist.Rows.Count > 0)
                    {
                        foreach (DataRow row in submenulist.Rows)
                        {
                            data.Add(new KeyValuePair<string, string>(row["SubMenuKeyValue"].ToString(), row["AliasName"].ToString()));
                        }
                    }
                    txt_description.Text = decsreption.Rows[0]["Value"].ToString();
                    if (data.Count > 0)
                    {
                        txt_mainmenuname.Text = txt_name.Text;                        
                    }
                }               
                this.data_grid.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void Bind_firstgrid()
        {
            
            try

            {
                //bl.Bind_firstgrid();


                using (connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select Id,AliasName,IsMultipleChoice from SubMenuKey where MainMenuId ='" + mainmenueupdateid + "'", connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        connection.Open();

                        DataTable dt1 = new DataTable();
                        dt1.Load(cmd.ExecuteReader());
                        {
                            lst_grid.DataSource = dt1;
                            int i = 1; foreach (DataGridViewRow row in lst_grid.Rows)
                            {
                                row.Cells["serial_no"].Value = i;
                                lst_grid.Rows[i-1].Tag = row.Cells["Id"].Value;
                                //row.Tag = row.Cells["Id"].Value;
                                i++;
                            }
                            lst_grid.Columns[1].Width = 30;
                            lst_grid.Columns[2].Width = 120;
                            lst_grid.Columns[3].Width = 50;
                            lst_grid.DefaultCellStyle.Font = new Font("TimesNewRoman", 10);
                            lst_grid.ColumnHeadersDefaultCellStyle.Font = new Font("TimesNewRoman", 10);

                            lst_grid.Columns[2].HeaderText = "Value";
                            lst_grid.Columns[3].HeaderText = "MultiValue";
                        }
                        lst_grid.Columns["Id"].Visible = false;
                        connection.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string key = txt_name.Text;
            string value = txt_description.Text;
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please Enter Name First");
            }
            else if (txt_description.Text == "")
            {
                MessageBox.Show("Please Enter Description First");
            }
            else {
                if (status == "NEW")
                {
                    try
                    {
                        //serching for is record already exist or not
                        int count = bl.ispreviousrecord(key);
                        if (count > 0)
                        {
                            MessageBox.Show("Record Already Exists Please Check");
                        }
                        else
                        {
                            //function for saving that is inserting record in database
                            if (data.Count > 0)
                            {
                                data.Clear();
                            }                           
                            int cnt = 1;
                            char[] delimiters = new[] { ' ', '.' };
                            foreach (var item in txt_description.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))                                
                            {
                                if (item.StartsWith("#") && item.EndsWith("#"))
                                {
                                    itemofdata = item;
                                    itemofdata = itemofdata.Replace('#', ' ');
                                    data.Add(new KeyValuePair<string, string>(("menu" + cnt), (itemofdata.Trim())));
                                    cnt++;
                                }
                            }
                            ans = bl.savemenu(key, value, cnt, data);
                            if (ans != null)
                            {
                                MessageBox.Show("Record Inserted Successfully");
                                bind_list();
                                MainWindow();
                                function_clear();
                                data.Clear();                             
                                if (llcnt > 0)
                                {
                                    txt_description.Controls.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Try Again");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    try
                    {
                        //if the save button is presed without new then function for updating the record
                        if (data.Count > 0)
                        {
                            data.Clear();
                        }
                        int cnt = 1;
                        foreach (var item in txt_description.Text.Split(' '))
                        {
                            if (item.StartsWith("#") && item.EndsWith("#"))
                            {
                                itemofdata = item;
                                itemofdata = itemofdata.Replace('#', ' ');
                                data.Add(new KeyValuePair<string, string>(("menu" + cnt), (itemofdata.Trim())));
                                cnt++;
                            }
                        }
                        ans = bl.updatemenu(txt_name.Text, data, txt_description.Text, mainmenueupdateid);
                        if (ans != null)
                        {
                            MessageBox.Show("Record Updated Successfully");
                            bind_list();
                            MainWindow();
                            function_clear();
                            data.Clear();
                            if (llcnt > 0)
                            {
                                txt_description.Controls.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Try Again");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (txt_name.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Please Select Value First");
            }
            else
            {
                DialogResult delresult = MessageBox.Show("Do You Really Want to Delete", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delresult == DialogResult.Yes)
                {
                    try
                    {
                        //function for deleting the record
                        ans = bl.delete_record(txt_name.Text);
                        
                        if (!ans.Equals("0"))
                        {
                            MessageBox.Show("Deleted Successfully");
                            bind_list();
                            MainWindow();                         
                            function_clear();
                        }
                        else
                        {
                            MessageBox.Show("Please Try Again");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            char[] delimiters = new[] { ' ','.'};
            foreach (var item in txt_description.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))
            {
                if (item.StartsWith("#") && item.EndsWith("#"))
                {
                    itemofdata = item;
                    itemofdata = itemofdata.Trim();
                    this.CheckKeyword(itemofdata, Color.Blue, 0);
                }
            }
        }

        private void addFunction()
        {

            if (txt_Value.Text.Trim() != "")
            {
                using (connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("insert into SubMenuValue(SubMenuId,Value) values(@SubMenuId,@Value)", connection))
                    { 
                        connection.Open();
                        cmd.Parameters.AddWithValue("@SubMenuId", text);

                        cmd.Parameters.AddWithValue("@Value", txt_Value.Text);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Record Inserted Successfully");
                        BindGrid();
                        clearData();
                    }
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            addFunction();           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //code to update record into database on button click
            try
            {
                if (txt_Value.Text != "" || txt_Value.Text.Trim() != "" || txt_record_id.Text != "")
                {
                    ans = bl.update_submenu(txt_record_id.Text, txt_Value.Text);
                    if (ans != null)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        BindGrid();
                        clearData();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_delete_record_Click(object sender, EventArgs e)
        {
            //code to delete record into database on button click
            try
            {
                if (txt_Value.Text != "" || txt_Value.Text.Trim() != "" || txt_record_id.Text != "")
                {

                    DialogResult delresult = MessageBox.Show("DO YOU REALLY WANT TO DELETE", "CONFIRM DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (delresult == DialogResult.Yes)
                    {

                        ans = bl.del_submenu(txt_record_id.Text);
                        if (!ans.Equals("0"))
                        {
                            MessageBox.Show("Record Deleted Successfully!");
                            clearData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Bind_firstgrid();
            clearData();
            data_grid.DataSource = null;
        }
        private void data_grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//data grid view Mouse click event
            try { ID = Convert.ToInt32(data_grid.Rows[e.RowIndex].Cells[0].Value.ToString()); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            function_clear();
            bind_list();
        }    

        private void lst_grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                text = lst_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
                if (e.ColumnIndex == 3)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)lst_grid.Rows[lst_grid.CurrentRow.Index].Cells[3];
                if (ch1.Value == null)

                    ch1.Value = false;
                // int ch;
                switch (ch1.Value.ToString())
                {
                    case "True":
                        ch1.Value = false;
                        break;
                    case "False":
                        ch1.Value = true;
                        break;
                }
                if (ch1.Value.ToString().Equals("True"))
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Update SubMenuKey set IsMultipleChoice=1 where Id=" + text + "", connection))
                        {
                            connection.Open();
                            result = cmd.ExecuteNonQuery().ToString();
                            connection.Close();
                            if (result == null)
                            {
                                MessageBox.Show("Record not updated");
                            }
                            else
                            {
                                MessageBox.Show("Record Updates Successfully");
                            }
                        }
                    }
                }

                else if (ch1.Value.ToString().Equals("False"))
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Update SubMenuKey set IsMultipleChoice=0 where Id=" + text + "", connection))
                        {
                            connection.Open();
                            result = cmd.ExecuteNonQuery().ToString();
                            connection.Close();
                            if (result == null)
                            {
                                MessageBox.Show("Record not updated");
                            }
                            else
                            {
                                MessageBox.Show("Record Updates Successfully");
                            }
                        }
                    }
                }
            }          
            BindGrid();
        }               
        private void data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.data_grid.Rows[e.RowIndex];
                    txt_Value.Text = row.Cells["Value"].Value.ToString();
                    txt_record_id.Text = row.Cells["Id"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }     
     private void data_grid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in data_grid.SelectedRows)
                {
                    value1 = row.Cells[0].Value.ToString();
                    MessageBox.Show(value1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void clearData()
        {//code to clear all specified textboxes when this function is called
            try
            {
                txt_Value.Text = String.Empty;
                txt_record_id.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BindGrid()
        {//code to bind gridview with the database..
           
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM SubMenuValue where SubMenuId='" + text + "'", connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        connection.Open();

                        DataTable dt1 = new DataTable();
                        dt1.Load(cmd.ExecuteReader());
                         if (dt1.Rows.Count > 0)
                        {
                            data_grid.DataSource = dt1;
                            data_grid.Columns["Id"].Visible = false;
                            data_grid.Columns["SubMenuId"].Visible = false;
                            int i = 1; foreach (DataGridViewRow row in data_grid.Rows)
                            {

                                row.Cells["serial_number"].Value = i; i++;
                            }

                        }
                        else
                        {
                            MessageBox.Show("please provide value to add");
                            this.ActiveControl = txt_Value;
                            addFunction();
                          
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            //special function for converting normal menu word with forecolor
            if (this.txt_description.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.txt_description.SelectionStart;

                while ((index = this.txt_description.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.txt_description.Select((index + startIndex), word.Length);
                    this.txt_description.SelectionColor = color;
                    this.txt_description.Select(selectStart, 0);
                    this.txt_description.SelectionColor = Color.Black;
                }
            }
        }
        public void MainWindow()
        {
            //function for adding values in list collection which will be benificial for sorting purpose
            list.Clear();
            foreach (String str in lst_disease.Items)
            {
                list.Add(str);
            }
        }
        public void bind_list()
        {
            //function for binding the list that is adding the items in listbox            
            if (lst_disease.Items.Count > 0)
            {
                lst_disease.Items.Clear();
            }
            try
            {
                dt = bl.displaylist();
                foreach (DataRow r in dt.Rows)
                {
                    lst_disease.Items.Add(r["MenuKey"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
