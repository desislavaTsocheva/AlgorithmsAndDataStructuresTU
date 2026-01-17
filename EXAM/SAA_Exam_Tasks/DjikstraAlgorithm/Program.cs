
public class Program
{   
    static void Main()
    {
        int n = 5;

        int[,] graph = {
            { 0, 10, 0, 0, 5 },
            { 10, 0, 1, 0, 2 },
            { 0, 1, 0, 4, 0 },
            { 0, 0, 4, 0, 3 },
            { 5, 2, 0, 3, 0 }
        };

        Djikstra(n, 0, graph); 
    }

    public static void Djikstra(int n, int start, int[,] graph)
    {
        int[] min = new int[n];
        bool[]visited=new bool[n];

        int INF = int.MaxValue; 

        for (int i = 0; i < n; i++) min[i] = INF;

        min[start] = 0;
        for(int i = 0; i < n - 1; i++)
        {
            int u = -1;
            for(int j = 0; j < n; j++)
            {
                if (!visited[j] && (u == -1 || min[j] < min[u]))
                {
                    u = j;
                }
            }
            visited[u] = true;

            for(int j = 0; j < n; ++j)
            {
                if (graph[u, j] != 0 && !visited[j])
                {
                    int newMin = min[u]+graph[u,j];
                    if (newMin < min[j])
                    {
                        min[j] = newMin;
                    }
                }
            }
        }

        Console.WriteLine("Разстояния от възел " + start + ":");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("До възел " + i + " -> " + min[i]);
        }

    }
}