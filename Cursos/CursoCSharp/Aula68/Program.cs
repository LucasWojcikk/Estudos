namespace Aula68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SOBRE NULLABLE

            // Definir uma variavel struct como null utilizando o NULLABLE
            double? x = null;
            double? y = 10.0;

            // Esse metodo pega o valor de X, se o valor for null, entao ele irá pegar o valor padrão do tipo
            // Nesse exemplo, o valor padrão de double é 0
            Console.WriteLine(x.GetValueOrDefault());

            // Nesse exemplo irá pegar o valor que é 10
            Console.WriteLine(y.GetValueOrDefault());

            // Retorna se existe valor na variavel x
            // Como não tem valor, retorna False
            Console.WriteLine(x.HasValue);

            // Retorna True pois existe valor para y
            Console.WriteLine(y.HasValue);

            // Essa operação da erro ao chamar uma variavel que não tem valor
            //Console.WriteLine(x.Value);
            // maneira correta de chamar:

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            Console.WriteLine();

            double? z = null;
            double? v = 10;

            double a = z ?? 5;
            double b = v ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
