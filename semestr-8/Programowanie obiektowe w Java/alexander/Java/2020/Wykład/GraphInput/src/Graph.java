import java.security.InvalidParameterException;
import java.util.HashMap;
public class Graph
{
   private HashMap<String,Node> nodes=new HashMap<>();
   public Graph(String content,boolean list)
   {
      if(list) fromList(content);
      else fromMatrix(content);
   }
   private void fromMatrix(String content)
   {
      String[] rows=content.split("===");
      if(rows.length==2)
      {
         String[] city=rows[0].trim().split("[\r\n]+");
         for(int c=0;c<city.length;++c)
         {
            city[c]=city[c].trim();
            getOrMake(city[c]);
         }
         double[][] tb=new double[city.length][city.length];
         rows=rows[1].trim().split("[\r\n]+");
         if(rows.length==city.length)
         {
            for(int r=0;r<city.length;++r)
            {
               String[] cells=rows[r].split("[\\s\t]+");
               if(cells.length==city.length)
               {
                  for(int c=0;c<city.length;++c)
                  {
                     try
                     {
                        addEdge(city[r], city[c], Double.parseDouble(cells[c].replace(',', '.')));
                     }
                     catch(Exception ex) {}
                  }
               }
               else new InvalidParameterException("Bad columns count");
            }
         }
         else new InvalidParameterException("Bad rows count");
      }
      else new InvalidParameterException("Bad delimeter '==='");
   }
   private void fromList(String content)
   {
      String[] rows=content.split("[\r\n]+");
      for (String row : rows)
      {
         String[] items=row.split("[\\s\t]+");
         if(items.length>=3)
         {
            addEdge(items[0],items[1],Double.parseDouble(items[2].replace(',', '.')));
         }
      }
   }
   public HashMap<String,Node> getNodes() { return nodes; }
   private Node getOrMake(String name)
   {
      if(nodes.containsKey(name)) return nodes.get(name);
      Node node=new Node(name,nodes.size());
      nodes.put(name, node);
      return node;
   }
   void addEdge(String from,String to, double distance)
   {
      Node nodeFrom=getOrMake(from);
      Node nodeto=getOrMake(to);
      nodeFrom.addEdge(nodeto, distance);
      nodeto.addEdge(nodeFrom, distance);
   }
}
