
namespace ИС
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.techniqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.иСDataSet = new ИС.ИСDataSet();
            this.tipoplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodagatechniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaga_techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.Prodaga_techniqueTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.techniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.TechniqueTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sotrudnikTableAdapter = new ИС.ИСDataSetTableAdapters.SotrudnikTableAdapter();
            this.tip_oplatiTableAdapter = new ИС.ИСDataSetTableAdapters.Tip_oplatiTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.iDTechniqueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProdagatechniqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Technique = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Tip_oplati = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Поиск данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdagatechniqueDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.ID_Technique,
            this.ID_Tip_oplati,
            this.ID_Sotrudnik});
            this.dataGridView1.DataSource = this.prodagatechniqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // techniqueBindingSource1
            // 
            this.techniqueBindingSource1.DataMember = "Technique";
            this.techniqueBindingSource1.DataSource = this.иСDataSet;
            // 
            // иСDataSet
            // 
            this.иСDataSet.DataSetName = "ИСDataSet";
            this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoplatiBindingSource
            // 
            this.tipoplatiBindingSource.DataMember = "Tip_oplati";
            this.tipoplatiBindingSource.DataSource = this.иСDataSet;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.иСDataSet;
            // 
            // prodagatechniqueBindingSource
            // 
            this.prodagatechniqueBindingSource.DataMember = "Prodaga_technique";
            this.prodagatechniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // prodaga_techniqueTableAdapter
            // 
            this.prodaga_techniqueTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTechniqueDataGridViewTextBoxColumn1,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.moshnostDataGridViewTextBoxColumn,
            this.razmerDataGridViewTextBoxColumn,
            this.сolorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.techniqueBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 120);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // techniqueBindingSource
            // 
            this.techniqueBindingSource.DataMember = "Technique";
            this.techniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // techniqueTableAdapter
            // 
            this.techniqueTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "Поиск данных";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Добавить данные";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // tip_oplatiTableAdapter
            // 
            this.tip_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(272, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(252, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 38);
            this.button7.TabIndex = 10;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // iDTechniqueDataGridViewTextBoxColumn1
            // 
            this.iDTechniqueDataGridViewTextBoxColumn1.DataPropertyName = "ID_Technique";
            this.iDTechniqueDataGridViewTextBoxColumn1.HeaderText = "ID_Technique";
            this.iDTechniqueDataGridViewTextBoxColumn1.Name = "iDTechniqueDataGridViewTextBoxColumn1";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // moshnostDataGridViewTextBoxColumn
            // 
            this.moshnostDataGridViewTextBoxColumn.DataPropertyName = "Moshnost";
            this.moshnostDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.moshnostDataGridViewTextBoxColumn.Name = "moshnostDataGridViewTextBoxColumn";
            // 
            // razmerDataGridViewTextBoxColumn
            // 
            this.razmerDataGridViewTextBoxColumn.DataPropertyName = "Razmer";
            this.razmerDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.razmerDataGridViewTextBoxColumn.Name = "razmerDataGridViewTextBoxColumn";
            // 
            // сolorDataGridViewTextBoxColumn
            // 
            this.сolorDataGridViewTextBoxColumn.DataPropertyName = "Сolor";
            this.сolorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.сolorDataGridViewTextBoxColumn.Name = "сolorDataGridViewTextBoxColumn";
            // 
            // iDProdagatechniqueDataGridViewTextBoxColumn
            // 
            this.iDProdagatechniqueDataGridViewTextBoxColumn.DataPropertyName = "ID_Prodaga_technique";
            this.iDProdagatechniqueDataGridViewTextBoxColumn.HeaderText = "ID_Prodaga_technique";
            this.iDProdagatechniqueDataGridViewTextBoxColumn.Name = "iDProdagatechniqueDataGridViewTextBoxColumn";
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            // 
            // ID_Technique
            // 
            this.ID_Technique.DataPropertyName = "ID_Technique";
            this.ID_Technique.DataSource = this.techniqueBindingSource1;
            this.ID_Technique.DisplayMember = "Naimenovanie";
            this.ID_Technique.HeaderText = "Номер техники";
            this.ID_Technique.Name = "ID_Technique";
            this.ID_Technique.ValueMember = "ID_Technique";
            // 
            // ID_Tip_oplati
            // 
            this.ID_Tip_oplati.DataPropertyName = "ID_Tip_oplati";
            this.ID_Tip_oplati.DataSource = this.tipoplatiBindingSource;
            this.ID_Tip_oplati.DisplayMember = "Tip_oplati";
            this.ID_Tip_oplati.HeaderText = "Тип оплаты";
            this.ID_Tip_oplati.Name = "ID_Tip_oplati";
            this.ID_Tip_oplati.ValueMember = "ID_Tip_oplati";
            // 
            // ID_Sotrudnik
            // 
            this.ID_Sotrudnik.DataPropertyName = "ID_Sotrudnik";
            this.ID_Sotrudnik.DataSource = this.sotrudnikBindingSource;
            this.ID_Sotrudnik.DisplayMember = "Familiya";
            this.ID_Sotrudnik.HeaderText = "Номер сотрудника";
            this.ID_Sotrudnik.Name = "ID_Sotrudnik";
            this.ID_Sotrudnik.ValueMember = "ID_Sotrudnik";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ИС.Properties.Resources.maxresdefault__1_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Prodaga";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public ИСDataSet иСDataSet;
        public System.Windows.Forms.BindingSource prodagatechniqueBindingSource;
        public ИСDataSetTableAdapters.Prodaga_techniqueTableAdapter prodaga_techniqueTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource techniqueBindingSource;
        private ИСDataSetTableAdapters.TechniqueTableAdapter techniqueTableAdapter;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ИСDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource tipoplatiBindingSource;
        private ИСDataSetTableAdapters.Tip_oplatiTableAdapter tip_oplatiTableAdapter;
        private System.Windows.Forms.BindingSource techniqueBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdagatechniqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Technique;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Tip_oplati;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTechniqueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolorDataGridViewTextBoxColumn;
    }
}