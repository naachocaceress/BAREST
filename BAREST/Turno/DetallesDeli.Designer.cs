﻿
namespace BAREST.Turno
{
    partial class DetallesDeli
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
            this.Imprimir = new FontAwesome.Sharp.IconButton();
            this.Confirmar = new FontAwesome.Sharp.IconButton();
            this.Cancelar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAbona = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textObse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.Imprimir);
            this.panel1.Controls.Add(this.Confirmar);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 50);
            this.panel1.TabIndex = 48;
            // 
            // Imprimir
            // 
            this.Imprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.Imprimir.FlatAppearance.BorderSize = 0;
            this.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Imprimir.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.Imprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Imprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Imprimir.IconSize = 30;
            this.Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir.Location = new System.Drawing.Point(0, 0);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(100, 50);
            this.Imprimir.TabIndex = 6;
            this.Imprimir.Text = "       Imprimir";
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            this.Confirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Confirmar.FlatAppearance.BorderSize = 0;
            this.Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Confirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Confirmar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Confirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Confirmar.IconSize = 30;
            this.Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmar.Location = new System.Drawing.Point(138, 0);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(109, 50);
            this.Confirmar.TabIndex = 7;
            this.Confirmar.Text = "       Confirmar";
            this.Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Cancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.Cancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cancelar.IconSize = 30;
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.Location = new System.Drawing.Point(247, 0);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 50);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "       Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Direccion:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(73, 14);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(127, 20);
            this.textNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(73, 69);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 2;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(73, 119);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(258, 20);
            this.textDireccion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Abona con: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "$400";
            // 
            // textAbona
            // 
            this.textAbona.Location = new System.Drawing.Point(6, 74);
            this.textAbona.Name = "textAbona";
            this.textAbona.Size = new System.Drawing.Size(100, 20);
            this.textAbona.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textAbona);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(214, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 103);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // textObse
            // 
            this.textObse.Location = new System.Drawing.Point(12, 173);
            this.textObse.Multiline = true;
            this.textObse.Name = "textObse";
            this.textObse.Size = new System.Drawing.Size(319, 44);
            this.textObse.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Observaciones:";
            // 
            // DetallesDeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 279);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textObse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DetallesDeli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.DetallesDeli_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Confirmar;
        private FontAwesome.Sharp.IconButton Cancelar;
        private FontAwesome.Sharp.IconButton Imprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textObse;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textAbona;
    }
}