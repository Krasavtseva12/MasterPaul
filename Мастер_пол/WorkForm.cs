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
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

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


        private void складToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void WorkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
