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

                            // Предположим, у вас есть DataGridView на форме с именем dataGridView1
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
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void отмененныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCompletedOrders1();
        }
        private void LoadCompletedOrders1()
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
    }
    
}
