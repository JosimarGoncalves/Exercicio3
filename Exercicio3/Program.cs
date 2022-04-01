using System;
using System.Threading;
using System.Diagnostics;

class Program {

    public static int[] posicaoX = new int[10];
    public static int[] posicaoY = new int[10];
    public static int valorMinimo = 0;
    public static int valorMaximo = 10;
    public static int [] posicaoSobreposta = new int[10];

    
    static void Main()
    {
        Random posicaoAleatoria = new Random();
        var stopWatch = new Stopwatch();

        stopWatch.Start();

        Console.WriteLine("Numeros sorteados de: {0} até {1} ", valorMinimo, valorMaximo  );

        for (int i = 0; i < posicaoX.Length; i++)
        {
            posicaoX[i] = posicaoAleatoria.Next(valorMinimo, valorMaximo);
        }

        for (int i = 0; i < posicaoY.Length; i++)
        {
            posicaoY[i] = posicaoAleatoria.Next(valorMinimo, valorMaximo);
        }

       

        Console.Write("Posicao de X e Y: "  );
        Console.Write("[");

        for (int i = 0; i < posicaoX.Length; i++)
        {
            Console.Write("{0} -", i);
        }


        Console.Write("]");
        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);

        t1.Start();
        t2.Start();


        t1.Join();
        t2.Join();

        PularLinha();

        

        //for (int i = 0; i < posicaoX.Length; i++)
        //{
        //    if(posicaoX[i] == posicaoX[i++])
        //    {
        //        Console.Write(" {0} - ",i);
        //    }    
        //}

        stopWatch.Stop();

        
        Console.WriteLine($"O Tempo de processamento total é de {stopWatch.ElapsedMilliseconds}ms");

        

    }

    private static void Thread1()
    {
        Console.Write("\nEixo X (vetor X): " );
        Console.Write("[");

        for (int i = 0; i < posicaoX.Length; i++)
        {
          
            Console.Write(posicaoX[i] + " - ");
          
        }

        Console.Write("]");



    }
    private static void Thread2()
    {        
        Console.Write("\nEixo Y (vetor Y): ");

        Console.Write("[");

        for (int i = 0 ; i < posicaoY.Length; i++)
        {
           
           Console.Write(posicaoY[i] + " - ");
         
        }
        Console.Write("]");


    }

    public static void PularLinha()
    {
        Console.WriteLine(" ");
    }
}