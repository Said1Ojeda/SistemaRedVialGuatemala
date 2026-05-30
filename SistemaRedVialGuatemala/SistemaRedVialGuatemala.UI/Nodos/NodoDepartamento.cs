using SistemaRedVialGuatemala.UI.Entidades;
using System;


namespace SistemaRedVialGuatemala.UI.Nodos
{
    public class NodoDepartamento
    {
        public Departamento Informacion { get; set; }
        public NodoDepartamento Izquierdo { get; set; }
        public NodoDepartamento Derecho { get; set; }

        public NodoDepartamento()
        {
            Informacion = null;
            Izquierdo = null;
            Derecho = null;
        }

        public NodoDepartamento(Departamento informacion)
        {
            Informacion = informacion;
            Izquierdo = null;
            Derecho = null;
        }
    }
}