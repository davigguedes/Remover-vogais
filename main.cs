using System;

class Program {
  public static void Main (string[] args) {
    
    // Faça um programa para criptografar uma frase informada pelo usuário.
    // A criptografia deverá troca as vogais da frase por *
    //   Exemplo:
    //     Frase: EU ESTOU NA ESCOLA
    //     Saída: ** *ST** N* *SC*L*

    // declaração

    string frase;

    // solicitar frase
    Console.Write("Digite a frase: ");
    frase = Console.ReadLine();

    // verificar se é vogal e imprimir a frase
    for (int i = 0; i < frase.Length; i++) {
      if (frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U' || frase[i] == 'a'  || frase[i] == 'e'  || frase[i] == 'i'  || frase[i] == 'o'  || frase[i] == 'u') {
        Console.Write("*");
      }
      else {
        Console.Write(frase[i]);
      }
    }
  }
}