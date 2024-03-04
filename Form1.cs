using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_País
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbo_lista_países_SelectedIndexChanged(object sender, EventArgs e)
        {

            string pais = cbo_lista_países.SelectedItem.ToString();

            // Mostrar la información del país en los TextBox
            switch (pais)
            {
                case "Estados Unidos":
                    txt_capital.Text = "Washington D.C.";
                    txt_población.Text = "331,002,651";
                    txt_idioma.Text = "Inglés";
                    txt_religión.Text = "Cristianismo";
                    break;
                case "China":
                    txt_capital.Text = "Pekín";
                    txt_población.Text = "1,439,323,776";
                    txt_idioma.Text = "Chino Mandarín";
                    txt_religión.Text = "Ateísmo / Religiones tradicionales chinas";
                    break;
                case "República Dominicana":
                    txt_capital.Text = "Santo Domingo";
                    txt_población.Text = "10.9 millones de habitantes";
                    txt_idioma.Text = "Español";
                    txt_religión.Text = "Cristianismo";
                    break;
                case "Haití":
                    txt_capital.Text = "Pueto Príncipe";
                    txt_población.Text = "11 millones de habitantes";
                    txt_idioma.Text = "Francés";
                    txt_religión.Text = "Cristianismo";
                    break;
                case "España":
                    txt_capital.Text = "Madrid";
                    txt_población.Text = " 46.9 millones de habitantes";
                    txt_idioma.Text = " Español";
                    txt_religión.Text = "El catolicismo";
                    break;
                case "Corea del Sur":
                    txt_capital.Text = "Seúl.";
                    txt_población.Text = "51 millones de habitantes.";
                    txt_idioma.Text = " Es el coreano, pero en Corea del Sur se utiliza una forma ligeramente diferente del idioma, conocida como Hangeul.";
                    txt_religión.Text = "Budismo y el cristianismo";
                    break;
                case "Corea del Norte":
                    txt_capital.Text = "Pyongyang. ";
                    txt_población.Text = "25 millones de habitantes.";
                    txt_idioma.Text = "El idioma oficial es el coreano, conocido como Chosŏn'gŭl en Corea del Norte.";
                    txt_religión.Text = "Ateísmo de estado.";
                    break;
                case "Venezuela":
                    txt_capital.Text = "Caracas";
                    txt_población.Text = "28,5 millones de habitantes.5";
                    txt_idioma.Text = "Hindi, Inglés";
                    txt_religión.Text = "Español.";
                    break;
                case "México":
                    txt_capital.Text = "Ciudad de México";
                    txt_población.Text = "1,380,004,385";
                    txt_idioma.Text = "Español";
                    txt_religión.Text = "Catolicismo romano";
                    break;
                case "Canadá":
                    txt_capital.Text = "Ottawa";
                    txt_población.Text = "38 millones de habitantes";
                    txt_idioma.Text = " Inglés y el francés";
                    txt_religión.Text = "Cristianismo, el islam, el judaísmo, el hinduismo y el sijismo";
                    break;
                case "Perú":
                    txt_capital.Text = "Lima";
                    txt_población.Text = "33 millones de habitantes";
                    txt_idioma.Text = "Hindi, Inglés";
                    txt_religión.Text = "La religión en Perú tradicionalmente está relacionada al sincretismo religioso originado del catolicismo" +
                        "con la antigua religión incaica tras la Conquista española.Sin embargo en los últimos 32 años se han desarrollado" +
                        "considerablemente iglesias protestantes de distintas denominaciones en los sectores populares.";
                    break;
                case "Colombia":
                    txt_capital.Text = "Bogotá";
                    txt_población.Text = "51 millones de habitantes";
                    txt_idioma.Text = "Español";
                    txt_religión.Text = "Colombia es un país laico, lo que significa que no tiene una religión oficial establecida por el gobierno. " +
                        "Sin embargo, la religión predominante en Colombia es el cristianismo, específicamente el catolicismo romano";
                    break;
                case "Argentina":
                    txt_capital.Text = " Buenos Aires";
                    txt_población.Text = " 45 millones de habitantes";
                    txt_idioma.Text = "Español";
                    txt_religión.Text = "En Argentina, la religión predominante es el cristianismo, " +
                        "específicamente el catolicismo romano. ";
                    break;

                default:
                    MessageBox.Show("Seleccione un país válido.");
                    break;

            }

       
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txt_capital.Clear();
            txt_población.Clear();
            txt_idioma.Clear();
            txt_religión.Clear();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}