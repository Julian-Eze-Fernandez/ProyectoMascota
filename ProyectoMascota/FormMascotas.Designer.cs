namespace ProyectoMascota
{
    partial class FormMascotas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_SiCastrada = new System.Windows.Forms.RadioButton();
            this.radiobtn_NoCastrada = new System.Windows.Forms.RadioButton();
            this.groupBox_Vacunada = new System.Windows.Forms.GroupBox();
            this.radiobtn_NoVacuna = new System.Windows.Forms.RadioButton();
            this.radiobtn_SiVacuna = new System.Windows.Forms.RadioButton();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl_UltControl = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.dgv_Mascotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Vacunada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Modificar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Eliminar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Vacunada);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Cargar);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Sexo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_UltControl);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Peso);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Edad);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Peso);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Nombre);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Nombre);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Tipo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Tipo);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Edad);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Sexo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Mascotas);
            this.splitContainer1.Size = new System.Drawing.Size(1359, 420);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 18;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(43, 334);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(256, 37);
            this.btn_Modificar.TabIndex = 26;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(43, 377);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(256, 37);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_SiCastrada);
            this.groupBox2.Controls.Add(this.radiobtn_NoCastrada);
            this.groupBox2.Location = new System.Drawing.Point(142, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 86);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Castrada";
            // 
            // radiobtn_SiCastrada
            // 
            this.radiobtn_SiCastrada.AutoSize = true;
            this.radiobtn_SiCastrada.Location = new System.Drawing.Point(10, 26);
            this.radiobtn_SiCastrada.Name = "radiobtn_SiCastrada";
            this.radiobtn_SiCastrada.Size = new System.Drawing.Size(34, 17);
            this.radiobtn_SiCastrada.TabIndex = 21;
            this.radiobtn_SiCastrada.TabStop = true;
            this.radiobtn_SiCastrada.Text = "Si";
            this.radiobtn_SiCastrada.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NoCastrada
            // 
            this.radiobtn_NoCastrada.AutoSize = true;
            this.radiobtn_NoCastrada.Location = new System.Drawing.Point(10, 49);
            this.radiobtn_NoCastrada.Name = "radiobtn_NoCastrada";
            this.radiobtn_NoCastrada.Size = new System.Drawing.Size(39, 17);
            this.radiobtn_NoCastrada.TabIndex = 22;
            this.radiobtn_NoCastrada.TabStop = true;
            this.radiobtn_NoCastrada.Text = "No";
            this.radiobtn_NoCastrada.UseVisualStyleBackColor = true;
            // 
            // groupBox_Vacunada
            // 
            this.groupBox_Vacunada.Controls.Add(this.radiobtn_NoVacuna);
            this.groupBox_Vacunada.Controls.Add(this.radiobtn_SiVacuna);
            this.groupBox_Vacunada.Location = new System.Drawing.Point(142, 12);
            this.groupBox_Vacunada.Name = "groupBox_Vacunada";
            this.groupBox_Vacunada.Size = new System.Drawing.Size(184, 86);
            this.groupBox_Vacunada.TabIndex = 23;
            this.groupBox_Vacunada.TabStop = false;
            this.groupBox_Vacunada.Text = "Vacunada";
            // 
            // radiobtn_NoVacuna
            // 
            this.radiobtn_NoVacuna.AutoSize = true;
            this.radiobtn_NoVacuna.Location = new System.Drawing.Point(10, 52);
            this.radiobtn_NoVacuna.Name = "radiobtn_NoVacuna";
            this.radiobtn_NoVacuna.Size = new System.Drawing.Size(39, 17);
            this.radiobtn_NoVacuna.TabIndex = 20;
            this.radiobtn_NoVacuna.TabStop = true;
            this.radiobtn_NoVacuna.Text = "No";
            this.radiobtn_NoVacuna.UseVisualStyleBackColor = true;
            // 
            // radiobtn_SiVacuna
            // 
            this.radiobtn_SiVacuna.AutoSize = true;
            this.radiobtn_SiVacuna.Location = new System.Drawing.Point(10, 28);
            this.radiobtn_SiVacuna.Name = "radiobtn_SiVacuna";
            this.radiobtn_SiVacuna.Size = new System.Drawing.Size(34, 17);
            this.radiobtn_SiVacuna.TabIndex = 19;
            this.radiobtn_SiVacuna.TabStop = true;
            this.radiobtn_SiVacuna.Text = "Si";
            this.radiobtn_SiVacuna.UseVisualStyleBackColor = true;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(14, 23);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 14;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(43, 291);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(256, 37);
            this.btn_Cargar.TabIndex = 0;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Items.AddRange(new object[] {
            "Hembra",
            "Macho"});
            this.cmb_Sexo.Location = new System.Drawing.Point(14, 165);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(100, 21);
            this.cmb_Sexo.TabIndex = 16;
            // 
            // lbl_UltControl
            // 
            this.lbl_UltControl.AutoSize = true;
            this.lbl_UltControl.Location = new System.Drawing.Point(139, 237);
            this.lbl_UltControl.Name = "lbl_UltControl";
            this.lbl_UltControl.Size = new System.Drawing.Size(72, 13);
            this.lbl_UltControl.TabIndex = 13;
            this.lbl_UltControl.Text = "Ultimo Control";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Location = new System.Drawing.Point(15, 240);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_Peso.TabIndex = 6;
            this.lbl_Peso.Text = "Peso";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 27, 23, 29, 29, 0);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(11, 7);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_Codigo.TabIndex = 15;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(11, 99);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_Edad.TabIndex = 3;
            this.lbl_Edad.Text = "Edad";
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(14, 256);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(100, 20);
            this.txt_Peso.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(14, 67);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(11, 51);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Conejo",
            "Gato",
            "Hamster",
            "Pajaro",
            "Perro",
            "Otro"});
            this.cmb_Tipo.Location = new System.Drawing.Point(14, 211);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(100, 21);
            this.cmb_Tipo.TabIndex = 9;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(15, 195);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_Tipo.TabIndex = 4;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(14, 115);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 20);
            this.txt_Edad.TabIndex = 7;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(11, 147);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sexo.TabIndex = 5;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // dgv_Mascotas
            // 
            this.dgv_Mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mascotas.Location = new System.Drawing.Point(3, 3);
            this.dgv_Mascotas.Name = "dgv_Mascotas";
            this.dgv_Mascotas.Size = new System.Drawing.Size(1002, 403);
            this.dgv_Mascotas.TabIndex = 0;
            // 
            // FormMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 455);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMascotas";
            this.Text = "FormMascotas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Vacunada.ResumeLayout(false);
            this.groupBox_Vacunada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtn_SiCastrada;
        private System.Windows.Forms.RadioButton radiobtn_NoCastrada;
        private System.Windows.Forms.GroupBox groupBox_Vacunada;
        private System.Windows.Forms.RadioButton radiobtn_NoVacuna;
        private System.Windows.Forms.RadioButton radiobtn_SiVacuna;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.ComboBox cmb_Sexo;
        private System.Windows.Forms.Label lbl_UltControl;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.DataGridView dgv_Mascotas;
    }
}