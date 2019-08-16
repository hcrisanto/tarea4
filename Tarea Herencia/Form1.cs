using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Id = 1;
            heroe1.Nombre = "Lucifer";
            heroe1.Genero = "Masculino";
            heroe1.Poder = "CambioDeForma";
            heroe1.Debilidades = true;

            var heroe2= new Heroe();
            heroe2.Id = 2;
            heroe2.Nombre = "Deku";
            heroe2.Genero = "Masculino";
            heroe2.Poder = "Super Fuerza";
            heroe2.Debilidades = false;

            var heroe3 = new Heroe();
            heroe3.Id = 3;
            heroe3.Nombre = "Lastania";
            heroe3.Genero = "Femenino";
            heroe3.Poder = "Telequinesis";
            heroe3.Debilidades = true;


            MessageBox.Show("Nombre:" + heroe1.Nombre + "Genero:" + heroe1.Genero + "Super Poder:" + heroe1.Poder+"Debilidades" + heroe1.Debilidades);
            MessageBox.Show("Nombre:" + heroe2.Nombre + "Genero:" + heroe2.Genero + "Super Poder:" + heroe2.Poder + "Debilidades" + heroe2.Debilidades);
            MessageBox.Show("Nombre:" + heroe3.Nombre + "Genero:" + heroe3.Genero + "Super Poder:" + heroe3.Poder + "Debilidades" + heroe3.Debilidades);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            var vil1 = new Villano();
            vil1.Id = 1;
            vil1.Nombre = "Pantera";
            vil1.Genero = "Femenino";
            vil1.Poder = "Velocidad";
            vil1.Debilidades = false;

            var vil2 = new Villano();
            vil2.Id = 2;
            vil2.Nombre = "Takashi";
            vil2.Genero = "Masculino";
            vil2.Poder = "Volar";
            vil2.Debilidades = true;

            var vil3 = new Villano();
            vil3.Id = 3;
            vil3.Nombre = "Agakill";
            vil3.Genero = "Femenino";
            vil3.Poder = "Invisibilidad";
            vil3.Debilidades = true;

            MessageBox.Show("Nombre:" + vil1.Nombre + "Genero:" + vil1.Genero + "Super Poder:" + vil1.Poder + "Debilidades" + vil1.Debilidades);
            MessageBox.Show("Nombre:" + vil2.Nombre + "Genero:" + vil2.Genero + "Super Poder:" + vil2.Poder + "Debilidades" + vil2.Debilidades);
            MessageBox.Show("Nombre:" + vil3.Nombre + "Genero:" + vil3.Genero + "Super Poder:" + vil3.Poder + "Debilidades" + vil3.Debilidades);


        }
    }
}
