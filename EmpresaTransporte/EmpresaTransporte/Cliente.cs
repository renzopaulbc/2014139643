﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    public class Cliente
    {
        public int dni { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public String Correo { get; set; }
        public int telefono { get; set; }

        public Cliente(int dni, String nombres, String apellidos, int edad, char sexo, String correo, int telefono)
        {
            this.dni = dni;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Correo = correo;
            this.telefono = telefono;
        }
    }
}
