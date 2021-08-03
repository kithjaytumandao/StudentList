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

namespace StudentList
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\Visual_Studio\StudentList\StudentList\Database1.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.listDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'listDataSet.List' table. You can move, or remove it, as needed.
            this.listTableAdapter.Fill(this.listDataSet.List);

        }

        private void listBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
