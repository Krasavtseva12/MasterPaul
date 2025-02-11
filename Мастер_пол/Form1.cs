using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мастер_пол
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол";
        public Form1()
        {
            InitializeComponent();
            comboBoxStatus.Visible = false;
            btnUpdateStatus.Visible = false;
            label1.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void стяжкаИНаливныеПолыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void ламинатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Продукция WHERE Тип = 'Ламинат'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);


                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void партнёрыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выполненыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Заявки WHERE Статус = 'Выполнена'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }
        

        private void созданныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadZayavki();
            
        }
        private void LoadZayavki()
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Заявки WHERE Статус = 'Добавлена'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                            if (dt.Rows.Count > 0)
                            {
                                
                                comboBoxStatus.Visible = true;
                                btnUpdateStatus.Visible = true;
                                label1.Visible = true;
                            }
                            else
                            {
                                
                                comboBoxStatus.Visible = false;
                                btnUpdateStatus.Visible = false;
                                label1.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void отмененныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Заявки WHERE Статус = 'Отменена'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }


        private void оптовикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCompletedOrders2();
        }

        private void LoadCompletedOrders2()
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Партнеры WHERE Тип = 'Оптовик'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);


                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void розничныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Партнеры WHERE Тип = 'Розничный'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);


                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }
        private void ковролинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Продукция WHERE Тип = 'Ковролин'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);


                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void паркетнаяДоскаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Продукция WHERE Тип = 'Паркет'";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);


                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void создатьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void регистрацияПартнёраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegUser regUser = new RegUser();
            regUser.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void складToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Склад ";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int id_Заявки = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id_Заявки"].Value); 
                string newStatus = comboBoxStatus.SelectedItem.ToString(); 

                using (var connection = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Заявки SET Статус = @newStatus WHERE id_Заявки = @id"; // Предположим, что у вас есть столбец Id
                        using (var command = new NpgsqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@newStatus", newStatus);
                            command.Parameters.AddWithValue("@id", id_Заявки);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Статус успешно обновлен.");
                                LoadZayavki(); // Обновляем данные в DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Не удалось обновить статус.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении статуса: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку для изменения статуса.");
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
