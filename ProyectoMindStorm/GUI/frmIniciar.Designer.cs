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
            this.lblAVGmeditacion = new System.Windows.Forms.Label();
            this.lblBlink = new System.Windows.Forms.Label();
            this.lblPacketsRead = new System.Windows.Forms.Label();
            this.lblRelaxation = new System.Windows.Forms.Label();
            this.lblConcentration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.PBRelaxation = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PBConcentration = new System.Windows.Forms.ProgressBar();
            this.PBEye = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSenial = new System.Windows.Forms.Label();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCalibrar = new System.Windows.Forms.Button();
            this.zg1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.PBEye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAVGConcentracion
            // 
            this.lblAVGConcentracion.AutoSize = true;
            this.lblAVGConcentracion.Location = new System.Drawing.Point(341, 195);
            this.lblAVGConcentracion.Name = "lblAVGConcentracion";
            this.lblAVGConcentracion.Size = new System.Drawing.Size(124, 13);
            this.lblAVGConcentracion.TabIndex = 17;
            this.lblAVGConcentracion.Text = "promedio concentración:";
            // 
            // lblAVGmeditacion
            // 
            this.lblAVGmeditacion.AutoSize = true;
            this.lblAVGmeditacion.Location = new System.Drawing.Point(341, 173);
            this.lblAVGmeditacion.Name = "lblAVGmeditacion";
            this.lblAVGmeditacion.Size = new System.Drawing.Size(107, 13);
            this.lblAVGmeditacion.TabIndex = 16;
            this.lblAVGmeditacion.Text = "promedio meditación:";
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
            this.btnIniciar.Location = new System.Drawing.Point(12, 75);
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
            this.btndetener.Location = new System.Drawing.Point(118, 75);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(107, 28);
            this.btndetener.TabIndex = 23;
            this.btndetener.Text = "Detener demo";
            this.btndetener.UseVisualStyleBackColor = false;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // lblLowGammaValue
            // 
            this.lblLowGammaValue.AutoSize = true;
            this.lblLowGammaValue.Location = new System.Drawing.Point(244, 381);
            this.lblLowGammaValue.Name = "lblLowGammaValue";
            this.lblLowGammaValue.Size = new System.Drawing.Size(37, 13);
            this.lblLowGammaValue.TabIndex = 36;
            this.lblLowGammaValue.Text = " Value";
            // 
            // lblHighGammaValue
            // 
            this.lblHighGammaValue.AutoSize = true;
            this.lblHighGammaValue.Location = new System.Drawing.Point(244, 352);
            this.lblHighGammaValue.Name = "lblHighGammaValue";
            this.lblHighGammaValue.Size = new System.Drawing.Size(37, 13);
            this.lblHighGammaValue.TabIndex = 37;
            this.lblHighGammaValue.Text = " Value";
            // 
            // lblLowBetaValue
            // 
            this.lblLowBetaValue.AutoSize = true;
            this.lblLowBetaValue.Location = new System.Drawing.Point(244, 323);
            this.lblLowBetaValue.Name = "lblLowBetaValue";
            this.lblLowBetaValue.Size = new System.Drawing.Size(37, 13);
            this.lblLowBetaValue.TabIndex = 38;
            this.lblLowBetaValue.Text = " Value";
            // 
            // lblHighBetaValue
            // 
            this.lblHighBetaValue.AutoSize = true;
            this.lblHighBetaValue.Location = new System.Drawing.Point(244, 292);
            this.lblHighBetaValue.Name = "lblHighBetaValue";
            this.lblHighBetaValue.Size = new System.Drawing.Size(37, 13);
            this.lblHighBetaValue.TabIndex = 39;
            this.lblHighBetaValue.Text = " Value";
            // 
            // lblLowAlphaValue
            // 
            this.lblLowAlphaValue.AutoSize = true;
            this.lblLowAlphaValue.Location = new System.Drawing.Point(98, 381);
            this.lblLowAlphaValue.Name = "lblLowAlphaValue";
            this.lblLowAlphaValue.Size = new System.Drawing.Size(34, 13);
            this.lblLowAlphaValue.TabIndex = 35;
            this.lblLowAlphaValue.Text = "Value";
            // 
            // lblHighAlphaValue
            // 
            this.lblHighAlphaValue.AutoSize = true;
            this.lblHighAlphaValue.Location = new System.Drawing.Point(98, 352);
            this.lblHighAlphaValue.Name = "lblHighAlphaValue";
            this.lblHighAlphaValue.Size = new System.Drawing.Size(34, 13);
            this.lblHighAlphaValue.TabIndex = 34;
            this.lblHighAlphaValue.Text = "Value";
            // 
            // lblThetaValue
            // 
            this.lblThetaValue.AutoSize = true;
            this.lblThetaValue.Location = new System.Drawing.Point(98, 323);
            this.lblThetaValue.Name = "lblThetaValue";
            this.lblThetaValue.Size = new System.Drawing.Size(34, 13);
            this.lblThetaValue.TabIndex = 33;
            this.lblThetaValue.Text = "Value";
            // 
            // lblDeltaValue
            // 
            this.lblDeltaValue.AutoSize = true;
            this.lblDeltaValue.Location = new System.Drawing.Point(98, 292);
            this.lblDeltaValue.Name = "lblDeltaValue";
            this.lblDeltaValue.Size = new System.Drawing.Size(34, 13);
            this.lblDeltaValue.TabIndex = 32;
            this.lblDeltaValue.Text = "Value";
            // 
            // lblLowGamma
            // 
            this.lblLowGamma.AutoSize = true;
            this.lblLowGamma.Location = new System.Drawing.Point(154, 381);
            this.lblLowGamma.Name = "lblLowGamma";
            this.lblLowGamma.Size = new System.Drawing.Size(84, 13);
            this.lblLowGamma.TabIndex = 31;
            this.lblLowGamma.Text = "Gamma baja (γ):";
            // 
            // lblHighGamma
            // 
            this.lblHighGamma.AutoSize = true;
            this.lblHighGamma.Location = new System.Drawing.Point(157, 352);
            this.lblHighGamma.Name = "lblHighGamma";
            this.lblHighGamma.Size = new System.Drawing.Size(81, 13);
            this.lblHighGamma.TabIndex = 30;
            this.lblHighGamma.Text = "Gamma alta (Γ):";
            // 
            // lblHighBeta
            // 
            this.lblHighBeta.AutoSize = true;
            this.lblHighBeta.Location = new System.Drawing.Point(171, 292);
            this.lblHighBeta.Name = "lblHighBeta";
            this.lblHighBeta.Size = new System.Drawing.Size(67, 13);
            this.lblHighBeta.TabIndex = 29;
            this.lblHighBeta.Text = "Beta alta (Β):";
            // 
            // lblHighAlpha
            // 
            this.lblHighAlpha.AutoSize = true;
            this.lblHighAlpha.Location = new System.Drawing.Point(34, 352);
            this.lblHighAlpha.Name = "lblHighAlpha";
            this.lblHighAlpha.Size = new System.Drawing.Size(64, 13);
            this.lblHighAlpha.TabIndex = 28;
            this.lblHighAlpha.Text = "Alfa alta (Α):";
            // 
            // lblLowBeta
            // 
            this.lblLowBeta.AutoSize = true;
            this.lblLowBeta.Location = new System.Drawing.Point(168, 323);
            this.lblLowBeta.Name = "lblLowBeta";
            this.lblLowBeta.Size = new System.Drawing.Size(70, 13);
            this.lblLowBeta.TabIndex = 27;
            this.lblLowBeta.Text = "Beta baja (β):";
            // 
            // lblLowAlpha
            // 
            this.lblLowAlpha.AutoSize = true;
            this.lblLowAlpha.Location = new System.Drawing.Point(32, 381);
            this.lblLowAlpha.Name = "lblLowAlpha";
            this.lblLowAlpha.Size = new System.Drawing.Size(67, 13);
            this.lblLowAlpha.TabIndex = 26;
            this.lblLowAlpha.Text = "Alfa baja (α):";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(35, 323);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(53, 13);
            this.lblTheta.TabIndex = 25;
            this.lblTheta.Text = "Theta (θ):";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.Location = new System.Drawing.Point(35, 292);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(51, 13);
            this.lblDelta.TabIndex = 24;
            this.lblDelta.Text = "Delta (Δ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 358);
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
            this.PBRelaxation.Location = new System.Drawing.Point(307, 381);
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
            this.label4.Location = new System.Drawing.Point(336, 292);
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
            this.PBConcentration.Location = new System.Drawing.Point(306, 323);
            this.PBConcentration.Name = "PBConcentration";
            this.PBConcentration.Size = new System.Drawing.Size(184, 30);
            this.PBConcentration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBConcentration.TabIndex = 40;
            this.PBConcentration.Value = 90;
            // 
            // PBEye
            // 
            this.PBEye.Image = global::ProyectoMindStorm.Properties.Resources.closed_eye;
            this.PBEye.Location = new System.Drawing.Point(90, 134);
            this.PBEye.Name = "PBEye";
            this.PBEye.Size = new System.Drawing.Size(135, 128);
            this.PBEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBEye.TabIndex = 44;
            this.PBEye.TabStop = false;
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
            // btnCalibrar
            // 
            this.btnCalibrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCalibrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.btnCalibrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(113)))), ((int)(((byte)(22)))));
            this.btnCalibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibrar.ForeColor = System.Drawing.Color.White;
            this.btnCalibrar.Location = new System.Drawing.Point(231, 75);
            this.btnCalibrar.Name = "btnCalibrar";
            this.btnCalibrar.Size = new System.Drawing.Size(104, 28);
            this.btnCalibrar.TabIndex = 50;
            this.btnCalibrar.Text = "Calibrar";
            this.btnCalibrar.UseVisualStyleBackColor = false;
            this.btnCalibrar.Click += new System.EventHandler(this.btnCalibrar_Click);
            // 
            // zg1
            // 
            this.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg1.Location = new System.Drawing.Point(492, 40);
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
            // frmIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 426);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.btnCalibrar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIntensity);
            this.Controls.Add(this.lblSenial);
            this.Controls.Add(this.PBEye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PBRelaxation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBConcentration);
            this.Controls.Add(this.lblLowGammaValue);
            this.Controls.Add(this.lblHighGammaValue);
            this.Controls.Add(this.lblLowBetaValue);
            this.Controls.Add(this.lblHighBetaValue);
            this.Controls.Add(this.lblLowAlphaValue);
            this.Controls.Add(this.lblHighAlphaValue);
            this.Controls.Add(this.lblThetaValue);
            this.Controls.Add(this.lblDeltaValue);
            this.Controls.Add(this.lblLowGamma);
            this.Controls.Add(this.lblHighGamma);
            this.Controls.Add(this.lblHighBeta);
            this.Controls.Add(this.lblHighAlpha);
            this.Controls.Add(this.lblLowBeta);
            this.Controls.Add(this.lblLowAlpha);
            this.Controls.Add(this.lblTheta);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAVGConcentracion);
            this.Controls.Add(this.lblAVGmeditacion);
            this.Controls.Add(this.lblBlink);
            this.Controls.Add(this.lblPacketsRead);
            this.Controls.Add(this.lblRelaxation);
            this.Controls.Add(this.lblConcentration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciar";
            this.Text = "frmIniciar";
            this.Load += new System.EventHandler(this.frmIniciar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAVGConcentracion;
        private System.Windows.Forms.Label lblAVGmeditacion;
        private System.Windows.Forms.Label lblBlink;
        private System.Windows.Forms.Label lblPacketsRead;
        private System.Windows.Forms.Label lblRelaxation;
        private System.Windows.Forms.Label lblConcentration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Label lblLowGammaValue;
        private System.Windows.Forms.Label lblHighGammaValue;
        private System.Windows.Forms.Label lblLowBetaValue;
        private System.Windows.Forms.Label lblHighBetaValue;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PBRelaxation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PBConcentration;
        private System.Windows.Forms.PictureBox PBEye;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSenial;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCalibrar;
        private ZedGraph.ZedGraphControl zg1;
    }
}