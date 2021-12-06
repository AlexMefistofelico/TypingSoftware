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
using Typing.Control;
using System.Text.RegularExpressions;

namespace Typing.Presentacion
{
    public partial class FormAdminUsuarioModo : Form
    {
        public FormAdminUsuarioModo()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            //[1] @A\ patron \Z para concidencia de principio a fin
            //por que IsMatch podria verificar "true" es sig caso "1341var111"
            //encontramos el patron pero no de principio a fin para eso me sirve [1]

            Regex validador = new Regex(@"\A[a-zA-Z_][a-zA-Z0-9_]{3,14}\Z");  
            if (validador.IsMatch(txtNombre.Text.ToString())){

                using (TYPINGEntities db = new TYPINGEntities()){
                    USUARIO usuario = null;
                    try
                    {
                        int modo = 0;
                        if (radioButton1.Checked) modo = 1;
                        if (radioButton2.Checked) modo = 2;
                        if (radioButton3.Checked) modo = 3;
                        if (radioButton4.Checked) modo = 4;
                        if (radioButton5.Checked) modo = 5;
                        if (radioButton6.Checked) modo = 6;
                        usuario = new USUARIO { UsuarioID = db.USUARIO.Select(x => x.UsuarioID).Max()+1, Nombre = txtNombre.Text, Modo = modo };
                        db.USUARIO.Add(usuario);
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio Un Error\n(No Se Ingreso Usuario)...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }else{
                MessageBox.Show("Ingresa Nombre VAlido...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdminUsuarioModo_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {   //si presiono enter es como el [OK]
            if (e.KeyChar == 13)
                btnOK_Click(sender,e);
        }
    }
}
