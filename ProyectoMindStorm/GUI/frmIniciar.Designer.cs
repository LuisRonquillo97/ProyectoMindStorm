namespace ProyectoMindStorm.GUI
{
    partial class frmIniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciar));
            this.lblAVGConcentracion = new System.Windows.Forms.Label();
            this.lblBlink = new System.Windows.Forms.Label();
            this.lblPacketsRead = new System.Windows.Forms.Label();
            this.lblRelaxation = new System.Windows.Forms.Label();
            this.lblConcentration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PBRelaxation = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PBConcentration = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSenial = new System.Windows.Forms.Label();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.lblModeText = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActivacionLego = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAVGConcentracion
            // 
            this.lblAVGConcentracion.AutoSize = true;
            this.lblAVGConcentracion.Location = new System.Drawing.Point(337, 173);
            this.lblAVGConcentracion.Name = "lblAVGConcentracion";
            this.lblAVGConcentracion.Size = new System.Drawing.Size(124, 13);
            this.lblAVGConcentracion.TabIndex = 17;
            this.lblAVGConcentracion.Text = "promedio concentración:";
            // 
            // lblBlink
            // 
            this.lblBlink.AutoSize = true;
            this.lblBlink.Location = new System.Drawing.Point(341, 149);
            this.lblBlink.Name = "lblBlink";
            this.lblBlink.Size = new System.Drawing.Size(86, 13);
            this.lblBlink.TabIndex = 15;
            this.lblBlink.Text = "Valor Parpadeo: ";
            // 
            // lblPacketsRead
            // 
            this.lblPacketsRead.AutoSize = true;
            this.lblPacketsRead.Location = new System.Drawing.Point(341, 75);
            this.lblPacketsRead.Name = "lblPacketsRead";
            this.lblPacketsRead.Size = new System.Drawing.Size(110, 13);
            this.lblPacketsRead.TabIndex = 14;
            this.lblPacketsRead.Text = "Paquetes leídos: N/A";
            // 
            // lblRelaxation
            // 
            this.lblRelaxation.AutoSize = true;
            this.lblRelaxation.Location = new System.Drawing.Point(341, 121);
            this.lblRelaxation.Name = "lblRelaxation";
            this.lblRelaxation.Size = new System.Drawing.Size(105, 13);
            this.lblRelaxation.TabIndex = 13;
            this.lblRelaxation.Text = "Valor relajación: N/A";
            // 
            // lblConcentration
            // 
            this.lblConcentration.AutoSize = true;
            this.lblConcentration.Location = new System.Drawing.Point(341, 98);
            this.lblConcentration.Name = "lblConcentration";
            this.lblConcentration.Size = new System.Drawing.Size(128, 13);
            this.lblConcentration.TabIndex = 12;
            this.lblConcentration.Text = "Valor concentración: N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Parametros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Simulador";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(5, 75);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 28);
            this.btnIniciar.TabIndex = 22;
            this.btnIniciar.Text = "Iniciar demo";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btndetener
            // 
            this.btndetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btndetener.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.btndetener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.btndetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetener.ForeColor = System.Drawing.Color.White;
            this.btndetener.Location = new System.Drawing.Point(108, 75);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(107, 28);
            this.btndetener.TabIndex = 23;
            this.btndetener.Text = "Detener demo";
            this.btndetener.UseVisualStyleBackColor = false;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Relajación";
            // 
            // PBRelaxation
            // 
            this.PBRelaxation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBRelaxation.Location = new System.Drawing.Point(492, 385);
            this.PBRelaxation.Name = "PBRelaxation";
            this.PBRelaxation.Size = new System.Drawing.Size(183, 29);
            this.PBRelaxation.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBRelaxation.TabIndex = 42;
            this.PBRelaxation.Value = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Concentración";
            // 
            // PBConcentration
            // 
            this.PBConcentration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBConcentration.Location = new System.Drawing.Point(491, 327);
            this.PBConcentration.Name = "PBConcentration";
            this.PBConcentration.Size = new System.Drawing.Size(184, 30);
            this.PBConcentration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBConcentration.TabIndex = 40;
            this.PBConcentration.Value = 90;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(355, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 13);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "Desconectado";
            // 
            // lblSenial
            // 
            this.lblSenial.AutoSize = true;
            this.lblSenial.Location = new System.Drawing.Point(459, 9);
            this.lblSenial.Name = "lblSenial";
            this.lblSenial.Size = new System.Drawing.Size(37, 13);
            this.lblSenial.TabIndex = 46;
            this.lblSenial.Text = "Señal:";
            // 
            // lblIntensity
            // 
            this.lblIntensity.AutoSize = true;
            this.lblIntensity.Location = new System.Drawing.Point(502, 9);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(33, 13);
            this.lblIntensity.TabIndex = 47;
            this.lblIntensity.Text = "100%";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(313, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 48;
            this.lblEstado.Text = "Estado:";
            // 
            // zg1
            // 
            this.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg1.Location = new System.Drawing.Point(492, 25);
            this.zg1.Name = "zg1";
            this.zg1.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(353, 265);
            this.zg1.TabIndex = 51;
            // 
            // lblModeText
            // 
            this.lblModeText.AutoSize = true;
            this.lblModeText.Location = new System.Drawing.Point(13, 121);
            this.lblModeText.Name = "lblModeText";
            this.lblModeText.Size = new System.Drawing.Size(37, 13);
            this.lblModeText.TabIndex = 52;
            this.lblModeText.Text = "Modo:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(56, 121);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(142, 13);
            this.lblMode.TabIndex = 53;
            this.lblMode.Text = "Inicie para seleccionar modo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(217, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "Habilitar/deshabilitar lego";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblActivacionLego
            // 
            this.lblActivacionLego.AutoSize = true;
            this.lblActivacionLego.Location = new System.Drawing.Point(24, 159);
            this.lblActivacionLego.Name = "lblActivacionLego";
            this.lblActivacionLego.Size = new System.Drawing.Size(92, 13);
            this.lblActivacionLego.TabIndex = 55;
            this.lblActivacionLego.Text = "Lego desactivado";
            // 
            // frmIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 426);
            this.Controls.Add(this.lblActivacionLego);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblModeText);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIntensity);
            this.Controls.Add(this.lblSenial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PBRelaxation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBConcentration);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAVGConcentracion);
            this.Controls.Add(this.lblBlink);
            this.Controls.Add(this.lblPacketsRead);
            this.Controls.Add(this.lblRelaxation);
            this.Controls.Add(this.lblConcentration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciar";
            this.Text = "frmIniciar";
            this.Load += new System.EventHandler(this.frmIniciar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAVGConcentracion;
        private System.Windows.Forms.Label lblBlink;
        private System.Windows.Forms.Label lblPacketsRead;
        private System.Windows.Forms.Label lblRelaxation;
        private System.Windows.Forms.Label lblConcentration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PBRelaxation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PBConcentration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSenial;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.Label lblEstado;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.Label lblModeText;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblActivacionLego;
    }
}