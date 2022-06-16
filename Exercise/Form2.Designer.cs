
namespace Exercise
{
    partial class Form2
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
            this.btnnext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exerciseDataSet1 = new Exercise.ExerciseDataSet1();
            this.pembimbingAkademikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembimbing_AkademikTableAdapter = new Exercise.ExerciseDataSet1TableAdapters.Pembimbing_AkademikTableAdapter();
            this.nIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPembimbingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keahlianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembimbingAkademikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pembimbing Akademik";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(632, 365);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 33);
            this.btnnext.TabIndex = 9;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIKDataGridViewTextBoxColumn,
            this.namaPembimbingDataGridViewTextBoxColumn,
            this.keahlianDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pembimbingAkademikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 202);
            this.dataGridView1.TabIndex = 10;
            // 
            // exerciseDataSet1
            // 
            this.exerciseDataSet1.DataSetName = "ExerciseDataSet1";
            this.exerciseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembimbingAkademikBindingSource
            // 
            this.pembimbingAkademikBindingSource.DataMember = "Pembimbing_Akademik";
            this.pembimbingAkademikBindingSource.DataSource = this.exerciseDataSet1;
            // 
            // pembimbing_AkademikTableAdapter
            // 
            this.pembimbing_AkademikTableAdapter.ClearBeforeFill = true;
            // 
            // nIKDataGridViewTextBoxColumn
            // 
            this.nIKDataGridViewTextBoxColumn.DataPropertyName = "NIK";
            this.nIKDataGridViewTextBoxColumn.HeaderText = "NIK";
            this.nIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIKDataGridViewTextBoxColumn.Name = "nIKDataGridViewTextBoxColumn";
            this.nIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPembimbingDataGridViewTextBoxColumn
            // 
            this.namaPembimbingDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pembimbing";
            this.namaPembimbingDataGridViewTextBoxColumn.HeaderText = "Nama_Pembimbing";
            this.namaPembimbingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPembimbingDataGridViewTextBoxColumn.Name = "namaPembimbingDataGridViewTextBoxColumn";
            this.namaPembimbingDataGridViewTextBoxColumn.Width = 125;
            // 
            // keahlianDataGridViewTextBoxColumn
            // 
            this.keahlianDataGridViewTextBoxColumn.DataPropertyName = "Keahlian";
            this.keahlianDataGridViewTextBoxColumn.HeaderText = "Keahlian";
            this.keahlianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keahlianDataGridViewTextBoxColumn.Name = "keahlianDataGridViewTextBoxColumn";
            this.keahlianDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembimbingAkademikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ExerciseDataSet1 exerciseDataSet1;
        private System.Windows.Forms.BindingSource pembimbingAkademikBindingSource;
        private ExerciseDataSet1TableAdapters.Pembimbing_AkademikTableAdapter pembimbing_AkademikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPembimbingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keahlianDataGridViewTextBoxColumn;
    }
}