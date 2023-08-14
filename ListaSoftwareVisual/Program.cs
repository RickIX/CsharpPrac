//Escrever um algoritmo que receba a altura e a largura de um retângulo e calculea sua área.
// Console.WriteLine("Digite a Altura:");
// double h = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Digite a largura:");
// double l = Convert.ToDouble(Console.ReadLine());

// double a = (h*l)/2;

// Console.WriteLine($"Área = {a}");


// 02 Crie um algoritmo que permita fazer três conversões monetárias.
//  O algoritmodeve receber o valor em real (R$) e apresentar os valores
//   convertidos 
//   em:
//   a) Dólar (1 dólar = 5,18 reais)
//   b) Euro (1 euro = 5,31 reais)
//   c) Peso argentino (1 peso argentino = 0,04 reais)

// Console.WriteLine("Valor:");
// double v = Convert.ToDouble(Console.ReadLine());

// double dol = v/4.91;
// Console.WriteLine($"Dolár:{dol}");

// double eu = v/5.31;
// Console.WriteLine($"euro:{eu}");

// double pes = v/0.04;
// Console.WriteLine($"peso:{pes}");

// Console.WriteLine("2 valores, qual é maior:");
// Console.WriteLine("val 1");
// double v1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("val 2");
// double v2 = Convert.ToDouble(Console.ReadLine());

// if(v1>v2){
//     Console.WriteLine($"{v1} é maior que {v2}");
// }else if(v1 == v2){
//     Console.WriteLine("Os valores são iguais");
// }else{
//     Console.WriteLine($"{v2} é maior que {v1}");
// }


// Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa eimprimir uma das mensagens:
//  se idade <= 13: Criança, se idade > 13 e <= 18:Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso.

// Console.WriteLine("idade:");
// short idade = Convert.ToInt16(Console.ReadLine());

// if (idade <= 13){
//     Console.WriteLine("Criança");
// }else if (idade <= 18){
//     Console.WriteLine("Adolescente");
// }else if (idade <= 60){
//     Console.WriteLine("adulto");
// }else{
//     Console.WriteLine("Idoso");
// }


// Criar um algoritmo que receba um valor positivo inteiro e imprima a sequênciaFibonacci até o valor lido.
//  Por exemplo: caso o usuário insira o número 15, oprograma deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13

//  Console.WriteLine("Digite um número inteiro positivo:");
//         int numero = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Sequência de Fibonacci até o número " + numero + ":");

//         for (int i = 0; i <= numero; i++)
//         {
//             int resultado = Fibonacci(i);
//             Console.Write(resultado + " ");
//         }
    

//     static int Fibonacci(int n)
//     {
//         if (n == 0)
//             return 0;
//         else if (n == 1)
//             return 1;
//         else
//             return Fibonacci(n - 1) + Fibonacci(n - 2);
//     }

// 06Desenvolver um algoritmo para receber 1000 valores automaticamente dentro deum vetor e ordenar do menor para o maior.
// a) Desenvolver o algoritmo de ordenação;b) Utilizar uma função em C# para ordenação

// int[] vetor = new int[1000];
//         Random random = new Random();

//         for (int i = 0; i < vetor.Length; i++)
//         {
//             vetor[i] = random.Next(1000); // Preenche o vetor com valores aleatórios de 0 a 999
//         }

//         // Ordenação usando Bubble Sort
//         OrdenarBubbleSort(vetor);

//         // Imprimir vetor ordenado
//         Console.WriteLine("Vetor ordenado:");
//         foreach (int valor in vetor)
//         {
//             Console.Write(valor + " ");
//         }
    

//     static void OrdenarBubbleSort(int[] arr)
//     {
//         int tamanho = arr.Length;
//         for (int i = 0; i < tamanho - 1; i++)
//         {
//             for (int j = 0; j < tamanho - i - 1; j++)
//             {
//                 if (arr[j] > arr[j + 1])
//                 {
//                     int temp = arr[j];
//                     arr[j] = arr[j + 1];
//                     arr[j + 1] = temp;
//                 }
//             }
//         }
//     }