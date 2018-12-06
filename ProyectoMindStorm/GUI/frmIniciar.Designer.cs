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
            this.button2 = new System.Windows.Forms.Button();
            this.flechaArriba = new System.Windows.Forms.Button();
            this.flechaAbajo = new System.Windows.Forms.Button();
            this.flechaIzquierda = new System.Windows.Forms.Button();
            this.flechaDerecha = new System.Windows.Forms.Button();
            this.picArriba = new System.Windows.Forms.Panel();
            this.picDerecha = new System.Windows.Forms.Panel();
            this.picAbajo = new System.Windows.Forms.Panel();
            this.picIzquierda = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.picStop1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.picStop2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.picStop3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.picStop4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picStop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.picStop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.picStop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.picStop4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAVGConcentracion
            // 
            this.lblAVGConcentracion.AutoSize = true;
            this.lblAVGConcentracion.Location = new System.Drawing.Point(351, 173);
            this.lblAVGConcentracion.Name = "lblAVGConcentracion";
            this.lblAVGConcentracion.Size = new System.Drawing.Size(124, 13);
            this.lblAVGConcentracion.TabIndex = 17;
            this.lblAVGConcentracion.Text = "promedio concentración:";
            // 
            // lblBlink
            // 
            this.lblBlink.AutoSize = true;
            this.lblBlink.Location = new System.Drawing.Point(355, 149);
            this.lblBlink.Name = "lblBlink";
            this.lblBlink.Size = new System.Drawing.Size(86, 13);
            this.lblBlink.TabIndex = 15;
            this.lblBlink.Text = "Valor Parpadeo: ";
            // 
            // lblPacketsRead
            // 
            this.lblPacketsRead.AutoSize = true;
            this.lblPacketsRead.Location = new System.Drawing.Point(355, 75);
            this.lblPacketsRead.Name = "lblPacketsRead";
            this.lblPacketsRead.Size = new System.Drawing.Size(110, 13);
            this.lblPacketsRead.TabIndex = 14;
            this.lblPacketsRead.Text = "Paquetes leídos: N/A";
            // 
            // lblRelaxation
            // 
            this.lblRelaxation.AutoSize = true;
            this.lblRelaxation.Location = new System.Drawing.Point(355, 121);
            this.lblRelaxation.Name = "lblRelaxation";
            this.lblRelaxation.Size = new System.Drawing.Size(105, 13);
            this.lblRelaxation.TabIndex = 13;
            this.lblRelaxation.Text = "Valor relajación: N/A";
            // 
            // lblConcentration
            // 
            this.lblConcentration.AutoSize = true;
            this.lblConcentration.Location = new System.Drawing.Point(355, 98);
            this.lblConcentration.Name = "lblConcentration";
            this.lblConcentration.Size = new System.Drawing.Size(128, 13);
            this.lblConcentration.TabIndex = 12;
            this.lblConcentration.Text = "Valor concentración: N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Parametros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
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
            this.label3.Location = new System.Drawing.Point(530, 356);
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
            this.PBRelaxation.Location = new System.Drawing.Point(493, 379);
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
            this.label4.Location = new System.Drawing.Point(522, 295);
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
            this.PBConcentration.Location = new System.Drawing.Point(492, 321);
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
            this.lblActivacionLego.Location = new System.Drawing.Point(75, 149);
            this.lblActivacionLego.Name = "lblActivacionLego";
            this.lblActivacionLego.Size = new System.Drawing.Size(92, 13);
            this.lblActivacionLego.TabIndex = 55;
            this.lblActivacionLego.Text = "Lego desactivado";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(235, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 56;
            this.button2.Text = "Cambiar modo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flechaArriba
            // 
            this.flechaArriba.BackColor = System.Drawing.Color.Transparent;
            this.flechaArriba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.flechaArriba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.flechaArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flechaArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flechaArriba.ForeColor = System.Drawing.Color.White;
            this.flechaArriba.Image = ((System.Drawing.Image)(resources.GetObject("flechaArriba.Image")));
            this.flechaArriba.Location = new System.Drawing.Point(144, 198);
            this.flechaArriba.Name = "flechaArriba";
            this.flechaArriba.Size = new System.Drawing.Size(63, 57);
            this.flechaArriba.TabIndex = 57;
            this.flechaArriba.UseVisualStyleBackColor = false;
            // 
            // flechaAbajo
            // 
            this.flechaAbajo.BackColor = System.Drawing.Color.Transparent;
            this.flechaAbajo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.flechaAbajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.flechaAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flechaAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flechaAbajo.ForeColor = System.Drawing.Color.White;
            this.flechaAbajo.Image = ((System.Drawing.Image)(resources.GetObject("flechaAbajo.Image")));
            this.flechaAbajo.Location = new System.Drawing.Point(144, 346);
            this.flechaAbajo.Name = "flechaAbajo";
            this.flechaAbajo.Size = new System.Drawing.Size(63, 57);
            this.flechaAbajo.TabIndex = 58;
            this.flechaAbajo.UseVisualStyleBackColor = false;
            // 
            // flechaIzquierda
            // 
            this.flechaIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.flechaIzquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.flechaIzquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.flechaIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flechaIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flechaIzquierda.ForeColor = System.Drawing.Color.White;
            this.flechaIzquierda.Image = ((System.Drawing.Image)(resources.GetObject("flechaIzquierda.Image")));
            this.flechaIzquierda.Location = new System.Drawing.Point(62, 269);
            this.flechaIzquierda.Name = "flechaIzquierda";
            this.flechaIzquierda.Size = new System.Drawing.Size(63, 57);
            this.flechaIzquierda.TabIndex = 59;
            this.flechaIzquierda.UseVisualStyleBackColor = false;
            // 
            // flechaDerecha
            // 
            this.flechaDerecha.BackColor = System.Drawing.Color.Transparent;
            this.flechaDerecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.flechaDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.flechaDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flechaDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flechaDerecha.ForeColor = System.Drawing.Color.White;
            this.flechaDerecha.Image = ((System.Drawing.Image)(resources.GetObject("flechaDerecha.Image")));
            this.flechaDerecha.Location = new System.Drawing.Point(224, 269);
            this.flechaDerecha.Name = "flechaDerecha";
            this.flechaDerecha.Size = new System.Drawing.Size(63, 57);
            this.flechaDerecha.TabIndex = 60;
            this.flechaDerecha.UseVisualStyleBackColor = false;
            // 
            // picArriba
            // 
            this.picArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picArriba.Location = new System.Drawing.Point(139, 190);
            this.picArriba.Name = "picArriba";
            this.picArriba.Size = new System.Drawing.Size(73, 73);
            this.picArriba.TabIndex = 61;
            this.picArriba.Visible = false;
            // 
            // picDerecha
            // 
            this.picDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picDerecha.Location = new System.Drawing.Point(220, 261);
            this.picDerecha.Name = "picDerecha";
            this.picDerecha.Size = new System.Drawing.Size(73, 73);
            this.picDerecha.TabIndex = 62;
            this.picDerecha.Visible = false;
            // 
            // picAbajo
            // 
            this.picAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picAbajo.Location = new System.Drawing.Point(139, 338);
            this.picAbajo.Name = "picAbajo";
            this.picAbajo.Size = new System.Drawing.Size(73, 73);
            this.picAbajo.TabIndex = 63;
            this.picAbajo.Visible = false;
            // 
            // picIzquierda
            // 
            this.picIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picIzquierda.Location = new System.Drawing.Point(57, 261);
            this.picIzquierda.Name = "picIzquierda";
            this.picIzquierda.Size = new System.Drawing.Size(73, 73);
            this.picIzquierda.TabIndex = 63;
            this.picIzquierda.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(75, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 64;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // picStop1
            // 
            this.picStop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picStop1.Controls.Add(this.pictureBox4);
            this.picStop1.Location = new System.Drawing.Point(71, 194);
            this.picStop1.Name = "picStop1";
            this.picStop1.Size = new System.Drawing.Size(47, 47);
            this.picStop1.TabIndex = 65;
            this.picStop1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(235, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 39);
            this.button4.TabIndex = 66;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // picStop2
            // 
            this.picStop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picStop2.Controls.Add(this.pictureBox1);
            this.picStop2.Location = new System.Drawing.Point(231, 194);
            this.picStop2.Name = "picStop2";
            this.picStop2.Size = new System.Drawing.Size(47, 47);
            this.picStop2.TabIndex = 67;
            this.picStop2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(231, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 39);
            this.button5.TabIndex = 68;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // picStop3
            // 
            this.picStop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picStop3.Controls.Add(this.pictureBox2);
            this.picStop3.Location = new System.Drawing.Point(227, 349);
            this.picStop3.Name = "picStop3";
            this.picStop3.Size = new System.Drawing.Size(47, 47);
            this.picStop3.TabIndex = 69;
            this.picStop3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(79, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 39);
            this.button6.TabIndex = 70;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // picStop4
            // 
            this.picStop4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(113)))), ((int)(((byte)(25)))));
            this.picStop4.Controls.Add(this.pictureBox3);
            this.picStop4.Location = new System.Drawing.Point(75, 351);
            this.picStop4.Name = "picStop4";
            this.picStop4.Size = new System.Drawing.Size(47, 47);
            this.picStop4.TabIndex = 71;
            this.picStop4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // frmIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 426);
            this.Controls.Add(this.picStop4);
            this.Controls.Add(this.picStop3);
            this.Controls.Add(this.picStop2);
            this.Controls.Add(this.picStop1);
            this.Controls.Add(this.flechaDerecha);
            this.Controls.Add(this.flechaIzquierda);
            this.Controls.Add(this.flechaAbajo);
            this.Controls.Add(this.flechaArriba);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.picArriba);
            this.Controls.Add(this.picDerecha);
            this.Controls.Add(this.picAbajo);
            this.Controls.Add(this.picIzquierda);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciar";
            this.Text = "frmIniciar";
            this.Load += new System.EventHandler(this.frmIniciar_Load);
            this.picStop1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.picStop2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.picStop3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.picStop4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button flechaArriba;
        private System.Windows.Forms.Button flechaAbajo;
        private System.Windows.Forms.Button flechaIzquierda;
        private System.Windows.Forms.Button flechaDerecha;
        private System.Windows.Forms.Panel picArriba;
        private System.Windows.Forms.Panel picDerecha;
        private System.Windows.Forms.Panel picAbajo;
        private System.Windows.Forms.Panel picIzquierda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel picStop1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel picStop2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel picStop3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel picStop4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}