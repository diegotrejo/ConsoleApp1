using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tienda_cs
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Sucursal> Sucursales { get; set; }
        public List<Bodega> Bodegas { get; set; }
        public Tienda_cs(string nombre, string direccion, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Sucursales = new List<Sucursal>();
            Bodegas = new List<Bodega>();
        }
        public override string ToString()
        {
            return $"Tienda: {Nombre}, Dirección: {Direccion}, Teléfono: {Telefono}";
        }
    }
}
