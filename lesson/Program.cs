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
            //LessonInformation();

            Esercizio6();
        }


        /// <summary>
        /// Contiene le informazioni relative alla lezione
        /// </summary>
        private static void LessonInformation()
        {
            Console.WriteLine("Esercitazione 3 - .NET Console");


            Console.WriteLine("I tipi primitivi: ");
            Console.WriteLine(@"I tipi di dato primitivo sono quei tipi di dato
            elementare che non possono essere scomposti in tipi piu' semplici
            Rientrano in questa categoria i seguenti dati:
            -short, int, long
            - float, double, decimal
            - char
            - string");


            Console.WriteLine("I tipi derivati:");
            Console.WriteLine(@"I tipi di dato derivati sono quei tipi di dato
            non elementare che si creano componendo i tipi primitivi in diverse maniere.
            Rientrano in questa categoria i seguenti tipi di dato:
            - gli array (su qualsiasi dimensione) - tipi primitivi allocati in maniera omogenea
            - le struct - tipi primitivi allocati in maniera non omogenea
            - le classi - tipi primitivi allocati in maniera non omogenea, che seguono
              le regole della programmazione a oggetti
                (Object Oriente Programming - OOP");


            Console.WriteLine("Gli array: ");
            Console.WriteLine(@"Definiamo array una variabile che consiste nell' allocazione
            contigua (aka uno attaccato all'altro) di celle che contengono valori appartententi
            allo stesso tipo primitivo. Sono tipicamente mono-dimensionali (matrici multi-dimensionali)");

            //compilazione diretta/in modo statico di un array
            //Tutti i valori delle celle sono quelli che impostiamo noi (nessuna extra)
            //non si da la dimensione del vettore perche' prende per scontato
            //che sia la quantita' di numeri che gli diamo
            //la maniera per iniziallizzare un vettore vuoto e'
            //int[] array = {};
            //mettere solo int[] array; significa dichiarare un vettore "??"
            int[] array = { 1, 2, 3 };


            //inizializzare un array vuoto di dimensione 10
            //con questa inizializzazione impostiamo le 10 celle a
            //0. Non ne aggiungiamo altre vuote
            //se diamo un valore in imput come dimensione non deve
            //per forza essere costante anche variabili vanno bene
            // AL VARIARE DELLA VARIABILE VARIA LA DIMENSIONE DELL'ARRAY
            int[] array2 = new int[10];

            //metodo Array.resize ti permette di ridimensionare un array
            //Se do un valore piu' piccolo della dimensione precedente
            //si perdono gli ultimi elementi
            //si usa "ref" per per passare la referenza di una variabile
            //passare come red e come passare con puntatore in C
            //aka se poi modifichi il valore in un altra parte verra'
            //Modificato il valore dovunque
            Array.Resize(ref array2, 2);

            Console.WriteLine(@"Per accedere a una cella di un array, usiamo la notazione
            'a indice' (array[indice]). Questo si puo' fare sia per lettura che per scrittura");


            //imposto
            array2[0] = 1;

            //leggo
            Console.WriteLine(array2[0]);

            //l'indice puo' anche essere una variabile

            int x = 1;
            Console.WriteLine($"array[{x}] -> {array[x]}");

            //e' possibile scorrere un array di qualsiasi tipo con no o piu' cicli
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"array[{x}] -> {array[x]}");
            }


            Console.WriteLine(@"Definiamo matrice (a N dimensioni) un array
            multi-dimensionale ");

            //inizializzazione diretta
            int[,] matrix2D =
            {
                { 1, 2 },
                { 1, 2},
            };

            //inizializzazione con 0-values
            int[,] matrix2Dzero = new int[10, 10];

            //assegnamento
            matrix2Dzero[0, 1] = 1;

            x = 1;
            int y = 2;
            Console.WriteLine($"matrix2Dzero[{x}, {y}] -> matrix2Dzero[0, 1]");

            //iniziallizzazione diretta di una matrice a 3 dimensioni
            int[,,] matrix3D =
            {
                {
                    { 1, 2 },
                    { 1, 2},
                },
                {
                    { 1, 2 },
                    { 1, 2},
                }
            };


            int z = 0;
            Console.WriteLine($"matrix2Dzero[{x}, {y}, {z}] -> {matrix3D[x, y, z]}");

            Console.WriteLine("Nelle matrici, il .Length contiene il totale di celle");
            Console.WriteLine(@"Per ottenere gli elementi in una determinata dimensione,
            usiamo il metodo .GetLength(dimensione)");

            int rows = matrix2D.GetLength(0);
            int columns = matrix2D.GetLength(1);

            Console.WriteLine($"matrix2D ha {rows} righe e {columns} colonne");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"matrix2D ha {i} righe e {j} colonne");
                }
            }
        }

        /// <summary>
        /// Carica un array di n celle, chiedendo in input tutti i valori
        /// </summary>
        /// <param name="n">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static int[] LoadArray(int n)
        {
            //condizione di guardia
            if (n < 0)
            {

                Console.WriteLine("Errore");
                return new int[] { };

            }
            else
            {
                int[] array = new int[n];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Scrivi un numero per la {i} cella ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                return array;
            }
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Cella {i} -> {array[i]}");
            }
        }

        /// <summary>
        /// Carico array bi-dimensionale date righe e colonne
        /// </summary>
        /// <param name="rows">Il numero delle righe dell'array</param>
        /// <param name="columns">Il numero delle colonne dell'array</param>
        /// <returns>L'array bi-dimensionale risultato</returns>
        private static int[,] LoadMatrix(int rows, int columns)
        {
            if (rows < 0 || columns < 0)
            {
                Console.WriteLine("Righe e colonne devono essere positive");
                return new int[,] { };
            }
            else
            {
                int[,] matrix = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine($"Siamo alla Riga {i}");
                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine($"Siamo alla Colonna {j} - che valore vuoi inserire? ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return matrix;
            }
        }

        /// <summary>
        /// Stampa gli elementi di un array bi-dimensionale riga per riga
        /// </summary>
        /// <returns></returns>
        private static void PrintMatrix(int[,] matrix)
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine($"Stampo matrice con {rows} righe e {cols} colonne");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($" {matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Copia gli elementi di un array caricato in input in un secondo array,
        /// poi li stampa entrambi
        /// </summary>
        private static void Esercizio1()
        {

            Console.Write("Quanto grande vuoi il vettore? ");
            int Dim = Convert.ToInt32(Console.ReadLine());

            int[] array = LoadArray(Dim);
            int[] arrayCopy = new int[Dim];

            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }

            Console.WriteLine("Primo Array: ");
            PrintArray(array);
            Console.WriteLine("Array copiato: ");
            PrintArray(arrayCopy);

        }

        /// <summary>
        /// Copia gli elementi di un array caricato in input invertendo l'ordine
        /// poi stampo entrambi
        /// </summary>
        private static void Esercizio2()
        {
            Console.Write("Quanto grande vuoi il vettore? ");
            int Dim = Convert.ToInt32(Console.ReadLine());

            int[] array = LoadArray(Dim);
            int[] arrayCopy = new int[Dim];

            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[array.Length - i - 1];
            }

            Console.WriteLine("Primo Array: ");
            PrintArray(array);
            Console.WriteLine("Array copiato: ");
            PrintArray(arrayCopy);


        }


        /// <summary>
        /// Inverto gli elementi di un array
        /// </summary>
        private static void Esercizio3()
        {
            Console.Write("Quanto grande vuoi il vettore? ");
            int Dim = Convert.ToInt32(Console.ReadLine());

            int[] array = LoadArray(Dim);

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }

            Console.WriteLine("Primo Array: ");
            PrintArray(array);
        }


        /// <summary>
        /// Trova il valore maggiore in un vettore
        /// </summary>
        private static void Esercizio4()
        {
            Console.Write("Quanto grande vuoi il vettore? ");
            int Dim = Convert.ToInt32(Console.ReadLine());

            int[] array = LoadArray(Dim);

            //facendo cosi si fa 1 ciclo in piu'
            //int nMag = int.MinValue;
            //int nMin = int.MaxValue;

            //facendo cosi si risparmia 1 ciclo
            int nMag = array[0];
            int nMin = array[0];


            for (int i = 1; i < array.Length; i++)
            {
                if (nMag < array[i])
                {
                    nMag = array[i];
                }
                if (nMin > array[i])
                {
                    nMin = array[i];
                }
            }

            Console.WriteLine("Primo Array: ");
            PrintArray(array);
            Console.WriteLine($"nMag = {nMag}");
            Console.WriteLine($"nMin = {nMin}");

        }

        /// <summary>
        /// Calcolare la somma di due matrici richieste in input
        /// </summary>
        /// <returns></returns>
        private static void Esercizio5()
        {

            Console.Write("Inseririe il numero di righe: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inseririe il numero di colonne: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = LoadMatrix(rows, cols);
            int[,] matrixB = LoadMatrix(rows, cols);

            int[,] MatrixResult = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    MatrixResult[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            PrintMatrix(MatrixResult);

        }


        /// <summary>
        /// Conta quante volte appare un valore dato in input in una matrice
        /// </summary>
        /// <returns></returns>
        private static void Esercizio6()
        {

            Console.Write("Inseririe il numero di righe: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inseririe il numero di colonne: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = LoadMatrix(rows, cols);

            PrintMatrix(matrix);

            Console.Write("Che valore vuoi controllare se c'e' nella matrice?: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            int trovato = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (numb == matrix[i, j])
                    {
                        trovato++;
                    }
                }
            }

            Console.WriteLine($"{numb} e' stato trovato {trovato} volte");
        }

    }
}

