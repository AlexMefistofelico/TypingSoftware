namespace Typing.Presentacion
{
    partial class FormEjercitar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEjercitar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblLeccion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxTeclado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAConseguir = new System.Windows.Forms.Label();
            this.lblPPM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPulsacionesTotales = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnReloj = new System.Windows.Forms.Button();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPulsarTecla = new System.Windows.Forms.CheckBox();
            this.checkBoxOcultarTeclado = new System.Windows.Forms.CheckBox();
            this.checkBoxDedos = new System.Windows.Forms.CheckBox();
            this.richTextBoxPrincipal = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeclado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(371, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leccion: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(74, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(12, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = " ";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(308, 18);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(12, 16);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = " ";
            // 
            // lblLeccion
            // 
            this.lblLeccion.AutoSize = true;
            this.lblLeccion.BackColor = System.Drawing.Color.Transparent;
            this.lblLeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeccion.ForeColor = System.Drawing.Color.White;
            this.lblLeccion.Location = new System.Drawing.Point(439, 18);
            this.lblLeccion.Name = "lblLeccion";
            this.lblLeccion.Size = new System.Drawing.Size(12, 16);
            this.lblLeccion.TabIndex = 5;
            this.lblLeccion.Text = " ";
            this.lblLeccion.Click += new System.EventHandler(this.lblLeccion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(630, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxTeclado
            // 
            this.pictureBoxTeclado.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTeclado.Image")));
            this.pictureBoxTeclado.Location = new System.Drawing.Point(12, 275);
            this.pictureBoxTeclado.Name = "pictureBoxTeclado";
            this.pictureBoxTeclado.Size = new System.Drawing.Size(479, 153);
            this.pictureBoxTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeclado.TabIndex = 8;
            this.pictureBoxTeclado.TabStop = false;
            this.pictureBoxTeclado.Click += new System.EventHandler(this.pictureBoxTeclado_Click);
            this.pictureBoxTeclado.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTeclado_Paint);
            this.pictureBoxTeclado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTeclado_MouseClick);
            this.pictureBoxTeclado.MouseEnter += new System.EventHandler(this.pictureBoxTeclado_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(514, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "P.P.M.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(567, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "A Conseguir";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblAConseguir
            // 
            this.lblAConseguir.AutoSize = true;
            this.lblAConseguir.BackColor = System.Drawing.Color.Transparent;
            this.lblAConseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAConseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConseguir.ForeColor = System.Drawing.Color.White;
            this.lblAConseguir.Location = new System.Drawing.Point(587, 356);
            this.lblAConseguir.Name = "lblAConseguir";
            this.lblAConseguir.Size = new System.Drawing.Size(11, 13);
            this.lblAConseguir.TabIndex = 15;
            this.lblAConseguir.Text = " ";
            this.lblAConseguir.Click += new System.EventHandler(this.lblAConseguir_Click);
            // 
            // lblPPM
            // 
            this.lblPPM.AutoSize = true;
            this.lblPPM.BackColor = System.Drawing.Color.Transparent;
            this.lblPPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPM.ForeColor = System.Drawing.Color.White;
            this.lblPPM.Location = new System.Drawing.Point(538, 356);
            this.lblPPM.Name = "lblPPM";
            this.lblPPM.Size = new System.Drawing.Size(11, 13);
            this.lblPPM.TabIndex = 14;
            this.lblPPM.Text = " ";
            this.lblPPM.Click += new System.EventHandler(this.lblPPM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(528, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pulsaciones Totales";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPulsacionesTotales
            // 
            this.lblPulsacionesTotales.AutoSize = true;
            this.lblPulsacionesTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblPulsacionesTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPulsacionesTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulsacionesTotales.ForeColor = System.Drawing.Color.White;
            this.lblPulsacionesTotales.Location = new System.Drawing.Point(562, 298);
            this.lblPulsacionesTotales.Name = "lblPulsacionesTotales";
            this.lblPulsacionesTotales.Size = new System.Drawing.Size(11, 13);
            this.lblPulsacionesTotales.TabIndex = 13;
            this.lblPulsacionesTotales.Text = " ";
            this.lblPulsacionesTotales.Click += new System.EventHandler(this.lblPulsacionesTotales_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BackColor = System.Drawing.Color.Transparent;
            this.lblErrores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.White;
            this.lblErrores.Location = new System.Drawing.Point(528, 414);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(11, 13);
            this.lblErrores.TabIndex = 17;
            this.lblErrores.Text = " ";
            this.lblErrores.Click += new System.EventHandler(this.lblErrores_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(548, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Errores";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(577, 464);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(72, 46);
            this.btnReiniciar.TabIndex = 18;
            this.btnReiniciar.Text = "Reinicio";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnReloj
            // 
            this.btnReloj.BackColor = System.Drawing.Color.Transparent;
            this.btnReloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.btnReloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloj.ForeColor = System.Drawing.Color.White;
            this.btnReloj.Location = new System.Drawing.Point(494, 465);
            this.btnReloj.Name = "btnReloj";
            this.btnReloj.Size = new System.Drawing.Size(77, 45);
            this.btnReloj.TabIndex = 19;
            this.btnReloj.Text = "Reloj";
            this.btnReloj.UseVisualStyleBackColor = false;
            this.btnReloj.Click += new System.EventHandler(this.btnReloj_Click);
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // checkBoxPulsarTecla
            // 
            this.checkBoxPulsarTecla.AutoSize = true;
            this.checkBoxPulsarTecla.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPulsarTecla.Checked = true;
            this.checkBoxPulsarTecla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPulsarTecla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPulsarTecla.ForeColor = System.Drawing.Color.White;
            this.checkBoxPulsarTecla.Location = new System.Drawing.Point(322, 487);
            this.checkBoxPulsarTecla.Name = "checkBoxPulsarTecla";
            this.checkBoxPulsarTecla.Size = new System.Drawing.Size(125, 19);
            this.checkBoxPulsarTecla.TabIndex = 20;
            this.checkBoxPulsarTecla.Text = "Teclas a Pulsar";
            this.checkBoxPulsarTecla.UseVisualStyleBackColor = false;
            this.checkBoxPulsarTecla.CheckedChanged += new System.EventHandler(this.checkBoxPulsarTecla_CheckedChanged);
            // 
            // checkBoxOcultarTeclado
            // 
            this.checkBoxOcultarTeclado.AutoSize = true;
            this.checkBoxOcultarTeclado.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOcultarTeclado.Checked = true;
            this.checkBoxOcultarTeclado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOcultarTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOcultarTeclado.ForeColor = System.Drawing.Color.White;
            this.checkBoxOcultarTeclado.Location = new System.Drawing.Point(322, 468);
            this.checkBoxOcultarTeclado.Name = "checkBoxOcultarTeclado";
            this.checkBoxOcultarTeclado.Size = new System.Drawing.Size(77, 19);
            this.checkBoxOcultarTeclado.TabIndex = 21;
            this.checkBoxOcultarTeclado.Text = "Teclado";
            this.checkBoxOcultarTeclado.UseVisualStyleBackColor = false;
            this.checkBoxOcultarTeclado.CheckedChanged += new System.EventHandler(this.checkBoxOcultarTeclado_CheckedChanged);
            // 
            // checkBoxDedos
            // 
            this.checkBoxDedos.AutoSize = true;
            this.checkBoxDedos.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDedos.Checked = true;
            this.checkBoxDedos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDedos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDedos.ForeColor = System.Drawing.Color.White;
            this.checkBoxDedos.Location = new System.Drawing.Point(322, 449);
            this.checkBoxDedos.Name = "checkBoxDedos";
            this.checkBoxDedos.Size = new System.Drawing.Size(135, 19);
            this.checkBoxDedos.TabIndex = 22;
            this.checkBoxDedos.Text = "Dedos Utilizados";
            this.checkBoxDedos.UseVisualStyleBackColor = false;
            this.checkBoxDedos.CheckedChanged += new System.EventHandler(this.checkBoxDedos_CheckedChanged);
            // 
            // richTextBoxPrincipal
            // 
            this.richTextBoxPrincipal.BackColor = System.Drawing.Color.Black;
            this.richTextBoxPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxPrincipal.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxPrincipal.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPrincipal.ForeColor = System.Drawing.Color.Blue;
            this.richTextBoxPrincipal.Location = new System.Drawing.Point(13, 41);
            this.richTextBoxPrincipal.Name = "richTextBoxPrincipal";
            this.richTextBoxPrincipal.ReadOnly = true;
            this.richTextBoxPrincipal.Size = new System.Drawing.Size(634, 223);
            this.richTextBoxPrincipal.TabIndex = 23;
            this.richTextBoxPrincipal.Text = "";
            this.richTextBoxPrincipal.TextChanged += new System.EventHandler(this.richTextBoxPrincipal_TextChanged);
            this.richTextBoxPrincipal.Enter += new System.EventHandler(this.richTextBoxPrincipal_Enter);
            this.richTextBoxPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxPrincipal_KeyDown);
            this.richTextBoxPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxPrincipal_KeyPress);
            this.richTextBoxPrincipal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxPrincipal_KeyUp);
            // 
            // FormEjercitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 521);
            this.Controls.Add(this.richTextBoxPrincipal);
            this.Controls.Add(this.btnReloj);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAConseguir);
            this.Controls.Add(this.lblPPM);
            this.Controls.Add(this.lblPulsacionesTotales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxTeclado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLeccion);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDedos);
            this.Controls.Add(this.checkBoxOcultarTeclado);
            this.Controls.Add(this.checkBoxPulsarTecla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEjercitar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEjercitar";
            this.Load += new System.EventHandler(this.FormEjercitar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEjercitar_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormEjercitar_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblLeccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxTeclado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAConseguir;
        private System.Windows.Forms.Label lblPPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPulsacionesTotales;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnReloj;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.CheckBox checkBoxPulsarTecla;
        private System.Windows.Forms.CheckBox checkBoxOcultarTeclado;
        private System.Windows.Forms.CheckBox checkBoxDedos;
        private System.Windows.Forms.RichTextBox richTextBoxPrincipal;
    }
}