using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Vector
    {   
        private int post = 0;
        public struct Product
        {
            public int codigo;
            public string nombre;
            public string descripcion;
            public int cantidad;
            public int costo;
        }
        private Product[] prod = new Product[15];

        public void llenar(int cod, string nom, string descr, int cant, int cost)
        {
            prod[post].codigo = cod;
            prod[post].nombre = nom;
            prod[post].descripcion = descr;
            prod[post].cantidad = cant;
            prod[post].costo = cost;
            post++;
        }

        public string buscar(int cod)
        {
            string cadena = "";
            for(int i = 0; i < 15; i++)
            {
                if(prod[i].codigo == cod)
                {
                    cadena+= "Codigo:" + prod[i].codigo + "| Nombre: " + prod[i].nombre
                        + "| Descripcion: " + prod[i].descripcion + "| Cantidad: " +
                        prod[i].cantidad + "| Precio: $" + prod[i].costo + "\r\n";
                }
            }
            return cadena;
        }
        public void eliminar(int cod)
        {
            int lugar = 0;
            for (int i = 0; i < 15; i++)
            {
                if (prod[i].codigo == cod)
                {
                    lugar = i;
                }
            }
            for(int i= lugar; i < 15; i++)
            {
                if (i < 14)
                {
                    prod[i].codigo = prod[i + 1].codigo;
                    prod[i].nombre = prod[i + 1].nombre;
                    prod[i].descripcion = prod[i + 1].descripcion;
                    prod[i].cantidad = prod[i + 1].cantidad;
                    prod[i].costo = prod[i + 1].costo;
                }else
                {
                    prod[i].codigo = 0;
                    prod[i].nombre = "";
                    prod[i].descripcion = "";
                    prod[i].cantidad = 0;
                    prod[i].costo = 0;
                }
            }
        }

        public void insertar(int cod, string nom, string descr, int cant, int cost, int post)
        {
            prod[post].codigo = cod;
            prod[post].nombre = nom;
            prod[post].descripcion = descr;
            prod[post].cantidad = cant;
            prod[post].costo = cost;          
        }

        public string listar()
        {
            string cadena = "";
            for (int i = 0; i < 15; i++)
            {
                cadena += "Codigo:" + prod[i].codigo + "| Nombre: " + prod[i].nombre
                + "| Descripcion: " + prod[i].descripcion + "| Cantidad: " +
                prod[i].cantidad + "| Precio: $" + prod[i].costo + "\r\n";    
            }
            return cadena;
        }



    }
}
