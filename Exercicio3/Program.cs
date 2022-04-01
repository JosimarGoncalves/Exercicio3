using System;
using System.Threading;
using System.Diagnostics;

class Program {

    public static int[] posicaoX = new int[10];
    public static int[] posicaoY = new int[10];
    public static int valorMinimo = 0;
    public static int valorMaximo = 5;
    public static int [] posicaoSobreposta = new int[10];

    


    static void Main()
    {
        Random posicaoAleatoria = new Random();
        var stopWatch = new Stopwatch();

        stopWatch.Start();

        for (int i = 0; i < posicaoX.Length; i++)
        {
            posicaoX[i] = posicaoAleatoria.Next(valorMinimo, valorMaximo);
        }

        for (int i = 0; i < posicaoY.Length; i++)
        {
            posicaoY[i] = posicaoAleatoria.Next(valorMinimo, valorMaximo);
        }

        Console.WriteLine("\nPosicao de X e Y:");

        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);

        t1.Start();
        t2.Start();


        t1.Join();
        t2.Join();


        //for (int i = 0; i < posicaoX.Length; i++)
        //{
        //    if (i == i++ )
        //    {
        //        Console.WriteLine("Deu merda");
        //    }
        //}

        PularLinha();

        Console.WriteLine("Palmeiras não tem mundial!!! Desisto desse exercicio ");

        stopWatch.Stop();

        
        Console.WriteLine($"O Tempo de processamento total é de {stopWatch.ElapsedMilliseconds}ms");

        

    }

    private static void Thread1()
    {
        Console.Write("Eixo X (vetor X): " );

        for (int i = 0; i < posicaoX.Length; i++)
        {
          
            Console.Write(posicaoX[i] + " - ");
          
        }

        


       
        
    }
    private static void Thread2()
    {        
        Console.Write("\nEixo Y (vetorY): ");

        for (int i = 0 ; i < posicaoY.Length; i++)
        {
           
           Console.Write(posicaoY[i] + " - ");
         
        }

        

    }

    public static void PularLinha()
    {
        Console.WriteLine(" ");
    }
}