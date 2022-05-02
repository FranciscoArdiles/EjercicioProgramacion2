using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Programacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nummonth = System.Convert.ToInt32(nummes.Value);
            int numday = System.Convert.ToInt32(numdia.Value);
            int numyear = System.Convert.ToInt32(numanio.Value);
            
            string nombremes = "Test";
            string fechacom = "Test";


            if (nummonth == 1)
            {
                nombremes = "Enero";
            }
            else if (nummonth == 2)
            {
                nombremes = "Febrero";
            }
            else if (nummonth == 3)
            {
                nombremes = "Marzo";
            }
            else if (nummonth == 4)
            {
                nombremes = "Abril";
            }
            else if (nummonth == 5)
            {
                nombremes = "Mayo";
            }
            else if (nummonth == 6)
            {
                nombremes = "Junio";
            }
            else if (nummonth == 7)
            {
                nombremes = "Julio";
            }
            else if (nummonth == 8)
            {
                nombremes = "Agosto";
            }
            else if (nummonth == 9)
            {
                nombremes = "Septiembre";
            }
            else if (nummonth == 10)
            {
                nombremes = "Octubre";
            }
            else if (nummonth == 11)
            {
                nombremes = "Noviembre";
            }
            else if (nummonth == 12)
            {
                nombremes = "Diciembre";
            }

            fechacom = numday + " de " + nombremes + " de " + numyear;


            if(numday == 31)
            {
                if (nummonth == 2 | nummonth == 4 | nummonth == 6 | nummonth == 9 | nummonth == 11)
                {

                    fechacom = "Fecha Invalida";
                    lblFecha.Visible = true;
                    lblFecha.Text = fechacom;

                    lblResult.Visible = false;

                }
                else
                {
                    lblResult.Visible = true;

                    lblFecha.Text = fechacom;
                    lblFecha.Visible = true;
                }
             
            
            }
            else if (numday == 30)
            {
                if (nummonth == 2)
                {
                        fechacom = "Fecha Invalida";
                        lblFecha.Visible = true;
                        lblFecha.Text = fechacom;


                        lblResult.Visible = false;
                }
                else
                {

                    lblResult.Visible = true;

                    lblFecha.Text = fechacom;
                    lblFecha.Visible = true;


                }
           
            
            
            }
            else if (numday == 29)
            {
                    if (nummonth == 2 & numyear % 4 != 0)
                    {

                        fechacom = "Fecha Invalida";
                        lblFecha.Visible = true;
                        lblFecha.Text = fechacom;


                        lblResult.Visible = false;
                    }
                    else if (nummonth == 2 & numyear % 4 == 0)
                    {
                        lblResult.Visible = true;

                        lblFecha.Text = fechacom;
                        lblFecha.Visible = true;
                    }
                    else
                    {
                        lblResult.Visible = true;

                        lblFecha.Text = fechacom;
                        lblFecha.Visible = true;

                    }

            }
            else
            {

                    lblResult.Visible = true;

                    lblFecha.Text = fechacom;
                    lblFecha.Visible = true;

            }
        }












    }



}
