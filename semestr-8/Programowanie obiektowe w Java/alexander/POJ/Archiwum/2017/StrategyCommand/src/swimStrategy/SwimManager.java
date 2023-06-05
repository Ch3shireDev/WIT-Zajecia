package swimStrategy;

import runStrategy.*;
import jumpStrategy.*;
import java.util.HashMap;
import java.util.Set;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author alex
 */
public class SwimManager {
   
   private static final HashMap<String, SwimMaker> map = makeMap(); 
   
   private static HashMap<String, SwimMaker> makeMap() {
      HashMap<String, SwimMaker> map = new HashMap<>();
      map.put("Grzbiet", () -> {
         return new Backstroke();
      });
      map.put("Motyl", () -> {
         return new Butterfly();
      });
      map.put("Kraul", () -> {
         return new FrontCrawl();
      });
      return map;
   }
   
   public static Set<String> keys() {
      return map.keySet();
   }
   
   public static ISwim make(String key) {
      return map.get(key).make();
   }
}
