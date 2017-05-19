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
using System.Globalization;

namespace diplom
{
    public partial class Add_Import : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;

        public Add_Import()
        {
            InitializeComponent();
        }

        private async void Add_Import_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storacDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.storacDataSet.Suppliers);
            string connectionString = @"Data Source=DESKTOP-V3J850P;Initial Catalog=Storac;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        

        private async void metroTile1_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            if (!string.IsNullOrEmpty(metroTextBox1.Text) && !string.IsNullOrWhiteSpace(metroTextBox1.Text) &&
                !string.IsNullOrEmpty(metroTextBox2.Text) && !string.IsNullOrWhiteSpace(metroTextBox2.Text)                
                )
            {
                try
                {

                
                SqlCommand command = new SqlCommand("INSERT INTO [Import] (sup_name,i_code,i_quanity,i_date) VALUES (@Name, @Code, @Quanity, @Date)", sqlConnection);
                command.Parameters.AddWithValue("Name", metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem));
                command.Parameters.AddWithValue("Code", metroTextBox1.Text);
                command.Parameters.AddWithValue("Quanity", metroTextBox2.Text);
                command.Parameters.AddWithValue("Date", localDate.ToString());

                metroTextBox1.Text = "";
                metroTextBox2.Text = "";

                    await command.ExecuteNonQueryAsync();
                }
                catch
                {

                }
                
            }
            else
            {
                
            }
            this.Visible = false;
        }

        
    }
}
