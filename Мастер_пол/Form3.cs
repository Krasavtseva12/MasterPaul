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
    public partial class Form3 : Form
    {
        private string connectionString = "Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол";
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO public.Заявки (id_Партнера, Дата_Создания_Заявки, Дата_Предоплаты, Сумма_предоплаты, Статус) VALUES (@partnerId, @creationDate, @prepaymentDate, @prepaymentAmount, @status)", conn))
                {
                    cmd.Parameters.AddWithValue("partnerId", int.Parse(txtIdPartner.Text));
                    cmd.Parameters.AddWithValue("creationDate", dtpCreationDate.Value);
                    cmd.Parameters.AddWithValue("prepaymentDate", dtpPrepaymentDate.Value);
                    cmd.Parameters.AddWithValue("prepaymentAmount", decimal.Parse(txtPrepaymentAmount.Text));
                    cmd.Parameters.AddWithValue("status", "Добавлена");

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Заявка успешно создана!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserForn userForn = new UserForn();
            userForn.Show();
            this.Hide();
        }
    }
}
