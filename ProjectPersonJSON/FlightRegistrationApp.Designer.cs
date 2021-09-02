
namespace ProjectPersonJSON
{
    partial class FlightRegistrationApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUser = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SexText = new System.Windows.Forms.ComboBox();
            this.WhereText = new System.Windows.Forms.ComboBox();
            this.FromText = new System.Windows.Forms.ComboBox();
            this.DateTwoText = new System.Windows.Forms.DateTimePicker();
            this.DateOneText = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.NumberPassangerText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ValidityText = new System.Windows.Forms.DateTimePicker();
            this.NumberPasText = new System.Windows.Forms.TextBox();
            this.CitizenshipText = new System.Windows.Forms.ComboBox();
            this.DateBirthText = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.MiddleNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderCompleted = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.btnSetialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUser
            // 
            this.listUser.HideSelection = false;
            this.listUser.Location = new System.Drawing.Point(26, 44);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(121, 97);
            this.listUser.TabIndex = 0;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.View = System.Windows.Forms.View.List;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SexText);
            this.panel1.Controls.Add(this.WhereText);
            this.panel1.Controls.Add(this.FromText);
            this.panel1.Controls.Add(this.DateTwoText);
            this.panel1.Controls.Add(this.DateOneText);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.NumberPassangerText);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ValidityText);
            this.panel1.Controls.Add(this.NumberPasText);
            this.panel1.Controls.Add(this.CitizenshipText);
            this.panel1.Controls.Add(this.DateBirthText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MiddleNameText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OrderCompleted);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Controls.Add(this.EmailText);
            this.panel1.Controls.Add(this.SurnameText);
            this.panel1.Location = new System.Drawing.Point(172, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 265);
            this.panel1.TabIndex = 1;
            // 
            // SexText
            // 
            this.SexText.FormattingEnabled = true;
            this.SexText.Location = new System.Drawing.Point(6, 51);
            this.SexText.Name = "SexText";
            this.SexText.Size = new System.Drawing.Size(63, 21);
            this.SexText.TabIndex = 37;
            // 
            // WhereText
            // 
            this.WhereText.FormattingEnabled = true;
            this.WhereText.Location = new System.Drawing.Point(215, 191);
            this.WhereText.Name = "WhereText";
            this.WhereText.Size = new System.Drawing.Size(97, 21);
            this.WhereText.TabIndex = 36;
            this.WhereText.Enter += new System.EventHandler(this.comboBox4_Enter);
            this.WhereText.Leave += new System.EventHandler(this.comboBox4_Leave);
            // 
            // FromText
            // 
            this.FromText.FormattingEnabled = true;
            this.FromText.Location = new System.Drawing.Point(109, 191);
            this.FromText.Name = "FromText";
            this.FromText.Size = new System.Drawing.Size(97, 21);
            this.FromText.TabIndex = 35;
            this.FromText.Enter += new System.EventHandler(this.comboBox3_Enter);
            this.FromText.Leave += new System.EventHandler(this.comboBox3_Leave);
            // 
            // DateTwoText
            // 
            this.DateTwoText.Location = new System.Drawing.Point(432, 192);
            this.DateTwoText.Name = "DateTwoText";
            this.DateTwoText.Size = new System.Drawing.Size(108, 20);
            this.DateTwoText.TabIndex = 32;
            // 
            // DateOneText
            // 
            this.DateOneText.Location = new System.Drawing.Point(318, 192);
            this.DateOneText.Name = "DateOneText";
            this.DateOneText.Size = new System.Drawing.Size(108, 20);
            this.DateOneText.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Passenger number";
            // 
            // NumberPassangerText
            // 
            this.NumberPassangerText.Enabled = false;
            this.NumberPassangerText.Location = new System.Drawing.Point(6, 192);
            this.NumberPassangerText.Name = "NumberPassangerText";
            this.NumberPassangerText.Size = new System.Drawing.Size(97, 20);
            this.NumberPassangerText.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "The validity of the passport";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Citizenship ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Gender";
            // 
            // ValidityText
            // 
            this.ValidityText.Location = new System.Drawing.Point(334, 123);
            this.ValidityText.Name = "ValidityText";
            this.ValidityText.Size = new System.Drawing.Size(139, 20);
            this.ValidityText.TabIndex = 16;
            // 
            // NumberPasText
            // 
            this.NumberPasText.Location = new System.Drawing.Point(243, 122);
            this.NumberPasText.Name = "NumberPasText";
            this.NumberPasText.Size = new System.Drawing.Size(74, 20);
            this.NumberPasText.TabIndex = 15;
            this.NumberPasText.Enter += new System.EventHandler(this.textBox2_Enter);
            this.NumberPasText.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // CitizenshipText
            // 
            this.CitizenshipText.FormattingEnabled = true;
            this.CitizenshipText.Location = new System.Drawing.Point(138, 121);
            this.CitizenshipText.Name = "CitizenshipText";
            this.CitizenshipText.Size = new System.Drawing.Size(89, 21);
            this.CitizenshipText.TabIndex = 13;
            this.CitizenshipText.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.CitizenshipText.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // DateBirthText
            // 
            this.DateBirthText.Location = new System.Drawing.Point(6, 122);
            this.DateBirthText.Name = "DateBirthText";
            this.DateBirthText.Size = new System.Drawing.Size(117, 20);
            this.DateBirthText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Middle Name (if you have)";
            // 
            // MiddleNameText
            // 
            this.MiddleNameText.Location = new System.Drawing.Point(300, 52);
            this.MiddleNameText.Name = "MiddleNameText";
            this.MiddleNameText.Size = new System.Drawing.Size(128, 20);
            this.MiddleNameText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Surname";
            // 
            // OrderCompleted
            // 
            this.OrderCompleted.AutoSize = true;
            this.OrderCompleted.Location = new System.Drawing.Point(378, 236);
            this.OrderCompleted.Name = "OrderCompleted";
            this.OrderCompleted.Size = new System.Drawing.Size(76, 17);
            this.OrderCompleted.TabIndex = 5;
            this.OrderCompleted.Text = "Completed";
            this.OrderCompleted.UseVisualStyleBackColor = true;
            this.OrderCompleted.CheckedChanged += new System.EventHandler(this.OrderCompleted_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(460, 232);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Buy";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(191, 52);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 4;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(440, 51);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 20);
            this.EmailText.TabIndex = 3;
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(82, 52);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(100, 20);
            this.SurnameText.TabIndex = 0;
            // 
            // btnSetialize
            // 
            this.btnSetialize.Location = new System.Drawing.Point(91, 172);
            this.btnSetialize.Name = "btnSetialize";
            this.btnSetialize.Size = new System.Drawing.Size(75, 23);
            this.btnSetialize.TabIndex = 0;
            this.btnSetialize.Text = "Serialize";
            this.btnSetialize.UseVisualStyleBackColor = true;
            this.btnSetialize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(10, 172);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize.TabIndex = 2;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "JSON to XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "JSON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "XML";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Passengers";
            // 
            // FlightRegistrationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 299);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSetialize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightRegistrationApp";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetialize;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox OrderCompleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ValidityText;
        private System.Windows.Forms.TextBox NumberPasText;
        private System.Windows.Forms.ComboBox CitizenshipText;
        private System.Windows.Forms.DateTimePicker DateBirthText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MiddleNameText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateTwoText;
        private System.Windows.Forms.DateTimePicker DateOneText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NumberPassangerText;
        private System.Windows.Forms.ComboBox WhereText;
        private System.Windows.Forms.ComboBox FromText;
        private System.Windows.Forms.ComboBox SexText;
        private System.Windows.Forms.Label label12;
    }
}

