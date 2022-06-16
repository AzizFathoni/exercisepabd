
namespace Exercise
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exerciseDataSet = new Exercise.ExerciseDataSet();
            this.exerciseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataKontrakanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_KontrakanTableAdapter = new Exercise.ExerciseDataSetTableAdapters.Data_KontrakanTableAdapter();
            this.nKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPenghuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKontrakanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Kontrakan ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(670, 375);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(103, 32);
            this.btnnext.TabIndex = 7;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nKDataGridViewTextBoxColumn,
            this.namaPenghuniDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.tesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataKontrakanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 226);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exerciseDataSet
            // 
            this.exerciseDataSet.DataSetName = "ExerciseDataSet";
            this.exerciseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseDataSetBindingSource
            // 
            this.exerciseDataSetBindingSource.DataSource = this.exerciseDataSet;
            this.exerciseDataSetBindingSource.Position = 0;
            // 
            // dataKontrakanBindingSource
            // 
            this.dataKontrakanBindingSource.DataMember = "Data_Kontrakan";
            this.dataKontrakanBindingSource.DataSource = this.exerciseDataSetBindingSource;
            // 
            // data_KontrakanTableAdapter
            // 
            this.data_KontrakanTableAdapter.ClearBeforeFill = true;
            // 
            // nKDataGridViewTextBoxColumn
            // 
            this.nKDataGridViewTextBoxColumn.DataPropertyName = "NK";
            this.nKDataGridViewTextBoxColumn.HeaderText = "NK";
            this.nKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nKDataGridViewTextBoxColumn.Name = "nKDataGridViewTextBoxColumn";
            this.nKDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPenghuniDataGridViewTextBoxColumn
            // 
            this.namaPenghuniDataGridViewTextBoxColumn.DataPropertyName = "Nama_Penghuni";
            this.namaPenghuniDataGridViewTextBoxColumn.HeaderText = "Nama_Penghuni";
            this.namaPenghuniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPenghuniDataGridViewTextBoxColumn.Name = "namaPenghuniDataGridViewTextBoxColumn";
            this.namaPenghuniDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodiDataGridViewTextBoxColumn
            // 
            this.prodiDataGridViewTextBoxColumn.DataPropertyName = "Prodi";
            this.prodiDataGridViewTextBoxColumn.HeaderText = "Prodi";
            this.prodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodiDataGridViewTextBoxColumn.Name = "prodiDataGridViewTextBoxColumn";
            this.prodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // tesDataGridViewTextBoxColumn
            // 
            this.tesDataGridViewTextBoxColumn.DataPropertyName = "Tes";
            this.tesDataGridViewTextBoxColumn.HeaderText = "Tes";
            this.tesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tesDataGridViewTextBoxColumn.Name = "tesDataGridViewTextBoxColumn";
            this.tesDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKontrakanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource exerciseDataSetBindingSource;
        private ExerciseDataSet exerciseDataSet;
        private System.Windows.Forms.BindingSource dataKontrakanBindingSource;
        private ExerciseDataSetTableAdapters.Data_KontrakanTableAdapter data_KontrakanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPenghuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tesDataGridViewTextBoxColumn;
    }
}

