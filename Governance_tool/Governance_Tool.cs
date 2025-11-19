using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Governance_tool
{
    public partial class Governance_Tool : Form
    {
        public string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Governance_Tool()
        {
            InitializeComponent();
        }

        private void Governance_Tool_Load(object sender, EventArgs e)
        {
            searchby_L1_handler_list();
            reset_overall();
        }

        public void reset_overall()
        { 
            datagridview_display_overall();
        }

        public void searchby_L1_handler_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                Emp_Names obj_l1_handler = new Emp_Names();
                DataTable dtaa = new DataTable();

                obj_l1_handler.searchby_l1_handler_list(dtaa);

                searchby_l1_handler.DataSource = dtaa;
                searchby_l1_handler.DisplayMember = "L1_Handler";


                conn.Close();
                searchby_l1_handler.SelectedIndex = -1;
            }

            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }

        public void datagridview_display_overall()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.Clear();

                if (string.IsNullOrEmpty(searchby_l1_handler.Text) && searchby_date.Text.Trim() == string.Empty)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select top 100 ID,Date,L1_Handler,Control_Report_Name,Frequency,ProcessName,LastUpdatedBy,IsStatus_Updated,Description from dbo.vw_governance_tracker_transactional_dotnet order by ID";
                    //cmd.Parameters.AddWithValue("@lastupdatedby", Environment.UserName.ToString());
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_governance_tracker_datagridview_search_dotnet";
                    if (string.IsNullOrEmpty(searchby_l1_handler.Text))
                    {
                        cmd.Parameters.AddWithValue("@searchby_l1_handler", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@searchby_l1_handler", searchby_l1_handler.Text);
                    }
                    if (searchby_date.Text.Trim() == string.Empty)
                    {
                        cmd.Parameters.AddWithValue("@searchby_date", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@searchby_date", searchby_date.Value.Date);
                    }

                }
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }

        }

        private void searchby_date_ValueChanged(object sender, EventArgs e)
        {
            searchby_date.CustomFormat = "dd-MMMM-yyyy";
            datagridview_display_overall();
        }

        private void searchby_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchby_date.CustomFormat = " ";
            }
        }

        private void searchby_l1_handler_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_display_overall();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myrow in dataGridView1.Rows)
            {
                if (myrow.Cells["txt_IsStatus_Updated"].Value.ToString() == "Updated")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Green;
                    myrow.DefaultCellStyle.ForeColor = Color.White;
                }
                if (myrow.Cells["txt_IsStatus_Updated"].Value.ToString() == "Not Updated")
                {
                    myrow.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void update_status_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    bool isselected = Convert.ToBoolean(item.Cells["txt_CheckValue"].Value);
                    //if ((bool)item.Cells["txtCheckValue"].Value == true)
                    if (isselected)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        cmd.Parameters.Clear();
                        conn.ConnectionString = connectionstringtxt;
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.usp_governance_tracker_bulkupdate_dotnet";
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(item.Cells["txt_ID"].Value));
                        cmd.Parameters.AddWithValue("@LastUpdatedBy", Environment.UserName.ToString());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                    }
                }
                MessageBox.Show("Records Updated Successfully");
                datagridview_display_overall();
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details: " + ab.ToString());
            }
        }
    }
}
