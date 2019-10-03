namespace ProjectWS1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panelError = new System.Windows.Forms.Panel();
            this.linkRegin = new System.Windows.Forms.LinkLabel();
            this.linkAuto = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelReginDone = new System.Windows.Forms.Panel();
            this.linkAutho = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelreg = new System.Windows.Forms.Panel();
            this.lblErrorRow = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btn_show2 = new System.Windows.Forms.Button();
            this.btn_show1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Top.SuspendLayout();
            this.panelError.SuspendLayout();
            this.panelReginDone.SuspendLayout();
            this.panelreg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.BlueViolet;
            this.pnl_Top.Controls.Add(this.btn_close);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(963, 35);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(922, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(41, 35);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.linkRegin);
            this.panelError.Controls.Add(this.linkAuto);
            this.panelError.Controls.Add(this.label1);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelError.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelError.Location = new System.Drawing.Point(0, 35);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(963, 465);
            this.panelError.TabIndex = 1;
            // 
            // linkRegin
            // 
            this.linkRegin.AutoSize = true;
            this.linkRegin.LinkColor = System.Drawing.Color.Indigo;
            this.linkRegin.Location = new System.Drawing.Point(556, 224);
            this.linkRegin.Name = "linkRegin";
            this.linkRegin.Size = new System.Drawing.Size(183, 23);
            this.linkRegin.TabIndex = 9;
            this.linkRegin.TabStop = true;
            this.linkRegin.Text = "Повторить попытку";
            // 
            // linkAuto
            // 
            this.linkAuto.AutoSize = true;
            this.linkAuto.LinkColor = System.Drawing.Color.Indigo;
            this.linkAuto.Location = new System.Drawing.Point(223, 224);
            this.linkAuto.Name = "linkAuto";
            this.linkAuto.Size = new System.Drawing.Size(203, 23);
            this.linkAuto.TabIndex = 9;
            this.linkAuto.TabStop = true;
            this.linkAuto.Text = "<-- Окно авторизации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "При регистрации произошла ошибка, пожалуйста перейдите в окно авторизации или пов" +
    "торите попытку.";
            // 
            // panelReginDone
            // 
            this.panelReginDone.Controls.Add(this.linkAutho);
            this.panelReginDone.Controls.Add(this.label2);
            this.panelReginDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReginDone.Location = new System.Drawing.Point(0, 35);
            this.panelReginDone.Name = "panelReginDone";
            this.panelReginDone.Size = new System.Drawing.Size(963, 465);
            this.panelReginDone.TabIndex = 10;
            // 
            // linkAutho
            // 
            this.linkAutho.AutoSize = true;
            this.linkAutho.LinkColor = System.Drawing.Color.Indigo;
            this.linkAutho.Location = new System.Drawing.Point(394, 251);
            this.linkAutho.Name = "linkAutho";
            this.linkAutho.Size = new System.Drawing.Size(174, 19);
            this.linkAutho.TabIndex = 10;
            this.linkAutho.TabStop = true;
            this.linkAutho.Text = "<-- Окно авторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(149, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = " Регистрация прошла успешно! Пожалйста, вернитесь в окно авторизации.";
            // 
            // panelreg
            // 
            this.panelreg.Controls.Add(this.lblErrorRow);
            this.panelreg.Controls.Add(this.lblError);
            this.panelreg.Controls.Add(this.btn_show2);
            this.panelreg.Controls.Add(this.btn_show1);
            this.panelreg.Controls.Add(this.btn_back);
            this.panelreg.Controls.Add(this.btn_done);
            this.panelreg.Controls.Add(this.txt_phone);
            this.panelreg.Controls.Add(this.cmbgender);
            this.panelreg.Controls.Add(this.panel7);
            this.panelreg.Controls.Add(this.panel4);
            this.panelreg.Controls.Add(this.panel6);
            this.panelreg.Controls.Add(this.panel3);
            this.panelreg.Controls.Add(this.panel5);
            this.panelreg.Controls.Add(this.panel2);
            this.panelreg.Controls.Add(this.panel1);
            this.panelreg.Controls.Add(this.txt_confirmpassword);
            this.panelreg.Controls.Add(this.label9);
            this.panelreg.Controls.Add(this.label6);
            this.panelreg.Controls.Add(this.txtpassword);
            this.panelreg.Controls.Add(this.label8);
            this.panelreg.Controls.Add(this.label5);
            this.panelreg.Controls.Add(this.txtusername);
            this.panelreg.Controls.Add(this.label7);
            this.panelreg.Controls.Add(this.txt_surname);
            this.panelreg.Controls.Add(this.label4);
            this.panelreg.Controls.Add(this.txt_name);
            this.panelreg.Controls.Add(this.label10);
            this.panelreg.Controls.Add(this.label3);
            this.panelreg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelreg.Location = new System.Drawing.Point(0, 35);
            this.panelreg.Name = "panelreg";
            this.panelreg.Size = new System.Drawing.Size(963, 465);
            this.panelreg.TabIndex = 10;
            // 
            // lblErrorRow
            // 
            this.lblErrorRow.AutoSize = true;
            this.lblErrorRow.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRow.Location = new System.Drawing.Point(12, 41);
            this.lblErrorRow.Name = "lblErrorRow";
            this.lblErrorRow.Size = new System.Drawing.Size(0, 19);
            this.lblErrorRow.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(525, 202);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 7;
            // 
            // btn_show2
            // 
            this.btn_show2.BackColor = System.Drawing.Color.White;
            this.btn_show2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show2.FlatAppearance.BorderSize = 0;
            this.btn_show2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_show2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show2.ForeColor = System.Drawing.Color.White;
            this.btn_show2.Image = ((System.Drawing.Image)(resources.GetObject("btn_show2.Image")));
            this.btn_show2.Location = new System.Drawing.Point(814, 310);
            this.btn_show2.Name = "btn_show2";
            this.btn_show2.Size = new System.Drawing.Size(40, 28);
            this.btn_show2.TabIndex = 6;
            this.btn_show2.UseVisualStyleBackColor = false;
            // 
            // btn_show1
            // 
            this.btn_show1.BackColor = System.Drawing.Color.White;
            this.btn_show1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show1.FlatAppearance.BorderSize = 0;
            this.btn_show1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_show1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show1.ForeColor = System.Drawing.Color.White;
            this.btn_show1.Image = ((System.Drawing.Image)(resources.GetObject("btn_show1.Image")));
            this.btn_show1.Location = new System.Drawing.Point(814, 246);
            this.btn_show1.Name = "btn_show1";
            this.btn_show1.Size = new System.Drawing.Size(40, 28);
            this.btn_show1.TabIndex = 6;
            this.btn_show1.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(348, 391);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 29);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(497, 391);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(117, 29);
            this.btn_done.TabIndex = 5;
            this.btn_done.Text = "Готово";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.Btn_done_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Location = new System.Drawing.Point(161, 262);
            this.txt_phone.Mask = "+7 (999) 999-99999";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(279, 20);
            this.txt_phone.TabIndex = 4;
            // 
            // cmbgender
            // 
            this.cmbgender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Не выбрано",
            "Муж",
            "Жен"});
            this.cmbgender.Location = new System.Drawing.Point(161, 194);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(279, 27);
            this.cmbgender.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Indigo;
            this.panel7.Location = new System.Drawing.Point(529, 331);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(279, 5);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(162, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 5);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(529, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 5);
            this.panel6.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(161, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(162, 352);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 5);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(345, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 5);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(345, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 5);
            this.panel1.TabIndex = 2;
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmpassword.Location = new System.Drawing.Point(529, 310);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(279, 20);
            this.txt_confirmpassword.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Подтвердите пароль*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Номер телеона*:";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Location = new System.Drawing.Point(529, 255);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(279, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Пароль*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пол*:";
            // 
            // txtusername
            // 
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Location = new System.Drawing.Point(162, 331);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(279, 20);
            this.txtusername.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Имя пользователя*:";
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(345, 107);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(279, 20);
            this.txt_surname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Фамилия*:";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(345, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(279, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Поля отмеченные (*) - обязательны.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя*:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 500);
            this.Controls.Add(this.panelreg);
            this.Controls.Add(this.panelReginDone);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnl_Top.ResumeLayout(false);
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.panelReginDone.ResumeLayout(false);
            this.panelReginDone.PerformLayout();
            this.panelreg.ResumeLayout(false);
            this.panelreg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRegin;
        private System.Windows.Forms.LinkLabel linkAuto;
        private System.Windows.Forms.Panel panelReginDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkAutho;
        private System.Windows.Forms.Panel panelreg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.MaskedTextBox txt_phone;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_show1;
        private System.Windows.Forms.Button btn_show2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorRow;
    }
}