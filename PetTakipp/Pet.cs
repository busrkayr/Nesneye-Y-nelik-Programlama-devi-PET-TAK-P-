using System;
namespace PetTakipp
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public DateTime BirthDate { get; set; }
        public string Owner { get; set; }
        public string MicrochipNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }

        public Pet()
        {
            Name = string.Empty;
            Type = string.Empty;
            Breed = string.Empty;
            Gender = string.Empty;
            Color = string.Empty;
            MicrochipNumber = string.Empty;
            RegistrationDate = DateTime.Now;
            IsActive = true;
        }

        public virtual string GetSpecialNeeds()
        {
            return "Genel bakım ihtiyaçları.";
        }

        public override string ToString()
        {
            return $"{Name} ({Type} - {Breed})";
        }
    }

    public class Dog : Pet
    {
        public bool IsNeutered { get; set; }
        public string TrainingLevel { get; set; }

        public Dog()
        {
            Type = "Köpek";
            TrainingLevel = string.Empty;
        }

        public override string GetSpecialNeeds()
        {
            return "Günlük yürüyüş ve egzersiz gerekir. " +
                   (IsNeutered ? "Kısırlaştırılmış. " : "Kısırlaştırılmamış. ");
        }
    }

    public class Cat : Pet
    {
        public bool IsIndoor { get; set; }
        public bool IsNeutered { get; set; }

        public Cat()
        {
            Type = "Kedi";
        }

        public override string GetSpecialNeeds()
        {
            return "Kum kabı temizliği ve tırnak bakımı gerekir. " +
                   (IsIndoor ? "Ev kedisi. " : "Dışarı çıkan kedi, parazit kontrolleri gerekli. ") +
                   (IsNeutered ? "Kısırlaştırılmış. " : "Kısırlaştırılmamış. ");
        }
    }

    public class Bird : Pet
    {
        public bool CanFly { get; set; }
        public bool IsTalking { get; set; }
        public string CageSize { get; set; }

        public Bird()
        {
            Type = "Kuş";
            CageSize = string.Empty;
        }

        public override string GetSpecialNeeds()
        {
            return "Kafes temizliği ve uygun yem gerekir. " +
                   (CanFly ? "Uçabilir, kafesten çıkartılırken dikkat edin. " : "Uçamaz. ") +
                   (IsTalking ? "Konuşabilen tür. " : "");
        }
    }
}
