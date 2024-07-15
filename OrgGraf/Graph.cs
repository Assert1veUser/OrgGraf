namespace OrgGraf;

public class Graph
{
    List<Vertex> V = new List<Vertex>();
    List<Edge> E = new List<Edge>();
    private int[,] matrix;
    public int VertexCount => V.Count;
    public int EdgeCount => E.Count;
    public void AddVertex(Vertex vertex)
    {
        V.Add(vertex);
    }
    public void AddEdge(Vertex from, Vertex to)
    {
        var edge = new Edge(from, to);
        E.Add(edge);
    }

    public List<Vertex> GetVertexLists(Vertex vertex)
    {
        var result = new List<Vertex>();
        foreach (var egde in E)
        {
            if (egde.From == vertex)
            {
                result.Add(egde.To);
            }
        }
        return result;
    }
}