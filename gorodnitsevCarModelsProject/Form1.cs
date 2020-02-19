using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorodnitsevCarModelsProject
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\projects\gorodnitsevCarModelsProject\gorodnitsevCarModelsProject\CarModelDb.mdf;Integrated Security=True;Connect Timeout=30");
        int CarID = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (saveButton.Text == "Сохранить")
                {
                    SqlCommand sqlCmd = new SqlCommand("ContactAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@CarID", 0);
                    sqlCmd.Parameters.AddWithValue("@Mark", markText.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Model", modelText.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Avaria", checkAvaraia.Checked);
                    sqlCmd.Parameters.AddWithValue("@Years", yearText.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@BodyType", bodyText.SelectedItem);
                    sqlCmd.Parameters.AddWithValue("@FuelType", fuelText.SelectedItem);
                    sqlCmd.Parameters.AddWithValue("@Price", priceText.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Автомобиль выставлен на продажу");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("ContactAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@CarID", CarID);
                    sqlCmd.Parameters.AddWithValue("@Mark", markText.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Model", modelText.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Avaria", checkAvaraia.Checked);
                    sqlCmd.Parameters.AddWithValue("@Years", yearText.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@BodyType", bodyText.SelectedItem);
                    sqlCmd.Parameters.AddWithValue("@FuelType", fuelText.SelectedItem);
                    sqlCmd.Parameters.AddWithValue("@Price", priceText.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Данные автомабился обновлены");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ContactViewSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@ContactName",0);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;

            sqlCon.Close();
        }

        private void SearchButtonn_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error MEssage");
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carModelDbDataSet.tbl_Cars' table. You can move, or remove it, as needed.
            //this.tbl_CarsTableAdapter.Fill(this.carModelDbDataSet.tbl_Cars);
            FillDataGridView();
            dataGridView1.Columns["Mark"].HeaderText = "Имя";
            dataGridView1.Columns["Model"].HeaderText = "Модель";
            dataGridView1.Columns["Avaria"].HeaderText = "Авария";
            dataGridView1.Columns["Years"].HeaderText = "Год";
            dataGridView1.Columns["BodyType"].HeaderText = "Тип кузова";
            dataGridView1.Columns["FuelType"].HeaderText = "Тип топлива";
            dataGridView1.Columns["Price"].HeaderText = "Цена";
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                CarID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                markText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                modelText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkAvaraia.Checked= false;
                yearText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                bodyText.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                fuelText.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                priceText.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                if (checkAvaraia.Checked==true)
                {
                    checkAvaraia.Text = "Да";
                }
                else
                {
                    checkAvaraia.Text = "Да";
                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("ContactDeletion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@CarID", CarID);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Автомобиль удален или продан");
                Reset();
                FillDataGridView();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        void Reset()
        {
            markText.Text = modelText.Text = yearText.Text = priceText.Text = "";
            checkAvaraia.Checked = false;
            saveButton.Text = "Сохранить";
            CarID = 0;
            deleteButton.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
