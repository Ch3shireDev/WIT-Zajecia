package jumpStrategy;


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
public class JumpManager {
   
   private static final HashMap<String, JumpMaker> map = makeMap(); 
   
   private static HashMap<String, JumpMaker> makeMap() {
      HashMap<String, JumpMaker> map = new HashMap<>();
      map.put("Wzwyż", () -> {
         return new HighJump();
      });
      map.put("W dal", () -> {
         return new LongJump();
      });
      map.put("O tyczce", () -> {
         return new PoleVault();
      });
      return map;
   }
   
   public static Set<String> keys() {
      return map.keySet();
   }
   
   public static IJump make(String key) {
      return map.get(key).make();
   }
}
