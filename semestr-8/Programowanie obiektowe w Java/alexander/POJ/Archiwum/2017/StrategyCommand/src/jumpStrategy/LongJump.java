/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jumpStrategy;

/**
 *
 * @author alex
 */
public class LongJump implements IJump {

   @Override
   public String jump() {
      return "Skaczę w dal";
   }

   @Override
   public String toString() {
      return "W dal";
   }

}
