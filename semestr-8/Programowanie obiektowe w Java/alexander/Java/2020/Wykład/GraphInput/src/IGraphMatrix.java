public class IGraphMatrix implements IGraphReprezentation
{
   @Override public String convert(Graph graph)
   {
      StringBuilder sb=new StringBuilder();
      for(String name: graph.getNodes().keySet())
      {
         sb.append(name).append(System.lineSeparator());
      }
      sb.append("===").append(System.lineSeparator());
      for(String rname: graph.getNodes().keySet())
      {
         boolean first=true;
         for(String cname: graph.getNodes().keySet())
         {
            boolean found=false;
            for(Edge edge:graph.getNodes().get(rname).getEdges())
            {
               if(edge.getNodeTo().getName().equals(cname))
               {
                  if(first) first=false;
                  else sb.append("\t");
                  sb.append(String.format("%f", edge.getDistance()));
                  found=true;
                  break;
               }
            }
            if(!found)
            {
               if(first) first=false;
               else sb.append("\t");
               sb.append("@");
            }
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }
}