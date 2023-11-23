namespace WinFormsApp1
{
    partial class AccountForm
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
            label1 = new Label();
            TBAccName = new TextBox();
            TBBalance = new TextBox();
            label2 = new Label();
            TBAccType = new TextBox();
            label3 = new Label();
            TBOpDate = new TextBox();
            label4 = new Label();
            btnCrtAcc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(42, 61);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Название счета";
            // 
            // TBAccName
            // 
            TBAccName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBAccName.Location = new Point(42, 105);
            TBAccName.Name = "TBAccName";
            TBAccName.Size = new Size(248, 33);
            TBAccName.TabIndex = 1;
            // 
            // TBBalance
            // 
            TBBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBBalance.Location = new Point(42, 220);
            TBBalance.Name = "TBBalance";
            TBBalance.Size = new Size(248, 33);
            TBBalance.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(42, 176);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 2;
            label2.Text = "Баланс";
            // 
            // TBAccType
            // 
            TBAccType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBAccType.Location = new Point(42, 336);
            TBAccType.Name = "TBAccType";
            TBAccType.Size = new Size(248, 33);
            TBAccType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(42, 292);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 4;
            label3.Text = "Тип счета";
            // 
            // TBOpDate
            // 
            TBOpDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBOpDate.Location = new Point(42, 455);
            TBOpDate.Name = "TBOpDate";
            TBOpDate.Size = new Size(248, 33);
            TBOpDate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(42, 411);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 6;
            label4.Text = "Дата открытия";
            // 
            // btnCrtAcc
            // 
            btnCrtAcc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtAcc.Location = new Point(106, 505);
            btnCrtAcc.Name = "btnCrtAcc";
            btnCrtAcc.Size = new Size(117, 58);
            btnCrtAcc.TabIndex = 8;
            btnCrtAcc.Text = "Добавить";
            btnCrtAcc.UseVisualStyleBackColor = true;
            btnCrtAcc.Click += btnCrtAcc_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 586);
            Controls.Add(btnCrtAcc);
            Controls.Add(TBOpDate);
            Controls.Add(label4);
            Controls.Add(TBAccType);
            Controls.Add(label3);
            Controls.Add(TBBalance);
            Controls.Add(label2);
            Controls.Add(TBAccName);
            Controls.Add(label1);
            Name = "AccountForm";
            Text = "AccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBAccName;
        private TextBox TBBalance;
        private Label label2;
        private TextBox TBAccType;
        private Label label3;
        private TextBox TBOpDate;
        private Label label4;
        private Button btnCrtAcc;
    }
}