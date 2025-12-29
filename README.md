# Personel Kayıt Sistemi

## Projenin Amacı
Bu proje, bir kurumda çalışan personellerin bilgilerini kayıt altına almak, güncellemek, silmek ve bu veriler
üzerinden istatistiksel sonuçlar elde etmek amacıyla geliştirilmiş bir C# Windows Forms uygulamasıdır.Gerçek 
hayattaki personel kayıt süreçleri örnek alınarak tasarlanmıştır.

## Projenin Gerçekte Yaptıkları

Bu projede kullanıcı aşağıdaki işlemleri gerçekleştirebilmektedir:

Personel ekleme

Personel silme

Personel bilgilerini güncelleme

Tüm personelleri listeleme

Personel verileri üzerinden:

Toplam personel sayısı

Evli / bekar personel sayısı

Farklı şehir sayısı

Toplam maaş

Ortalama maaş bilgilerini görüntüleme

Şehirlere göre personel dağılımı ve mesleklere göre maaş ortalamalarını grafikler ile görselleştirme

Tüm bu işlemler SQL Server veritabanı ile bağlantılı olarak gerçek veriler üzerinde yapılmaktadır.

## Kullanılan Sınıflar ve OOP Yapısı
## Personel Sınıfı

Projede gerçek hayattaki bir personeli temsil eden Personel sınıfı bulunmaktadır.
Bu sınıf; ad, soyad, şehir, meslek, maaş ve medeni durum gibi özellikleri barındırır.

Maaş ve medeni durum bilgileri doğrudan dışarıdan değiştirilemez, yalnızca sınıf içerisinde tanımlanan metotlar aracılığıyla atanır.

Örnek:

Maaş bilgisi yalnızca MaasBelirle() metodu ile atanır.

Medeni durum bilgisi DurumBelirle() metodu ile kontrol edilerek ayarlanır.

## Form Sınıfları

Projede aşağıdaki form sınıfları bulunmaktadır:

Ana form (personel ekleme, silme, güncelleme ve listeleme)

İstatistik formu

Grafikler formu

Bu formlar, kullanıcı etkileşimini sağlayan ve iş mantığını yöneten sınıflardır.

## Veritabanı Kullanımı

Projede SQL Server kullanılmıştır.

## Sonuç

Bu proje, gerçek hayattaki bir personel kayıt sisteminin basitleştirilmiş bir modelidir.
Nesne yönelimli programlama prensiplerine uygun olarak geliştirilmiş, gereksiz sınıf ve değişkenlerden kaçınılmış ve uygulama boyunca anlamlı görevler yerine getiren yapılar tercih edilmiştir.

## Video Tanıtımı
Projeyi çalıştırırken ve kod yapısını gösterirken çekilen video:  
[videolar/PersonelKayitSistemi.mp4]
