﻿namespace Мастер_пол
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpPrepaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.txtPrepaymentAmount = new System.Windows.Forms.TextBox();
            this.txtIdPartner = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(269, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "▄︻デСоздание заявки══━一";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpPrepaymentDate);
            this.panel1.Controls.Add(this.dtpCreationDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelLastname);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.txtPrepaymentAmount);
            this.panel1.Controls.Add(this.txtIdPartner);
            this.panel1.Location = new System.Drawing.Point(64, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 465);
            this.panel1.TabIndex = 4;
            // 
            // dtpPrepaymentDate
            // 
            this.dtpPrepaymentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPrepaymentDate.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtpPrepaymentDate.Location = new System.Drawing.Point(457, 282);
            this.dtpPrepaymentDate.Name = "dtpPrepaymentDate";
            this.dtpPrepaymentDate.Size = new System.Drawing.Size(352, 22);
            this.dtpPrepaymentDate.TabIndex = 19;
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpCreationDate.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtpCreationDate.Location = new System.Drawing.Point(457, 221);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(352, 22);
            this.dtpCreationDate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата Предоплаты";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(457, 393);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(361, 52);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(50, 393);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(342, 52);
            this.buttonRegister.TabIndex = 14;
            this.buttonRegister.Text = "Создание ";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(44, 148);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(326, 36);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Сумма Предоплаты";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastname.Location = new System.Drawing.Point(44, 271);
            this.labelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(373, 36);
            this.labelLastname.TabIndex = 10;
            this.labelLastname.Text = "Дата Создания Заявки";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.AliceBlue;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(44, 80);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(296, 36);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Ваш индефикатор";
            // 
            // txtPrepaymentAmount
            // 
            this.txtPrepaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrepaymentAmount.Location = new System.Drawing.Point(457, 148);
            this.txtPrepaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrepaymentAmount.Name = "txtPrepaymentAmount";
            this.txtPrepaymentAmount.Size = new System.Drawing.Size(352, 41);
            this.txtPrepaymentAmount.TabIndex = 5;
            // 
            // txtIdPartner
            // 
            this.txtIdPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdPartner.Location = new System.Drawing.Point(457, 80);
            this.txtIdPartner.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPartner.Name = "txtIdPartner";
            this.txtIdPartner.Size = new System.Drawing.Size(352, 41);
            this.txtIdPartner.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1010, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "𝑀𝒶𝓈𝓉𝑒𝓇 𝓅𝑜𝓁";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpPrepaymentDate;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox txtPrepaymentAmount;
        private System.Windows.Forms.TextBox txtIdPartner;
    }
}