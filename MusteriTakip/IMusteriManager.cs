namespace MusteriTakip
{
    public interface IMusteriManager
    {
        public void Add(List<Musteri> musteriList, Musteri musteri);
        public void List(List<Musteri> musteriList);
        public void Delete(List<Musteri> musteriList, Musteri musteri);
    }
}
