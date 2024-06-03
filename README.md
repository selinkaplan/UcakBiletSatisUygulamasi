# Uçak Bilet Satış Uygulaması

Uçak Bilet Satış Uygulaması, kullanıcıların uçak biletlerini kolayca rezerve edebilmeleri için tasarlanmış bir masaüstü uygulamasıdır. Bu uygulama, kullanıcıların çeşitli lokasyonlar arasında uçuş aramaları, koltuk seçmeleri ve rezervasyon yapmaları için basit ve kullanıcı dostu bir arayüz sağlar.

## Özellikler

### Kullanıcı Girişi ve Kayıt Olma
- Kullanıcılar mevcut hesaplarıyla giriş yapabilir veya yeni bir hesap oluşturabilir.
- Adminler için ayrı bir giriş ekranı bulunmaktadır.

### Uçuş Arama ve Listeleme
- Kullanıcılar belirli bir kalkış ve varış noktasına göre uçuşları arayabilir.
- Arama sonuçları, kullanıcının seçtiği kriterlere göre filtrelenir ve listelenir.

### Koltuk Seçimi
- Kullanıcılar, seçtikleri uçuş için mevcut koltukları görebilir ve koltuklarını seçebilir.
- Seçilen koltuklar rezervasyon öncesinde kullanıcıya gösterilir.
- Koltuklar satılmadıysa yeşil, satıldıysa kırmızı renge döner ve üzerine tıklandığında müşteri bilgileri görüntülenir.

### Rezervasyon
- Kullanıcılar, seçtikleri koltuklarla birlikte uçuş rezervasyonu yapabilir.
- Rezervasyon tamamlandığında, kullanıcıya başarılı bir rezervasyon bildirimi gösterilir.

### Yönetici Paneli
- Yöneticiler, admin giriş yaparak uçuş, kullanıcı, uçak ve lokasyon yönetimi yapabilir.
- Yönetici paneli, uçuş bilgilerini ve kullanıcı rezervasyonlarını yönetmek için çeşitli araçlar sunar.

### Uçak Yönetimi
- Uçaklar (model, marka, seri no, koltuk kapasitesi vb.) listelenir ve kaydedilir.

### Lokasyon Yönetimi
- Lokasyonlar (ülke, şehir, havaalanı, aktif/pasif vb.) listelenir ve kaydedilir.

## Kullanılan Teknolojiler

- **Programlama Dili:** C#
- **Veritabanı:** SQLite
- **ORM:** EntityFramework
- **Arayüz:** Windows Forms

### Kullanıcı Paneli
1. Kayıt olma veya giriş yapma işlemini gerçekleştirin.
2. Bilet almak istediğiniz lokasyonları seçin.
3. Seçilen lokasyonlara ait uçuşları listeleyin ve bir uçuş seçin.
4. Uçuşa ait uçağın koltuklarını görüntüleyin ve koltuk seçin.
5. Rezervasyon ekranında bilgileri onaylayın ve bilet alımını gerçekleştirin.

### Admin Paneli
1. Admin olarak giriş yapın.
2. Uçak ekleme veya uçuş ekleme paneline girin.
3. Gerekli bilgileri doldurun ve data ekleme işlemini onaylayın.

## Sınıflar

- **Program.cs:** Ana uygulama dosyası.
- **User.cs:** Kullanıcıları temsil eden sınıf.
- **Admin.cs:** Yöneticileri temsil eden sınıf.
- **Flight.cs:** Uçuşları temsil eden sınıf.
- **Plane.cs:** Uçakları temsil eden sınıf.
- **Reservation.cs:** Bilet rezervasyonlarını temsil eden sınıf.

## Önemli Notlar
- Bu uygulama temsili amaçlıdır ve gerçek bir bilet rezervasyon sistemi olarak kullanılmaz.
- Uygulama, SQLite veritabanını kullanarak rezervasyonları "Data" klasöründeki db dosyasına kaydeder.
- Kredi kartı giriş ekranı göstermeliktir; girilen veriler işlenmez veya kaydedilmez.
- Hatalı girişlerde uygulama çökmez; hata mesajı gösterir ve kullanıcıyı tekrar giriş yapmaya yönlendirir.
- Kullanıcı istediği zaman geri dönüp farklı bir seçim yapabilir ve bilet işlemlerini yeniden başlatabilir.
