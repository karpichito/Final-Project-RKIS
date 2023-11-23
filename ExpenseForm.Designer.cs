namespace WinFormsApp1
{
    partial class ExpenseForm
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
            TBExCtg = new TextBox();
            TBVal = new TextBox();
            label2 = new Label();
            btnCrt1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(50, 66);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Категория расхода";
            // 
            // TBExCtg
            // 
            TBExCtg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBExCtg.Location = new Point(50, 106);
            TBExCtg.Name = "TBExCtg";
            TBExCtg.Size = new Size(197, 29);
            TBExCtg.TabIndex = 1;
            // 
            // TBVal
            // 
            TBVal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TBVal.Location = new Point(50, 225);
            TBVal.Name = "TBVal";
            TBVal.Size = new Size(197, 29);
            TBVal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(50, 185);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 2;
            label2.Text = "Цена";
            // 
            // btnCrt1
            // 
            btnCrt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrt1.Location = new Point(98, 296);
            btnCrt1.Name = "btnCrt1";
            btnCrt1.Size = new Size(110, 52);
            btnCrt1.TabIndex = 4;
            btnCrt1.Text = "Добавить";
            btnCrt1.UseVisualStyleBackColor = true;
            btnCrt1.Click += btnCrt1_Click;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 395);
            Controls.Add(btnCrt1);
            Controls.Add(TBVal);
            Controls.Add(label2);
            Controls.Add(TBExCtg);
            Controls.Add(label1);
            Name = "ExpenseForm";
            Text = "Добавить расходы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBExCtg;
        private TextBox TBVal;
        private Label label2;
        private Button btnCrt1;
    }
}