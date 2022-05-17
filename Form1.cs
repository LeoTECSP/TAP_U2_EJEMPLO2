using System;
using System.Drawing;//La voy a usar para bitmap
using System.Windows.Forms;
//Agregar las librerías de video
using AForge.Video;
using BarcodeLib.BarcodeReader;
using System.Drawing.Imaging;//Para hacer la foto 
using AForge.Video.DirectShow;

namespace TAP_U2_EJEMPLO2
{
    public partial class Form1 : Form
    {
        //Variables globales - que dispositivos tneemos para grabar
        FilterInfoCollection filterInfo; //clase para enlistar las camaras que tengo disponibles
        //Clase para usar la camara
        VideoCaptureDevice videoCapture;
        //videocapturedeviceform se usa cuando ya se tiene funcional en el formulario

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Conocer los dispostivos de video disponibles
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo infoCamaras in filterInfo)//se cambia el tipo de dato de los elementos que se
                //guardan en el foreach
            {
                cbVideoCamara.Items.Add(infoCamaras.Name);
            }
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            //Acceder a la cámara
            videoCapture = new VideoCaptureDevice(filterInfo[cbVideoCamara.SelectedIndex].MonikerString);
            //el monikerstring hace que el indice seleccionado lo transforma o relaciona al numero de
            //puerto que esta conecado esa camara que selecciona de la placa madre
            videoSourcePlayer1.VideoSource = videoCapture;
            videoSourcePlayer1.Start();
 
            //el index me pasa el nombre de la camara
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //Guardar una foto tomada con la WebCam - cuadro de dialogo si queremos guardar el archivo en
            //una ruta específica
            SaveFileDialog fileDialog = new SaveFileDialog();
            //ya tengo un objeto llamado fileDialog
            fileDialog.Filter = "Imagen JPG | *.jpg";
            //Se va a guardar con la extensión jpg


            //Guardar la imagen
            //Primero tengo que garantizar que tenga un nombre
            if (fileDialog.FileName != null)
            {
                //El FileName es el nombre del archivo

                //Para capturar imagenes utilizamos bitmap - se captura la imagen de la camara
                Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();
                //Guardar la imagen
                //La propiead filename agarra el nombre que el usuario escriió 
                
                //Guarda el archivo en la ruta que escogí con el nombre que yo escriba y con el formato que yo escogí
                img.Save(fileDialog.FileName, ImageFormat.Jpeg);
                //Libreramos la memoria
                img.Dispose();

                    //Las imagenes se llaman como img
            }


            //Mostrar el fileDialog
            fileDialog.ShowDialog();


            
                //todo lo que diga dialog es un cuadro contextual que aparece aparte del form y nos
                //va a dar opciones de respuesta
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Por medio de la camaraa, leer un QR o un Barcode
              //Es el obeto que recibe la señal de video, vamos a checar si está recbiendo video
            if (videoSourcePlayer1.GetCurrentVideoFrame ()!= null)
            {
                //Con el bitmap estoy cambiando cada segundo la imagen y se guarda
                //No se crea un objeto cada tantos, solo va cambiando la foto
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());

                //Creo un arreglo para tener informacion de distintas partes
                //Checo que tipo de cosa quiero leer, en este cso un qr
                //BarcodeReader me va a separar la información consultada
                string[] resultadoLectura = BarcodeReader.read(img, BarcodeReader.QRCODE);

                //garantizamos que solo haya un objeto eliminando lo contenido
                img.Dispose();

                if (resultadoLectura != null )
                {
                    textBox1.Text = resultadoLectura[0];

                }

            }
        }

        private void btnLeerQR_Click(object sender, EventArgs e)
        {
            //prendo el timer de la cámara
            timer1.Enabled = true;

        }
    }
} 
