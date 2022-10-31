
namespace ИС
{
    partial class Zakupka
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
            this.iDZakupkatechiqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDogovoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.иСDataSet = new ИС.ИСDataSet();
            this.comboBox2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postavchikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.techniqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoplatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zakupkatechiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.zakupka_techiqueTableAdapter = new ИС.ИСDataSetTableAdapters.Zakupka_techiqueTableAdapter();
            this.sotrudnikTableAdapter = new ИС.ИСDataSetTableAdapters.SotrudnikTableAdapter();
            this.zakupkatechiqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikTableAdapter = new ИС.ИСDataSetTableAdapters.PostavchikTableAdapter();
            this.techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.TechniqueTableAdapter();
            this.tip_oplatiTableAdapter = new ИС.ИСDataSetTableAdapters.Tip_oplatiTableAdapter();
            this.techniqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.postavchikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDPostavchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomertelephonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavchikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZakupkatechiqueDataGridViewTextBoxColumn,
            this.nomerDogovoraDataGridViewTextBoxColumn,
            this.datapostavkiDataGridViewTextBoxColumn,
            this.comboBox1,
            this.comboBox2,
            this.comboBox3,
            this.comboBox4});
            this.dataGridView1.DataSource = this.zakupkatechiqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDZakupkatechiqueDataGridViewTextBoxColumn
            // 
            this.iDZakupkatechiqueDataGridViewTextBoxColumn.DataPropertyName = "ID_Zakupka_techique";
            this.iDZakupkatechiqueDataGridViewTextBoxColumn.HeaderText = "ID_Zakupka_techique";
            this.iDZakupkatechiqueDataGridViewTextBoxColumn.Name = "iDZakupkatechiqueDataGridViewTextBoxColumn";
            // 
            // nomerDogovoraDataGridViewTextBoxColumn
            // 
            this.nomerDogovoraDataGridViewTextBoxColumn.DataPropertyName = "Nomer dogovora";
            this.nomerDogovoraDataGridViewTextBoxColumn.HeaderText = "Nomer dogovora";
            this.nomerDogovoraDataGridViewTextBoxColumn.Name = "nomerDogovoraDataGridViewTextBoxColumn";
            // 
            // datapostavkiDataGridViewTextBoxColumn
            // 
            this.datapostavkiDataGridViewTextBoxColumn.DataPropertyName = "Data_postavki";
            this.datapostavkiDataGridViewTextBoxColumn.HeaderText = "Data_postavki";
            this.datapostavkiDataGridViewTextBoxColumn.Name = "datapostavkiDataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.DataPropertyName = "ID_Sotrudnik";
            this.comboBox1.DataSource = this.sotrudnikBindingSource1;
            this.comboBox1.DisplayMember = "Familiya";
            this.comboBox1.HeaderText = "ID_Sotrudnik";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource1
            // 
            this.sotrudnikBindingSource1.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource1.DataSource = this.иСDataSet;
            // 
            // иСDataSet
            // 
            this.иСDataSet.DataSetName = "ИСDataSet";
            this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataPropertyName = "ID_Postavchik";
            this.comboBox2.DataSource = this.postavchikBindingSource1;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.HeaderText = "ID_Postavchik";
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.ValueMember = "ID_Postavchik";
            // 
            // postavchikBindingSource1
            // 
            this.postavchikBindingSource1.DataMember = "Postavchik";
            this.postavchikBindingSource1.DataSource = this.иСDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataPropertyName = "ID_Technique";
            this.comboBox3.DataSource = this.techniqueBindingSource1;
            this.comboBox3.DisplayMember = "Naimenovanie";
            this.comboBox3.HeaderText = "ID_Technique";
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.ValueMember = "ID_Technique";
            // 
            // techniqueBindingSource1
            // 
            this.techniqueBindingSource1.DataMember = "Technique";
            this.techniqueBindingSource1.DataSource = this.иСDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataPropertyName = "ID_Tip_oplati";
            this.comboBox4.DataSource = this.tipoplatiBindingSource1;
            this.comboBox4.DisplayMember = "Tip_oplati";
            this.comboBox4.HeaderText = "ID_Tip_oplati";
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.ValueMember = "ID_Tip_oplati";
            // 
            // tipoplatiBindingSource1
            // 
            this.tipoplatiBindingSource1.DataMember = "Tip_oplati";
            this.tipoplatiBindingSource1.DataSource = this.иСDataSet;
            // 
            // zakupkatechiqueBindingSource
            // 
            this.zakupkatechiqueBindingSource.DataMember = "Zakupka_techique";
            this.zakupkatechiqueBindingSource.DataSource = this.иСDataSet;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.иСDataSet;
            // 
            // postavchikBindingSource
            // 
            this.postavchikBindingSource.DataMember = "Postavchik";
            this.postavchikBindingSource.DataSource = this.иСDataSet;
            // 
            // techniqueBindingSource
            // 
            this.techniqueBindingSource.DataMember = "Technique";
            this.techniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // tipoplatiBindingSource
            // 
            this.tipoplatiBindingSource.DataMember = "Tip_oplati";
            this.tipoplatiBindingSource.DataSource = this.иСDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(777, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // zakupka_techiqueTableAdapter
            // 
            this.zakupka_techiqueTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // zakupkatechiqueBindingSource1
            // 
            this.zakupkatechiqueBindingSource1.DataMember = "Zakupka_techique";
            this.zakupkatechiqueBindingSource1.DataSource = this.иСDataSet;
            // 
            // postavchikTableAdapter
            // 
            this.postavchikTableAdapter.ClearBeforeFill = true;
            // 
            // techniqueTableAdapter
            // 
            this.techniqueTableAdapter.ClearBeforeFill = true;
            // 
            // tip_oplatiTableAdapter
            // 
            this.tip_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // techniqueBindingSource2
            // 
            this.techniqueBindingSource2.DataMember = "Technique";
            this.techniqueBindingSource2.DataSource = this.иСDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // postavchikBindingSource2
            // 
            this.postavchikBindingSource2.DataMember = "Postavchik";
            this.postavchikBindingSource2.DataSource = this.иСDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPostavchikDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.nomertelephonaDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.postavchikBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(12, 286);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(445, 150);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // iDPostavchikDataGridViewTextBoxColumn
            // 
            this.iDPostavchikDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavchik";
            this.iDPostavchikDataGridViewTextBoxColumn.HeaderText = "ID_Postavchik";
            this.iDPostavchikDataGridViewTextBoxColumn.Name = "iDPostavchikDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // nomertelephonaDataGridViewTextBoxColumn
            // 
            this.nomertelephonaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_telephona";
            this.nomertelephonaDataGridViewTextBoxColumn.HeaderText = "Nomer_telephona";
            this.nomertelephonaDataGridViewTextBoxColumn.Name = "nomertelephonaDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // postavchikBindingSource3
            // 
            this.postavchikBindingSource3.DataMember = "Postavchik";
            this.postavchikBindingSource3.DataSource = this.иСDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(261, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(235, 442);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Zakupka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ИС.Properties.Resources.maxresdefault__1_;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zakupka";
            this.Text = "Zakupka";
            this.Load += new System.EventHandler(this.Zakupka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public ИСDataSet иСDataSet;
        public System.Windows.Forms.BindingSource zakupkatechiqueBindingSource;
        public ИСDataSetTableAdapters.Zakupka_techiqueTableAdapter zakupka_techiqueTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ИСDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        public System.Windows.Forms.BindingSource zakupkatechiqueBindingSource1;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        public ИСDataSetTableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        private System.Windows.Forms.BindingSource techniqueBindingSource;
        private ИСDataSetTableAdapters.TechniqueTableAdapter techniqueTableAdapter;
        private System.Windows.Forms.BindingSource tipoplatiBindingSource;
        private ИСDataSetTableAdapters.Tip_oplatiTableAdapter tip_oplatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZakupkatechiqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDogovoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBox1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBox2;
        private System.Windows.Forms.BindingSource postavchikBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBox3;
        private System.Windows.Forms.BindingSource techniqueBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBox4;
        private System.Windows.Forms.BindingSource tipoplatiBindingSource1;
        private System.Windows.Forms.BindingSource techniqueBindingSource2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.BindingSource postavchikBindingSource2;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomertelephonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postavchikBindingSource3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}