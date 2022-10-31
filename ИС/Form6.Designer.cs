
namespace ИС
{
    partial class Form6
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.иСDataSet = new ИС.ИСDataSet();
            this.proizvoditelyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditelyTableAdapter = new ИС.ИСDataSetTableAdapters.ProizvoditelyTableAdapter();
            this.uchettechniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchet_techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.Uchet_techniqueTableAdapter();
            this.techniqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniqueTableAdapter = new ИС.ИСDataSetTableAdapters.TechniqueTableAdapter();
            this.uchettechniqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new ИС.ИСDataSetTableAdapters.SotrudnikTableAdapter();
            this.uchettechniqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchettechniqueBindingSource, "ID_Proizvoditelya", true));
            this.comboBox1.DataSource = this.proizvoditelyBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "ID_Proizvoditelya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Кол-во на складе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Брак";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер склада";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 103);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchettechniqueBindingSource1, "ID_Technique", true));
            this.comboBox2.DataSource = this.techniqueBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "ID_Technique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Техника";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchettechniqueBindingSource2, "ID_Sotrudnik", true));
            this.comboBox3.DataSource = this.sotrudnikBindingSource;
            this.comboBox3.DisplayMember = "Familiya";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(110, 221);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(166, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.ValueMember = "ID_Sotrudnik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Сотрудник";
            // 
            // иСDataSet
            // 
            this.иСDataSet.DataSetName = "ИСDataSet";
            this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // uchettechniqueBindingSource
            // 
            this.uchettechniqueBindingSource.DataMember = "Uchet_technique";
            this.uchettechniqueBindingSource.DataSource = this.иСDataSet;
            // 
            // uchet_techniqueTableAdapter
            // 
            this.uchet_techniqueTableAdapter.ClearBeforeFill = true;
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
            // uchettechniqueBindingSource1
            // 
            this.uchettechniqueBindingSource1.DataMember = "Uchet_technique";
            this.uchettechniqueBindingSource1.DataSource = this.иСDataSet;
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
            // uchettechniqueBindingSource2
            // 
            this.uchettechniqueBindingSource2.DataMember = "Uchet_technique";
            this.uchettechniqueBindingSource2.DataSource = this.иСDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchettechniqueBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private ИСDataSet иСDataSet;
        private System.Windows.Forms.BindingSource proizvoditelyBindingSource;
        private ИСDataSetTableAdapters.ProizvoditelyTableAdapter proizvoditelyTableAdapter;
        private System.Windows.Forms.BindingSource uchettechniqueBindingSource;
        private ИСDataSetTableAdapters.Uchet_techniqueTableAdapter uchet_techniqueTableAdapter;
        private System.Windows.Forms.BindingSource techniqueBindingSource;
        private ИСDataSetTableAdapters.TechniqueTableAdapter techniqueTableAdapter;
        private System.Windows.Forms.BindingSource uchettechniqueBindingSource1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ИСDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource uchettechniqueBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}