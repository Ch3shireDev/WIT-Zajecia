public class Edge
{
   private Node nodeTo;
   private double distance;

   public Edge(Node nodeTo, double distance)
   {
      this.nodeTo = nodeTo;
      this.distance = distance;
   }
   public Node getNodeTo() { return nodeTo; }
   public double getDistance() { return distance; }
}
