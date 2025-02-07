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

                int? employeeId = null; // Используем nullable int для id_Сотрудника

                // Получаем id_Сотрудника по логину и паролю
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id_Сотрудника FROM Доступ WHERE Логин = @useremail AND Пароль = @userpassword", connect))
                {
                    command.Parameters.AddWithValue("useremail", email);
                    command.Parameters.AddWithValue("userpassword", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = reader.IsDBNull(0) ? (int?)null : reader.GetInt32(0); // Получаем id_Сотрудника или null
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                            return;
                        }
                    }
                }

                // Проверяем значение id_Сотрудника
                if (employeeId.HasValue)
                {
                    // Если id_Сотрудника не равен NULL, проверяем уровень доступа
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT Наименование_Должности, Допуск_К_Работе FROM Должность WHERE id_Сотрудника = @employeeId", connect))
                    {
                        command.Parameters.AddWithValue("employeeId", employeeId.Value);

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
                else
                {
                    // Если id_Сотрудника равен NULL, переходим на форму UserForn
                    var userForm = new UserForn();
                    userForm.Show();
                    this.Hide(); // Скрыть форму входа
                }
            }
        }

        private void ShowAppropriateForm(string accessLevel)
        {
            if (accessLevel.Equals("Уровень 1", StringComparison.OrdinalIgnoreCase))
            {
                // Логика для уровня 1
            }
            else if (accessLevel.Equals("Уровень 2", StringComparison.OrdinalIgnoreCase))
            {
                WorkForm workForm = new WorkForm(); 
                workForm.Show();
            }
            else if (accessLevel.Equals("Уровень 3", StringComparison.OrdinalIgnoreCase))
            {
                var form1 = new Form1();
                form1.Show();
            }
            else if (accessLevel.Equals("Уровень 4", StringComparison.OrdinalIgnoreCase))
            {
                // Логика для уровня 4
            }
            else
            {
                // Логика для других уровней
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

        private void button1_Click(object sender, EventArgs e)
        {
            RegUser regUser = new RegUser();
            regUser.Show();
            this.Hide();

        }
    }
}
