namespace DZ
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
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secondNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marriedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            hadChildrenDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            employeeBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            specialisationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, secondNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, marriedDataGridViewCheckBoxColumn, hadChildrenDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Location = new Point(27, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(638, 467);
            dataGridView1.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // marriedDataGridViewCheckBoxColumn
            // 
            marriedDataGridViewCheckBoxColumn.DataPropertyName = "Married";
            marriedDataGridViewCheckBoxColumn.HeaderText = "Married";
            marriedDataGridViewCheckBoxColumn.Name = "marriedDataGridViewCheckBoxColumn";
            // 
            // hadChildrenDataGridViewCheckBoxColumn
            // 
            hadChildrenDataGridViewCheckBoxColumn.DataPropertyName = "HadChildren";
            hadChildrenDataGridViewCheckBoxColumn.HeaderText = "HadChildren";
            hadChildrenDataGridViewCheckBoxColumn.Name = "hadChildrenDataGridViewCheckBoxColumn";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Employee);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, specialisationDataGridViewTextBoxColumn });
            dataGridView2.DataSource = companyBindingSource;
            dataGridView2.Location = new Point(685, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(481, 467);
            dataGridView2.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // specialisationDataGridViewTextBoxColumn
            // 
            specialisationDataGridViewTextBoxColumn.DataPropertyName = "Specialisation";
            specialisationDataGridViewTextBoxColumn.HeaderText = "Specialisation";
            specialisationDataGridViewTextBoxColumn.Name = "specialisationDataGridViewTextBoxColumn";
            // 
            // companyBindingSource
            // 
            companyBindingSource.DataSource = typeof(Company);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 590);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn marriedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn hadChildrenDataGridViewCheckBoxColumn;
        private BindingSource employeeBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specialisationDataGridViewTextBoxColumn;
        private BindingSource companyBindingSource;
    }
}
