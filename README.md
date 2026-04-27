# SupportFlow API 🚀

**SupportFlow API**, modern .NET 9 teknolojileri kullanılarak geliştirilmiş, kurumsal standartlarda bir teknik destek (ticket) yönetim sistemidir. Bu proje, temel CRUD işlemlerinin ötesinde, sürdürülebilir yazılım mimarisi prensiplerini ve modern backend geliştirme pratiklerini sergilemek amacıyla kurgulanmıştır.

## 🛠️ Kullanılan Teknolojiler

* **Runtime:** .NET 9
* **Web Framework:** ASP.NET Core Web API
* **ORM:** Entity Framework Core (Code-First Approach)
* **Database:** Microsoft SQL Server (LocalDB)
* **Documentation:** Swagger / UI (Swashbuckle)

## 🏗️ Mimari Yapı (Architecture)

Proje, **Katmanlı Mimari (N-Tier Architecture)** prensiplerine uygun olarak tasarlanmıştır. Bu yapı sayesinde kodun test edilebilirliği artırılmış ve bileşenler arasındaki bağımlılıklar minimize edilmiştir:

* **Models:** Veritabanı tablolarını ve veri transfer yapılarını temsil eden Entity sınıfları.
* **Data (Persistence):** `AppDbContext` aracılığıyla veritabanı erişim, konfigürasyon ve Migration yönetimi.
* **Services (Business Logic):** İş mantığının (Business Logic) yürütüldüğü, Controller ve Veritabanı arasında köprü görevi gören katman.
* **Controllers (API):** HTTP isteklerini karşılayan, uygun servisleri tetikleyen ve standart HTTP yanıtlarını dönen uç noktalar.



## 🌟 Öne Çıkan Teknik Özellikler

* **Dependency Injection (DI):** Servisler arası bağımlılıklar `AddScoped` yaşam döngüsü ile yönetilerek esneklik ve performans sağlanmıştır.
* **Asynchronous Programming:** Tüm veritabanı işlemleri `async/await` yapısıyla asenkron olarak kurgulanmış, bu sayede sistem kaynaklarının verimli kullanımı hedeflenmiştir.
* **Interface-Based Design:** Servis katmanında Interface kullanımı ile "Loosely Coupled" (Gevşek Bağlı) bir yapı oluşturulmuştur.
* **RESTful Design:** Endpoint'ler REST standartlarına uygun olarak tasarlanmış ve doğru HTTP durum kodları (200 OK, 201 Created vb.) kullanılmıştır.

## 🚀 Kurulum ve Çalıştırma

Projeyi yerel ortamınızda ayağa kaldırmak için aşağıdaki adımları izleyebilirsiniz:

### 1. Repository'yi Klonlayın
```bash
git clone [https://github.com/kullanici-adiniz/SupportFlowAPI.git](https://github.com/kullanici-adiniz/SupportFlowAPI.git)
cd SupportFlowAPI