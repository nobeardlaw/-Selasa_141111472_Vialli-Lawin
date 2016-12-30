using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pertemuan11_a
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter customerDA;
        //DataSet ds;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=testing;Uid=root;Pwd=;";
            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            //ds = new DataSet();
            dt = new DataTable();
            initializeDA();
            customerDA.SelectCommand.ExecuteScalar();
            //customerDA.Fill(ds, "customer");
            customerDA.Fill(dt);
            dgvDaftar.ReadOnly = true;
            dgvDaftar.AllowUserToAddRows = true;
            dgvDaftar.AllowUserToDeleteRows = true;
            dgvDaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingSource bs = new BindingSource();
            //bs.DataSource = ds.Tables["customer"];
            bs.DataSource = dt;
            dgvDaftar.DataSource = bs;
            //dgvDaftar.DataSource = ds.Tables["customer"];
        }

        private void initializeDA()
        {
            customerDA = new MySqlDataAdapter();

            //select
            string customerSelectSql = String.Concat("Select * from customer");
            customerDA.SelectCommand = new MySqlCommand(customerSelectSql, conn);

            //insert
            string customerInsertSql = String.Concat("Insert into customer (name, address, zip_code, phone_number, email, created_at) values (@name, @address, @zip_code, @phone_number, @email, @created_at)");
            MySqlCommand customerInsertCommand = new MySqlCommand(customerInsertSql, conn);
            customerInsertCommand.Parameters.AddWithValue("@name", txName.Text);
            customerInsertCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerInsertCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerInsertCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerInsertCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerInsertCommand.Parameters.AddWithValue("@created_at", DateTime.Now);
            customerDA.InsertCommand = customerInsertCommand;

            //update
            string customerUpdateSql = String.Concat("Update customer set name = @name, address = @address, zip_code = @zip_code, phone_number = @phone_number, email = @email, updated_at = @updated_at where id = @id");
            MySqlCommand customerUpdateCommand = new MySqlCommand(customerUpdateSql, conn);
            customerUpdateCommand.Parameters.AddWithValue("@id", txId.Text);
            customerUpdateCommand.Parameters.AddWithValue("@name", txName.Text);
            customerUpdateCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerUpdateCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerUpdateCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerUpdateCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerInsertCommand.Parameters.AddWithValue("@updated_at", DateTime.Now);
            customerDA.UpdateCommand = customerUpdateCommand;

            //delete            
            string customerDeleteSql = string.Concat("Delete customer set name = @name, address = @address, zip_code = @zip_code, phone_number = @phone_number, email = @email, created_at = @created_at, updated_at = @updated_at where id = @id");
            MySqlCommand customerDeleteCommand = new MySqlCommand(customerDeleteSql, conn);
            customerDA.DeleteCommand = customerDeleteCommand;            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeDA();
            string pesan = "";
            if (txId.Text == "")
            {
                pesan = String.Concat(customerDA.InsertCommand.ExecuteNonQuery(), " Record succesfully saved.");
            }
            else
            {
                pesan = String.Concat(customerDA.UpdateCommand.ExecuteNonQuery(), " Record succesfully updated.");
            }
            MessageBox.Show(pesan, "Save Information");
            customerDA.SelectCommand.ExecuteScalar();
            dt.Clear();
            customerDA.Fill(dt);
        }

        private void deklarasiDA(TextBox txnama)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txAddress.Text = "";
            txEmail.Text = "";
            txId.Text = "";
            txName.Text = "";
            txPhoneNumber.Text = "";
            txZipCode.Text = "";
        }




        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvDaftar.Rows.RemoveAt(dgvDaftar.CurrentRow.Index);
                    string customerDeleteSql = string.Concat("Delete customer set name = @name, address = @address, zip_code = @zip_code, phone_number = @phone_number, email = @email, created_at = @created_at, updated_at = @updated_at where id = @id");
                    MySqlCommand customerDeleteCommand = new MySqlCommand(customerDeleteSql, conn);
                    customerDA.DeleteCommand = customerDeleteCommand;
                    customerDA.DeleteCommand.ExecuteNonQuery();
                    customerDA.SelectCommand.ExecuteScalar();
                    dt.Clear();
                    customerDA.Fill(dt);
                }
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }        
        }

        private void dgvDaftar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDaftar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
