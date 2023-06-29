using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LTS2.Repository;
using LTS2.Models;

namespace LTS2.Forms
{
    public partial class FormWarehouse : Form
    {

        WarehouseRepository warehouseRepository = new WarehouseRepository();
        Warehouse warehouse = new Warehouse();
        private MySqlDataAdapter da = null;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();  
        private MySqlCommand cmd;

        public FormWarehouse()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "ID";
            this.dataGridView1.Columns[1].Name = "Code";
            this.dataGridView1.Columns[2].Name = "Name";
            this.dataGridView1.Columns[3].Name = "Description";

            this.initDatas();
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            
        }

        private void clearForm()
        {
            code.Text = "";
            name.Text = "";
            description.Text = "";
        }

        private void initDatas()
        {
            //List<Warehouse> warehouseList = warehouseRepository.getAll();       
            this.dataGridView1.Rows.Clear();
            this.dt.Rows.Clear();
            string query = "SELECT * FROM Warehouse;";
            this.cmd = new MySqlCommand(query, Program.con);
            this.da = new MySqlDataAdapter(cmd);
            this.da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                this.dataGridView1.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                warehouse = new Warehouse(code.Text, name.Text, description.Text);
                warehouseRepository.save(warehouse);
                
                MessageBox.Show("Magasin enregistré.");
                warehouse = new Warehouse();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            this.clearForm();
            this.initDatas();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            warehouse = new Warehouse(
                long.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(), 
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString());

            code.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            description.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            warehouse = new Warehouse();
            this.clearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            warehouse.code = code.Text;
            warehouse.name = name.Text;
            warehouse.description = description.Text;
            warehouseRepository.update(warehouse);

            MessageBox.Show("Magasin enregistré.");
            warehouse = new Warehouse();
            this.clearForm();
            this.initDatas();
        }
    }
}
