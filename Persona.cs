using System;

namespace ConceptosAvanzados
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento {get; set;}

        
        public bool PuedeVotar(){
            int anioValido = DateTime.Today.AddYears(-18).Year;
            if(FechaNacimiento.Year <= anioValido){
                return true;
            }
            else{
                return false;
            }
        }
    }

}