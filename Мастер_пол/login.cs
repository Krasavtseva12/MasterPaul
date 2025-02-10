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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол"))
            {
                connect.Open();

                // Проверка учетных данных и получение id_Сотрудника
                int employeeId = -1;
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id_Сотрудника FROM Доступ WHERE Логин = @useremail AND Пароль = @userpassword", connect))
                {
                    command.Parameters.AddWithValue("useremail", email);
                    command.Parameters.AddWithValue("userpassword", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = reader.GetInt32(0); // Получаем id_Сотрудника
                        }
                        else
                        {
                            MessageBox.Show("Неверные учетные данные");
                            return;
                        }
                    }
                }
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT Наименование_Должности, Допуск_К_Работе FROM Должность WHERE id_Сотрудника = @employeeId", connect))
                {
                    command.Parameters.AddWithValue("employeeId", employeeId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string positionName = reader.GetString(0);
                            string accessLevel = reader.GetString(1);
                            ShowAppropriateForm(accessLevel);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить информацию о должности.");
                        }
                    }
                }
            }
        }

        private void ShowAppropriateForm(string accessLevel)
        {
            if (accessLevel.Equals("Уровень 1", StringComparison.OrdinalIgnoreCase))
            {

            }
            else if (accessLevel.Equals("Уровень 2", StringComparison.OrdinalIgnoreCase))
            {

            }
            else if (accessLevel.Equals("Уровень 3", StringComparison.OrdinalIgnoreCase))
            {
                var Form1 = new Form1();
                Form1.Show();
            }
            else if (accessLevel.Equals("Уровень 4", StringComparison.OrdinalIgnoreCase))
            {

            }
            else
            {
                MessageBox.Show("Неизвестный уровень доступа.");
            }

            this.Hide(); // Скрыть форму входа
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
