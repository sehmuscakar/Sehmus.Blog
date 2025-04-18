# 📝 Sehmus Blog Platformu

Merhaba! Bu proje, kişisel portföyünü, bloglarını ve hizmetlerini tanıtabileceğin **katmanlı mimariye sahip** güçlü bir ASP.NET Core MVC uygulamasıdır. 💼

---

## 📁 Proje Katmanları

### 🧠 **BusinessLayer**
Uygulama içerisindeki iş kurallarının yönetildiği katmandır.

- 🔧 `Concrete/` - Manager sınıfları (ör: `BlogManager.cs`, `ServiceManager.cs`)
- 🧩 `Abstract/` - Service interface'leri
- 📦 `DependencyResolvers/Autofac` - IoC Container yapılandırması

---

### 🧱 **CoreLayer**
Projede tekrar eden veri erişim işlemleri burada tanımlanır.

- ⚙️ `EfEntityRepositoryBase.cs` - Generic Repository kalıbı
- 🧬 `IEntity.cs`, `IDto.cs` - Base entity ve DTO arayüzleri

---

### 🗃️ **DataAccessLayer**
Veri erişim işlemleri bu katmanda gerçekleştirilir.

- 🧩 `Abstract/` - DAL interface'leri
- 🧱 `Concrete/` - Entity Framework implementasyonları
- 🧪 `Context/` - DbContext (`ProjeContextDb.cs`)

---

### 👤 **EntitiesLayer**
Veritabanı tablolarına karşılık gelen modeller burada bulunur.

- 📄 `Concrete/` - Entity sınıfları (ör: `Blog.cs`, `Service.cs`)
- 📋 `Dtos/` - Listeleme ve veri aktarım modelleri

---

### 🌐 **PresentationLayer (UI)**
Kullanıcıya sunulan arayüz burada yer alır.

#### 🔒 Admin Panel
- 🧭 `Controllers/` - Admin işlemleri (ör: `BlogController.cs`)
- 🛠️ `Views/` - Razor View dosyaları
- 📦 `ViewComponents/` - Sayfa bileşenleri

#### 🏠 Public Arayüz
- 🧭 `HomeController.cs`
- 📦 `ViewComponents/` - Kullanıcıya gösterilen bileşenler
- 💅 `wwwroot/` - CSS, JS, görseller

---

## ⚙️ Kullanılan Teknolojiler

- 🧪 ASP.NET Core MVC
- 🐘 Entity Framework Core
- 🛠️ Autofac (IoC)
- 🎨 Razor Pages
- 💾 SQL Server
- 🔐 Identity & Authorization

---
