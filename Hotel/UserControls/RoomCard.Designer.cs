namespace Hotel.Forms
{
    partial class RoomCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumber = new Label();
            lblStatus = new Label();
            lblType = new Label();
            lblFloor = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(13, 45);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(57, 20);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Номер";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(240, 17);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "статут";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(13, 17);
            lblType.Name = "lblType";
            lblType.Size = new Size(33, 20);
            lblType.TabIndex = 2;
            lblType.Text = "тип";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(119, 45);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(41, 20);
            lblFloor.TabIndex = 3;
            lblFloor.Text = "этаж";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(240, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Цена";
            // 
            // RoomCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(lblFloor);
            Controls.Add(lblType);
            Controls.Add(lblStatus);
            Controls.Add(lblNumber);
            Name = "RoomCard";
            Size = new Size(332, 114);
            Click += RoomCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber;
        private Label lblStatus;
        private Label lblType;
        private Label lblFloor;
        private Label lblPrice;
    }
}
