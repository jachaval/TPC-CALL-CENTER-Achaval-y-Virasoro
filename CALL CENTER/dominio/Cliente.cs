﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente : Persona
    {
        public int NroCliente { get; set; }
        public Persona persona { get; set; }
        public Cliente(int nrocliente)
        {
             NroCliente = nrocliente;
        }

    }
}
