public class IGraphHuman implements IGraphReprezentation
{
   @Override public String convert(Graph graph)
   {
      StringBuilder sb=new StringBuilder();
      for(String name: graph.getNodes().keySet())
      {
         Node node=graph.getNodes().get(name);
         sb.append(name).append(System.lineSeparator());
         for(Edge edge:node.getEdges())
         {
             sb.append(String.format("\t%s => %f", edge.getNodeTo().getName(),edge.getDistance()));
             sb.append(System.lineSeparator());
         }
      }
      return sb.toString();
   }
}