﻿# C# Kurumsal Tasarım ile Northwind API Çalışması

### Proje (Class Library) tanımları
Solution içerisinde bulunan Entities, DataAccess ve Business klasörlerinin tanımları;

| Klasör | Görev | Anahtar Kelime |
|---|---|---|
| Entities | Sınıflarımızı tuttuğumuz Class Library projesidir. Veritabanı ile aynı properties sahip olmalıdır. | Model |
| DataAccess | Verilere erişim sağlayıp üzerilerinde işlem yaptığımız Class Library projesidir. | Dal |
| Business | Kurallarımızı belirlediğimiz, DataAccess projesi ile Entities referansıyla verilere erişim sağladığımız bölümdür. | Service ve Manager |
| Core | Uygulamanın genelinde kullanılan bölümleri barındırır. DİKKAT!!! Core hiç bir sınıfı referans almaz. Bu sayede projeden rahatlıkla ayrılabilir. | Referens barındırmaz |

### Abstract ve Concrete Klasörleri
Entities, DataAccess ve Business klasörleri (Class Library) içerisinde bulunan Abstract ve Concrete klasörlerinin görevleri;

| Klasör | Görev | Anahtar Kelime |
|---|---|---|
| Abstract | Arayüzleri (Interface) tuttuğumuz bölümdür. Bir sınıfın arayüze ihtiyacı yoksa bile boş bir arayüz tanımlanması önerilir.| Sınıfın metod isimleri ve Referans tutucu |
| Concrete | Asıl sınıfın tanımlandığı ve arayüzde belirtilen fonksiyonların oluşturulduğu veya doldurulduğu yerdir. | Metodların doldurması |

### ConsoleUI klasörü
İçerisinde Console app barından simulasyon yapmak için kullandığımız bir arayüzdür. Bir angular, react uygulaması gibi düşünülebilir. 