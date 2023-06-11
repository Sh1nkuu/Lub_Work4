namespace Lab_work4
{
    partial class Form1
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
            this.dgvMas = new System.Windows.Forms.DataGridView();
            this.btGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSort = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMas
            // 
            this.dgvMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMas.Location = new System.Drawing.Point(12, 12);
            this.dgvMas.Name = "dgvMas";
            this.dgvMas.RowHeadersWidth = 62;
            this.dgvMas.RowTemplate.Height = 28;
            this.dgvMas.Size = new System.Drawing.Size(776, 90);
            this.dgvMas.TabIndex = 0;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(118, 108);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(261, 44);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Створити";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(10, 71);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(234, 33);
            this.btSearch.TabIndex = 5;
            this.btSearch.Text = "Пошук";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шукати значення";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(151, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(93, 26);
            this.tbSearch.TabIndex = 0;
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(439, 108);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(261, 44);
            this.btSort.TabIndex = 4;
            this.btSort.Text = "Сортувати";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(12, 158);
            this.txtSort.Multiline = true;
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(776, 83);
            this.txtSort.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(560, 292);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(228, 59);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Вийти";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(320, 8);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(216, 117);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.dgvMas);
            this.Name = "Form1";
            this.Text = "Сортування та пошук";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMas;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}

