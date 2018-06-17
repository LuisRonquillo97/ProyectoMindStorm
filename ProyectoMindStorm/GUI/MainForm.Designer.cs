namespace ProyectoMindStorm.GUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mindwaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mindStormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.lblPacketsRead = new System.Windows.Forms.Label();
            this.lblRelaxation = new System.Windows.Forms.Label();
            this.lblConcentration = new System.Windows.Forms.Label();
            this.btnStopDemo = new System.Windows.Forms.Button();
            this.btnStartDemo = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLowGammaValue = new System.Windows.Forms.Label();
            this.lblHighGammaValue = new System.Windows.Forms.Label();
            this.lblLowBetaValue = new System.Windows.Forms.Label();
            this.lblHighBetaValue = new System.Windows.Forms.Label();
            this.lblLowAlphaValue = new System.Windows.Forms.Label();
            this.lblHighAlphaValue = new System.Windows.Forms.Label();
            this.lblThetaValue = new System.Windows.Forms.Label();
            this.lblDeltaValue = new System.Windows.Forms.Label();
            this.lblLowGamma = new System.Windows.Forms.Label();
            this.lblHighGamma = new System.Windows.Forms.Label();
            this.lblHighBeta = new System.Windows.Forms.Label();
            this.lblHighAlpha = new System.Windows.Forms.Label();
            this.lblLowBeta = new System.Windows.Forms.Label();
            this.lblLowAlpha = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.lblSenial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PBEye = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PBRelaxation = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBConcentration = new System.Windows.Forms.ProgressBar();
            this.lblBlink = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBEye)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mindwaveToolStripMenuItem,
            this.mindStormToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mindwaveToolStripMenuItem
            // 
            this.mindwaveToolStripMenuItem.Name = "mindwaveToolStripMenuItem";
            this.mindwaveToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.mindwaveToolStripMenuItem.Text = "Mindwave";
            // 
            // mindStormToolStripMenuItem
            // 
            this.mindStormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simuladorToolStripMenuItem});
            this.mindStormToolStripMenuItem.Name = "mindStormToolStripMenuItem";
            this.mindStormToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.mindStormToolStripMenuItem.Text = "MindStorm";
            // 
            // simuladorToolStripMenuItem
            // 
            this.simuladorToolStripMenuItem.Name = "simuladorToolStripMenuItem";
            this.simuladorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.simuladorToolStripMenuItem.Text = "Simulador";
            this.simuladorToolStripMenuItem.Click += new System.EventHandler(this.simuladorToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(0, 24);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.lblBlink);
            this.MainContainer.Panel1.Controls.Add(this.lblPacketsRead);
            this.MainContainer.Panel1.Controls.Add(this.lblRelaxation);
            this.MainContainer.Panel1.Controls.Add(this.lblConcentration);
            this.MainContainer.Panel1.Controls.Add(this.btnStopDemo);
            this.MainContainer.Panel1.Controls.Add(this.btnStartDemo);
            this.MainContainer.Panel1.Controls.Add(this.lblVersion);
            this.MainContainer.Panel1.Controls.Add(this.label17);
            this.MainContainer.Panel1.Controls.Add(this.lblSimulador);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.lblStatus);
            this.MainContainer.Panel2.Controls.Add(this.lblEstado);
            this.MainContainer.Panel2.Controls.Add(this.lblLowGammaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblHighGammaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblLowBetaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblHighBetaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblLowAlphaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblHighAlphaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblThetaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblDeltaValue);
            this.MainContainer.Panel2.Controls.Add(this.lblLowGamma);
            this.MainContainer.Panel2.Controls.Add(this.lblHighGamma);
            this.MainContainer.Panel2.Controls.Add(this.lblHighBeta);
            this.MainContainer.Panel2.Controls.Add(this.lblHighAlpha);
            this.MainContainer.Panel2.Controls.Add(this.lblLowBeta);
            this.MainContainer.Panel2.Controls.Add(this.lblLowAlpha);
            this.MainContainer.Panel2.Controls.Add(this.lblTheta);
            this.MainContainer.Panel2.Controls.Add(this.lblDelta);
            this.MainContainer.Panel2.Controls.Add(this.lblIntensity);
            this.MainContainer.Panel2.Controls.Add(this.lblSenial);
            this.MainContainer.Panel2.Controls.Add(this.label5);
            this.MainContainer.Panel2.Controls.Add(this.PBEye);
            this.MainContainer.Panel2.Controls.Add(this.label4);
            this.MainContainer.Panel2.Controls.Add(this.label3);
            this.MainContainer.Panel2.Controls.Add(this.PBRelaxation);
            this.MainContainer.Panel2.Controls.Add(this.label2);
            this.MainContainer.Panel2.Controls.Add(this.label1);
            this.MainContainer.Panel2.Controls.Add(this.PBConcentration);
            this.MainContainer.Size = new System.Drawing.Size(843, 494);
            this.MainContainer.SplitterDistance = 586;
            this.MainContainer.TabIndex = 1;
            // 
            // lblPacketsRead
            // 
            this.lblPacketsRead.AutoSize = true;
            this.lblPacketsRead.Location = new System.Drawing.Point(414, 45);
            this.lblPacketsRead.Name = "lblPacketsRead";
            this.lblPacketsRead.Size = new System.Drawing.Size(110, 13);
            this.lblPacketsRead.TabIndex = 7;
            this.lblPacketsRead.Text = "Paquetes leídos: N/A";
            // 
            // lblRelaxation
            // 
            this.lblRelaxation.AutoSize = true;
            this.lblRelaxation.Location = new System.Drawing.Point(414, 74);
            this.lblRelaxation.Name = "lblRelaxation";
            this.lblRelaxation.Size = new System.Drawing.Size(105, 13);
            this.lblRelaxation.TabIndex = 6;
            this.lblRelaxation.Text = "Valor relajación: N/A";
            // 
            // lblConcentration
            // 
            this.lblConcentration.AutoSize = true;
            this.lblConcentration.Location = new System.Drawing.Point(414, 61);
            this.lblConcentration.Name = "lblConcentration";
            this.lblConcentration.Size = new System.Drawing.Size(128, 13);
            this.lblConcentration.TabIndex = 5;
            this.lblConcentration.Text = "Valor concentración: N/A";
            // 
            // btnStopDemo
            // 
            this.btnStopDemo.Location = new System.Drawing.Point(218, 61);
            this.btnStopDemo.Name = "btnStopDemo";
            this.btnStopDemo.Size = new System.Drawing.Size(103, 23);
            this.btnStopDemo.TabIndex = 4;
            this.btnStopDemo.Text = "Detener demo";
            this.btnStopDemo.UseVisualStyleBackColor = true;
            this.btnStopDemo.Click += new System.EventHandler(this.btnStopDemo_Click);
            // 
            // btnStartDemo
            // 
            this.btnStartDemo.Location = new System.Drawing.Point(41, 61);
            this.btnStartDemo.Name = "btnStartDemo";
            this.btnStartDemo.Size = new System.Drawing.Size(75, 23);
            this.btnStartDemo.TabIndex = 3;
            this.btnStartDemo.Text = "Iniciar Demo";
            this.btnStartDemo.UseVisualStyleBackColor = true;
            this.btnStartDemo.Click += new System.EventHandler(this.btnStartDemo_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(459, 4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Versión del driver:";
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.Location = new System.Drawing.Point(213, 22);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(108, 25);
            this.lblSimulador.TabIndex = 0;
            this.lblSimulador.Text = "Simulador";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(49, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Desconectado";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // lblLowGammaValue
            // 
            this.lblLowGammaValue.AutoSize = true;
            this.lblLowGammaValue.Location = new System.Drawing.Point(191, 459);
            this.lblLowGammaValue.Name = "lblLowGammaValue";
            this.lblLowGammaValue.Size = new System.Drawing.Size(37, 13);
            this.lblLowGammaValue.TabIndex = 22;
            this.lblLowGammaValue.Text = " Value";
            // 
            // lblHighGammaValue
            // 
            this.lblHighGammaValue.AutoSize = true;
            this.lblHighGammaValue.Location = new System.Drawing.Point(191, 430);
            this.lblHighGammaValue.Name = "lblHighGammaValue";
            this.lblHighGammaValue.Size = new System.Drawing.Size(37, 13);
            this.lblHighGammaValue.TabIndex = 22;
            this.lblHighGammaValue.Text = " Value";
            // 
            // lblLowBetaValue
            // 
            this.lblLowBetaValue.AutoSize = true;
            this.lblLowBetaValue.Location = new System.Drawing.Point(191, 401);
            this.lblLowBetaValue.Name = "lblLowBetaValue";
            this.lblLowBetaValue.Size = new System.Drawing.Size(37, 13);
            this.lblLowBetaValue.TabIndex = 22;
            this.lblLowBetaValue.Text = " Value";
            // 
            // lblHighBetaValue
            // 
            this.lblHighBetaValue.AutoSize = true;
            this.lblHighBetaValue.Location = new System.Drawing.Point(191, 370);
            this.lblHighBetaValue.Name = "lblHighBetaValue";
            this.lblHighBetaValue.Size = new System.Drawing.Size(37, 13);
            this.lblHighBetaValue.TabIndex = 22;
            this.lblHighBetaValue.Text = " Value";
            // 
            // lblLowAlphaValue
            // 
            this.lblLowAlphaValue.AutoSize = true;
            this.lblLowAlphaValue.Location = new System.Drawing.Point(66, 459);
            this.lblLowAlphaValue.Name = "lblLowAlphaValue";
            this.lblLowAlphaValue.Size = new System.Drawing.Size(34, 13);
            this.lblLowAlphaValue.TabIndex = 21;
            this.lblLowAlphaValue.Text = "Value";
            // 
            // lblHighAlphaValue
            // 
            this.lblHighAlphaValue.AutoSize = true;
            this.lblHighAlphaValue.Location = new System.Drawing.Point(66, 430);
            this.lblHighAlphaValue.Name = "lblHighAlphaValue";
            this.lblHighAlphaValue.Size = new System.Drawing.Size(34, 13);
            this.lblHighAlphaValue.TabIndex = 20;
            this.lblHighAlphaValue.Text = "Value";
            // 
            // lblThetaValue
            // 
            this.lblThetaValue.AutoSize = true;
            this.lblThetaValue.Location = new System.Drawing.Point(66, 401);
            this.lblThetaValue.Name = "lblThetaValue";
            this.lblThetaValue.Size = new System.Drawing.Size(34, 13);
            this.lblThetaValue.TabIndex = 19;
            this.lblThetaValue.Text = "Value";
            // 
            // lblDeltaValue
            // 
            this.lblDeltaValue.AutoSize = true;
            this.lblDeltaValue.Location = new System.Drawing.Point(66, 370);
            this.lblDeltaValue.Name = "lblDeltaValue";
            this.lblDeltaValue.Size = new System.Drawing.Size(34, 13);
            this.lblDeltaValue.TabIndex = 18;
            this.lblDeltaValue.Text = "Value";
            // 
            // lblLowGamma
            // 
            this.lblLowGamma.AutoSize = true;
            this.lblLowGamma.Location = new System.Drawing.Point(101, 459);
            this.lblLowGamma.Name = "lblLowGamma";
            this.lblLowGamma.Size = new System.Drawing.Size(84, 13);
            this.lblLowGamma.TabIndex = 17;
            this.lblLowGamma.Text = "Gamma baja (γ):";
            // 
            // lblHighGamma
            // 
            this.lblHighGamma.AutoSize = true;
            this.lblHighGamma.Location = new System.Drawing.Point(104, 430);
            this.lblHighGamma.Name = "lblHighGamma";
            this.lblHighGamma.Size = new System.Drawing.Size(81, 13);
            this.lblHighGamma.TabIndex = 16;
            this.lblHighGamma.Text = "Gamma alta (Γ):";
            // 
            // lblHighBeta
            // 
            this.lblHighBeta.AutoSize = true;
            this.lblHighBeta.Location = new System.Drawing.Point(118, 370);
            this.lblHighBeta.Name = "lblHighBeta";
            this.lblHighBeta.Size = new System.Drawing.Size(67, 13);
            this.lblHighBeta.TabIndex = 15;
            this.lblHighBeta.Text = "Beta alta (Β):";
            // 
            // lblHighAlpha
            // 
            this.lblHighAlpha.AutoSize = true;
            this.lblHighAlpha.Location = new System.Drawing.Point(2, 430);
            this.lblHighAlpha.Name = "lblHighAlpha";
            this.lblHighAlpha.Size = new System.Drawing.Size(64, 13);
            this.lblHighAlpha.TabIndex = 14;
            this.lblHighAlpha.Text = "Alfa alta (Α):";
            // 
            // lblLowBeta
            // 
            this.lblLowBeta.AutoSize = true;
            this.lblLowBeta.Location = new System.Drawing.Point(115, 401);
            this.lblLowBeta.Name = "lblLowBeta";
            this.lblLowBeta.Size = new System.Drawing.Size(70, 13);
            this.lblLowBeta.TabIndex = 13;
            this.lblLowBeta.Text = "Beta baja (β):";
            // 
            // lblLowAlpha
            // 
            this.lblLowAlpha.AutoSize = true;
            this.lblLowAlpha.Location = new System.Drawing.Point(0, 459);
            this.lblLowAlpha.Name = "lblLowAlpha";
            this.lblLowAlpha.Size = new System.Drawing.Size(67, 13);
            this.lblLowAlpha.TabIndex = 12;
            this.lblLowAlpha.Text = "Alfa baja (α):";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(3, 401);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(53, 13);
            this.lblTheta.TabIndex = 11;
            this.lblTheta.Text = "Theta (θ):";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.Location = new System.Drawing.Point(3, 370);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(51, 13);
            this.lblDelta.TabIndex = 10;
            this.lblDelta.Text = "Delta (Δ):";
            // 
            // lblIntensity
            // 
            this.lblIntensity.AutoSize = true;
            this.lblIntensity.Location = new System.Drawing.Point(195, 4);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(33, 13);
            this.lblIntensity.TabIndex = 9;
            this.lblIntensity.Text = "100%";
            // 
            // lblSenial
            // 
            this.lblSenial.AutoSize = true;
            this.lblSenial.Location = new System.Drawing.Point(149, 4);
            this.lblSenial.Name = "lblSenial";
            this.lblSenial.Size = new System.Drawing.Size(37, 13);
            this.lblSenial.TabIndex = 8;
            this.lblSenial.Text = "Señal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zonas de la mente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBEye
            // 
            this.PBEye.Image = global::ProyectoMindStorm.Properties.Resources.closed_eye;
            this.PBEye.Location = new System.Drawing.Point(41, 209);
            this.PBEye.Name = "PBEye";
            this.PBEye.Size = new System.Drawing.Size(128, 128);
            this.PBEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBEye.TabIndex = 6;
            this.PBEye.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parpadeo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relajación";
            // 
            // PBRelaxation
            // 
            this.PBRelaxation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBRelaxation.Location = new System.Drawing.Point(7, 149);
            this.PBRelaxation.Name = "PBRelaxation";
            this.PBRelaxation.Size = new System.Drawing.Size(238, 37);
            this.PBRelaxation.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBRelaxation.TabIndex = 3;
            this.PBRelaxation.Value = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concentración";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indicadores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBConcentration
            // 
            this.PBConcentration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBConcentration.Location = new System.Drawing.Point(7, 84);
            this.PBConcentration.Name = "PBConcentration";
            this.PBConcentration.Size = new System.Drawing.Size(238, 34);
            this.PBConcentration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBConcentration.TabIndex = 0;
            this.PBConcentration.Value = 90;
            // 
            // lblBlink
            // 
            this.lblBlink.AutoSize = true;
            this.lblBlink.Location = new System.Drawing.Point(417, 91);
            this.lblBlink.Name = "lblBlink";
            this.lblBlink.Size = new System.Drawing.Size(86, 13);
            this.lblBlink.TabIndex = 8;
            this.lblBlink.Text = "Valor Parpadeo: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 518);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MindStorm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel1.PerformLayout();
            this.MainContainer.Panel2.ResumeLayout(false);
            this.MainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mindwaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mindStormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.PictureBox PBEye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PBRelaxation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PBConcentration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.Label lblSenial;
        private System.Windows.Forms.Label lblLowAlphaValue;
        private System.Windows.Forms.Label lblHighAlphaValue;
        private System.Windows.Forms.Label lblThetaValue;
        private System.Windows.Forms.Label lblDeltaValue;
        private System.Windows.Forms.Label lblLowGamma;
        private System.Windows.Forms.Label lblHighGamma;
        private System.Windows.Forms.Label lblHighBeta;
        private System.Windows.Forms.Label lblHighAlpha;
        private System.Windows.Forms.Label lblLowBeta;
        private System.Windows.Forms.Label lblLowAlpha;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblSimulador;
        private System.Windows.Forms.Label lblLowGammaValue;
        private System.Windows.Forms.Label lblHighGammaValue;
        private System.Windows.Forms.Label lblLowBetaValue;
        private System.Windows.Forms.Label lblHighBetaValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStopDemo;
        private System.Windows.Forms.Button btnStartDemo;
        private System.Windows.Forms.Label lblConcentration;
        private System.Windows.Forms.Label lblRelaxation;
        private System.Windows.Forms.Label lblPacketsRead;
        private System.Windows.Forms.ToolStripMenuItem simuladorToolStripMenuItem;
        private System.Windows.Forms.Label lblBlink;
    }
}