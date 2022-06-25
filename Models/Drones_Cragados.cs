using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DronesApi.Models
{
    public class Drones_Cargados
    {
        public int id { get; set; }
        public string IdDrone { get; set; }
       
        public string MedicamentosId { get; set; }

        public int Cantidad { get; set; }

    }
}
