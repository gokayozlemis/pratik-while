int sayac = 0;

while (sayac < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac++;
}





int i = 1;

while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}




int ia = 2;

while (ia <= 20)
{
    Console.WriteLine(ia);  
    ia += 2;  
}



int toplam = 0;
int ib = 50;

while (ib <= 150)
{
    toplam += ib;
    ib++;
}

Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);




int tekToplam = 0;
int ciftToplam = 0;
int ic = 1;

while (ic <= 120)
{
    if (ic % 2 == 0)
    {
        ciftToplam += ic;
    }
    else
    {
        tekToplam += ic;
    }
    ic++;
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);