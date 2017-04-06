using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_TP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Boton Limpiar: Deja en blanco todos los cuadros de texto y label en el formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.Text = "";
        }
        //Boton Operar crea e instancia los numeros que se utilizaran para operar, tomandolos desde el cuadro de texto, para luego operar mediante el metodo "Operar" situado en la clase "Calculadora"
        //luego los asigna a resultado y este es mostrado por el label "lblResultado"
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double Resultado;
            
            Clases_TP1.Numero Numero1 = new Clases_TP1.Numero(txtNumero1.Text);
            Clases_TP1.Numero Numero2 = new Clases_TP1.Numero(txtNumero2.Text);

            Resultado = Clases_TP1.Calculadora.Operar(Numero1, Numero2, cmbOperacion.Text);

            lblResultado.Text = Resultado.ToString();

        }

    }
}
