namespace Knight_Move
{
    public class Node

    {
        public int x;
        public int y;
        public int dist;
        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Node(int x, int y, int dist)
        {
            this.x = x;
            this.y = y;
            this.dist = dist;
        }

    }
    public class knightMove
    {
        static int[] row = { 2, 2, -2, -2, 1, 1, -1, -1 };
        static int[] col = { -1, 1, 1, -1, 2, -2, 2, -2 };

        private static bool isValid(int x, int y, int N)
        {
            return (x >= 0 && x < N) && (y >= 0 && y < N);
        }

        public static int KnightShortDistance(Node src, Node dest, int N)
        {
            ISet<Node> visited = new HashSet<Node>();
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(src);

            while (q.Count > 0)
            {
                Node node = q.Dequeue();
                int x = node.x;
                int y = node.y;
                int dist = node.dist;
                if (x == dest.x && y == dest.y)
                {
                    return dist;
                }
                if (!visited.Contains(node))
                {
                    visited.Add(node);

                    for (int i = 0; i < row.Length; i++)
                    {
                        int xk1 = x + row[i];
                        int yk1 = y + col[i];

                        if (isValid(xk1, yk1, N))
                        {
                            q.Enqueue(new Node(xk1, yk1, dist + 1));
                        }
                    }


                }
            }
            return int.MaxValue;

        }


    }


    class program
    {
        public static void Inserstion(string[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = " ";

                }
            }

        }
        public static void Affichage(string[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {

                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("[" + tab[i, j] + "]");

                }
                Console.WriteLine(" ");
            }

        }


        static void Main(string[] args)
        {
        loop:
            Console.Write("number cols and row of bord =", Console.ForegroundColor = ConsoleColor.White);

            if (!int.TryParse(Console.ReadLine(), out int N))
            {

                Console.WriteLine("_____Caracter not available[ should be a positif number ]_____ ", Console.ForegroundColor = ConsoleColor.Red);
                goto loop;
            }
            else
            {
                if (N > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---------->number of row and cols is ={0}", N);
                }

                else
                {

                    Console.WriteLine("_____Negative number aren't available[ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________________________________________________________");

            string[,] tabNotes = new string[N, N];
            Inserstion(tabNotes);

        loop1:
            Console.Write("number row of knight =", Console.ForegroundColor = ConsoleColor.White);
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("_____Caracter not available[ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                goto loop1;
            }
            else
            {
                if ((x >= 0) && (x < N))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---------->row of knight is = {0}", x);
                }

                else if (x < 0)
                {
                    Console.WriteLine("_____Negative number aren't available [ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop1;
                }
                else
                {

                    Console.WriteLine("_____the row of your  knight is out of bord [ should be in the bord ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop1;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________________________________________________________");

        loop2:
            Console.Write("number cols of knight =", Console.ForegroundColor = ConsoleColor.White);
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("_____Caracter not available[ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                goto loop2;
            }
            else
            {
                if ((y >= 0) && (y < N))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---------->cols of knight  is {0}", y);
                }

                else if (y < 0)
                {
                    Console.WriteLine("_____Negative number aren't available[ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop2;
                }
                else
                {
                    System.Console.WriteLine("_____the col of your  knight is out of bord [ should be in the bord ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop2;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________________________________________________________");

            Node src = new Node(x, y);
            tabNotes[x, y] = "K";



        loop3:
            Console.Write("number row of target =", Console.ForegroundColor = ConsoleColor.White);
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("_____Caracter not available[ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                goto loop3;
            }
            else
            {
                if ((a >= 0) && (a < N))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---------->row of target is {0}", a);
                }

                else if (a < 0)
                {
                    Console.WriteLine("_____Negative number aren't available[ should be a positif number ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop3;
                }
                else
                {
                    Console.WriteLine("_____the row of your  knight is out of bord [ should be in the bord ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop3;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________________________________________________________");

        loop4:
            Console.Write("number cols of target is =", Console.ForegroundColor = ConsoleColor.White);
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("_____Caracter not available [ should be in the bord ]_____", Console.ForegroundColor = ConsoleColor.Red);
                goto loop4;
            }
            else
            {
                if ((b >= 0) && (b < N))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---------->cols number of target is {0}", b);
                }

                else if ((b < 0))
                {
                    Console.WriteLine("_____Negative number aren't available [ should be in the bord ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop4;
                }
                else
                {
                    Console.WriteLine("_____the col of your  target is out of bord [ should be in the bord ]_____", Console.ForegroundColor = ConsoleColor.Red);
                    goto loop4;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________________________________________________________");
            Console.ResetColor();

            Node dest = new Node(a, b);
            tabNotes[a, b] = "T";



            DateTime now = DateTime.Now;
            Console.WriteLine("Begin of Executer =" + now);


            Console.WriteLine("The minimum number of steps required is " + knightMove.KnightShortDistance(src, dest, N), Console.ForegroundColor = ConsoleColor.Blue);
            Console.ResetColor();

            Affichage(tabNotes);

            DateTime noww = DateTime.Now;
            Console.WriteLine("End of Executer = " + noww);

        }
    }
}
