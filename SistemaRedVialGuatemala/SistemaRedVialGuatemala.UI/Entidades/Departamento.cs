using System;

namespace SistemaRedVialGuatemala.UI.Entidades
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public decimal DistanciaCapital { get; set; }
        public int CantidadMunicipios { get; set; }
        public string Region { get; set; }

        public Departamento()
        {
        }


        public Departamento(int idDepartamento, string nombre, decimal distanciaCapital, int cantidadMunicipios, string region)
        {   
            IdDepartamento  = idDepartamento;
            Nombre = nombre;
            DistanciaCapital = distanciaCapital;
            CantidadMunicipios = cantidadMunicipios;
            Region = region;
        }   
    }     
} 
