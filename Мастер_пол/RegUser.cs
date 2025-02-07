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
    public partial class RegUser : Form
    {
        private string connectionString = "Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол";
        public RegUser()
        {
            InitializeComponent();
        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void labelLastname_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Вставка данных о партнере
                        var cmd = new NpgsqlCommand("INSERT INTO public.Партнеры (Тип, Наименование_Компании, Юридический_Адрес, Физический_Адрес, ИНН, Фамилия_Директора, Имя_Директора, Отчество_Директора, Номер_телефона, email) VALUES (@type, @name, @legalAddress, @physicalAddress, @inn, @lastName, @firstName, @middleName, @phoneNumber, @email) RETURNING id_Партнера;", conn);
                        cmd.Parameters.AddWithValue("type", txtType.Text);
                        cmd.Parameters.AddWithValue("name", txtCompanyName.Text);
                        cmd.Parameters.AddWithValue("legalAddress", txtLegalAddress.Text);
                        cmd.Parameters.AddWithValue("physicalAddress", txtPhysicalAddress.Text);
                        cmd.Parameters.AddWithValue("inn", txtINN.Text);
                        cmd.Parameters.AddWithValue("lastName", txtDirectorLastName.Text);
                        cmd.Parameters.AddWithValue("firstName", txtDirectorFirstName.Text);
                        cmd.Parameters.AddWithValue("middleName", txtDirectorMiddleName.Text);
                        cmd.Parameters.AddWithValue("phoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);

                        // Получаем id_Партнера после вставки
                        int partnerId = (int)cmd.ExecuteScalar();

                        // Вставка данных о доступе
                        var accessCmd = new NpgsqlCommand("INSERT INTO public.Доступ (id_Партнера, Логин, Пароль) VALUES (@partnerId, @login, @password);", conn);

                        accessCmd.Parameters.AddWithValue("partnerId", partnerId);
                        accessCmd.Parameters.AddWithValue("login", txtLogin.Text);
                        accessCmd.Parameters.AddWithValue("password", txtPassword.Text);

                        accessCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Партнер и доступ успешно добавлены!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void RegUser_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
