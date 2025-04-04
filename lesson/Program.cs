using System;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            LessonInformation();

            Console.WriteLine("Ora gli esercizi: ");

            int[] array = LoadArray(10);

            Console.WriteLine("Esercizio 1:");
            Exercise1();
            Esercizio2();
            Esercizio3();
            Esercizio4();
            Esercizio5();
            Esercizio6();

            Console.ReadLine();
        }
        /// <summary>
        /// Stampa gli elementi di un array bi-dimensionale, riga per riga.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <returns>L'array risultato</returns>
        private static int[,] LoadMatrix(int rows, int columns)
        {
            if(rows < 0 || columns < 0)
            {
                Console.WriteLine($"righe e colonne devono essere numeri positivi ");
                return new int[,] { };
            }
            else
            {
                int[,] result = new int[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < columns; j++)
                    {
                        Console.Write($"matrix[{i},{j}] = ");
                        result[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return result;

            }
        }
        /// <summary>
        /// Stampa gli elementi di un array bi-dimensionale, riga per riga.
        /// </summary>
        /// <param name="matrix">L'array bi-dimensionale da stampare a video</param>
        private static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1); 
            Console.WriteLine($"Stampa di una matrice con {rows} righe e {columns} colonne");
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Carica un array di n celle, chiedendo in input
        /// tutti i valori
        /// </summary>
        /// <param name="n"">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static int[] LoadArray(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"N deve essere un numero positivo, {n} non lo è");
                return new int[] { };
            }
            else
            {
                Console.WriteLine($"Caricamento vettore di {n} elementi...");

                int[] result = new int[n];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"array[{i}] = ");
                    result[i] = Convert.ToInt32(Console.ReadLine());
                }

                return result;
            };

        }
        ///<summary>
        /// Copia gli elementi di un array caricato in input in un secondo array,
        /// invertendoli e poi li stampa entrambi.
        /// </summary>
        /// <param name="n"">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static void Esercizio2()
        {
            Console.WriteLine("Inserire N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);
            int[] arrayDestination = new int[n];

            //copiamo arrayA dentro array B
            //...
            for (int i = 0; i < arraySource.Length; i++)
            {
                arrayDestination[n - i - 1] = arraySource[i];
            }

            //stampiamo i 2 array
            Console.WriteLine("arraySource");
            PrintArray(arraySource);
            //...
            Console.WriteLine("arrayDestination");
            PrintArray(arrayDestination);
            //...
        }
        ///<summary>
        /// Inverte gli elementi di un vettore senza usare un secondo array
        /// </summary>
        /// <param name="n"">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static void Esercizio3()
        {
            Console.WriteLine("Inserire N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);

            //copiamo arrayA dentro array B
            //...
            for (int i = 0; i < arraySource.Length/2; i++)
            {
                int temp = arraySource[i];
                arraySource[i] = arraySource[n - i - 1];
                arraySource[n - i - 1] = temp;
            }

            //stampiamo i 2 array
            Console.WriteLine("arraySource");
            PrintArray(arraySource);
        }
        ///<summary>
        /// trova il numero massimo e il numero minimo di un array
        /// </summary>
        /// <param name="n"">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static void Esercizio4()
        {
            Console.WriteLine("Inserire N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);

            if (n == 0)
            {
                Console.WriteLine("Non posso trovare il massimo e minimo valore in un array vuoto");
            }
            else
            {
                int max = int.MinValue;
                int min = int.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (min > arraySource[i])
                    {
                        min = arraySource[i];
                    }
                    if (max < arraySource[i])
                    {
                        max = arraySource[i];
                    }
                }
                //stampiamo i 2 array
                Console.WriteLine($"Il valore massimo è: {max}");
                Console.WriteLine($"Il valore massimo è: {min}");
            }
        }
        ///<summary>
        /// Calcolare la somma di due matrici richieste in input
        /// </summary>
        /// <param name="n"">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static void Esercizio5()
        {
            Console.WriteLine("Inserire il numero di colonne:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero di colonne:");
            int rows = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = LoadMatrix(columns, rows);
            int[,] matrixB = LoadMatrix(rows, columns);

            int[,] matrixResult = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixResult[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            //stampiamo il risultato  della somma tra 2 matrici

            Console.WriteLine("matrice somma: ");
            PrintMatrix(matrixResult);

        }
        ///<summary>
        /// Conta il numero di occorrenze di un valore preso in input all'interno
        /// di una matrice presa in input
        /// </summary>
        /// <param name="n"">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static void Esercizio6()
        {
            Console.WriteLine("Inserire il numero di colonne:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero di colonne:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero da cercare:");
            int x = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = LoadMatrix(columns, rows);

            int count = 0;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        count++;
                    }
                }
            }

            
            //stampiamo quante volte è apparso il valore n

            Console.WriteLine($"il valore compare: {n}");

            

        }
        /// <summary>
        /// Stampa gli elementi di un array, uno per riga, mettendo anche
        /// le informazioni sull'indice
        /// </summary>
        /// <param name="array">L'array da stampare a video</param>">
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine($"array[{i}] -> {array[i]}");
            }

        }
        /// <summary>
        /// Copia gli elementi di un array caricato in input in un secondo array,
        /// poi li stampa entrambi
        /// </summary>
        private static void Exercise1()
        {
            Console.WriteLine("Inserire N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);
            int[] arrayDestination = new int[n];

            //copiamo arrayA dentro array B
            //...
            for (int i = 0; i < arraySource.Length; i++)
            {
                arrayDestination[i] = arraySource[i];
            }

            //stampiamo i 2 array
            Console.WriteLine("arraySource");
            PrintArray(arraySource);
            //...
            Console.WriteLine("arrayDestination");
            PrintArray(arrayDestination);
            //...
        }
        private static void LessonInformation()
        {
            Console.WriteLine("Esercitazione 3 - :Net Console");

            Console.WriteLine(@"I tipi di dato primitivo sono quei tipi di da 
                elementare che non possono essere scomposti in tipi più semplici.
                Rientrano in questa categoria i seguenti tipi di dato:
                -bool
                -byte, short, int, long
                -float, double, decimal
                -char
                string");
            Console.WriteLine("i tipi derivati");
            Console.WriteLine(@"I tipi di dato derivati sono quei tipi di dato
            non elementare che si creano componendo i tipi primitivi in diverse
            maniere.
            Rientrano in questa categoria i seguenti tipi di dato:
            - gli array (su qualsiasi dimensione) - tipi primitivi allocati 
                in  maniera omogenea.
            - le struct - tipi primitivi allocati in  maniera non omogenea.
            - le classi - tipi primitivi allocati in  maniera non omogenea, che seguono
                le regole della programmazione a oggetti
                (Object Oriented Programming - OOP)");

            Console.WriteLine("Gli array:");
            Console.WriteLine(@"Definiamo array una variabile che consiste nell'allocazione
                                contigua di celle di memoria che contengono valori appartenenti allo stesso tipo
                                primitivo
                                Tipicamente noi conosciamo gli array mono dimensionali, e chiamiamo 'matrici'
                                gli array multi-dimensionali");

            // inizializzazione diretta
            // con questa inizializzazione impostiamo
            // tutti e valori delle celle dell'array e
            // solo quelle (non ne aggiungiamo altre vuote)
            //
            int[] array = {};

            // inizializzazione array vuoto di dimensione 10
            // con questa inizializzazione impostiamo le 10 celle a
            // zero. Non ne aggiungiamo altre vuote
            int[] array2 = new int[10];

            //la dimensione non deve essere per forza definita come
            //constante : le variabili canno anche bene
            int n = 10;
            int[] array3 = new int[n];

            //il metodo Array.resize ridimensiona un array monodimensionale
            //dandogli una nuova dimensione
            //
            //se la uova dimensione è maggiore della precedente, aggiunge nuove
            //celle impostando lo zero-value
            //
            //se la nuova dimensione è minore della precedente, gli ultimi elementi
            //verranno eliminati per fare spazio.
            //
            //la parola chiave "ref" serve a passare per referenze (indirizzo / parola
            //con la p) la variabile.

            Array.Resize(ref array3, n * 2);

            Console.WriteLine(@"Per acedere a una cella di un array, usiamo la notazione 
            'a indice' (array[indice]). Questo si può fare sia per la lettura che per 
            l'impostazione / assegnamento");

            //imposto
            array[0] = 10;

            //leggo
            Console.WriteLine(array[0]);

            //l'indice può anche essere una variabile
            int x = 1;

            Console.WriteLine($"array[{x}]-> {array[x]}");

            // è impossibile scorrere un array di qualsiasi tipo con uno o più cicli

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] -> {array[i]}");
            }

            Console.WriteLine(@"Definiamo matrice (a N dimesioni) un array
            multi-dimensionale avente esattamente N dimensioni.");

            //inizializzazione diretta

            int[,] matrix2D =
            {
                { 1, 2 },
                { 3, 4 },
            };

            //inizializzazione con zero-values
            int[,] matrix2DZero = new int[10, 10];

            //assegnamento (notare come gli indici sono 2)
            matrix2DZero[0, 1] = 1;

            //lettura
            x = 1;
            int y = 1;
            Console.WriteLine($"matrix2DZero[{x},{y}] -> {matrix2DZero[x, y]}");

            // inizializzazione diretta di una matrice a 3 dimensioni
            int[,,] matrix3D =
            {
                {
                    { 1, 2},
                    { 3, 4},
                },
                {
                    { 5, 6},
                    { 7, 8},
                },
            };
            //lettura
            int z = 0;
            Console.WriteLine($"matrix3D[{x}, {y}, {z}] -> {matrix3D[x, y, z]}");

            Console.WriteLine("Nelle matrici, il .Lenght contiene il totale di celle");
            Console.WriteLine(@"Per ottenere gli elementi in una determinata dimensione,
                usiamo il metodo. GetLegth(dimensione)");

            int rows = matrix2D.GetLength(0);
            int columns = matrix2D.GetLength(1);

            Console.WriteLine($"matrix2D ha {rows} righe e {columns} colonne");

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"matrix[{i}, {j}] -> {matrix2DZero[i, j]}");
                }
            }
        }
        
    }
}
