﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140


/*
 * In javascript  (closure)
  Maker() {
    let tot = 0;
    return (n) => {
        tot += n;
        return tot;
    }
  }
 * */
//1: per evitare di dichiarare un tipo cosa uso? var!!!
var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};
var acc1 = Maker();
var acc2 = Maker();
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));

var somma = (int n) => { n++; Console.WriteLine(n); };
somma(9);


//Data una lista di interi, metterli tutti al quadrato

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
List<int> lisquare = MettiAlQuadrato(list);
foreach(int n in lisquare)
    Console.WriteLine(n);

List<int> MettiAlQuadrato(List<int> list)
{
    List<int> lout= new List<int>();
    foreach(int n in list)
        lout.Add(n * n);
    return lout;
}

List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> li3 = MettiAlCubo(list);
foreach (int n in li3)
    Console.WriteLine(n);

List<int> MettiAlCubo(List<int> list)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(n * n * n);
    return lout;
}

List<int> EseguiIlCalcolo(List<int> li, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(fun(n));
    return lout;
}
List<int> lcalcolo = EseguiIlCalcolo(li, (n) => n * (n + 1) / 2);
foreach (int n in lcalcolo)
    Console.WriteLine(n);
//Abbiamo in questo modo costruito una funzione "generale" per trasformare
//tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
//Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
//e torna una lista di numeri interi


//ordinare una lista di interi
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort();
li.Reverse();  //se la volessi al contrario
foreach (int n in li)
    Console.WriteLine(n);
Console.WriteLine("\n\n\n\n");
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return -1;
    if (v1 == v2)
        return 0;
    else
        return 1;
});
foreach (int n in li)
    Console.WriteLine(n);
//crescente
Console.WriteLine("\n\n\n\n");
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return 1;
    if (v1 == v2)
        return 0;
    else
        return -1;
});
foreach (int n in li)
    Console.WriteLine(n);
//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla e stamparla in verso decrescente

List <string> lstr = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "Sei" };
lstr.Sort((string s1, string s2) => -s1.CompareTo(s2));
foreach (String s in lstr)
    Console.WriteLine(s);