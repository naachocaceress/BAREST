﻿
namespace BAREST.Compras
{
    partial class Insumos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnLista = new FontAwesome.Sharp.IconButton();
            this.agregarInsu = new FontAwesome.Sharp.IconButton();
            this.EliminarInsu = new FontAwesome.Sharp.IconButton();
            this.modificarInsu = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaRubro = new System.Windows.Forms.DataGridView();
            this.Rubros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarRubro = new System.Windows.Forms.Button();
            this.agregarRubro = new System.Windows.Forms.Button();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescInsumo = new System.Windows.Forms.TextBox();
            this.comboRubroInsumo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.tablaInsumo = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboUnidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimefechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.textidInsumo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(this.agregarInsu);
            this.panel1.Controls.Add(this.EliminarInsu);
            this.panel1.Controls.Add(this.modificarInsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnguardar
            // 
            this.btnguardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 30;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(308, 0);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(99, 62);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "       Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLista.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLista.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLista.IconSize = 30;
            this.btnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.Location = new System.Drawing.Point(0, 0);
            this.btnLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(110, 62);
            this.btnLista.TabIndex = 10;
            this.btnLista.Text = "       Lista";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // agregarInsu
            // 
            this.agregarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregarInsu.FlatAppearance.BorderSize = 0;
            this.agregarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarInsu.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.agregarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarInsu.IconSize = 30;
            this.agregarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarInsu.Location = new System.Drawing.Point(407, 0);
            this.agregarInsu.Margin = new System.Windows.Forms.Padding(4);
            this.agregarInsu.Name = "agregarInsu";
            this.agregarInsu.Size = new System.Drawing.Size(102, 62);
            this.agregarInsu.TabIndex = 7;
            this.agregarInsu.Text = "       Agregar";
            this.agregarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarInsu.UseVisualStyleBackColor = true;
            this.agregarInsu.Click += new System.EventHandler(this.agregarInsu_Click);
            // 
            // EliminarInsu
            // 
            this.EliminarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarInsu.FlatAppearance.BorderSize = 0;
            this.EliminarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.EliminarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarInsu.IconSize = 30;
            this.EliminarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.Location = new System.Drawing.Point(509, 0);
            this.EliminarInsu.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarInsu.Name = "EliminarInsu";
            this.EliminarInsu.Size = new System.Drawing.Size(98, 62);
            this.EliminarInsu.TabIndex = 6;
            this.EliminarInsu.Text = "       Eliminar";
            this.EliminarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.UseVisualStyleBackColor = true;
            this.EliminarInsu.Click += new System.EventHandler(this.EliminarInsu_Click);
            // 
            // modificarInsu
            // 
            this.modificarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.modificarInsu.FlatAppearance.BorderSize = 0;
            this.modificarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarInsu.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.modificarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificarInsu.IconSize = 30;
            this.modificarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarInsu.Location = new System.Drawing.Point(607, 0);
            this.modificarInsu.Margin = new System.Windows.Forms.Padding(4);
            this.modificarInsu.Name = "modificarInsu";
            this.modificarInsu.Size = new System.Drawing.Size(102, 62);
            this.modificarInsu.TabIndex = 5;
            this.modificarInsu.Text = "       Modificar";
            this.modificarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarInsu.UseVisualStyleBackColor = true;
            this.modificarInsu.Click += new System.EventHandler(this.modificarInsu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaRubro);
            this.groupBox1.Controls.Add(this.eliminarRubro);
            this.groupBox1.Controls.Add(this.agregarRubro);
            this.groupBox1.Controls.Add(this.textRubro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(460, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(225, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rubros";
            // 
            // tablaRubro
            // 
            this.tablaRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rubros});
            this.tablaRubro.Location = new System.Drawing.Point(11, 46);
            this.tablaRubro.Margin = new System.Windows.Forms.Padding(4);
            this.tablaRubro.Name = "tablaRubro";
            this.tablaRubro.Size = new System.Drawing.Size(206, 145);
            this.tablaRubro.TabIndex = 4;
            // 
            // Rubros
            // 
            this.Rubros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rubros.HeaderText = "Rubros";
            this.Rubros.Name = "Rubros";
            // 
            // eliminarRubro
            // 
            this.eliminarRubro.Location = new System.Drawing.Point(147, 199);
            this.eliminarRubro.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarRubro.Name = "eliminarRubro";
            this.eliminarRubro.Size = new System.Drawing.Size(70, 29);
            this.eliminarRubro.TabIndex = 3;
            this.eliminarRubro.Text = "Eliminar";
            this.eliminarRubro.UseVisualStyleBackColor = true;
            this.eliminarRubro.Click += new System.EventHandler(this.eliminarRubro_Click);
            // 
            // agregarRubro
            // 
            this.agregarRubro.Location = new System.Drawing.Point(11, 199);
            this.agregarRubro.Margin = new System.Windows.Forms.Padding(4);
            this.agregarRubro.Name = "agregarRubro";
            this.agregarRubro.Size = new System.Drawing.Size(70, 29);
            this.agregarRubro.TabIndex = 2;
            this.agregarRubro.Text = "Agregar";
            this.agregarRubro.UseVisualStyleBackColor = true;
            this.agregarRubro.Click += new System.EventHandler(this.agregarRubro_Click);
            // 
            // textRubro
            // 
            this.textRubro.Location = new System.Drawing.Point(76, 16);
            this.textRubro.Margin = new System.Windows.Forms.Padding(4);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(141, 22);
            this.textRubro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // textDescInsumo
            // 
            this.textDescInsumo.Location = new System.Drawing.Point(109, 17);
            this.textDescInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.textDescInsumo.Name = "textDescInsumo";
            this.textDescInsumo.Size = new System.Drawing.Size(240, 22);
            this.textDescInsumo.TabIndex = 1;
            // 
            // comboRubroInsumo
            // 
            this.comboRubroInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRubroInsumo.FormattingEnabled = true;
            this.comboRubroInsumo.Location = new System.Drawing.Point(109, 126);
            this.comboRubroInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.comboRubroInsumo.Name = "comboRubroInsumo";
            this.comboRubroInsumo.Size = new System.Drawing.Size(160, 24);
            this.comboRubroInsumo.TabIndex = 4;
            this.comboRubroInsumo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(109, 51);
            this.textCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(85, 22);
            this.textCantidad.TabIndex = 2;
            // 
            // tablaInsumo
            // 
            this.tablaInsumo.AllowUserToAddRows = false;
            this.tablaInsumo.AllowUserToDeleteRows = false;
            this.tablaInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaInsumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tablaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.cantidad,
            this.unidad,
            this.rubro,
            this.fechaIngreso});
            this.tablaInsumo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablaInsumo.Location = new System.Drawing.Point(0, 257);
            this.tablaInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.tablaInsumo.Name = "tablaInsumo";
            this.tablaInsumo.ReadOnly = true;
            this.tablaInsumo.Size = new System.Drawing.Size(709, 262);
            this.tablaInsumo.TabIndex = 11;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // rubro
            // 
            this.rubro.HeaderText = "Rubro";
            this.rubro.Name = "rubro";
            this.rubro.ReadOnly = true;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.HeaderText = "Fecha Ingresado";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            // 
            // comboUnidad
            // 
            this.comboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnidad.FormattingEnabled = true;
            this.comboUnidad.Items.AddRange(new object[] {
            "Kg",
            "Litro",
            "Un",
            "Bolsa",
            "Caja",
            "Otra"});
            this.comboUnidad.Location = new System.Drawing.Point(109, 87);
            this.comboUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.comboUnidad.Name = "comboUnidad";
            this.comboUnidad.Size = new System.Drawing.Size(85, 24);
            this.comboUnidad.TabIndex = 3;
            this.comboUnidad.SelectedIndexChanged += new System.EventHandler(this.comboUnidad_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "F. ingresado:";
            // 
            // dateTimefechaIngreso
            // 
            this.dateTimefechaIngreso.Location = new System.Drawing.Point(109, 166);
            this.dateTimefechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimefechaIngreso.Name = "dateTimefechaIngreso";
            this.dateTimefechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.dateTimefechaIngreso.TabIndex = 5;
            // 
            // textidInsumo
            // 
            this.textidInsumo.Location = new System.Drawing.Point(289, 228);
            this.textidInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.textidInsumo.Name = "textidInsumo";
            this.textidInsumo.Size = new System.Drawing.Size(85, 22);
            this.textidInsumo.TabIndex = 16;
            this.textidInsumo.Visible = false;
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(709, 581);
            this.Controls.Add(this.textidInsumo);
            this.Controls.Add(this.dateTimefechaIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboUnidad);
            this.Controls.Add(this.tablaInsumo);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboRubroInsumo);
            this.Controls.Add(this.textDescInsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Insumos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.Insumos_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubros;
        private System.Windows.Forms.Button eliminarRubro;
        private System.Windows.Forms.Button agregarRubro;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDescInsumo;
        private System.Windows.Forms.ComboBox comboRubroInsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCantidad;
        private FontAwesome.Sharp.IconButton agregarInsu;
        private FontAwesome.Sharp.IconButton EliminarInsu;
        private FontAwesome.Sharp.IconButton modificarInsu;
        private System.Windows.Forms.DataGridView tablaInsumo;
        private System.Windows.Forms.ComboBox comboUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimefechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.TextBox textidInsumo;
        private FontAwesome.Sharp.IconButton btnLista;
        private FontAwesome.Sharp.IconButton btnguardar;
    }
}