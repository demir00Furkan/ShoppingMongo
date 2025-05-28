# ShoppingMongo

---

## Kullanıcı Arayüzü (UI)

### 1. Ana Sayfa
- Erkek/Kadın yeni sezon gibi başlıklar ve görseller veritabanından dinamik olarak çekilir.
- Navbar’daki butonlar, sayfa içinde ilgili bölümlere yönlendirir.
- Modern ve mobil uyumlu tasarım.

  ![Header](https://github.com/user-attachments/assets/cb743a18-766c-49e2-a014-0a7b62412b30)


### 2. Kategoriler Sayfası
- Müşterilerin sitede daha hızlı ve kolay gezinmesi için tasarlanmıştır.
- Kategori kartının üzerine gelindiğinde “Alışverişe Başla” butonu belirir ve ilgili kategoriye yönlendirir.
  
![Categories](https://github.com/user-attachments/assets/ea318f3c-9503-43b0-b756-35c27c505e79)


---

### 3. Ürünler Sayfası

Bu sayfa, sitedeki tüm ürünlerin kullanıcıya kartlar halinde listelendiği alandır.

- **Ürün Kartları:** Her ürün, görseli, adı, kısa açıklaması ve fiyatı ile birlikte kart şeklinde gösterilir.
- **Kategorilerden Bağımsız Listeleme:** Tüm ürünler tek bir sayfada, kategori filtresi olmadan listelenir.
- **Kullanıcı Deneyimi:** Kullanıcılar ürün görsellerine veya isimlerine tıklayarak ürün detay sayfasına yönlendirilir.
- **Modern Tasarım:** Responsive ve sade bir grid yapısı ile ürünler kolayca incelenebilir.

Bu sayfa, müşterilerin tüm ürünleri hızlıca gözden geçirmesini ve ilgilendikleri ürüne kolayca ulaşmasını sağlar.
![Products](https://github.com/user-attachments/assets/ce158a1c-dbb1-4e06-996a-f451f7926df2)

---


### 4. Ürün Detay Sayfası
- Seçilen ürünün detaylı bilgileri ve görselleri dinamik olarak gösterilir.

  ![ProductDetailUi](https://github.com/user-attachments/assets/97ce520a-2812-4f82-a127-e6da36cdad0a)


### 5. Footer Alanı
- Kategoriler, yardım, iletişim ve kupon kodu bölümlerinden oluşur.
- Kullanıcılar iletişim bilgilerine ve indirim kuponu formuna kolayca ulaşabilir.
  
![Footer](https://github.com/user-attachments/assets/eaf7df24-cc15-44f7-a8b9-916c9dff377d)

---

## Admin Paneli

### 1. Gösterge Paneli (Dashboard)
- Yöneticiler için sistemdeki genel durumu özetler.
- Toplam ürün, düşük stoklu ürün, toplam kategori ve talebi yüksek ürün sayısı gibi bilgiler sunar.
- Son eklenen ürünler tablo halinde gösterilir.

  ![DashboardList](https://github.com/user-attachments/assets/82a12ae3-3ede-405c-8e5d-7c4989234af1)


### 2. Ürün Yönetimi
#### a) Ürün Listeleme
- Tüm ürünler tablo halinde listelenir.
- Ürünler üzerinde düzenleme ve silme işlemleri yapılabilir.
- Arama ve yeni ürün ekleme fonksiyonları mevcuttur.

  ![ProductList](https://github.com/user-attachments/assets/394bddeb-2a93-4687-8f15-a806444e3891)


#### b) Ürün Oluşturma
- Yeni ürün eklemek için kullanılır.
- Ürün adı, fiyat, açıklama, görseller, stok sayısı ve kategori seçimi yapılır.

  ![ProductCreate](https://github.com/user-attachments/assets/8e7dcf68-239a-4af9-b25a-01d9d2977307)


#### c) Ürün Güncelleme
- Mevcut ürün bilgileri güncellenebilir.
- ID, ürün adı, fiyat, açıklama, görseller, stok sayısı, kategori ve oluşturma tarihi alanları bulunur.
  
![ProductUpdate](https://github.com/user-attachments/assets/92e3043f-7d10-4f1f-94c6-71ed59ccb089)

### 3. Kategori Yönetimi
#### a) Kategori Listeleme
- Tüm kategoriler tablo halinde listelenir.
- Kategoriler üzerinde düzenleme ve silme işlemleri yapılabilir.
- Arama ve yeni kategori ekleme fonksiyonları mevcuttur.

  ![CategoryList](https://github.com/user-attachments/assets/18345212-d1ab-43d8-a94a-70985e30e729)


#### b) Kategori Oluşturma
- Yeni kategori eklemek için kullanılır.
- Kategori adı, alt başlık ve fotoğraf yolu girilir.

  ![CategoryCreate](https://github.com/user-attachments/assets/b41cea09-6c66-4d82-90f8-a609600672f8)


#### c) Kategori Güncelleme
- Mevcut kategori bilgileri güncellenebilir.
- ID, kategori adı, alt başlık ve fotoğraf yolu alanları bulunur.

  ![CategoryUpdate](https://github.com/user-attachments/assets/daaf4c5a-6ab0-4cf1-b38f-afed305e2708)


### 4. Slider Yönetimi
#### a) Slider Listeleme
- Tüm slider içerikleri tablo halinde listelenir.
- Her slider için birden fazla başlık, alt başlık ve görsel yolu bulunabilir.
- Düzenleme işlemi yapılabilir.
- Silme ve ekleme işlemlerine sayfa düzeninin bozulmaması açısından izin verilmemektedir.

  ![SlidierList](https://github.com/user-attachments/assets/3bdd6f2e-70df-4696-9aa3-ee5e8589cd33)


#### b) Slider Güncelleme
- Seçilen slider içeriği güncellenebilir.
- Birden fazla başlık, alt başlık ve görsel yolu düzenlenebilir.

  ![SlidierUpdate](https://github.com/user-attachments/assets/79d339c6-6456-4689-a52e-bb15af4a13dc)


### 5. Sol Menü (Sidebar)
- Kullanıcı bilgisi, ana sayfa, ürünler, kategoriler, slider yönetimi ve diğer işlemler için hızlı erişim sağlar.
- “Siteye Git” ve “Çıkış Yap” gibi ek fonksiyonlar içerir.
  
![Sidebar](https://github.com/user-attachments/assets/9af82692-5c2a-4cf9-84ee-82bd6da79dcf)

---
