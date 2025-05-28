using System;
namespace PetTakipp
{
    public class Vaccination
    {
        public int Id { get; set; }                 
        public int PetId { get; set; }              
        public string Name { get; set; }            
        public DateTime Date { get; set; }           
        public bool IsCompleted { get; set; }        
        public string VeterinarianName { get; set; } 
        public DateTime? NextVaccinationDate { get; set; } 
        public string VaccineBrand { get; set; }     
        public string BatchNumber { get; set; }      

        public Vaccination()
        {
            Name = string.Empty;
            VeterinarianName = string.Empty;
            VaccineBrand = string.Empty;
            BatchNumber = string.Empty;
            Date = DateTime.Now;
            IsCompleted = true;
        }
    }
}
