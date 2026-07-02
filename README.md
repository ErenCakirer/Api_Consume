# 🏨 OtelProjesi.NetCore.Api (Otel Rezervasyon & Yönetim Sistemi)

Bu proje, modern backend mimari prensiplerine uygun olarak geliştirilmiş kapsamlı bir **Otel Rezervasyon ve Yönetim Sistemi** uygulamasıdır. Projenin geliştirilme sürecinde, teorik bilgileri pratik ve ölçeklenebilir bir gerçek hayat senaryosuna dönüştürmek amacıyla **Udemy ("Murat Yücedağ"- Api Proje Kampı ve Api Consume**) eğitiminden büyük ölçüde destek alınmıştır.

Proje hem dinamik bir otel web sitesi ön yüzünü (UI) hem de tüm bu verileri güvenli ve performanslı bir şekilde yöneten güçlü bir API katmanını barındırmaktadır.

---

## 🚀 Öne Çıkan Özellikler

* **Katmanlı Mimari (N-Tier Architecture):** Proje; Sorumlulukların Ayrılması (Separation of Concerns) prensibine uygun olarak DataAccess, Business, Entity ve UI katmanlarından oluşur.
* **API Tüketimi (API Consume):** UI katmanı, veritabanına doğrudan bağlanmak yerine tamamen bağımsız çalışan ASP.NET Core Web API katmanını aslanlar gibi tüketerek (Consume ederek) haberleşir.
* **Gelişmiş Rezervasyon CRUD & Durum Yönetimi:** Sistem üzerinden yapılan rezervasyonlar admin paneli aracılığıyla onaylanabilir, iptal edilebilir veya anlık olarak güncellenebilir.
* **DTO (Data Transfer Object) Kullanımı:** Katmanlar arasında veri taşınırken performansı korumak ve güvenliği sağlamak adına sadece ihtiyaç duyulan veriler DTO yapılarıyla paketlenmiştir.

---

## 🛠️ Kullanılan Teknolojiler ve Yapılar

* **Backend Framework:** .NET Core 6.0 / 8.0 (ASP.NET Core Web API)
* **Veritabanı & ORM:** Microsoft SQL Server & Entity Framework Core
* **Veri Transferi:** DTO (Data Transfer Object) Yapıları
* **Serileştirme:** Newtonsoft.Json (JsonConvert)
* **Tasarım & Arayüz:** Admin paneli için modern Quixlab Bootstrap Teması
* **Mimari Desenler:** Repository Pattern, Dependency Injection

---

## 📂 Katman Yapısı (Architecture)

* **`HotelProjectEntity`:** Veritabanı tablolarının nesnel karşılıklarını (Concrete sınıfları) barındıran katman.
* **`HotelProjectDataAccess`:** Entity Framework ve Context yapılandırmalarının yer aldığı, veritabanı CRUD operasyonlarını üstlenen katman.
* **`HotelProjectBusiness`:** Validasyonların ve iş kurallarının (Business Logic) döndüğü katman.
* **`HotelProject.WebApi`:** Dış dünyaya servis sunan, HTTP metodları (GET, POST, PUT, DELETE) ile çalışan API katmanı.
* **`HotelProjectUI`:** API'yi tüketen, kullanıcı ve admin etkileşimlerini yöneten ön yüz katmanı.

---

## 🎓 Teşekkür ve Katkı

Bu projenin backend mimarisinin kurulmasında, API entegrasyonlarının ve servis yapılarının doğru standartlarda öğrenilmesinde **Udemy Api Proje Kampı** eğitiminin katkısı büyüktür. Eğitim boyunca edinilen mimari vizyon, projenin tamamlanmasında en büyük rehberim olmuştur.
