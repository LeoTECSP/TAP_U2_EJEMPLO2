
namespace TAP_U2_EJEMPLO2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbOpciones = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.cbVideoCamara = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLeerQR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOpciones
            // 
            this.cbOpciones.Controls.Add(this.textBox1);
            this.cbOpciones.Controls.Add(this.btnLeerQR);
            this.cbOpciones.Controls.Add(this.button2);
            this.cbOpciones.Controls.Add(this.btnFoto);
            this.cbOpciones.Controls.Add(this.btnCamara);
            this.cbOpciones.Controls.Add(this.cbVideoCamara);
            this.cbOpciones.Location = new System.Drawing.Point(39, 28);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(794, 132);
            this.cbOpciones.TabIndex = 0;
            this.cbOpciones.TabStop = false;
            this.cbOpciones.Text = "Opciones";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TAP_U2_EJEMPLO2.Properties.Resources.stop_FILL0_wght400_GRAD0_opsz48;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("a Anti Corona", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(476, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = " Detener";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("a Anti Corona", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Image = global::TAP_U2_EJEMPLO2.Properties.Resources.baseline_face_black_18dp;
            this.btnFoto.Location = new System.Drawing.Point(322, 51);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(103, 68);
            this.btnFoto.TabIndex = 2;
            this.btnFoto.Text = "Foto";
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.Font = new System.Drawing.Font("a Anti Corona", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamara.Image = global::TAP_U2_EJEMPLO2.Properties.Resources.baseline_video_call_black_18dp;
            this.btnCamara.Location = new System.Drawing.Point(23, 51);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(99, 68);
            this.btnCamara.TabIndex = 1;
            this.btnCamara.Text = " Iniciar";
            this.btnCamara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCamara.UseVisualStyleBackColor = true;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // cbVideoCamara
            // 
            this.cbVideoCamara.FormattingEnabled = true;
            this.cbVideoCamara.Location = new System.Drawing.Point(6, 21);
            this.cbVideoCamara.Name = "cbVideoCamara";
            this.cbVideoCamara.Size = new System.Drawing.Size(581, 24);
            this.cbVideoCamara.TabIndex = 0;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(39, 179);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(587, 224);
            this.videoSourcePlayer1.TabIndex = 1;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.Click += new System.EventHandler(this.videoSourcePlayer1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLeerQR
            // 
            this.btnLeerQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerQR.Font = new System.Drawing.Font("a Anti Corona", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerQR.Image = global::TAP_U2_EJEMPLO2.Properties.Resources.baseline_face_black_18dp;
            this.btnLeerQR.Location = new System.Drawing.Point(145, 51);
            this.btnLeerQR.Name = "btnLeerQR";
            this.btnLeerQR.Size = new System.Drawing.Size(103, 68);
            this.btnLeerQR.TabIndex = 4;
            this.btnLeerQR.Text = "Leer QR";
            this.btnLeerQR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeerQR.UseVisualStyleBackColor = true;
            this.btnLeerQR.Click += new System.EventHandler(this.btnLeerQR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 415);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.cbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cbOpciones.ResumeLayout(false);
            this.cbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbOpciones;
        private System.Windows.Forms.ComboBox cbVideoCamara;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFoto;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button btnLeerQR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

