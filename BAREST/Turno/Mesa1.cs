﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAREST
{
    public partial class Mesa1 : Form
    {
        public Mesa1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cobro();
            Comandas();
            ClaseCompartida.comanda++;
            //ClaseCompartida.valor = 1;

            // IMPRIMIR COMANDA -----------------------------------

            /* printDocument1 = new PrintDocument();
             PrinterSettings ps = new PrinterSettings();
             printDocument1.PrinterSettings = ps;
             printDocument1.PrintPage += Imprimir;
             printDocument1.Print();*/
            this.Close();
            
        }

        private void Comandas()
        {
            Conexion.ObtenerConexion();
            try
            {
                using (var comanda = new SqlCommand())
                {
                    comanda.Connection = Conexion.ObtenerConexion();
                    comanda.CommandText = "INSERT INTO Comandas (cantidad,detalles,precioUnitario,precioTotal,idMesa,idMozo) VALUES (@cantidad,@detalles,@precioUnitario,@precioTotal,@mesa,@mozo)";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        comanda.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = labelmesa.Text;
                        comanda.Parameters.AddWithValue("@mozo", SqlDbType.VarChar).Value = labelmozo.Text;
                        comanda.Parameters.AddWithValue("@cantidad", SqlDbType.Int).Value = row.Cells[0].Value;
                        comanda.Parameters.AddWithValue("@detalles", SqlDbType.VarChar).Value = row.Cells[1].Value;
                        comanda.Parameters.AddWithValue("@precioUnitario", SqlDbType.Float).Value = row.Cells[2].Value;
                        comanda.Parameters.AddWithValue("@precioTotal", SqlDbType.Float).Value = row.Cells[3].Value;
                        comanda.ExecuteNonQuery();
                        comanda.Parameters.Clear();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
        }
        private void Cobro()
        {
            Conexion.ObtenerConexion();
            try

            {
                using (var comanda = new SqlCommand())
                {
                    comanda.Connection = Conexion.ObtenerConexion();
                    comanda.CommandText = " INSERT INTO Cobro(idMozo,idMesa,comensal,total,fecha) VALUES (@mozoc,@mesac,@comensal,@total,@fecha)";
                    comanda.Parameters.AddWithValue("@mesac", SqlDbType.VarChar).Value = labelmesa.Text;
                    comanda.Parameters.AddWithValue("@mozoc", SqlDbType.VarChar).Value = labelmozo.Text;
                    comanda.Parameters.AddWithValue("@comensal", SqlDbType.VarChar).Value = textBox3.Text;
                    comanda.Parameters.AddWithValue("@total", SqlDbType.Float).Value = textTotal.Text;
                    comanda.Parameters.AddWithValue("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                    comanda.ExecuteNonQuery();
                    comanda.Parameters.Clear();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);


            e.Graphics.DrawString("COMANDA", font, Brushes.Black, new RectangleF(50, 10, 120, 20));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy") + "  Hora: " + DateTime.Now.ToString("HH:mm"), font2, Brushes.Black, new RectangleF(5, 40, 300, 20));


            e.Graphics.DrawString("Mozo: " + labelmozo.Text, font3, Brushes.Black, new RectangleF(5, 70, 300, 20));
            e.Graphics.DrawString("Mesa: " + labelmesa.Text, font3, Brushes.Black, new RectangleF(5, 90, 300, 20));
            e.Graphics.DrawString("N°: " + ClaseCompartida.comanda, font3, Brushes.Black, new RectangleF(150, 80, 300, 20));
            e.Graphics.DrawString("-------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 110, 300, 20));

            int counta = dataGridView1.Rows.Count;

            if (counta == 1)
            {
                e.Graphics.DrawString(" " + dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + dataGridView1.Rows[0].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 130, 300, 20));
                e.Graphics.DrawString("-------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 155, 300, 20));
            }
            else
            {
                e.Graphics.DrawString(" " + dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + dataGridView1.Rows[0].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 130, 300, 20));
                e.Graphics.DrawString(" " + dataGridView1.Rows[1].Cells[0].Value.ToString() + " " + dataGridView1.Rows[1].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 155, 300, 20));
                e.Graphics.DrawString("-------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 175, 300, 20));
            }

            //e.Graphics.DrawString(" " + dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + dataGridView1.Rows[0].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 130, 300, 20));
        }

        public static class ClaseCompartida
        {
            public static int valor = 0;
            public static int usu = 0;
            public static int mmm = 0;
            public static string Mesa = "";
            public static int comanda = 0;
            // otras variables estáticas
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            agregarMenulista2();
        }

        public int cantidad = 0;

        private void agregarMenulista2()
        {
            dataGridView1.ClearSelection();
            try
            {
                if (cantidad == 0)
                {
                    if (textBox2.Text.All(char.IsDigit) && textBox2.Text.Length != 0)
                    {
                        int cantN = Int32.Parse(textBox2.Text);
                        cantidad = cantN;
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            row.Cells["cant"].Value = cantidad;
                        }
                        dataGridView1.Rows.Add(new String[] { cantidad.ToString() });
                        textBox2.Text = "";
                    }
                    else
                    {
                        IngresarMenu();
                    }
                }
                else
                {
                    IngresarMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN LA AGREGAR MENU", MessageBoxButtons.OK);
            }
        }
        // insertar menu ------------------------------------------ falta un poco
        private void IngresarMenu()
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
            Conexion.ObtenerConexion();
            string sql = "SELECT nombre,precio FROM Menu WHERE id = @id";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Clear();
            //comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
            comando.Parameters.Add("@id", SqlDbType.Int).Value = textBox2.Text;
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                float tt2 = float.Parse(registros["precio"].ToString());
                float tt3 = cantidad * tt2;
                string tt4 = tt3.ToString();
                dataGridView1.Rows.Add(new String[] { cantidad.ToString(), registros["nombre"].ToString(), registros["precio"].ToString(), tt4 });
            }
            else
            registros.Close();
            sumaT();
            Conexion.ObtenerConexion().Close();
            textBox2.Text = "";

            ClaseCompartida.valor = 1;// color rojo
            cantidad = 0;
        }
        //  suma los precio total--------------- perfecto

        private void sumaT()
        {
            int sumatorio = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sumatorio += Convert.ToInt32(row.Cells["PTotal"].Value);
            }

            string hola = sumatorio.ToString();

            textTotal.Text = hola;
        }
        //------------------------------------------------------------------

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            sumaT();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textTotal.Text.Length; i++)
            {
                if (textTotal.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        // suma --------------------- perfecto----
        private void iconButton1_Click(object sender, EventArgs e)
        {
            double suma = 1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                suma += Convert.ToDouble(row.Cells["cant"].Value);
                row.Cells["cant"].Value = suma;

                int cant = Convert.ToInt32(row.Cells["cant"].Value);
                int puni = Convert.ToInt32(row.Cells["precio"].Value);

                double sum = cant * puni;

                row.Cells["PTotal"].Value = sum;

                sumaT();
            }
        }
        //  resta -----------------------perfecto----------------------
        private void iconButton2_Click(object sender, EventArgs e)
        {
            double resta = 1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                resta = Convert.ToDouble(row.Cells["cant"].Value) - resta;
                row.Cells["cant"].Value = resta;
                int cant = Convert.ToInt32(row.Cells["cant"].Value);
                int puni = Convert.ToInt32(row.Cells["precio"].Value);
                double sum = cant * puni;
                row.Cells["PTotal"].Value = sum;
            }
            if (resta == 0)
                eliminar();
            sumaT();
        }
        //---------------------------------------------------

        private void Mesa1_Load(object sender, EventArgs e)
        {
                if (ClaseCompartida.mmm == 1)//color rojo
                {
                    try
                    {
                        Conexion.ObtenerConexion();
                        string sql = "SELECT com.cantidad as canti, com.detalles as deta, com.precioUnitario as puni, com.preciototal as ptot, c.comensal as come, c.total as tota, com.idMesa as idm, com.idMozo as idmo FROM Comandas com INNER JOIN Cobro c ON c.idMesa = com.idMesa AND c.idMozo = com.idMozo where com.idMesa = @mesa AND com.estado ='A' AND c.estado ='A'";
                        SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                        comando.Parameters.AddWithValue("@mesa", ClaseCompartida.Mesa);
                        SqlDataReader leido = comando.ExecuteReader();
                        while (leido.Read())
                        {
                            dataGridView1.Rows.Add(new String[]{leido["canti"].ToString(),
                                                            leido["deta"].ToString(),
                                                            leido["puni"].ToString(),
                                                            leido["ptot"].ToString() });
                            textBox3.Text = leido["come"].ToString();
                            textTotal.Text = leido["tota"].ToString();
                            labelmesa.Text = leido["idm"].ToString();
                            labelmozo.Text = leido["idmo"].ToString();

                        }
                         ClaseCompartida.mmm = 0;//color verde
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }

                }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // IMPRIMIR CONTROL -----------------------------------

            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir2;
            printDocument1.Print();

            ClaseCompartida.valor = 5;// color celeste.
            this.Close();
        }
        private void Imprimir2(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font21 = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);


            e.Graphics.DrawString(" VIDON BAR", font, Brushes.Black, new RectangleF(90, 10, 120, 20));
            e.Graphics.DrawString("Fragueiro 2185", font21, Brushes.Black, new RectangleF(98, 35, 300, 20));
            e.Graphics.DrawString("3514742328", font21, Brushes.Black, new RectangleF(110, 50, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 60, 300, 20));

            e.Graphics.DrawString("Control del Pedido", font2, Brushes.Black, new RectangleF(90, 76, 300, 20));
            e.Graphics.DrawString("Mesa: " + labelmesa.Text, font3, Brushes.Black, new RectangleF(100, 90, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 100, 300, 20));

            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy") + "                         Hora: " + DateTime.Now.ToString("HH:mm"), font2, Brushes.Black, new RectangleF(5, 120, 300, 20));
            e.Graphics.DrawString("Mozo: " + labelmozo.Text, font2, Brushes.Black, new RectangleF(5, 135, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 150, 300, 20));

            e.Graphics.DrawString("Cant.  Descripcion                       SubTot.  Total", font2, Brushes.Black, new RectangleF(5, 165, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 170, 300, 20));

            e.Graphics.DrawString(dataGridView1.CurrentRow.Cells[0].Value.ToString() + "     " + dataGridView1.CurrentRow.Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(10, 190, 300, 20));
            e.Graphics.DrawString(dataGridView1.CurrentRow.Cells[2].Value.ToString() + "   " + dataGridView1.CurrentRow.Cells[3].Value.ToString(), font3, Brushes.Black, new RectangleF(205, 190, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 210, 300, 20));

            e.Graphics.DrawString("                                          Subtotal: $" + textTotal.Text, font21, Brushes.Black, new RectangleF(5, 230, 300, 20));
            e.Graphics.DrawString("                                      Descuento: ", font21, Brushes.Black, new RectangleF(5, 245, 300, 20));
            e.Graphics.DrawString("                                                Total: $" + textTotal.Text, font21, Brushes.Black, new RectangleF(5, 260, 300, 20));

            e.Graphics.DrawString("GRACIAS POR ELEGIR VIDON BAR", font21, Brushes.Black, new RectangleF(25, 290, 300, 20));
            e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(130, 320, 50, 50));
        }


        private void guardarVenta()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = "INSERT INTO[dbo].[Venta]([fecha] ,[total]) VALUES([@fecha],[@total])";
                    comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                    comando.Parameters.AddWithValue("@total", SqlDbType.Int).Value = textTotal.Text;
                    int row = comando.ExecuteNonQuery();
                    //if (row == 0)
                    //throw Exception("Error");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
