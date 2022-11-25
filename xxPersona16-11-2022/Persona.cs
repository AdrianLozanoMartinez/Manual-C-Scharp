namespace xxPersona16_11_2022
{
    //Debe ir fuera de la class Class1
    enum Sexos2 { Hombre, Mujer, Otre, Si, No }; //Se puede quitar public/private si vamos a usarlo fuera en 
                                                 //otra clase

    class Persona
    {
        //Puede ir dentro o fuera de la class Class1
        public enum Sexos { Hombre, Mujer, Otre, Si, No }; //Tiene que ser public/private pero debe ser igual
                                                           //arriba y abajo y no puede tener mismo nombre
                                                           //variable que enum
        //Atributo
        private string dni;
        private string name;
        private int age;
        private Sexos sexo; //Del enumerado
        private Sexos2 sexo2; //Del enumerado

        //Atributo - se recomienda _ para especificar que es PRIVADO
        private string _dni;
        private string _name;
        private int _age;
        private Sexos _sexo; //Del enumerado

        //Propiedad -> Acceder a los valores del atributo
        public string Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }
        public bool IsAdult { get => age >= 18; }
        public Sexos Sexo { get => sexo; set => sexo = value; }
        public Sexos2 Sexo2 { get => sexo2; set => sexo2 = value; }




        //Propiedad -> Acceder a los valores del atributo
        public string Dni2 { get => _dni; set => _dni = value; }
        public string Name2 { get => _name; set => _name = value; }
        public int Age2
        {
            get => _age;
            set
            {
                _age = value;
            }
        }
        public bool IsAdult2 { get => _age >= 18; }
        public Sexos Sexo3 { get => _sexo; set => _sexo = value; }



        //CONSTRUCTOR DE MAS PARAMETROS ARRIBA





        public Persona() //constructor por defecto modificamos PREDETERMINADO
        {
            dni = "-";
            name = "Tu nombre";
        }

        public Persona(string dni, string name, int age, Sexos sexo) //constructor por defecto, modificar mas complejo
        {
            //Se usa los atributos - NOOOOO se aconseja
            this.dni = dni;
            this.name = name;
            this.age = age;
            this.sexo = sexo;

            //Se usa los atributos con _ que se usa para especificar que es PRIVADO, NO ES OBLIGATORIO - NOOOOO se aconseja CONVENCION
            _dni = dni;
            _name = name;
            _age = age;
            _sexo = sexo;

            //SIIIII Se aconseja usar las propiedades
            Dni = dni;
            Name = name;
            Age = age;
            Sexo = sexo;
        }


        public Persona (string name, int age, Sexos sexo)
            :this("-",name,age,sexo)
        {
            Age /= 2;
        }

       
    }
}
