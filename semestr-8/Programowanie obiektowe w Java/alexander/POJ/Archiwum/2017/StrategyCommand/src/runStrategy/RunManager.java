package runStrategy;


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
public class RunManager {
   
   private static final HashMap<String, RunMaker> map = makeMap(); 
   
   private static HashMap<String, RunMaker> makeMap() {
      HashMap<String, RunMaker> map = new HashMap<>();
      map.put("Sprint", () -> {
         return new Sprint();
      });
      map.put("Długi dystans", () -> {
         return new LongDistance();
      });
      return map;
   }
   
   public static Set<String> keys() {
      return map.keySet();
   }
   
   public static IRun make(String key) {
      return map.get(key).make();
   }
}
