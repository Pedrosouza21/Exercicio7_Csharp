using System;

class MainClass {
  public static void Main (string[] args) {
    int n;
    string opc;
    do{
      Console.Write("Digite um número: ");
      n= int.Parse(Console.ReadLine());
      if(n<=0){
        Console.Write("\nOpção Inválido");
      }
       else if(n%2==0){
        Console.Write("\nO número é par ");
      }
      else{
        Console.Write("\nO número é ímpar");
      }
      do{
          Console.WriteLine("");
          Console.Write("\n Insira continuar ?\n\n1-(S)im\n2-(N)ão\n");
          opc = Console.ReadLine().ToUpper();
          if(opc!="S"&opc!="1"&opc!="N"&opc!="2")
          Console.Write("Opção Inválida\n");
        }
        while(opc!="S"&opc!="1"&opc!="N"&opc!="2");
    }
    while(opc=="S"||opc=="1");
    }
}