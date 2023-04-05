using semana1.Entidades;

namespace semana1.Negocio
{
    public class ClsTratamientoDePersonas
    {
        //las siguientes lines de codigo son para crear metodos
        // los metodos en c# pueden retornar informacion y existen metodos (void) que no retornan informacion
        //obligatorio tilizar la palabra return cuando se trata de un metodo que debuelve informacion
        public string ObtenerNombrePersona(persona per){
        return $"tu te llamas {per.Nombre}";
        }

        public String mayorDeEdad(persona per){

            if(per.edad>=18){
                return "eres mayor de edad";
            }

            return "eres menor de edad";

        }


        public int ObtenerEdad(){
        return 11;
        }
        public void NombrePersona(){

        }
    }
}