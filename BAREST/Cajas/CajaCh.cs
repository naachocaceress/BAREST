﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BAREST.Cajas
{
    public partial class CajaCh : Form
    {
        public CajaCh()
        {
            InitializeComponent();
        }

        private void btnAgregarRes_Click(object sender, System.EventArgs e)
        {
            Cajas.Cajagr m = new Cajas.Cajagr();
            m.Show();
        }

        private void btnEliminarRes_Click(object sender, System.EventArgs e)
        {
            Cajas.Cajasc m = new Cajas.Cajasc();
            m.Show();
        }




        private void gastosvarios_Click(object sender, System.EventArgs e)
        {
            IngresarMonto m = new IngresarMonto(this, "Gastos varios");
            m.TreeViewDestino = treeView1; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Gastos varios";
            m.Show();
        }

        private void ajustesdecaja_Click(object sender, System.EventArgs e)
        {
            IngresarMonto m = new IngresarMonto(this, "Ajuste de caja");
            m.TreeViewDestino = treeView1; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Ajustes de caja - Egreso";
            m.Show();
        }

        private void acajagrande_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this, "Retiros a caja grande");
            m.TreeViewDestino = treeView1; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Retiros a caja grande";
            m.Show();
        }

        private void acajasocios_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this, "Retiros a caja socios");
            m.TreeViewDestino = treeView1; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Retiros a caja socios";
            m.Show();
        }

        //---------------------------------------------------------------------------

        private void ajustesdecajaingreso_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this, "Ajuste de cajasd");
            m.TreeViewDestino = treeView2; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Ajustes de caja - Ingreso";
            m.Show();
        }

        private void decajagrande_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this, "Aporte de caja grande");
            m.TreeViewDestino = treeView2; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Aporte de caja grande";
            m.Show();
        }

        private void decajasocios_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this, "Aporte de caja socios");
            m.TreeViewDestino = treeView2; // Establece el TreeView 2 como destino
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Aporte de caja socios";
            m.Show();
        }

        public void sumarsaldo()
        {
            double ingreso = Convert.ToDouble(textBox3.Text);
            double salida = Convert.ToDouble(txtTotal.Text);

            double total = ingreso - salida;

            textBox1.Text = total.ToString("N2");
        }


        public void RealizarSumaTreeView1()
        {
            decimal suma = CalcularSumaNumerosTreeView2(treeView1.Nodes);
            txtTotal.Text = suma.ToString("N2");
        }

        public void RealizarSumaTreeView2()
        {
            decimal suma = CalcularSumaNumerosTreeView2(treeView2.Nodes);
            textBox3.Text = suma.ToString("N2");
        }

        private decimal CalcularSumaNumerosTreeView2(TreeNodeCollection nodes)
        {
            decimal suma = 0;

            foreach (TreeNode node in nodes)
            {
                suma += ExtraerNumerosNodo(node.Text);

                suma += CalcularSumaNumerosTreeView2(node.Nodes);
            }

            return suma;
        }

        private decimal ExtraerNumerosNodo(string texto)
        {
            string numerosString = string.Empty;

            foreach (char c in texto)
            {
                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                    numerosString += c;
                }
            }

            decimal valor;
            decimal.TryParse(numerosString, out valor);

            return valor;
        }

        private void CajaCh_Load(object sender, System.EventArgs e)
        {
            txtTotal.Text = "0,00";
            textBox1.Text = "0,00";
            textBox3.Text = "0,00";
        }



        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null && e.Node.Nodes.Count == 0) // Verifica que el nodo no tenga hijos
            {
                // Obtén el texto completo del nodo
                string nodeText = e.Node.Text;

                // Obtiene el índice del nodo
                int nodeIndex = e.Node.Index;

                // Busca el índice del signo peso en el texto
                int pesoIndex = nodeText.IndexOf('$');

                if (pesoIndex != -1)
                {
                    // Extrae el concepto y el monto separadamente
                    string concepto = nodeText.Substring(0, pesoIndex);
                    string montoStr = nodeText.Substring(pesoIndex + 1).Trim(); // Elimina los espacios iniciales y finales

                    // Elimina el signo de peso del monto
                    montoStr = montoStr.Replace("$", string.Empty);

                    // Crea una instancia del formulario IngresarMonto
                    IngresarMonto ingresoMonto = new IngresarMonto(this, concepto, montoStr);

                    ingresoMonto.NodoIndex = nodeIndex;
                    ingresoMonto.TreeViewDestino = treeView1;
                    // Muestra el formulario IngresarMonto
                    ingresoMonto.ShowDialog();

                    // Actualiza el nodo con los nuevos valores si se confirmó la operación
                    if (ingresoMonto.Confirmado)
                    {
                        // Actualiza los campos de concepto y monto del nodo
                        string updatedText = ingresoMonto.Concepto + " $" + ingresoMonto.Monto;
                        e.Node.Text = updatedText.Trim(); // Elimina los espacios iniciales y finales

                        // Refresca el TreeView para mostrar el cambio
                        treeView1.Refresh();
                    }
                }
            }
        }
    }
}