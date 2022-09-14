namespace MusteriTakip
{
    public class MusteriManager : IMusteriManager
    {

        public void Add(List<Musteri> musteriList, Musteri musteri)
        {
            musteriList.Add(musteri);

        }

        public void Delete(List<Musteri> musteriList, Musteri musteri)
        {
            musteriList.Remove(musteri);

        }

        public void List(List<Musteri> musteri)
        {
            foreach (Musteri m in musteri)
            {
                Console.WriteLine($"{m.MusteriID},{m.Name} {m.Surname}");
            }
        }

    }
}
