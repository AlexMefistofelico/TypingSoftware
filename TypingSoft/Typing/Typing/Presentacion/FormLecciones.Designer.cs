namespace Typing.Presentacion
{
    partial class FormLecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLecciones));
            this.listBoxNivel = new System.Windows.Forms.ListBox();
            this.listBoxLeccion = new System.Windows.Forms.ListBox();
            this.textBoxParrafo = new System.Windows.Forms.TextBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.labelLeccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxNivel
            // 
            this.listBoxNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.listBoxNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNivel.ForeColor = System.Drawing.Color.White;
            this.listBoxNivel.FormattingEnabled = true;
            this.listBoxNivel.Location = new System.Drawing.Point(12, 58);
            this.listBoxNivel.Name = "listBoxNivel";
            this.listBoxNivel.ScrollAlwaysVisible = true;
            this.listBoxNivel.Size = new System.Drawing.Size(53, 186);
            this.listBoxNivel.TabIndex = 0;
            this.listBoxNivel.SelectedIndexChanged += new System.EventHandler(this.listBoxNivel_SelectedIndexChanged);
            // 
            // listBoxLeccion
            // 
            this.listBoxLeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.listBoxLeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLeccion.ForeColor = System.Drawing.Color.White;
            this.listBoxLeccion.FormattingEnabled = true;
            this.listBoxLeccion.Location = new System.Drawing.Point(77, 58);
            this.listBoxLeccion.Name = "listBoxLeccion";
            this.listBoxLeccion.ScrollAlwaysVisible = true;
            this.listBoxLeccion.Size = new System.Drawing.Size(53, 186);
            this.listBoxLeccion.TabIndex = 1;
            this.listBoxLeccion.SelectedIndexChanged += new System.EventHandler(this.listBoxLeccion_SelectedIndexChanged);
            // 
            // textBoxParrafo
            // 
            this.textBoxParrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.textBoxParrafo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParrafo.ForeColor = System.Drawing.Color.White;
            this.textBoxParrafo.Location = new System.Drawing.Point(136, 12);
            this.textBoxParrafo.Multiline = true;
            this.textBoxParrafo.Name = "textBoxParrafo";
            this.textBoxParrafo.ReadOnly = true;
            this.textBoxParrafo.Size = new System.Drawing.Size(488, 208);
            this.textBoxParrafo.TabIndex = 2;
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackColor = System.Drawing.Color.Transparent;
            this.btnRealizar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRealizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar.ForeColor = System.Drawing.Color.White;
            this.btnRealizar.Location = new System.Drawing.Point(296, 226);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(75, 40);
            this.btnRealizar.TabIndex = 3;
            this.btnRealizar.Text = "Realizar";
            this.btnRealizar.UseVisualStyleBackColor = false;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(390, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(12, 29);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(39, 15);
            this.lblNivel.TabIndex = 5;
            this.lblNivel.Text = "Nivel";
            // 
            // labelLeccion
            // 
            this.labelLeccion.AutoSize = true;
            this.labelLeccion.BackColor = System.Drawing.Color.Transparent;
            this.labelLeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeccion.ForeColor = System.Drawing.Color.White;
            this.labelLeccion.Location = new System.Drawing.Point(77, 29);
            this.labelLeccion.Name = "labelLeccion";
            this.labelLeccion.Size = new System.Drawing.Size(57, 15);
            this.labelLeccion.TabIndex = 6;
            this.labelLeccion.Text = "Leccion";
            this.labelLeccion.Click += new System.EventHandler(this.labelLeccion_Click);
            // 
            // FormLecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 271);
            this.Controls.Add(this.labelLeccion);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.textBoxParrafo);
            this.Controls.Add(this.listBoxLeccion);
            this.Controls.Add(this.listBoxNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLecciones";
            this.Load += new System.EventHandler(this.FormLecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNivel;
        private System.Windows.Forms.ListBox listBoxLeccion;
        private System.Windows.Forms.TextBox textBoxParrafo;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label labelLeccion;
    }
}