namespace Client
{
    partial class Form1
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
            this.cbIhave = new System.Windows.Forms.ComboBox();
            this.labelIhave = new System.Windows.Forms.Label();
            this.labelIwant = new System.Windows.Forms.Label();
            this.cbIwant = new System.Windows.Forms.ComboBox();
            this.tbIhave = new System.Windows.Forms.TextBox();
            this.tbIwant = new System.Windows.Forms.TextBox();
            this.btCount = new System.Windows.Forms.Button();
            this.labelFam = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOtch = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbOst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbIhave
            // 
            this.cbIhave.FormattingEnabled = true;
            this.cbIhave.Location = new System.Drawing.Point(12, 145);
            this.cbIhave.Name = "cbIhave";
            this.cbIhave.Size = new System.Drawing.Size(279, 28);
            this.cbIhave.TabIndex = 0;
            this.cbIhave.SelectedIndexChanged += new System.EventHandler(this.cbIhave_SelectedIndexChanged);
            // 
            // labelIhave
            // 
            this.labelIhave.AutoSize = true;
            this.labelIhave.BackColor = System.Drawing.Color.Yellow;
            this.labelIhave.ForeColor = System.Drawing.Color.Black;
            this.labelIhave.Location = new System.Drawing.Point(8, 122);
            this.labelIhave.Name = "labelIhave";
            this.labelIhave.Size = new System.Drawing.Size(62, 20);
            this.labelIhave.TabIndex = 1;
            this.labelIhave.Text = "Отдаю";
            this.labelIhave.Click += new System.EventHandler(this.labelIhave_Click);
            // 
            // labelIwant
            // 
            this.labelIwant.AutoSize = true;
            this.labelIwant.BackColor = System.Drawing.Color.Lime;
            this.labelIwant.Location = new System.Drawing.Point(294, 122);
            this.labelIwant.Name = "labelIwant";
            this.labelIwant.Size = new System.Drawing.Size(77, 20);
            this.labelIwant.TabIndex = 2;
            this.labelIwant.Text = "Получаю";
            // 
            // cbIwant
            // 
            this.cbIwant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIwant.FormattingEnabled = true;
            this.cbIwant.Location = new System.Drawing.Point(301, 145);
            this.cbIwant.Name = "cbIwant";
            this.cbIwant.Size = new System.Drawing.Size(344, 28);
            this.cbIwant.TabIndex = 3;
            this.cbIwant.SelectedIndexChanged += new System.EventHandler(this.cbIwant_SelectedIndexChanged);
            // 
            // tbIhave
            // 
            this.tbIhave.Location = new System.Drawing.Point(12, 191);
            this.tbIhave.Name = "tbIhave";
            this.tbIhave.Size = new System.Drawing.Size(137, 26);
            this.tbIhave.TabIndex = 4;
            this.tbIhave.Text = "120";
            this.tbIhave.TextChanged += new System.EventHandler(this.tbIhave_TextChanged);
            // 
            // tbIwant
            // 
            this.tbIwant.Location = new System.Drawing.Point(301, 191);
            this.tbIwant.Name = "tbIwant";
            this.tbIwant.ReadOnly = true;
            this.tbIwant.Size = new System.Drawing.Size(137, 26);
            this.tbIwant.TabIndex = 5;
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(12, 341);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(633, 37);
            this.btCount.TabIndex = 6;
            this.btCount.Text = "Оформить перевод";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.Location = new System.Drawing.Point(8, 47);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(81, 20);
            this.labelFam.TabIndex = 7;
            this.labelFam.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 20);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Имя";
            // 
            // labelOtch
            // 
            this.labelOtch.AutoSize = true;
            this.labelOtch.Location = new System.Drawing.Point(12, 79);
            this.labelOtch.Name = "labelOtch";
            this.labelOtch.Size = new System.Drawing.Size(83, 20);
            this.labelOtch.TabIndex = 9;
            this.labelOtch.Text = "Отчество";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(158, 41);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(137, 26);
            this.tbLastName.TabIndex = 10;
            this.tbLastName.Text = "Б";
            this.tbLastName.TextChanged += new System.EventHandler(this.tbFam_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(158, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(137, 26);
            this.tbName.TabIndex = 11;
            this.tbName.Text = "А";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(158, 73);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(137, 26);
            this.tbOtch.TabIndex = 12;
            this.tbOtch.Text = "В";
            this.tbOtch.TextChanged += new System.EventHandler(this.tbOtch_TextChanged);
            // 
            // tbOst
            // 
            this.tbOst.Location = new System.Drawing.Point(12, 280);
            this.tbOst.Name = "tbOst";
            this.tbOst.Size = new System.Drawing.Size(100, 26);
            this.tbOst.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Остаток";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOst);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.labelOtch);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFam);
            this.Controls.Add(this.btCount);
            this.Controls.Add(this.tbIwant);
            this.Controls.Add(this.tbIhave);
            this.Controls.Add(this.cbIwant);
            this.Controls.Add(this.labelIwant);
            this.Controls.Add(this.labelIhave);
            this.Controls.Add(this.cbIhave);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIhave;
        private System.Windows.Forms.Label labelIhave;
        private System.Windows.Forms.Label labelIwant;
        private System.Windows.Forms.ComboBox cbIwant;
        private System.Windows.Forms.TextBox tbIhave;
        private System.Windows.Forms.TextBox tbIwant;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOtch;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbOst;
        private System.Windows.Forms.Label label1;
    }
}

