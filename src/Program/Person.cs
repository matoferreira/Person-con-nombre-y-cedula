using System; 
using System.Linq;

namespace Person 
{ 
    public class Person 
    { 
        private string name; 
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.name=value;
                }
                else 
                {
                    Console.WriteLine ("El nombre que ingresó no es válido");
                    this.name="[[Error en Nombre]]";
                }
            }
        }
        private string id; 
        
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id=value;
                }
                else 
                {
                    Console.WriteLine ("La C.I. que ingresó no es válida");
                    this.id="[[Error en C.I.]]";
                }
            }
        }
    


        public Person(string name, string id) 
        {
            ///Al cambiar "this.name" por "this.Name" antes del "=" hace que se invoque dentro del constructor el set de nombre para que verifique si no es null or empty
            ///lo mismo pasa con el "this.Id"
            this.Name = name; 
            this.Id = id; 
        } 

        public void IntroduceYourself() 
        { 
            if (this.name != "[[Error en Nombre]]" && this.id != "[[Error en C.I.]]")
                Console.WriteLine($"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 
}