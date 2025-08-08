# Lists 2 - Pratik

Bu uygulama, **C#** dilinde `List<T>` koleksiyonu kullanarak kullanıcının girdiği kahve isimlerini saklar ve **foreach** döngüsüyle ekrana yazdırır.

---

## 🎯 Amaç

* `List<string>` kullanarak dinamik olarak eleman eklemek.
* Kullanıcıdan klavye ile veri almak.
* Liste içeriğini **foreach** döngüsü ile ekrana yazdırmak.

---

## 🧠 Mantık Özeti

1. `List<string>` ile boş bir kahve listesi oluşturulur.
2. `for` döngüsü ile 5 kez kullanıcıdan kahve ismi alınır.
3. Her alınan kahve ismi listeye eklenir.
4. Döngü bittikten sonra **foreach** ile listedeki tüm kahve isimleri ekrana yazdırılır.

---

## 📁 Örnek Kod

```csharp
List<string> kahveler = new List<string>();

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Kahve {i}: ");
    string kahve = Console.ReadLine();
    kahveler.Add(kahve);
}

Console.WriteLine("\nGirilen Kahve İsimleri:");
foreach (var kahve in kahveler)
{
    Console.WriteLine(kahve);
}
```

---

## 🖨️ Örnek Çıktı

```
Kahve 1: Mocha
Kahve 2: Latte
Kahve 3: Espresso
Kahve 4: Americano
Kahve 5: Cappuccino

Girilen Kahve İsimleri:
Mocha
Latte
Espresso
Americano
Cappuccino
```

---

## 📌 Notlar

* `for` döngüsü, tekrar sayısı belli olduğunda idealdir.
* `foreach` döngüsü, listedeki tüm elemanlara erişip işlem yapmak için uygundur.
* Kullanıcı girişleri `Console.ReadLine()` ile string olarak alınır.

---
