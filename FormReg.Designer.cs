namespace WinFormsApp1111
{
    partial class FormReg
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
            labelNameReg = new Label();
            textBoxNameReg = new TextBox();
            textBoxSurnameReg = new TextBox();
            labelSurnameReg = new Label();
            textBoxEmailReg = new TextBox();
            labelEmailReg = new Label();
            textBoxLogReg = new TextBox();
            labelLogReg = new Label();
            textBoxPasReg = new TextBox();
            labelPasReg = new Label();
            btnCrtAcc = new Button();
            SuspendLayout();
            // 
            // labelNameReg
            // 
            labelNameReg.AutoSize = true;
            labelNameReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameReg.Location = new Point(29, 45);
            labelNameReg.Name = "labelNameReg";
            labelNameReg.Size = new Size(55, 30);
            labelNameReg.TabIndex = 0;
            labelNameReg.Text = "Имя";
            // 
            // textBoxNameReg
            // 
            textBoxNameReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNameReg.Location = new Point(29, 78);
            textBoxNameReg.Name = "textBoxNameReg";
            textBoxNameReg.Size = new Size(336, 35);
            textBoxNameReg.TabIndex = 1;
            // 
            // textBoxSurnameReg
            // 
            textBoxSurnameReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSurnameReg.Location = new Point(29, 154);
            textBoxSurnameReg.Name = "textBoxSurnameReg";
            textBoxSurnameReg.Size = new Size(336, 35);
            textBoxSurnameReg.TabIndex = 3;
            // 
            // labelSurnameReg
            // 
            labelSurnameReg.AutoSize = true;
            labelSurnameReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSurnameReg.Location = new Point(29, 121);
            labelSurnameReg.Name = "labelSurnameReg";
            labelSurnameReg.Size = new Size(100, 30);
            labelSurnameReg.TabIndex = 2;
            labelSurnameReg.Text = "Фамилия";
            // 
            // textBoxEmailReg
            // 
            textBoxEmailReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmailReg.Location = new Point(29, 234);
            textBoxEmailReg.Name = "textBoxEmailReg";
            textBoxEmailReg.Size = new Size(336, 35);
            textBoxEmailReg.TabIndex = 5;
            // 
            // labelEmailReg
            // 
            labelEmailReg.AutoSize = true;
            labelEmailReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEmailReg.Location = new Point(29, 201);
            labelEmailReg.Name = "labelEmailReg";
            labelEmailReg.Size = new Size(72, 30);
            labelEmailReg.TabIndex = 4;
            labelEmailReg.Text = "Почта";
            // 
            // textBoxLogReg
            // 
            textBoxLogReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogReg.Location = new Point(29, 317);
            textBoxLogReg.Name = "textBoxLogReg";
            textBoxLogReg.Size = new Size(336, 35);
            textBoxLogReg.TabIndex = 7;
            // 
            // labelLogReg
            // 
            labelLogReg.AutoSize = true;
            labelLogReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogReg.Location = new Point(29, 284);
            labelLogReg.Name = "labelLogReg";
            labelLogReg.Size = new Size(71, 30);
            labelLogReg.TabIndex = 6;
            labelLogReg.Text = "Логин";
            // 
            // textBoxPasReg
            // 
            textBoxPasReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPasReg.Location = new Point(29, 397);
            textBoxPasReg.Name = "textBoxPasReg";
            textBoxPasReg.Size = new Size(336, 35);
            textBoxPasReg.TabIndex = 9;
            // 
            // labelPasReg
            // 
            labelPasReg.AutoSize = true;
            labelPasReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPasReg.Location = new Point(29, 364);
            labelPasReg.Name = "labelPasReg";
            labelPasReg.Size = new Size(85, 30);
            labelPasReg.TabIndex = 8;
            labelPasReg.Text = "Пароль";
            // 
            // btnCrtAcc
            // 
            btnCrtAcc.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtAcc.Location = new Point(29, 457);
            btnCrtAcc.Name = "btnCrtAcc";
            btnCrtAcc.Size = new Size(336, 52);
            btnCrtAcc.TabIndex = 10;
            btnCrtAcc.Text = "Создать аккаунт";
            btnCrtAcc.UseVisualStyleBackColor = true;
            btnCrtAcc.Click += btnCrtAcc_Click;
            // 
            // FormReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 521);
            Controls.Add(btnCrtAcc);
            Controls.Add(textBoxPasReg);
            Controls.Add(labelPasReg);
            Controls.Add(textBoxLogReg);
            Controls.Add(labelLogReg);
            Controls.Add(textBoxEmailReg);
            Controls.Add(labelEmailReg);
            Controls.Add(textBoxSurnameReg);
            Controls.Add(labelSurnameReg);
            Controls.Add(textBoxNameReg);
            Controls.Add(labelNameReg);
            Name = "FormReg";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameReg;
        private TextBox textBoxNameReg;
        private TextBox textBoxSurnameReg;
        private Label labelSurnameReg;
        private TextBox textBoxEmailReg;
        private Label labelEmailReg;
        private TextBox textBoxLogReg;
        private Label labelLogReg;
        private TextBox textBoxPasReg;
        private Label labelPasReg;
        private Button btnCrtAcc;
    }
}