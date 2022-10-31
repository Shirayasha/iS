
namespace ИС
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.иСDataSet = new ИС.ИСDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new ИС.ИСDataSetTableAdapters.SotrudnikTableAdapter();
            this.zakupkatechiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupka_techiqueTableAdapter = new ИС.ИСDataSetTableAdapters.Zakupka_techiqueTableAdapter();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikTableAdapter = new ИС.ИСDataSetTableAdapters.PostavchikTableAdapter();
            this.zakupkatechiqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.TechniqueTableAdapter();
            this.zakupkatechiqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_oplatiTableAdapter = new ИС.ИСDataSetTableAdapters.Tip_oplatiTableAdapter();
            this.zakupkatechiqueBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата поставки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер договора";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zakupkatechiqueBindingSource, "ID_Sotrudnik", true));
            this.comboBox1.DataSource = this.sotrudnikBindingSource;
            this.comboBox1.DisplayMember = "Familiya";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "ID_Sotrudnik";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zakupkatechiqueBindingSource1, "ID_Postavchik", true));
            this.comboBox2.DataSource = this.postavchikBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "ID_Postavchik";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zakupkatechiqueBindingSource2, "ID_Technique", true));
            this.comboBox3.DataSource = this.techniqueBindingSource;
            this.comboBox3.DisplayMember = "Naimenovanie";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 118);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "ID_Technique";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zakupkatechiqueBindingSource3, "ID_Tip_oplati", true));
            this.comboBox4.DataSource = this.tipoplatiBindingSource;
            this.comboBox4.DisplayMember = "Tip_oplati";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(109, 145);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(198, 21);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.ValueMember = "ID_Tip_oplati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сотрудник";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поставщик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Техника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Тип оплаты";
            // 
            // иСDataSet
            // 
            this.иСDataSet.DataSetName = "ИСDataSet";
            this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.иСDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // zakupkatechiqueBindingSource
            // 
            this.zakupkatechiqueBindingSource.DataMember = "Zakupka_techique";
            this.zakupkatechiqueBindingSource.DataSource = this.иСDataSet;
            // 
            // zakupka_techiqueTableAdapter
            // 
            this.zakupka_techiqueTableAdapter.ClearBeforeFill = true;
            // 
            // postavchikBindingSource
            // 
            this.postavchikBindingSource.DataMember = "Postavchik";
            this.postavchikBindingSource.DataSource = this.иСDataSet;
            // 
            // postavchikTableAdapter
            // 
            this.postavchikTableAdapter.ClearBeforeFill = true;
            // 
            // zakupkatechiqueBindingSource1
            // 
            this.zakupkatechiqueBindingSource1.DataMember = "Zakupka_techique";
            this.zakupkatechiqueBindingSource1.DataSource = this.иСDataSet;
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
            // zakupkatechiqueBindingSource2
            // 
            this.zakupkatechiqueBindingSource2.DataMember = "Zakupka_techique";
            this.zakupkatechiqueBindingSource2.DataSource = this.иСDataSet;
            // 
            // tipoplatiBindingSource
            // 
            this.tipoplatiBindingSource.DataMember = "Tip_oplati";
            this.tipoplatiBindingSource.DataSource = this.иСDataSet;
            // 
            // tip_oplatiTableAdapter
            // 
            this.tip_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // zakupkatechiqueBindingSource3
            // 
            this.zakupkatechiqueBindingSource3.DataMember = "Zakupka_techique";
            this.zakupkatechiqueBindingSource3.DataSource = this.иСDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 228);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatechiqueBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ИСDataSet иСDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ИСDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource zakupkatechiqueBindingSource;
        private ИСDataSetTableAdapters.Zakupka_techiqueTableAdapter zakupka_techiqueTableAdapter;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        private ИСDataSetTableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        private System.Windows.Forms.BindingSource zakupkatechiqueBindingSource1;
        private System.Windows.Forms.BindingSource techniqueBindingSource;
        private ИСDataSetTableAdapters.TechniqueTableAdapter techniqueTableAdapter;
        private System.Windows.Forms.BindingSource zakupkatechiqueBindingSource2;
        private System.Windows.Forms.BindingSource tipoplatiBindingSource;
        private ИСDataSetTableAdapters.Tip_oplatiTableAdapter tip_oplatiTableAdapter;
        private System.Windows.Forms.BindingSource zakupkatechiqueBindingSource3;
    }
}