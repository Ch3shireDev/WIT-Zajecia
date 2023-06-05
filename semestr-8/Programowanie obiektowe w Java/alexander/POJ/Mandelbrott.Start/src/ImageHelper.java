
import java.awt.image.BufferedImage;

public class ImageHelper
{
   public static BufferedImage toImage(int[][][] clr)
   {
      int Height=clr.length;
      int Width=(Height>0?clr[0].length:0);
      int[] buff=new int[Width*Height*3];
      for(int h=0,p=0;h<Height;++h)
      {
         for(int w=0;w<Width;++w)
         {
            for(int i=0;i<3;++i) buff[p++]=clr[h][w][i];
         }
      }
      BufferedImage img=new BufferedImage(Width, Height, BufferedImage.TYPE_3BYTE_BGR);
      img.getRaster().setPixels(0,0,Width,Height,buff);
      return img;
   }
}
