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
namespace Typing.Presentacion {
    public partial class Principal : Form
    {
        public static int ID;
        public static bool inicio;
        public const int tamañoAltoConstante = 137;
        public const int tamañoAnchoConstante = 50;

        public Principal()
        {
            InitializeComponent();
          }

        public void asignaPanel(Panel panel,Color color, int alpha,int max)
        {
            Size tam_ = panel.Size;//rescatamos tamaño
            Point punt = panel.Location;//rescatamos punto inicio
            int a = (int)((double)alpha * ((double)tamañoAltoConstante / max));
            panel.Location = new Point(punt.X,punt.Y+ tamañoAltoConstante-a);
            panel.Size = new Size(tam_.Width,a);
            panel.BackColor = color;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            inicio = true;
            
            using (TYPINGEntities db = new TYPINGEntities())
            {
                var r = (from pro in db.PROGRESO where (from p in db.PROGRESO select p.Fecha).Max() == pro.Fecha select pro).FirstOrDefault();
                var reg = (from us in db.USUARIO where us.UsuarioID == r.UsuarioID select us).FirstOrDefault();
                
                lblUsuario.Text = reg.Nombre;
                lblLeccion.Text = "LECCION: "+r.Leccion.ToString();
                lblNivel.Text = r.Nivel.ToString();

                var lista = (from lec in db.PROGRESO where lec.UsuarioID == r.UsuarioID select lec.PPMC).ToList();
                int max = 0,sum =0,i,j = lista.Count() - 1;
                Panel[] vectPanel = {pnlColor1,pnlColor2,pnlColor3,pnlColor4,pnlColor5,pnlColor6,pnlColor7,pnlColor8,pnlColor9,pnlColor10};
                Color[] vectColor = { RGB(190, 67, 10), RGB(247,128,38), RGB(250,164,27), RGB(254,190,22), RGB(160,208,34), RGB(122,198,52), RGB(72,193,40), RGB(26,171,130), RGB(41,145,182), RGB(2,83,149) };
                Label[] vectLabel = { label4,label5,label6,label7,label8,label9,label10,label11,label12,label13 };
                for (i=0;i<10&&j>=0;i++)
                {
                    if (lista[j] > max)
                        max = Convert.ToInt32(lista[j]);
                    sum += Convert.ToInt32(lista[j--]);
                }
                j = lista.Count() - 1;
                for (i = 0; i < 10 && j >= 0; i++){

                    asignaPanel(vectPanel[i], vectColor[i], Convert.ToInt32(lista[j]), max);
                    vectLabel[i].Text = lista[j--].ToString();

                }
                lblPPM.Text = (sum / (i)).ToString();
            }            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //NOMBRES GRUPO
            MessageBox.Show("TypingSoft:\n\nChoque Clemente Alex Ariel\n\nChoque Flores Wendaly\n\nSillerico Suarez Jorge Armando\n\n(**** Proyecto INF-2720A ****)", "Acerca De: ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Color RGB(int R,int G,int B)
        {
            return Color.FromArgb(((int)(((byte)(R)))), ((int)(((byte)(G)))), ((int)(((byte)(B)))));

        }
        
        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            FormAdminUsuario frmAdminUsuario = new FormAdminUsuario();
            this.Visible = false;
            frmAdminUsuario.ShowDialog();
            this.Visible = true;
        }

        private void btnEjercitar_Click(object sender, EventArgs e)
        {
            using (TYPINGEntities db = new TYPINGEntities()){  
                var r = (from pro in db.PROGRESO where (from p in db.PROGRESO select p.Fecha).Max() == pro.Fecha select pro).FirstOrDefault();
                var reg = (from us in db.USUARIO where us.UsuarioID == r.UsuarioID select us).FirstOrDefault();
                FormEjercitar frmEjercitar = new FormEjercitar();
                frmEjercitar.objIdUsuario = reg.UsuarioID;
                frmEjercitar.cargarInicio();
                this.Visible = false;
                frmEjercitar.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            FormLecciones frmLecciones = new FormLecciones();
            this.Visible = false;
            frmLecciones.ShowDialog();
            this.Visible = true;
        }

        private void btnEjercitar_MouseEnter(object sender, EventArgs e){}

        private void btnEjercitar_MouseLeave(object sender, EventArgs e){}

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e){}

        private void label13_Click(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e){}

        private void lblUsuario_Click(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
