package astar;

import java.awt.Color;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.TreeMap;

public class AstarPath
{
   public static final int White=new Color(255,255,255).getRGB();
   public static final int Blue=new Color(200,200,255).getRGB();
   public static final int Black=new Color(0,0,0).getRGB();
   public static final int Green=new Color(0,125,0).getRGB();
   public static final int Red=new Color(255,0,0).getRGB();
   public static final int Gray=new Color(100,100,100).getRGB();
   public static final int Violet=new Color(163,73,164).getRGB();
   public static final int Teal=new Color(73,163,164).getRGB();
   private final HashMap<Long,Node> path=new HashMap<>();
   private final TreeMap<Long,ArrayList<Node>> visited=new TreeMap<>();
   private final Node start=new Node(-1),finish=new Node(-1);
   private long fx,fy;

   private int[][] clr;
   public AstarPath(int[][] clr)
   {
      this.clr=clr;
   }
   public void preparePath()
   {
      for(int h=0;h<clr.length;++h)
      {
         for(int w=0;w<clr[h].length;++w)
         {
            Node node=null;
            if(clr[h][w]==AstarPath.Black) node=new Node(toidx(w,h));
            else if(clr[h][w]==AstarPath.Violet)
            {
               start.idx=toidx(w,h);
               node=start;
               node.distance=0;
               ArrayList<Node> lst=new ArrayList<>();
               lst.add(node);
               visited.put(0L,lst);
            }
            else if(clr[h][w]==AstarPath.Red)
            {
               fx=w;
               fy=h;
               finish.idx=toidx(w,h);
               node=finish;
            }
            else continue;
            path.put(node.idx,node);
         }
      }
   }
   public void check(Node from,long idx)
   {
      Node node=path.get(idx);
      if(node==null) return;
      long newdistance=from.distance+1;
      long oldfun=node.distance+tomanchatan(node.idx);
      long newfun=newdistance+tomanchatan(node.idx);
      if(newfun<oldfun)
      {
         node.distance=newdistance;
         node.from=from;
         ArrayList<Node> lst=visited.get(oldfun);
         if(lst!=null) lst.remove(node);
         lst=visited.get(newfun);
         if(lst==null) visited.put(newfun,lst=new ArrayList<>());
         lst.add(node);
      }
   }
   public void calc()
   {
      while(visited.size()>0)
      {
         long minvalue=visited.firstKey();
         ArrayList<Node> lst=visited.get(minvalue);
         visited.remove(minvalue);
         for(Node node:lst)
         {
            if(node.distance<finish.distance)
            {
               check(node,node.idx+1);
               check(node,node.idx-1);
               check(node,node.idx+clr.length);
               check(node,node.idx-clr.length);
               check(node,node.idx+clr.length+1);
               check(node,node.idx-clr.length+1);
               check(node,node.idx+clr.length-1);
               check(node,node.idx-clr.length-1);
            }
         }
      }
   }
   public void colorize()
   {
      Node curr=finish;
      while(curr!=null)
      {
         if((curr!=start)&&(curr!=finish))
         {
            int x=tox(curr.idx),y=toy(curr.idx);
            clr[y][x]=AstarPath.Red;
         }
         curr=curr.from;
      }
   }
   public void run()
   {
      preparePath();
      calc();
      colorize();
   }
   private long toidx(long x,long y) { return x*clr.length+y; }
   private int tox(long idx) { return (int)(idx/clr.length); }
   private int toy(long idx) { return (int)(idx%clr.length); }
   private long tomanchatan(long idx)
   {
      return Math.abs(tox(idx)-fx)+Math.abs(toy(idx)-fy);
   }
}

class Node
{
   public long idx,distance;
   public Node from;
   public Node(long idx)
   {
      this.idx=idx;
      distance=1L<<62;
      from=null;
   }
}