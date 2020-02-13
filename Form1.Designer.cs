namespace S_Files
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
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(27, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prz,
            this.Reason1,
            this.Reason2,
            this.Reason3,
            this.Reason4,
            this.Reason5,
            this.Reason6,
            this.Reason7,
            this.Sum});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(782, 429);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Prz
            // 
            this.Prz.HeaderText = "Prz";
            this.Prz.Name = "Prz";
            this.Prz.ReadOnly = true;
            this.Prz.Width = 80;
            // 
            // Reason1
            // 
            this.Reason1.HeaderText = "Reason 1";
            this.Reason1.Name = "Reason1";
            this.Reason1.ReadOnly = true;
            this.Reason1.Width = 80;
            // 
            // Reason2
            // 
            this.Reason2.HeaderText = "Reason 2";
            this.Reason2.Name = "Reason2";
            this.Reason2.ReadOnly = true;
            this.Reason2.Width = 80;
            // 
            // Reason3
            // 
            this.Reason3.HeaderText = "Reason 3";
            this.Reason3.Name = "Reason3";
            this.Reason3.ReadOnly = true;
            this.Reason3.Width = 80;
            // 
            // Reason4
            // 
            this.Reason4.HeaderText = "Reason 4";
            this.Reason4.Name = "Reason4";
            this.Reason4.ReadOnly = true;
            this.Reason4.Width = 80;
            // 
            // Reason5
            // 
            this.Reason5.HeaderText = "Reason 5";
            this.Reason5.Name = "Reason5";
            this.Reason5.ReadOnly = true;
            this.Reason5.Width = 80;
            // 
            // Reason6
            // 
            this.Reason6.HeaderText = "Reason 6";
            this.Reason6.Name = "Reason6";
            this.Reason6.ReadOnly = true;
            this.Reason6.Width = 80;
            // 
            // Reason7
            // 
            this.Reason7.HeaderText = "Reason 7";
            this.Reason7.Name = "Reason7";
            this.Reason7.ReadOnly = true;
            this.Reason7.Width = 80;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 485);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 56);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 429);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(798, 96);
            this.Name = "Form1";
            this.Text = "S-Files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

