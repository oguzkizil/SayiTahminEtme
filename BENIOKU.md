Sayı Tahmin Etme

Proje Amacı
Bu projenin amacı; 4 basamaklı ve rakamları tekrar
etmeyen sayıların, dönen değerler* yardımıyla tahmin
edilmesini sağlamaktır. 

Proje “ Tahmin Et ” ve “ Sayı Tut ” olarak iki bölümden
oluşmakta.

--> “Tahmin Et” kısmı bilgisayarın rastgele bir sayı tutması
ve kullanıcının tahminlerine karşılık değerler döndürüp sayı
hakkında ipucu vermesi üzerine kurulmuştur.

*Dönen değerler tahmin edilen sayıdaki rakamların yerlerine göre
belirlenir. Eğer rakam tutulan sayıda varsa ve doğru pozisyondaysa her
bir rakam için +1 değer alırken, rakam sayıda var ama yanlış yerdeyse
her rakam için -1 değer alır.

Yöntem : Girilen tahmin sırasıyla basamaklarına
ayrılarak kontrolden geçirilir ve rakamların yerlerine göre
kullanıcıya değerler döndürülür. Dönen değerlere göre
kullanıcıdan yeni bir tahmin istenir.

--> “Sayı Tut” kısmı ise kullanıcının bir sayı tutması ve
bilgisayarın tahminlerine karşılık değerler döndürüp sayı
hakkında ipucu vererek, bilgisayarın en fazla 7 adımda
tutulan sayıyı bulması üzerine kurulmuştur.

Yöntem : Tutulan sayı bilgisayarın tahminlerine göre
incelenir ve uygun değerler bilgisayara gönderilir.
Bilgisayar aldığı değerleri “ Olasılık Tablosu ” içinde
karşılaştırır ve bu değere karşılık bir sonraki tahminini
yapar. Sayı bulunana kadar bu döngü devam eder.

Teknik
Program C# dili kullanılarak yazılmıştır. Temel olarak
rakamların kontrolünün sağlandığı döngüler ve döngülerin
içerisindeki sorgulardan oluşur.

“ Sayı Tut ” kısmında C# içinde mevcut bulunan TreeView
yapısı kullanıldı.
Her adımda dönen değerlerin indexleri tutularak ağaç
daha küçük ağaçlara ayrılarak TreeView içerinde ilerleme
sağlandı.

Versiyon
Mevcut versiyonun “Sayı Tut” kısmı sadece ‘0123’ rakamlarını
içermeyen sayılar için çalışır durumdadır. Olasılık tablosunda görüleceği
üzere her 4 basamaklı ve rakamları tekrar etmeyen sayıları bulmak için
toplam 5040 düğüm girilmelidir. Bu versiyonda 373 düğüm mevcuttur.

Notlar
Bilgisayarın tahmin etmesinde asıl hedef; tahmin edilen sayının en
fazla 7 adımda bulunmasıdır. Kendi kurduğum algoritmalar yeterince
tutarlı olmadığı için program olasılık tablosundan yararlanarak yapıldı.

Kaynak
http://slovesnov.users.sourceforge.net/index.php?bullscows_tree,english,avgBullsCows

Program 2016 yılında geliştirildi
