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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        
        public Main()
        {      
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AddSupplier Supplier = new AddSupplier();
            Supplier.Show();
        }

        private void Add_Import_Click(object sender, EventArgs e)
        {
            Add_Import Supplier = new Add_Import();
            Supplier.Show();

        }
    }
}
