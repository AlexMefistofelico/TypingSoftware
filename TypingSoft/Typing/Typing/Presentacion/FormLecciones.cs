using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Typing.Modelo;
namespace Typing.Presentacion
{
    public partial class FormLecciones : Form
    {

        int idActual ,NivelActual;

        public FormLecciones()
        {
            NivelActual = idActual = 1;
            InitializeComponent();
        }

        private void FormLecciones_Load(object sender, EventArgs e)
        {

            listBoxNivel.Items.Add(1);
            listBoxNivel.Items.Add(2);
            listBoxNivel.Items.Add(3);
            listBoxNivel.Items.Add(4);
            listBoxNivel.Items.Add(5);
            listBoxNivel.Items.Add(6);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxLeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            idActual = Convert.ToInt32(listBoxLeccion.SelectedItem);
            LlenarListBox();    
        }
        public void LlenarListBox()
        {
            listBoxLeccion.Items.Clear();
            using (var db = new TYPINGEntities())
            {
                int valor = Convert.ToInt32(db.LECCION.Select(x => x.LeccionID).Max());
                int Modulo = valor/6;
                if (valor % 6 != 0) Modulo++;
                var lista = from l in db.LECCION where l.LeccionID > NivelActual*Modulo-Modulo && l.LeccionID<=NivelActual*Modulo select l.LeccionID;
                foreach (var i in lista)
                {
                    listBoxLeccion.Items.Add(i);
                }
                var leccion = (from lec in db.LECCION where lec.LeccionID == idActual select lec.Parrafo).FirstOrDefault();
                //var leccion = db.LECCION.Where(x=>x.LeccionID == idActual);
                textBoxParrafo.Text = leccion.ToString();
            }
        }

        private void listBoxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            NivelActual = Convert.ToInt32(listBoxNivel.SelectedItem);
            LlenarListBox();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            FormEjercitar frmEjercitar = new FormEjercitar();
            //para el color para testeo ...

            MessageBox.Show("El Siguiente Formulario:\n(Eso Solo Para Prueba.)\n(No Se Registran Progresos.)\n(Por Tanto No Hay Una Meta A Vencer.) " , "Aclaracion ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            frmEjercitar.cargarInicio(textBoxParrafo.Text,NivelActual,idActual);
            
            frmEjercitar.ShowDialog();
        }

        private void labelLeccion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
