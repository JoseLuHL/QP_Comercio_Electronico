using System;

namespace QP_Comercio_Electronico
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

//private ICollection<Ordene> ordenes { get; set; }
//public virtual ICollection<Ordene> Ordenes
//{
//    get { return null; }
//    set { ordenes = value; }
//}

//private ICollection<Ordendetalle> ordendetalles { get; set; }
//public virtual ICollection<Ordendetalle> Ordendetalles
//{
//    get { return null; }
//    set { ordendetalles = value; }
//}