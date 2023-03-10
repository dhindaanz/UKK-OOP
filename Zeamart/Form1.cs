using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Zeamart
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = pbo");
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataPBO();

            btn_save.Enabled = false;
            tb_id.Enabled = false;
        }

        public DataTable getDataPBO()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM zeamart", connection))
            {
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void fillDataPBO()
        {
            dgv_zeamart.DataSource = getDataPBO();

            DataGridViewButtonColumn colEditZea = new DataGridViewButtonColumn();
            colEditZea.UseColumnTextForButtonValue = true;
            colEditZea.Text = "Edit";
            colEditZea.Name = "";
            dgv_zeamart.Columns.Add(colEditZea);

            DataGridViewButtonColumn colDelZea = new DataGridViewButtonColumn();
            colDelZea.UseColumnTextForButtonValue = true;
            colDelZea.Text = "Delete";
            colDelZea.Name = "";
            dgv_zeamart.Columns.Add(colDelZea);

            connection.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO zeamart(item, descriptions, amount, price) VALUE (@item, @descriptions, @amount, @price)";
                cmd.Parameters.AddWithValue("@item", tb_item.Text);
                cmd.Parameters.AddWithValue("@descriptions", tb_desc.Text);
                cmd.Parameters.AddWithValue("@amount", tb_amnt.Text);
                cmd.Parameters.AddWithValue("@price", tb_price.Text);
                cmd.ExecuteNonQuery();
                dgv_zeamart.Columns.Clear();
                dataTable.Clear();
                connection.Close();

                fillDataPBO();
            }catch (Exception ex)
            {

            }
        }

        private void dgv_zeamart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dgv_zeamart.CurrentCell.RowIndex.ToString());
                tb_id.Text = dgv_zeamart.Rows[id].Cells[0].Value.ToString();
                tb_item.Text = dgv_zeamart.Rows[id].Cells[1].Value.ToString();
                tb_desc.Text = dgv_zeamart.Rows[id].Cells[2].Value.ToString();
                tb_amnt.Text = dgv_zeamart.Rows[id].Cells[3].Value.ToString();
                tb_price.Text = dgv_zeamart.Rows[id].Cells[4].Value.ToString();

                btn_save.Enabled = true;
            }

            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dgv_zeamart.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM zeamart WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dgv_zeamart.Rows[id].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dgv_zeamart.Columns.Clear();
                    dataTable.Clear();
                    connection.Close();

                    fillDataPBO();
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE zeamart SET item = @item, descriptions = @descriptions, amount = @amount, price = @price WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@item", tb_item.Text);
                cmd.Parameters.AddWithValue("@descriptions", tb_desc.Text);
                cmd.Parameters.AddWithValue("@amount", tb_amnt.Text);
                cmd.Parameters.AddWithValue("@price", tb_price.Text);
                cmd.ExecuteNonQuery();
                dgv_zeamart.Columns.Clear();
                dataTable.Clear();
                connection.Close();

                fillDataPBO();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
