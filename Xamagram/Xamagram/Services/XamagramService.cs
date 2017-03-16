using System.Collections.ObjectModel;
using Xamagram.Models;

namespace Xamagram.Services
{
    public class XamagramService
    {
        private static XamagramService _instance;

        public static XamagramService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new XamagramService();
                }

                return _instance;
            }
        }

        public ObservableCollection<XamagramItem> GetItems()
        {
            return new ObservableCollection<XamagramItem>
            {
                new XamagramItem { Name = "New York", Description = "Nueva York es la ciudad más poblada del estado homónimo y de los Estados Unidos de América, y la segunda mayor concentración urbana del continente americano, después de la Ciudad de México. La ciudad de Nueva York está entre las aglomeraciones urbanas más grandes y más pobladas del mundo.", Image = "new_york" },
                new XamagramItem { Name = "Paris", Description = "París es la capital de Francia y su ciudad más poblada. Capital de la región de Isla de Francia, es constituida en la única comuna unidepartamental del país. Está situada a ambos márgenes de un largo meandro del río Sena, en el centro de la Cuenca parisina, entre la confluencia del río Marne y el Sena, aguas arriba, y el Oise y el Sena, aguas abajo.", Image = "paris" },
                new XamagramItem { Name = "Roma", Description = "Roma es una ciudad y capital italiana, de 2 872 082 habitantes, capital de la Ciudad metropolitana de Roma Capital, de la región del Lacio y de Italia. Es el municipio más poblado de Italia y es la cuarta ciudad más poblada de la Unión Europea.", Image = "roma" },
                new XamagramItem { Name = "San Francisco", Description = "San Francisco, de forma oficial la Ciudad y Condado de San Francisco (en inglés: City and County of San Francisco), es una ciudad que ocupa la cuarta posición de ciudad más poblada del estado de California y la 13.ª de Estados Unidos, con una población de aproximadamente 837 442 habitantes en 2013.", Image = "san_francisco" },
                new XamagramItem { Name = "Seattle", Description = "Seattle es la ciudad más grande del estado de Washington, en el noroeste de los Estados Unidos de América. El área metropolitana de la ciudad comprende Seattle-Tacoma-Bellevue, es la 15.ª más poblada del país y la mayor del Noroeste del Pacífico.5 La ciudad está situada entre el lago Washington y la bahía conocida como Puget Sound, junto al océano Pacífico. Se encuentra 155 kilómetros al sur de la frontera entre Estados Unidos y Canadá. Importante centro cultural, educativo y económico de la región, Seattle es sede del condado de King. En el Censo estimado de 2007, la ciudad contaba con una población municipal de 594.210 habitantes, por lo que es la vigésimo cuarta ciudad más poblada de los Estados Unidos, y un área metropolitana de 3.263.497 habitantes.", Image = "seattle" },
                new XamagramItem { Name = "Sevilla", Description = "Sevilla es un municipio y una ciudad de España, capital de la provincia homónima y de la comunidad autónoma de Andalucía.", Image = "seville" }
            };
        }
    }
}
