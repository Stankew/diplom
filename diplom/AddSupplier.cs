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

namespace diplom
{
    public partial class AddSupplier : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public AddSupplier()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-V3J850P;Initial Catalog=Storac;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

       

        private async void metroTile1_Click(object sender, EventArgs e)
        {      
            
            if (!string.IsNullOrEmpty(metroTextBox1.Text) && !string.IsNullOrWhiteSpace(metroTextBox1.Text) &&
                !string.IsNullOrEmpty(metroTextBox2.Text) && !string.IsNullOrWhiteSpace(metroTextBox2.Text) &&
                !string.IsNullOrEmpty(metroTextBox3.Text) && !string.IsNullOrWhiteSpace(metroTextBox3.Text) &&
                !string.IsNullOrEmpty(metroTextBox4.Text) && !string.IsNullOrWhiteSpace(metroTextBox4.Text)
                )
            {
                metroLabel6.Visible = false;
                SqlCommand command = new SqlCommand ("INSERT INTO [Suppliers] (sup_name,sup_adress,sup_phone, sup_info) VALUES (@Name, @Addr, @Phone, @Info)", sqlConnection);
             command.Parameters.AddWithValue("Name", metroTextBox1.Text);
             command.Parameters.AddWithValue("Addr", metroTextBox2.Text);
             command.Parameters.AddWithValue("Phone", metroTextBox3.Text);
             command.Parameters.AddWithValue("Info", metroTextBox4.Text);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
                await command.ExecuteNonQueryAsync();
            }else
            {
                metroLabel6.Visible = true;
            }
            this.Visible = false;
        }
    }
}
