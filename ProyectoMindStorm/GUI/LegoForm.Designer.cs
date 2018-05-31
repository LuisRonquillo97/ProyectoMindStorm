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
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnGarra = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArriba
            // 
            this.btnArriba.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.arriba;
            this.btnArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArriba.Location = new System.Drawing.Point(206, 38);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(111, 91);
            this.btnArriba.TabIndex = 0;
            this.btnArriba.Text = " ";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.abajo;
            this.btnAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbajo.Location = new System.Drawing.Point(206, 253);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(111, 91);
            this.btnAbajo.TabIndex = 1;
            this.btnAbajo.Text = " ";
            this.btnAbajo.UseVisualStyleBackColor = true;
            // 
            // btnGarra
            // 
            this.btnGarra.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.garra;
            this.btnGarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGarra.Location = new System.Drawing.Point(206, 144);
            this.btnGarra.Name = "btnGarra";
            this.btnGarra.Size = new System.Drawing.Size(111, 91);
            this.btnGarra.TabIndex = 2;
            this.btnGarra.Text = " ";
            this.btnGarra.UseVisualStyleBackColor = true;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.izquierda;
            this.btnIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzquierda.Location = new System.Drawing.Point(89, 144);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(111, 91);
            this.btnIzquierda.TabIndex = 3;
            this.btnIzquierda.Text = " ";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackgroundImage = global::ProyectoMindStorm.Properties.Resources.Derecha;
            this.btnDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDerecha.Location = new System.Drawing.Point(323, 144);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(111, 91);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = " ";
            this.btnDerecha.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(46, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnGarra);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Name = "LegoForm";
            this.Text = "LegoForm";
            this.Load += new System.EventHandler(this.LegoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnGarra;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button button1;
    }
}