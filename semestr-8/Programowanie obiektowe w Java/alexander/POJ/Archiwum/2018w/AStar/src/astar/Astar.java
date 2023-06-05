package astar;

import java.awt.Color;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class Astar
{
   public static int[][] read(String filename)
   {
      try
      {
         // Odczyt pliku
         BufferedImage img=ImageIO.read(new File(filename));
         int Height=img.getHeight();
         int Width=img.getWidth();

         // Pobranie danych rastrowych
         int[] buff=new int[Width*Height*4];
         img.getRaster().getPixels(0,0,Width,Height,buff);

         // Przetworzenie na tablice kolorów
         int[][] clr=new int[Height][Width];
         for(int h=0,p=0;h<Height;++h)
         {
            for(int w=0;w<Width;++w)
            {
               int r=buff[p++];
               int g=buff[p++];
               int b=buff[p++];
               ++p;
               clr[h][w]=new Color(r,g,b).getRGB();
            }
         }
         return clr;
      }
      catch (IOException e)
      {
         System.out.println(e.toString());
         return null;
      }
   }

   public static void write(int[][] clr,String filename)
   {
      try
      {
         int Height=clr.length;
         int Width=Height>0?clr[0].length:0;
         int[] buff=new int[Width*Height*4];
         // Przetworzenie na dane rastrowe
         for(int h=0,p=0;h<Height;++h)
         {
            for(int w=0;w<Width;++w)
            {
               Color c=new Color(clr[h][w]);
               buff[p++]=c.getRed();
               buff[p++]=c.getGreen();
               buff[p++]=c.getBlue();
               buff[p++]=255;
            }
         }

         final BufferedImage img=new BufferedImage(Width,Height,BufferedImage.TYPE_INT_ARGB);
         // Zapisane danych rastrowych
         img.getRaster().setPixels(0,0,Width,Height,buff);

         // Zapis pliku
         ImageIO.write(img,"png",new File(filename));
      }
      catch (IOException e)
      {
         System.out.println(e.toString());
      }
   }

   public static void changecolors(int[][] clr)
   {
      // Podmiana kolorów
      for(int h=0;h<clr.length;++h)
      {
         for(int w=0;w<clr[h].length;++w)
         {
            if(clr[h][w]==AstarPath.White) clr[h][w]=AstarPath.Blue;
            else if(clr[h][w]==AstarPath.Black) clr[h][w]=AstarPath.Green;
            else if(clr[h][w]==AstarPath.Red) clr[h][w]=AstarPath.Gray;
            else if(clr[h][w]==AstarPath.Violet) clr[h][w]=AstarPath.Teal;
         }
      }
   }

   public static void main(String[] args)
   {
      // https://pl.wikipedia.org/wiki/Algorytm_A*
      int[][] clr=read("P:\\Barski\\POJ\\2018_z\\AStar\\50x50maze.png");
      final AstarPath ap=new AstarPath(clr);
      ap.run();
      //changecolors(clr);
      write(clr,"P:\\Barski\\POJ\\2018_z\\AStar\\50x50maze-new.png");
   }
}
