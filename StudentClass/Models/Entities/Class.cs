namespace StudentClass.Models.Entities
{
    public class Class
    {
        public int ClassID { get; set; }
        public int Degree { get; set; } //kademe SINIF SEVİYESİ
        public string ClassName { get; set; }
        public int ClassStundentCount { get; set; } //Sınıf Mevcudu

        public ICollection<Student> Students { get; set; }
    }
}
