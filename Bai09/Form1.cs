using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai09
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DINHMANH\\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";
        SqlConnection cnn;
        SqlDataAdapter adapter;
        string sql;
     
        List<string> SelectedSubjectStrings;

        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            sql = "";
            SelectedSubjectStrings = new List<string>();
            rbMale.Checked = true;
            cnn.Open();
            DisplayComboBoxData();
            DisplayDataGridViewData();
        }
        private void DisplayComboBoxData()
        {
            adapter = new SqlDataAdapter("select MajorName from Majors", cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbMajor.Items.Add(dr[0].ToString());
            }
        }
        private void DisplayDataGridViewData()
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select st.*, count(sr.SubjectCode) 'Total subjects'\r\nfrom Students st left join StudentRecords sr on st.StudentCode=sr.StudentCode\r\ngroup by st.StudentCode, st.StudentName, st.MajorName, st.Gender", cnn);
            adapter.Fill(dt);
            dataGridView.DataSource = dt;  
        }
        private void btSaveInformation_Click(object sender, EventArgs e)
        {
            try { 
                if(tbName.Text!=""&&tbStudentCode.Text!=""&& cbMajor.Text!="")
                {
                    string gender;
                    if (rbMale.Checked)
                        gender = "Male";
                    else
                        gender = "female";
                    sql = "insert into Students values(" +"N'"+tbStudentCode.Text + "',N'"  + @tbName.Text + "',N'" + @cbMajor.Text + "',N'" + gender+"')";
                    SqlCommand command = new SqlCommand(sql,cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                   
                    foreach (string item in SelectedSubjectStrings)
                    {
                        sql = "select subjectCode\r\nfrom Subjects";//\r\nwhere SubjectName='"+item+"'";
                        SqlDataAdapter ada = new SqlDataAdapter(sql, cnn);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        string StudentCode = dt.Rows[0]["SubjectCode"].ToString();
                        sql = "insert into StudentRecords values(" + "N'" + tbStudentCode.Text + "',N'" + StudentCode+ "')";
                        command = new SqlCommand(sql,cnn);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                    DisplayDataGridViewData();
                    tbName.Text = tbStudentCode.Text = "";
                    rbMale.Select();
                    lwSeletedSubjects.Items.Clear();
                    SelectedSubjectStrings.Clear();
                    cbMajor.SelectedIndex = 0;
                    cbMajor.Text = cbMajor.Items[cbMajor.SelectedIndex].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormClosing1(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want close this form?", "Close form",MessageBoxButtons.YesNo)==DialogResult.Yes)
                cnn.Close();
            else
                e.Cancel = true;
        }

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                lwAllSubjects.Clear();
                lwSeletedSubjects.Clear();
                sql = "select MajorCode from Majors where MajorName='" + cbMajor.Text + "'";
                adapter = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                string majorCode = dt.Rows[0]["MajorCode"].ToString();
                sql = "select SubjectName from Subjects where MajorCode='" + majorCode + "'";
                adapter = new SqlDataAdapter(sql, cnn);
                DataTable dt2 = new DataTable();
                adapter.Fill(dt2);

                //lwAllSubjects.Items.Add(listitem);

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    ListViewItem listitem = new ListViewItem(dt2.Rows[i]["SubjectName"].ToString());
                    lwAllSubjects.Items.Add(listitem);
                }
            }
            catch { }
        }

        private void tbStudentCode_TextChanged(object sender, EventArgs e)
        {
            try {
                sql = "Select StudentCode from Students";
                adapter = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["StudentCode"].ToString()==tbStudentCode.Text)
                    {
                        
                        MessageBox.Show("StudentCode " + tbStudentCode.Text + " has existed","Input Student code Error", MessageBoxButtons.OK);
                    }
                    
                }
            }
            catch { }
        }

        private void btAddSubject_Click(object sender, EventArgs e)
        {
    
            foreach (ListViewItem item in lwAllSubjects.SelectedItems)
            {
                SelectedSubjectStrings.Add(item.Text);
                lwSeletedSubjects.Items.Add(item.Text);
            }
           
        }

        private void btRemoveSubject_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lwSeletedSubjects.SelectedItems)
            {
                SelectedSubjectStrings.Remove(item.Text);
                lwSeletedSubjects.Items.Remove(item);
            }    
        }
    }
}
