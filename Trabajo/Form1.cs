using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Solo_Decimal(object sender, KeyPressEventArgs e)
        {
            ErrorP.SetError((Control)sender, "");
            TextBox t = sender as TextBox;
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || e.KeyChar == 47 ||(e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ErrorP.SetError((Control)sender, "Solo se permite números enteros");
                e.Handled = true;
            }
        }

        private void Solo_Num(object sender, KeyPressEventArgs e)
        {
            ErrorP.SetError((Control)sender, "");
            TextBox t = sender as TextBox;
            if((e.KeyChar >= 32 && e.KeyChar <= 47)||(e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ErrorP.SetError((Control)sender, "Solo se permite números naturales");
                e.Handled = true;
            }
        }

        private void Vacio (object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if(t.Text == "")
            {
                ErrorP.SetError(t, "El campo no puede estar vació");
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            if(txt_PlazoI.Text == "")
            {
                ErrorP.SetError(txt_PlazoI, "Debe ingresar un valor");
                correcto = false;
            }

            if (txt_PlazoF.Text == "")
            {
                ErrorP.SetError(txt_PlazoF, "Debe ingresar un valor");
                correcto = false;
            }

            if (txt_Tasa.Text == "")
            {
                ErrorP.SetError(txt_Tasa, "Debe ingresar un valor");
                correcto = false;
            }


            if (correcto)
            {
                int rangoI = int.Parse(txt_PlazoI.Text);
                int rangoF = int.Parse(txt_PlazoF.Text);
                double tasa = double.Parse(txt_Tasa.Text);

                int i = Validar(rangoI, rangoF, tasa);
                if (i == 0)
                {
                    ActualizarGrid();
                }
                
                txt_PlazoI.Text = "";
                txt_PlazoF.Text = "";
                txt_Tasa.Text = "";

            }

        }

        int Validar(int rangoI, int rangoF, double tasa)
        {
            if (rangoF <= rangoI || rangoI < 0)
            {
                MessageBox.Show("Rango no valido","Error en el Plazo");
                return -1;
            }

            Plazos p;
            p.RangoI = rangoI;
            p.RangoF = rangoF;
            p.Tasa = tasa;

            //Caso 0: si no hay datos se agrega normalmente
            if(Valores.Count == 0) { 
                Valores.Add(p);
                return 0;
            }

            int pos = BusquedaBinaria(rangoI);

            //Caso 1: Cuando el plazo debe ser agregado al principio de la lista.
            if (pos == -1 && rangoF < Valores[0].RangoI && tasa < Valores[0].Tasa)
            {
                Valores.Insert(0, p);
                return 0;
            }

            //Caso 2: Cuando el plazo debe ser agregado al final de la lista.
            if (pos == Valores.Count() - 1 && rangoI > Valores[pos].RangoF && tasa > Valores[pos].Tasa)
            {
                Valores.Add(p);
                return 0;
            }

            //Caso 3: Cuando el plazo debe ser agregado en alguna posición intermedia de la lista.
            if (pos > -1 && pos < Valores.Count() - 1)
            {
                if (rangoI > Valores[pos].RangoF && rangoF < Valores[pos + 1].RangoI && tasa > Valores[pos].Tasa && tasa < Valores[pos + 1].Tasa)
                {
                    Valores.Insert( pos + 1, p);
                    return 0;
                }
            }

            MessageBox.Show("Plazo Incorrecto","Error en el Plazo");
            return -1;
        }

        /*
         * Esta es una busqueda binaria para el termino más grande que sea
         * menor que el valor buscado (Rango Inicial del nuevo plazo). La búsqueda binaria
         * no es completa, cuando los valores son muy cercanos se hace una búsqueda
         * secuencial para asegurar los valores
         */
        int BusquedaBinaria(int buscado)
        {
            int inicio = 0, fin = Valores.Count();

            while (inicio + 3 < fin)
            {
                int mitad = (inicio + fin) / 2;
                if (Valores[mitad].RangoF <= buscado) inicio = mitad;
                else fin = mitad - 1;
            }

            while (inicio < fin)
            {
                if (Valores[inicio].RangoF <= buscado)
                {
                    inicio++;
                }
                else break;
            }
            return inicio - 1;
        }

        struct Plazos
        {
            public int RangoI;
            public int RangoF;
            public double Tasa;
        }

        List<Plazos> Valores = new List<Plazos>();

        /*Forma de Actualizar los datos de la tabla, agregando cada valor que hay en la lista*/
        private void ActualizarGrid()
        {
            Datos.Rows.Clear();
            Valores.ForEach(x => { 
                Datos.Rows.Add(x.RangoI,x.RangoF,x.Tasa.ToString("0.00##"));
            });
        }
    }
}
