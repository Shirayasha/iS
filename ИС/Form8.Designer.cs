
namespace ИС
{
    partial class Form8
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Стоимость = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.иСDataSet = new ИС.ИСDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new ИС.ИСDataSetTableAdapters.SotrudnikTableAdapter();
            this.prodagatechniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaga_techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.Prodaga_techniqueTableAdapter();
            this.tipoplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_oplatiTableAdapter = new ИС.ИСDataSetTableAdapters.Tip_oplatiTableAdapter();
            this.prodagatechniqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.TechniqueTableAdapter();
            this.prodagatechniqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prodagatechniqueBindingSource2, "ID_Technique", true));
            this.comboBox1.DataSource = this.techniqueBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "ID_Technique";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prodagatechniqueBindingSource1, "ID_Tip_oplati", true));
            this.comboBox2.DataSource = this.tipoplatiBindingSource;
            this.comboBox2.DisplayMember = "Tip_oplati";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "ID_Tip_oplati";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prodagatechniqueBindingSource, "ID_Sotrudnik", true));
            this.comboBox3.DataSource = this.sotrudnikBindingSource;
            this.comboBox3.DisplayMember = "Familiya";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(165, 175);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(166, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.ValueMember = "ID_Sotrudnik";
            // 
            // Стоимость
            // 
            this.Стоимость.AutoSize = true;
            this.Стоимость.Location = new System.Drawing.Point(86, 17);
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.Size = new System.Drawing.Size(62, 13);
            this.Стоимость.TabIndex = 24;
            this.Стоимость.Text = "Стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Техника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 137);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Тип оплаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Сотрудник";
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
            // prodagatechniqueBindingSource
            // 
            this.prodagatechniqueBindingSource.DataMember = "Prodaga_technique";
            this.prodagatechniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // prodaga_techniqueTableAdapter
            // 
            this.prodaga_techniqueTableAdapter.ClearBeforeFill = true;
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
            // prodagatechniqueBindingSource1
            // 
            this.prodagatechniqueBindingSource1.DataMember = "Prodaga_technique";
            this.prodagatechniqueBindingSource1.DataSource = this.иСDataSet;
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
            // prodagatechniqueBindingSource2
            // 
            this.prodagatechniqueBindingSource2.DataMember = "Prodaga_technique";
            this.prodagatechniqueBindingSource2.DataSource = this.иСDataSet;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Стоимость);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagatechniqueBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Стоимость;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ИСDataSet иСDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ИСDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource prodagatechniqueBindingSource;
        private ИСDataSetTableAdapters.Prodaga_techniqueTableAdapter prodaga_techniqueTableAdapter;
        private System.Windows.Forms.BindingSource tipoplatiBindingSource;
        private ИСDataSetTableAdapters.Tip_oplatiTableAdapter tip_oplatiTableAdapter;
        private System.Windows.Forms.BindingSource prodagatechniqueBindingSource1;
        private System.Windows.Forms.BindingSource techniqueBindingSource;
        private ИСDataSetTableAdapters.TechniqueTableAdapter techniqueTableAdapter;
        private System.Windows.Forms.BindingSource prodagatechniqueBindingSource2;
    }
}