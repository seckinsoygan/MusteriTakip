using MusteriTakip;

List<Musteri> musteriListesi = new List<Musteri>();

Musteri musteri1 = new Musteri(1, "Seckin", "Soygan");
Musteri musteri2 = new Musteri(2, "Buse", "Bulut");
Musteri musteri3 = new Musteri(3, "Hilal", "Demirdelen");

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteriListesi, musteri1);
musteriManager.Add(musteriListesi, musteri2);
musteriManager.Add(musteriListesi, musteri3);

musteriManager.List(musteriListesi);

//Git versiyon çalışmaları için bu proje kullanıldı.