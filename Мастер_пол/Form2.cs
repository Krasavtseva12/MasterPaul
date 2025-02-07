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
    public partial class Form2 : Form
    {
        private string connectionString = "Host=localhost; Port=5433; Username=postgres; Password=qwerty; Database=Мастер_пол";
        public Form2()
        {
            InitializeComponent();
        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        private void labelLastname_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO public.Заявки (id_Партнера, id_Сотрудника, Дата_Создания_Заявки, Дата_Предоплаты, Сумма_предоплаты, Статус) VALUES (@partnerId, @employeeId, @creationDate, @prepaymentDate, @prepaymentAmount, @status)", conn))
                {
                    cmd.Parameters.AddWithValue("partnerId", int.Parse(txtIdPartner.Text));
                    cmd.Parameters.AddWithValue("employeeId", int.Parse(txtIdEmployee.Text));
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }
    }
}
