﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntrega
{
    public class Producto
    {
        // Atributos
        private long id;
        private string descripcion;
        private double costo;
        private double precioVenta;
        private int stock;
        private long idUsuario;

        // Getters and Setters
        public long Id 
        { 
            get 
            { 
                return this.id; 
            } 
            set 
            {  
                this.id = value; 
            } 
        }  

        public string Descripcion
        {
            get 
            {
                return this.descripcion;
            }
            set 
            {
                this.descripcion = value;
            }
        }

        public double Costo 
        {  
            get 
            { 
                return this.costo; 
            }
            set 
            {
               this.costo = value;
            }

        }

        public double PrecioVenta
        {
            get 
            { 
                return this.precioVenta;
            }
            set 
            {
                this.precioVenta = value; 
            }

        }

        public int Stock 
        { 
            get 
            { 
                return this.stock;
            }
            set 
            { 
                this.stock = value; 
            }

        }    

        public long IdUsuario
        {
            get 
            { 
                return this.idUsuario; 
            }
            set 
            {
                this.idUsuario = value; 
            }
        
        }

        // Constructores
        public Producto()
        {

        }

        public Producto(long id, string descripcion, double costo, double precioVenta, int stock, long idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta= precioVenta;
            this.stock = stock;
            this.idUsuario= idUsuario;
        }


    }
}
