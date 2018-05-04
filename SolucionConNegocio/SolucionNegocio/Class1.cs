using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionNegocio
{
    public class Persona
    {

        private DateTime _fechaNacimineto;

        private string _digitoVerificador;

        private long _rut;

        private string _nombre;


        public long Rut
        {
            get { return _rut; }
            set
            {
                if (value <= 0 || value >= 100000000)
                {
                    throw new ArgumentException("El rut no se encuetra en el rango");
                }


                _rut = value;
            }
        }


        public string DigitoVerificador
        {
            get { return _digitoVerificador; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("No se aceptan campos vacios");
                }
                else
                {
                    _digitoVerificador = value;
                }

            }
        }


        public DateTime FechaNacimineto
        {
            get { return _fechaNacimineto; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("No se puede ingresar una fecha mayor a la que hoy");
                }
                else
                {
                    _fechaNacimineto = value;
                }


                _fechaNacimineto = value;
            }
        }



        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("No se puede ingresar un nombre vacio");
                }
                else if (value.Trim().Length < 2)
                {
                    throw new ArgumentException("El nombre debe contener mas de dos letras");
                }

                else
                {
                    _nombre = value;
                }
            }
        }


        public Persona(string nombre, long rut,string dv,DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Rut = rut;
            DigitoVerificador = dv;
            FechaNacimineto = fechaNacimiento;
        }

      
    }



}

