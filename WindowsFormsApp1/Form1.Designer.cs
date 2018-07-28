namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.personasTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.PersonasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.edadTextbox = new System.Windows.Forms.TextBox();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nameTextbox.Location = new System.Drawing.Point(12, 415);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 2;
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Apellido", true));
            this.apellidoTextbox.Location = new System.Drawing.Point(119, 415);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextbox.TabIndex = 3;
            // 
            // edadTextbox
            // 
            this.edadTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Edad", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.edadTextbox.Location = new System.Drawing.Point(226, 415);
            this.edadTextbox.Name = "edadTextbox";
            this.edadTextbox.Size = new System.Drawing.Size(100, 20);
            this.edadTextbox.TabIndex = 4;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(632, 415);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 5;
            this.botonBorrar.Text = "-";
            this.botonBorrar.UseVisualStyleBackColor = true;
            //this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.edadTextbox);
            this.Controls.Add(this.apellidoTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private Database1DataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox apellidoTextbox;
        private System.Windows.Forms.TextBox edadTextbox;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

