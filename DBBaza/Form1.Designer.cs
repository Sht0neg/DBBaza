namespace DBBaza
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            productBindingSource1 = new BindingSource(components);
            productsBindingSource = new BindingSource(components);
            productsBindingSource1 = new BindingSource(components);
            productsBindingSource2 = new BindingSource(components);
            dataGridView2 = new DataGridView();
            productsBindingSource3 = new BindingSource(components);
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryFKDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn });
            dataGridView1.DataSource = categoryBindingSource;
            dataGridView1.Location = new Point(1, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(241, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Product);
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // productsBindingSource1
            // 
            productsBindingSource1.DataMember = "products";
            productsBindingSource1.DataSource = categoryBindingSource;
            // 
            // productsBindingSource2
            // 
            productsBindingSource2.DataMember = "products";
            productsBindingSource2.DataSource = categoryBindingSource;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, titleDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn, categoryFKDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridView2.DataSource = productsBindingSource3;
            dataGridView2.Location = new Point(248, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(540, 357);
            dataGridView2.TabIndex = 1;
            // 
            // productsBindingSource3
            // 
            productsBindingSource3.DataMember = "products";
            productsBindingSource3.DataSource = categoryBindingSource;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // categoryFKDataGridViewTextBoxColumn
            // 
            categoryFKDataGridViewTextBoxColumn.DataPropertyName = "CategoryFK";
            categoryFKDataGridViewTextBoxColumn.HeaderText = "CategoryFK";
            categoryFKDataGridViewTextBoxColumn.Name = "categoryFKDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource productsBindingSource2;
        private BindingSource productBindingSource1;
        private BindingSource productsBindingSource;
        private BindingSource productsBindingSource1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryFKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource3;
    }
}
