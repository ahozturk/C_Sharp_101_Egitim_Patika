using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int a = 10;
        int y = 2;
        y += a * 2;

        float t = 2.5f;
        t *= 3;

        if(t != y){
            Console.WriteLine("Hakan \t Bu sayılar farklı!");
            
            Console.WriteLine("Hakan");
            Console.WriteLine("Hakan \t Bu sayılar farklı!");
            Console.WriteLine("Hakan \t Bu sayılar farklı!");
            Console.WriteLine("Hakan \t Bu sayılar farklı!");
        }

        bool kofte = true, ekmek = false;

        if(kofte && ekmek){
            Console.WriteLine("Ekmek arası köfte");
        }
        else if(kofte){
            Console.WriteLine("Köfte menü");
        }
        else if(ekmek){
            Console.WriteLine("Ekmek arası ekmek");
        }

        int baraj = 50;
        int matNotu = 30;

        bool Gecti = baraj < matNotu;

        int sayi = 3;
        if(sayi % 2 == 0){
            Console.WriteLine("Çift Sayı");
            sayi++;
        }
        else{
            Console.WriteLine("Tek Sayı");
        }


    }
}
