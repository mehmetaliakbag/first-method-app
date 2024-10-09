#region Task1

// Geriye değer döndürmeyen bir metot, sevdiğim bir şarkının sözünü konsol ekranına yazdırıyor

static void PrintFavoriteSongLyrics()
{
    Console.WriteLine("Someone wrote this song before" +
                      "\nAnd I could tell you where it's from" +
                      "\nThe 4-7-3-6-2-5-1 to put my mind at ease");
}

PrintFavoriteSongLyrics();

#endregion

#region Task2

// Geriye değer döndüren metot, rastgele bir tam sayı üretip, iki ile bölümünden kalanı tam sayı şeklinde döndüren bir metot

static int GetRandomRemainder()
{
    Random random = new Random();
    int number = random.Next();
    int result = number % 2;
    return result;
}

int remain = GetRandomRemainder();

#endregion

#region Task3

// Parametre alan ve geriye değer döndüren bir metot, parametre olarak aldığı iki sayının çarpımını geriye döndürüyor

static int MultiplyNumbers(int num1, int num2)
{
    int result = num1 * num2;
    return result;
}

// Değer döndüren bir metotu bir değişkene tanımlamak zorunlu değildir

// Side-effect yani metot başka bir işlevi yerine getirdiği için çağrılmış olabilir.

int multiplyResult = MultiplyNumbers(100, 5);

#endregion

#region Task4 

// Parametre alan ve geriye değer döndürmeyen bir metot, parametre olarak aldığı adı ve soyadı "Hoşgeldin" mesajı ile karşılar
static void Welcome(string name, string surname)
{
    Console.WriteLine($"Hoşgeldiniz, {name} {surname}");
}

Welcome("Mehmet Ali", "Akbağ");

#endregion