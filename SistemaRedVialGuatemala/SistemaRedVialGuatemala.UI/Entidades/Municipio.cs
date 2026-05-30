using System;


namespace SistemaRedVialGuatemala.UI.Entidades
{
    public class Municipio
    {
        public int IdMunicipio { get; set; }
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public int Poblacion { get; set; }
        public decimal DistanciaCabecera { get; set; }

        public Municipio()
        {

        }

        public Municipio(int idMunicipio, int idDepartamento, string nombre, int poblacion, decimal distanciaCabecera)
        {
            IdMunicipio = idMunicipio;
            IdDepartamento = idDepartamento;
            Nombre = nombre;
            Poblacion = poblacion;
            DistanciaCabecera = distanciaCabecera;
        }
    }
}
