using System;

class Program {
  public static void Main(string[] args) {
    string gasoline;
    string alcohol;
    string average;

    Console.WriteLine("Digite o preço da gasolina: ");
    gasoline = Console.ReadLine();

    Console.WriteLine("Digite o preço do álcool: ");
    alcohol = Console.ReadLine();

    average = (Convert.ToDouble(gasoline) * 0.7) > Convert.ToDouble(alcohol) 
    ? "Álcool" 
    : "Gasolina";

    Console.WriteLine("A opção mais vantajosa é: " + average);

    Console.WriteLine("Pressione qualquer tecla para sair...");

    Console.ReadKey();
  }
}