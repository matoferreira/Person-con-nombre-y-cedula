using System; 
using System.Linq;

namespace Person 
{ 
    public class Person 
    { 
        private string name; 
        public string Name{
            get{
                return this.name;
            }
            set{
                if (!string.IsNullOrEmpty(value)){
                    this.name=value;
                }
                else {
                 Console.WriteLine ("La C.I. que ingresó no es válida");
                    this.id="Error en C.I.";
                }
            }
        }
        private string id; 
        
        public string Id{
            get{
                return this.id;
            }
            set{
                if (IdUtils.IdIsValid(value)){
                    this.id=value;
                }
                else {
                 Console.WriteLine ("La C.I. que ingresó no es válida");
                    this.id="Error en C.I.";
                }
            }
        }
    


        public Person(string name, string id) 
        { 
            this.name = name; 
            this.id = id; 
        } 

        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 
}