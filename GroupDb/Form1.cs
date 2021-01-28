using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupDb
{
    public partial class Form1 : Form
    {
        int Id = 0;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Groupdb.mdf; Integrated Security = True");
    
        public Form1()
        {
            InitializeComponent();
            PanelMenu();
            LoadData();
        }
        private void PanelMenu()
        {
            Form_Add.Visible = false;
            Form_Edit.Visible = false;
            Form_Send.Visible = false;
        }

        private void PanelHide()
        {
            if (Form_Add.Visible == true)
                Form_Add.Visible = false;
            if (Form_Edit.Visible == true)
                Form_Edit.Visible = false;
            if (Form_Send.Visible == true)
                Form_Send.Visible = false;
        }

        private void PanelShow(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                PanelHide();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void LoadData()
        {
            connection.Open();
            string query = "SELECT *FROM TARpv19 ORDER BY Id";
            adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void ClearData()
        {
            NameBox.Text = "";
            NumberBox.Text = "";
            EmailBox.Text = "";
            GroupBox.Text = "";
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            PanelShow(Form_Add);
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            PanelShow(Form_Edit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            NameEditBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            NumberEditBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmailEditBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            GroupEditBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("INSERT INTO TARpv19(Name,Number,Email,GroupName) VALUES (@name,@number,@email,@group)", connection);
            cmd.Parameters.AddWithValue("@name", NameBox.Text);
            cmd.Parameters.AddWithValue("@number", NumberBox.Text);
            cmd.Parameters.AddWithValue("@email", EmailBox.Text);
            cmd.Parameters.AddWithValue("@group", GroupBox.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            LoadData();
            ClearData();
            MessageBox.Show("Added to the database");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update record?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (NameEditBox.Text != "" && NumberEditBox.Text != "" && EmailEditBox.Text != "")
                {
                    cmd = new SqlCommand("update TARpv19 set Name=@name,Number=@number,Email=@email where Id=@id", connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@name", NameEditBox.Text);
                    cmd.Parameters.AddWithValue("@number", NumberEditBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailEditBox.Text.Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@group", GroupEditBox.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    LoadData();
                    ClearData();
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }    
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Id != 0)
                {
                    cmd = new SqlCommand("delete TARpv19 where ID=@id", connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    LoadData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            PanelShow(Form_Send);
        }


        private void BTN_send_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(TXT_from.Text, TXT_to.Text, TXT_subject.Text, TXT_msgbody.Text);
            try
            {
                mail.Attachments.Add(new Attachment(TXT_file.Text));
            }
            catch (Exception)
            {
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("sanderdemih@gmail.com", "");
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Message sent!", "Successful", MessageBoxButtons.OK);
            TXT_from.Text = "";
            TXT_to.Text = "";
            TXT_subject.Text = "";
            TXT_msgbody.Text = "";
            TXT_file.Text = "";
        }

        private void BTN_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                TXT_file.Text = op.FileName;
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to quit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
