using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxPersona16_11_2022
{       
        //Debe ir fuera de la class Class1
        enum Sexos2 {  Hombre, Mujer, Otre, Si, No }; //Se puede quitar public/private si vamos a usarlo fuera en 
                                                      //otra clase

    class Persona
    {
        //Puede ir dentro o fuera de la class Class1
        public enum Sexos { Hombre, Mujer, Otre, Si, No }; //Tiene que ser public/private pero debe ser igual
                                                           //arriba y abajo y no puede tener mismo nombre
                                                           //variable que enum

        private string dni;
        private string name;
        private bool isAdult;
        private int age;
        private Sexos sexo; //Del enumerado
        private Sexos2 sexo2; //Del enumerado

        public string Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => age;
            set
            {
                age = value;
                isAdult = age >= 18;
            }
        }
        public int IsAdult { get => IsAdult }
        public Sexos Sexo { get => sexo; set => sexo = value; }
        public Sexos2 Sexo2 { get => sexo2; set => sexo2 = value; }
    }
}
