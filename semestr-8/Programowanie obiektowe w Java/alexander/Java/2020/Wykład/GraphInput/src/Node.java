import java.util.ArrayList;

public class Node
{
   private int id;
   private String name;
   private ArrayList<Edge> edges=new ArrayList<>();
   public Node(String name,int id)
   {
      this.name = name;
      this.id = id;
   }
   public Node(String name)
   {
      this(name,0);
   }
   public void addEdge(Node nodeTo,double distance)
   {
      edges.add(new Edge(nodeTo, distance));
   }
   public int getId() { return id; }
   public String getName() { return name; }
   public ArrayList<Edge> getEdges() { return edges; }
}
