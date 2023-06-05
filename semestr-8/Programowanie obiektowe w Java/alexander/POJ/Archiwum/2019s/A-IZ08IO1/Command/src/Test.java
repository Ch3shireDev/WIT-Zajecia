
import java.util.ArrayList;

public class Test
{
   public static void main()
   {
      String[][] src = new String[][]
      {
         new String[] { "A", "B", "C", },
         new String[] { "D", "E", "F", "G", },
      };
      int count=0;
      for(int i=0;i<src.length;++i) count+=src[i].length;
      String[] dst1=new String[count];
      for(int i=0,p=0;i<src.length;++i) for(int k=0;k<src[i].length;++k,++p) dst1[p]=src[i][k];

      ArrayList<String> tmp=new ArrayList<>();
      String[] dst2=new String[tmp.size()];
      tmp.toArray(dst2);


   }
}
