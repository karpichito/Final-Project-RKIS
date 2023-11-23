namespace WinFormsApp1
{
    partial class IncomeForm
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
            TBIncSrc = new TextBox();
            TBIncDate = new TextBox();
            label2 = new Label();
            TBAmount = new TextBox();
            label3 = new Label();
            btnCrtInc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Источник дохода";
            // 
            // TBIncSrc
            // 
            TBIncSrc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBIncSrc.Location = new Point(28, 89);
            TBIncSrc.Name = "TBIncSrc";
            TBIncSrc.Size = new Size(251, 33);
            TBIncSrc.TabIndex = 1;
            // 
            // TBIncDate
            // 
            TBIncDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBIncDate.Location = new Point(28, 202);
            TBIncDate.Name = "TBIncDate";
            TBIncDate.Size = new Size(251, 33);
            TBIncDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(28, 159);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Дата";
            // 
            // TBAmount
            // 
            TBAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBAmount.Location = new Point(28, 312);
            TBAmount.Name = "TBAmount";
            TBAmount.Size = new Size(251, 33);
            TBAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(28, 269);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "Сумма";
            // 
            // btnCrtInc
            // 
            btnCrtInc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtInc.Location = new Point(96, 376);
            btnCrtInc.Name = "btnCrtInc";
            btnCrtInc.Size = new Size(120, 55);
            btnCrtInc.TabIndex = 6;
            btnCrtInc.Text = "Добавить";
            btnCrtInc.UseVisualStyleBackColor = true;
            btnCrtInc.Click += btnCrtInc_Click;
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 463);
            Controls.Add(btnCrtInc);
            Controls.Add(TBAmount);
            Controls.Add(label3);
            Controls.Add(TBIncDate);
            Controls.Add(label2);
            Controls.Add(TBIncSrc);
            Controls.Add(label1);
            Name = "IncomeForm";
            Text = "IncomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBIncSrc;
        private TextBox TBIncDate;
        private Label label2;
        private TextBox TBAmount;
        private Label label3;
        private Button btnCrtInc;
    }
}