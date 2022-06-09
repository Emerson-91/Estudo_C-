//VARIAVEIS 

// int 1 
// Float = 15.6
// bool = true or false
//String = "fsdfsdfsd"
/*
int idade = 3;
String nome = "Teste";
Console.WriteLine("Olá, "+nome);
Console.WriteLine("A idade é: "+idade);
*/

/*
var cor_favorita = "Verde";
var modelo = 123;

Console.WriteLine(cor_favorita);
Console.WriteLine(modelo);


dynamic cor_favorita = "vermelho";
Console.WriteLine(cor_favorita);

cor_favorita = 2121231;
Console.WriteLine(cor_favorita);    
*/


//CONSTANTES
/*
const float PI = (float)Math.PI;

dynamic valor = PI * 2 * 2;
Console.WriteLine( valor );

*/
// CAPTURANDO ENTRADA DO USUARIO
/*
Console.WriteLine("Escreva seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seu nome é: {nome}");
*/

// OPERADORES ARITMETICOS
/*
float n1 = 30, n2 = 12, soma, sub, mult;
soma = n1 + n2;
sub = n1 - n2;
mult = n1 * n2;
float div = n1 / n2;

Console.WriteLine($"a soma de {n1} + {n2} é {soma}");
Console.WriteLine($"a subtração de {n1} - {n2} é {sub}");
Console.WriteLine($"a multiplicacao de {n1} * {n2} é {mult}");
Console.WriteLine($"a divisão de {n1} / {n2} é {div}");
*/
//CONDICIONAIS
// > < != == >= <=
/*
Console.WriteLine("insira um numero: ");
int num = int.Parse(Console.ReadLine());

if (10 > num)
{
    Console.WriteLine($"10 é maior que {num}");
}
else if (10 < num)
{
    Console.WriteLine($"10 é menor que {num}");
}
else
{
    Console.WriteLine($"10 é igual a {num}");
}
*/

//FUNÇÕES

/*
//escrever a função
static void ExibirMsg()
{
    Console.WriteLine("teste");
    Console.WriteLine("Usando Função");
}

static void soma(int n1, int n2)
{
    int valor = n1 + n2;
    Console.WriteLine($"a soma de {n1} + {n2}= {valor}");
} 

soma(7,5);
ExibirMsg();
*/

//ARRAY
/*
string[] produtos = new string[5] {
  "Sea of thieves",
  "Halo",
  "Fifa",
  "Half-Life",
  "Tekken"};

Console.WriteLine(produtos[3]);

produtos[3] = "Portal";
Console.WriteLine(produtos[3]);

//METODO MAIS SIMPLES DE CRIACAO DE ARRAYS
int[] valores = { 7,8,9,10 };
*/

//SWITCH
/*
string cor = "Azul";
switch (cor)
{
    case "vermelho":
        Console.WriteLine("A cor é vermelho");
        break;
    case "amarelo":
        Console.WriteLine("A cor é amarelo");
        break;
    case "preto":
        Console.WriteLine("A cor é preto");
        break;
    case "branco":
        Console.WriteLine("A cor é branco");
        break;
    case "verde":
        Console.WriteLine("A cor é verde");
        break;
    case "Azul":
        Console.WriteLine("A cor é azul");
        break;
        default:
        Console.WriteLine("Cor nao definida");
        break;
}
*/

//ENUM == enumerador
enum Cor
{
    azul, verde, amarelo, vermelho
}

