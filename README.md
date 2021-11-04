# C# Kurumsal Tasarım ile Northwind API Çalışması

### Kurulum
Çalıştırmak için:

1. `$ git clone https://github.com/zkozak34/KurumsalDesign` ile projeyi klonlayın.

2. `KurumsalDesign/DataAccess/Concrete/NorthwindContext.cs` dosyasında ki `_connectionString` değişkenini veritabanınıza göre değiştirin. **Referans: [Connection String](https://www.connectionstrings.com/)**

3. `cd WebUI & dotnet run` komutu ile projeyi çalıştırın.

4. Mevcut endpoint ler için Postman uygulamasına `KurumsalDesignBackend.postman_collection.json` dosyasını import edin. 

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

### WebAPI klasörü
İçerisinde WebAPI barındıran bir API projesidir. Uygulamaya dışarıdan bağlantı kurulmasını sağlar. Çalıştırmak için `cd WebUI & dotnet run` komutunu çalıştırın ve tarayıcıdan `http://localhost:5001` adresi ile bağlanın.

### Kullanılan Teknolojiler
1. Entity Framework
2. Autofac IoC Container