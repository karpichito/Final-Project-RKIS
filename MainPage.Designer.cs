namespace WinFormsApp1111
{
    partial class MainPage
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
            labelExp = new Label();
            labelInc = new Label();
            labelAcc = new Label();
            listView1 = new ListView();
            btnCrtExp = new Button();
            listView2 = new ListView();
            listView3 = new ListView();
            btnCrtInc = new Button();
            btnCrtAcc = new Button();
            btnRfr = new Button();
            SuspendLayout();
            // 
            // labelExp
            // 
            labelExp.AutoSize = true;
            labelExp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelExp.Location = new Point(64, 9);
            labelExp.Name = "labelExp";
            labelExp.Size = new Size(85, 25);
            labelExp.TabIndex = 0;
            labelExp.Text = "Расходы";
            // 
            // labelInc
            // 
            labelInc.AutoSize = true;
            labelInc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInc.Location = new Point(350, 9);
            labelInc.Name = "labelInc";
            labelInc.Size = new Size(79, 25);
            labelInc.TabIndex = 1;
            labelInc.Text = "Доходы";
            // 
            // labelAcc
            // 
            labelAcc.AutoSize = true;
            labelAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAcc.Location = new Point(643, 9);
            labelAcc.Name = "labelAcc";
            labelAcc.Size = new Size(63, 25);
            labelAcc.TabIndex = 2;
            labelAcc.Text = "Счета";
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView1.Location = new Point(12, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(196, 445);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnCrtExp
            // 
            btnCrtExp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtExp.Location = new Point(48, 488);
            btnCrtExp.Name = "btnCrtExp";
            btnCrtExp.Size = new Size(129, 49);
            btnCrtExp.TabIndex = 8;
            btnCrtExp.Text = "Добавить";
            btnCrtExp.UseVisualStyleBackColor = true;
            btnCrtExp.Click += btnCrtExp_Click;
            // 
            // listView2
            // 
            listView2.Font = new Font("Segoe UI", 14.25F);
            listView2.Location = new Point(292, 37);
            listView2.Name = "listView2";
            listView2.Size = new Size(196, 445);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // listView3
            // 
            listView3.Font = new Font("Segoe UI", 14.25F);
            listView3.Location = new Point(579, 37);
            listView3.Name = "listView3";
            listView3.Size = new Size(196, 445);
            listView3.TabIndex = 10;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.List;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // btnCrtInc
            // 
            btnCrtInc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtInc.Location = new Point(326, 488);
            btnCrtInc.Name = "btnCrtInc";
            btnCrtInc.Size = new Size(129, 49);
            btnCrtInc.TabIndex = 12;
            btnCrtInc.Text = "Добавить";
            btnCrtInc.UseVisualStyleBackColor = true;
            btnCrtInc.Click += btnCrtInc_Click;
            // 
            // btnCrtAcc
            // 
            btnCrtAcc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCrtAcc.Location = new Point(613, 488);
            btnCrtAcc.Name = "btnCrtAcc";
            btnCrtAcc.Size = new Size(129, 49);
            btnCrtAcc.TabIndex = 13;
            btnCrtAcc.Text = "Добавить";
            btnCrtAcc.UseVisualStyleBackColor = true;
            btnCrtAcc.Click += btnCrtAcc_Click;
            // 
            // btnRfr
            // 
            btnRfr.FlatStyle = FlatStyle.Flat;
            btnRfr.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRfr.Location = new Point(808, 27);
            btnRfr.Name = "btnRfr";
            btnRfr.Size = new Size(50, 50);
            btnRfr.TabIndex = 14;
            btnRfr.Text = "🗘";
            btnRfr.UseVisualStyleBackColor = true;
            btnRfr.Click += btnRfr_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 549);
            Controls.Add(btnRfr);
            Controls.Add(btnCrtAcc);
            Controls.Add(btnCrtInc);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(btnCrtExp);
            Controls.Add(listView1);
            Controls.Add(labelAcc);
            Controls.Add(labelInc);
            Controls.Add(labelExp);
            Name = "MainPage";
            Text = "Основная страница";
            FormClosed += MainPage_FormClosed;
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelExp;
        private Label labelInc;
        private Label labelAcc;
        private ListView listView1;
        private Button btnCrtExp;
        private ListView listView2;
        private ListView listView3;
        private Button btnCrtInc;
        private Button btnCrtAcc;
        private Button btnRfr;
    }
}