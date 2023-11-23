namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TBLogIn = new TextBox();
            TBPassIn = new TextBox();
            label2 = new Label();
            btnIn = new Button();
            btnCrtAcc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 68);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // TBLogIn
            // 
            TBLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBLogIn.Location = new Point(52, 101);
            TBLogIn.Name = "TBLogIn";
            TBLogIn.Size = new Size(299, 35);
            TBLogIn.TabIndex = 1;
            // 
            // TBPassIn
            // 
            TBPassIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBPassIn.Location = new Point(52, 234);
            TBPassIn.Name = "TBPassIn";
            TBPassIn.PasswordChar = '*';
            TBPassIn.Size = new Size(299, 35);
            TBPassIn.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(52, 201);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnIn.Location = new Point(131, 293);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(152, 68);
            btnIn.TabIndex = 4;
            btnIn.Text = "Войти";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnCrtAcc
            // 
            btnCrtAcc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtAcc.Location = new Point(131, 378);
            btnCrtAcc.Name = "btnCrtAcc";
            btnCrtAcc.Size = new Size(152, 45);
            btnCrtAcc.TabIndex = 5;
            btnCrtAcc.Text = "Создать аккаунт";
            btnCrtAcc.UseVisualStyleBackColor = true;
            btnCrtAcc.Click += btnCrtAcc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 435);
            Controls.Add(btnCrtAcc);
            Controls.Add(btnIn);
            Controls.Add(TBPassIn);
            Controls.Add(label2);
            Controls.Add(TBLogIn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBLogIn;
        private TextBox TBPassIn;
        private Label label2;
        private Button btnIn;
        private Button btnCrtAcc;
    }
}
