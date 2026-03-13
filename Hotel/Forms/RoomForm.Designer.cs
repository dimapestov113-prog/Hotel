namespace Hotel.Forms
{
    partial class RoomForm
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ButtonSave = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(104, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 43);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Заезд";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 76);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "Выезд";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 110);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 10;
            label6.Text = "Цена:";
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(222, 106);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 13;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 4);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 15;
            label1.Text = "Пользователь";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 16;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 147);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(ButtonSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "RoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button ButtonSave;
        private Label label1;
        private ComboBox comboBox1;
    }
}