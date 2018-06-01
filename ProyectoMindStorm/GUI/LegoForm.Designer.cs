namespace ProyectoMindStorm.GUI
{
    partial class LegoForm
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnGarra = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(92, 80);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(347, 37);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Relizar Conexión";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.Derecha;
            this.btnDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDerecha.Location = new System.Drawing.Point(323, 242);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(111, 91);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = " ";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.izquierda;
            this.btnIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzquierda.Location = new System.Drawing.Point(89, 242);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(111, 91);
            this.btnIzquierda.TabIndex = 3;
            this.btnIzquierda.Text = " ";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnGarra
            // 
            this.btnGarra.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.garra;
            this.btnGarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGarra.Location = new System.Drawing.Point(206, 242);
            this.btnGarra.Name = "btnGarra";
            this.btnGarra.Size = new System.Drawing.Size(111, 91);
            this.btnGarra.TabIndex = 2;
            this.btnGarra.Text = " ";
            this.btnGarra.UseVisualStyleBackColor = true;
            this.btnGarra.Click += new System.EventHandler(this.btnGarra_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.abajo;
            this.btnAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbajo.Location = new System.Drawing.Point(206, 351);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(111, 91);
            this.btnAbajo.TabIndex = 1;
            this.btnAbajo.Text = " ";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.arriba;
            this.btnArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArriba.Location = new System.Drawing.Point(206, 136);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(111, 91);
            this.btnArriba.TabIndex = 0;
            this.btnArriba.Text = " ";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(103, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = " Simulador Lego";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(92, 80);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(347, 37);
            this.btnDesconectar.TabIndex = 8;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // LegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 465);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnGarra);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Name = "LegoForm";
            this.Text = "LegoForm";
            this.Load += new System.EventHandler(this.LegoForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LegoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LegoForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LegoForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnGarra;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
    }
}