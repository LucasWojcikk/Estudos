namespace Aula66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Somente a declaração simples ja funciona com struc, ele ja cria a caixinha na memoria
            // Aqui esta sendo definido os valores de X e Y
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            // Se quiser voce pode instanciar o struct, funciona também
            // mas por padrão as variáveis numéricas são iniciadas com valor 0 pois não esta definido valor de X e Y
            p = new Point();
            Console.WriteLine(p);

            // Quando alocamos com o new, qualquer tipo estruturado (classe, struct, array), são atribuidos
            // valores padrão ao seus elementos
            // numeros = 0
            // booleanos = False
            // char = caractere código 0
            // object = null

            // uma variável apenas declarada, não instanciada, inicia em estado "nao atribuida" e o compilador
            // nao permite que ela seja acessada

        }
    }
}
