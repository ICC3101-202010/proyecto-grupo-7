using Entrega3Spotiflix.CustomsEvenArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3Spotiflix.Controllers
{
    class VideoController
    {
        AppForm view;

        public VideoController(Form view)
        {
            initialize();
            this.view = view as AppForm;
            this.view.AgregarVideoClicked += OnAgregarVideoClicked;
            this.view.VideoChecked += OnVideoChecked;
        }
        public void initialize()
        {
            //Serialización
        }
        public bool OnAgregarVideoClicked(object sender, AgregarVideoEventArgs e)
        {
            string result = Archivos.AddVideo(new List<string>()
                {e.Titulo, e.Categoria, e.Director, e.Descripcion , Convert.ToString(e.Duracion), Convert.ToString(e.Año),Convert.ToString(e.Calificacion), Convert.ToString(e.Avg_calificacion), e.Imagen, e.Url, Convert.ToString(e.Reproducciones)});
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void OnVideoChecked(object sender, AgregarVideoEventArgs e)
        {
            Película pelicula = null;
            pelicula = Archivos.películasApp.Where(t =>
                t.Titulo.ToUpper().Contains(e.Titulo.ToUpper())).FirstOrDefault();
        }
    }
}
