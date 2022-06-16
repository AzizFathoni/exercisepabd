
namespace Exercise
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exerciseDataSet1 = new Exercise.ExerciseDataSet1();
            this.exerciseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodeTableAdapter = new Exercise.ExerciseDataSet1TableAdapters.PeriodeTableAdapter();
            this.idPeriodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thAjarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeriodeDataGridViewTextBoxColumn,
            this.thAjarDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.periodeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // exerciseDataSet1
            // 
            this.exerciseDataSet1.DataSetName = "ExerciseDataSet1";
            this.exerciseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseDataSet1BindingSource
            // 
            this.exerciseDataSet1BindingSource.DataSource = this.exerciseDataSet1;
            this.exerciseDataSet1BindingSource.Position = 0;
            // 
            // periodeBindingSource
            // 
            this.periodeBindingSource.DataMember = "Periode";
            this.periodeBindingSource.DataSource = this.exerciseDataSet1BindingSource;
            // 
            // periodeTableAdapter
            // 
            this.periodeTableAdapter.ClearBeforeFill = true;
            // 
            // idPeriodeDataGridViewTextBoxColumn
            // 
            this.idPeriodeDataGridViewTextBoxColumn.DataPropertyName = "Id_Periode";
            this.idPeriodeDataGridViewTextBoxColumn.HeaderText = "Id_Periode";
            this.idPeriodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPeriodeDataGridViewTextBoxColumn.Name = "idPeriodeDataGridViewTextBoxColumn";
            this.idPeriodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // thAjarDataGridViewTextBoxColumn
            // 
            this.thAjarDataGridViewTextBoxColumn.DataPropertyName = "Th_Ajar";
            this.thAjarDataGridViewTextBoxColumn.HeaderText = "Th_Ajar";
            this.thAjarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thAjarDataGridViewTextBoxColumn.Name = "thAjarDataGridViewTextBoxColumn";
            this.thAjarDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource exerciseDataSet1BindingSource;
        private ExerciseDataSet1 exerciseDataSet1;
        private System.Windows.Forms.BindingSource periodeBindingSource;
        private ExerciseDataSet1TableAdapters.PeriodeTableAdapter periodeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thAjarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}