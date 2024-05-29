using DesafioPOO.Models;

Console.WriteLine("Testando a classe Nokia");
Smartphone celular1 = new Nokia("123456", "C14", "29834954", 8);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Facebook");

Console.WriteLine("\n\n");

Smartphone celular2 = new Iphone("896654", "17", "5846138", 4);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("FreeFire");