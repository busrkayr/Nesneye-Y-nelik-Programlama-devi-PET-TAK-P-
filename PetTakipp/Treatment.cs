using System;
namespace PetTakipp
{
    public class Treatment
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string TreatmentType { get; set; }       
        public string TreatmentName { get; set; }      
        public DateTime TreatmentDate { get; set; }     
        public string Veterinarian { get; set; }       
        public decimal Cost { get; set; }               
        public string Diagnosis { get; set; }            
        public string Medications { get; set; }         
        public bool HasFollowUp { get; set; }            
        public DateTime? FollowUpDate { get; set; }    

        public Treatment()
        {
            TreatmentType = string.Empty;
            TreatmentName = string.Empty;
            Veterinarian = string.Empty;
            Diagnosis = string.Empty;
            Medications = string.Empty;
            TreatmentDate = DateTime.Now;
            HasFollowUp = false;
            Cost = 0m;
            FollowUpDate = null;
        }
    }
}
