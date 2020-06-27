using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_Image_Color_Switcher
{
    public partial class frmBulkImageColorSwitcher : Form
    {
        string carpetaOrigen, carpetaDestino;
        Color colorAnterior, colorNuevo;
        public frmBulkImageColorSwitcher()
        {
            InitializeComponent();

            //todo esto será comentado:
            colorAnterior = Color.FromArgb(77,255,0);//verde mio
            colorNuevo = Color.FromArgb(0, 0, 255);//azul puro
        }

        private void btnCargarOrigen_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdOrigen.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdOrigen.SelectedPath))
            {
                carpetaOrigen = fbdOrigen.SelectedPath;
                txtOrigen.Text = carpetaOrigen;
            }
        }

        private void btnCargarDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdDestino.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdOrigen.SelectedPath))
            {
                carpetaDestino = fbdDestino.SelectedPath;
                txtDestino.Text = carpetaDestino;
            }
        }

        private void btnReemplazarColor_Click(object sender, EventArgs e)
        {
            if (carpetaOrigen == null || carpetaOrigen == "" || carpetaDestino == null || carpetaDestino == "")
            {
                //FALTA ESPECIFICAR ALGUNA DE LAS CARPETAS
                lblMensaje.Text = "Falta especificar alguna de las carpetas";
                return;
            }
            if (colorAnterior.IsEmpty || colorNuevo.IsEmpty)
            {
                //FALTA ESPECIFICAR ALGUNO DE LOS COLORES
                lblMensaje.Text = "Falta especificar alguno de los colores";
                return;
            }
            if (!bgwReemplazarColor.IsBusy)
            {
                try
                {
                    lblMensaje.Text = "Convirtiendo...Espera unos segundos...";
                    bgwReemplazarColor.RunWorkerAsync();
                }
                catch
                {

                }
                finally
                {
                    lblMensaje.Text = "";
                }
            }
        }

        //creditos de esta parte del codigo:
        //https://efundies.com/replace-a-color-in-an-image-with-csharp/
        //remplaza cada pixel de colorAnterior por colorNuevo en imagenAnterior
        //retorna una imagenNueva como el resultado de la operación
        private Bitmap reemplazarColor(Bitmap imagenAnterior, Color colorAnterior, Color colorNuevo)
        {
            Bitmap imagenNueva = imagenAnterior;
            for (int y = 0; y < imagenNueva.Height; y++)
            {
                for (int x = 0; x < imagenNueva.Width; x++)
                {
                    if (imagenNueva.GetPixel(x, y) == colorAnterior)
                    {
                        imagenNueva.SetPixel(x, y, colorNuevo);
                    }
                }
            }
            return imagenNueva;
        }

        private void bgwReemplazarColor_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //creditos de esta pequeña parte del codigo:
                //https://stackoverflow.com/questions/163162/can-you-call-directory-getfiles-with-multiple-filters/8363526
                var rutasDeImagenesEnOrigen = Directory.GetFiles(carpetaOrigen, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase));

                Bitmap tempImg;
                string tempImgRuta, tempImgNombre;
                foreach (string rutaDeImagen in rutasDeImagenesEnOrigen)
                {
                    tempImg = new Bitmap(rutaDeImagen);
                    tempImg = reemplazarColor(tempImg, colorAnterior, colorNuevo);

                    //creditos de esta pequeña parte del codigo:
                    //https://www.it-swarm.dev/es/c%23/obtener-nombre-de-archivo-de-una-cadena-de-ruta-en-c/940642589/
                    string[] tempImgRutaPartida = rutaDeImagen.Split('\\');
                    tempImgNombre = tempImgRutaPartida.Last(); ;

                    tempImgRuta = carpetaDestino + "\\" + tempImgNombre;
                    guardarImagen(tempImg, tempImgRuta);

                    bgwReemplazarColor.ReportProgress(100 / rutasDeImagenesEnOrigen.ToList().Count);
                    Console.WriteLine("Cantidad de imagenes: " + rutasDeImagenesEnOrigen.ToList().Count);
                }
                MessageBox.Show("¡Listo! Las imágenes con el color reemplazado fueron creadas :D");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ocurrió un error. Verifica que todos los valores sean correctos e intenta de nuevo, crack ;)");
            }
        }

        private void bgwReemplazarColor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgProgreso.Value = e.ProgressPercentage;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bgwReemplazarColor.CancelAsync();
        }

        //creditos de esta parte del codigo:
        //https://efundies.com/c-sharp-save-png/
        //genera el enconder para un determinado formato de imagen
        ImageCodecInfo GetEncoder(ImageFormat format)
        {
            //creditos de esta porción de codigo:
            //https://efundies.com/c-sharp-save-png/
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        
        //creditos de esta parte del codigo:
        //https://efundies.com/c-sharp-save-png/
        //guarda la imagen en la rutaConNombre especificada
        public void guardarImagen(Bitmap imagen, string rutaConNombre)
        {
            try
            {
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 1L);
                imagen.Save(rutaConNombre, GetEncoder(ImageFormat.Png), encoderParameters);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
