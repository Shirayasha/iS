
namespace ИС
{
    partial class Uchet
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
            this.iDUchettechniqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerskladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvonaskladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvoditelyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.иСDataSet = new ИС.ИСDataSet();
            this.comboBox2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.techniqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.combobox3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchettechniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchet_techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.Uchet_techniqueTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDProizvoditelyaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomertelephonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Technique = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.techniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditelyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditelyTableAdapter = new ИС.ИСDataSetTableAdapters.ProizvoditelyTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.TechniqueTableAdapter();
            this.proizvoditelyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new ИС.ИСDataSetTableAdapters.SotrudnikTableAdapter();
            this.proizvoditelyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDSotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressprojivaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Doljnost = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1114, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUchettechniqueDataGridViewTextBoxColumn,
            this.nomerskladDataGridViewTextBoxColumn,
            this.brakDataGridViewTextBoxColumn,
            this.kolvonaskladeDataGridViewTextBoxColumn,
            this.comboBox1,
            this.comboBox2,
            this.combobox3});
            this.dataGridView1.DataSource = this.uchettechniqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDUchettechniqueDataGridViewTextBoxColumn
            // 
            this.iDUchettechniqueDataGridViewTextBoxColumn.DataPropertyName = "ID_Uchet_technique";
            this.iDUchettechniqueDataGridViewTextBoxColumn.Frozen = true;
            this.iDUchettechniqueDataGridViewTextBoxColumn.HeaderText = "ID_Uchet_technique";
            this.iDUchettechniqueDataGridViewTextBoxColumn.Name = "iDUchettechniqueDataGridViewTextBoxColumn";
            // 
            // nomerskladDataGridViewTextBoxColumn
            // 
            this.nomerskladDataGridViewTextBoxColumn.DataPropertyName = "Nomer_sklad";
            this.nomerskladDataGridViewTextBoxColumn.Frozen = true;
            this.nomerskladDataGridViewTextBoxColumn.HeaderText = "Nomer_sklad";
            this.nomerskladDataGridViewTextBoxColumn.Name = "nomerskladDataGridViewTextBoxColumn";
            // 
            // brakDataGridViewTextBoxColumn
            // 
            this.brakDataGridViewTextBoxColumn.DataPropertyName = "Brak";
            this.brakDataGridViewTextBoxColumn.Frozen = true;
            this.brakDataGridViewTextBoxColumn.HeaderText = "Brak";
            this.brakDataGridViewTextBoxColumn.Name = "brakDataGridViewTextBoxColumn";
            // 
            // kolvonaskladeDataGridViewTextBoxColumn
            // 
            this.kolvonaskladeDataGridViewTextBoxColumn.DataPropertyName = "Kol-vo_na_sklade";
            this.kolvonaskladeDataGridViewTextBoxColumn.Frozen = true;
            this.kolvonaskladeDataGridViewTextBoxColumn.HeaderText = "Kol-vo_na_sklade";
            this.kolvonaskladeDataGridViewTextBoxColumn.Name = "kolvonaskladeDataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.DataPropertyName = "ID_Proizvoditelya";
            this.comboBox1.DataSource = this.proizvoditelyBindingSource1;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.Frozen = true;
            this.comboBox1.HeaderText = "ID_Proizvoditelya";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "ID_Proizvoditelya";
            // 
            // proizvoditelyBindingSource1
            // 
            this.proizvoditelyBindingSource1.DataMember = "Proizvoditely";
            this.proizvoditelyBindingSource1.DataSource = this.иСDataSet;
            // 
            // иСDataSet
            // 
            this.иСDataSet.DataSetName = "ИСDataSet";
            this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataPropertyName = "ID_Technique";
            this.comboBox2.DataSource = this.techniqueBindingSource1;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.Frozen = true;
            this.comboBox2.HeaderText = "ID_Technique";
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.ValueMember = "ID_Technique";
            // 
            // techniqueBindingSource1
            // 
            this.techniqueBindingSource1.DataMember = "Technique";
            this.techniqueBindingSource1.DataSource = this.иСDataSet;
            // 
            // combobox3
            // 
            this.combobox3.DataPropertyName = "ID_Sotrudnik";
            this.combobox3.DataSource = this.sotrudnikBindingSource;
            this.combobox3.DisplayMember = "Familiya";
            this.combobox3.Frozen = true;
            this.combobox3.HeaderText = "ID_Sotrudnik";
            this.combobox3.Name = "combobox3";
            this.combobox3.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.иСDataSet;
            // 
            // uchettechniqueBindingSource
            // 
            this.uchettechniqueBindingSource.DataMember = "Uchet_technique";
            this.uchettechniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // uchet_techniqueTableAdapter
            // 
            this.uchet_techniqueTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProizvoditelyaDataGridViewTextBoxColumn1,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.nomertelephonaDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.ID_Technique});
            this.dataGridView2.DataSource = this.proizvoditelyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(769, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 150);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // iDProizvoditelyaDataGridViewTextBoxColumn1
            // 
            this.iDProizvoditelyaDataGridViewTextBoxColumn1.DataPropertyName = "ID_Proizvoditelya";
            this.iDProizvoditelyaDataGridViewTextBoxColumn1.HeaderText = "ID_Proizvoditelya";
            this.iDProizvoditelyaDataGridViewTextBoxColumn1.Name = "iDProizvoditelyaDataGridViewTextBoxColumn1";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // nomertelephonaDataGridViewTextBoxColumn
            // 
            this.nomertelephonaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_telephona";
            this.nomertelephonaDataGridViewTextBoxColumn.HeaderText = "Nomer_telephona";
            this.nomertelephonaDataGridViewTextBoxColumn.Name = "nomertelephonaDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // ID_Technique
            // 
            this.ID_Technique.DataPropertyName = "ID_Technique";
            this.ID_Technique.DataSource = this.techniqueBindingSource;
            this.ID_Technique.DisplayMember = "Naimenovanie";
            this.ID_Technique.HeaderText = "ID_Technique";
            this.ID_Technique.Name = "ID_Technique";
            this.ID_Technique.ValueMember = "ID_Technique";
            // 
            // techniqueBindingSource
            // 
            this.techniqueBindingSource.DataMember = "Technique";
            this.techniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // proizvoditelyBindingSource
            // 
            this.proizvoditelyBindingSource.DataMember = "Proizvoditely";
            this.proizvoditelyBindingSource.DataSource = this.иСDataSet;
            // 
            // proizvoditelyTableAdapter
            // 
            this.proizvoditelyTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(777, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(883, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // techniqueTableAdapter
            // 
            this.techniqueTableAdapter.ClearBeforeFill = true;
            // 
            // proizvoditelyBindingSource2
            // 
            this.proizvoditelyBindingSource2.DataMember = "Proizvoditely";
            this.proizvoditelyBindingSource2.DataSource = this.иСDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // proizvoditelyBindingSource3
            // 
            this.proizvoditelyBindingSource3.DataMember = "Proizvoditely";
            this.proizvoditelyBindingSource3.DataSource = this.иСDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSotrudnikDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.adressprojivaniaDataGridViewTextBoxColumn,
            this.nomerphoneDataGridViewTextBoxColumn,
            this.ID_Doljnost});
            this.dataGridView3.DataSource = this.sotrudnikBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(12, 231);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(736, 150);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // iDSotrudnikDataGridViewTextBoxColumn
            // 
            this.iDSotrudnikDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnik";
            this.iDSotrudnikDataGridViewTextBoxColumn.HeaderText = "ID_Sotrudnik";
            this.iDSotrudnikDataGridViewTextBoxColumn.Name = "iDSotrudnikDataGridViewTextBoxColumn";
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "Imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Imya";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // adressprojivaniaDataGridViewTextBoxColumn
            // 
            this.adressprojivaniaDataGridViewTextBoxColumn.DataPropertyName = "Adress_projivania";
            this.adressprojivaniaDataGridViewTextBoxColumn.HeaderText = "Adress_projivania";
            this.adressprojivaniaDataGridViewTextBoxColumn.Name = "adressprojivaniaDataGridViewTextBoxColumn";
            // 
            // nomerphoneDataGridViewTextBoxColumn
            // 
            this.nomerphoneDataGridViewTextBoxColumn.DataPropertyName = "Nomer_phone";
            this.nomerphoneDataGridViewTextBoxColumn.HeaderText = "Nomer_phone";
            this.nomerphoneDataGridViewTextBoxColumn.Name = "nomerphoneDataGridViewTextBoxColumn";
            // 
            // ID_Doljnost
            // 
            this.ID_Doljnost.DataPropertyName = "ID_Doljnost";
            this.ID_Doljnost.DataSource = this.sotrudnikBindingSource2;
            this.ID_Doljnost.DisplayMember = "Familiya";
            this.ID_Doljnost.HeaderText = "Должность";
            this.ID_Doljnost.Name = "ID_Doljnost";
            this.ID_Doljnost.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource2
            // 
            this.sotrudnikBindingSource2.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource2.DataSource = this.иСDataSet;
            // 
            // sotrudnikBindingSource1
            // 
            this.sotrudnikBindingSource1.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource1.DataSource = this.иСDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 37);
            this.button6.TabIndex = 9;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 387);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(245, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 34);
            this.button8.TabIndex = 10;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(245, 387);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(151, 37);
            this.button9.TabIndex = 11;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(983, 176);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Uchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ИС.Properties.Resources.maxresdefault__1_;
            this.ClientSize = new System.Drawing.Size(1310, 542);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MinimizeBox = false;
            this.Name = "Uchet";
            this.Text = "Uchet";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public ИСDataSet иСDataSet;
        private System.Windows.Forms.BindingSource uchettechniqueBindingSource;
        public ИСDataSetTableAdapters.Uchet_techniqueTableAdapter uchet_techniqueTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource proizvoditelyBindingSource;
        public ИСDataSetTableAdapters.ProizvoditelyTableAdapter proizvoditelyTableAdapter;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource techniqueBindingSource;
        private ИСDataSetTableAdapters.TechniqueTableAdapter techniqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProizvoditelyaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomertelephonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Technique;
        private System.Windows.Forms.BindingSource proizvoditelyBindingSource1;
        private System.Windows.Forms.BindingSource techniqueBindingSource1;
        private System.Windows.Forms.BindingSource proizvoditelyBindingSource2;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        public ИСDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUchettechniqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerskladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvonaskladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBox2;
        private System.Windows.Forms.DataGridViewComboBoxColumn combobox3;
        private System.Windows.Forms.BindingSource proizvoditelyBindingSource3;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressprojivaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Doljnost;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource2;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource1;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}