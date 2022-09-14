namespace MusteriTakip
{
    public class Musteri
    {
        public Musteri(int musteriID, string name, string surname)
        {
            MusteriID = musteriID;
            Name = name;
            Surname = surname;
        }

        public int MusteriID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
