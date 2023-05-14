/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package builderproject;

/**
 *
 * @author cheshire
 */
public class IdBuilderMain {
    
    public static void main(String args[]){
        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {

                IdBuilder model = new IdBuilder();
                IdBuilderView view = new IdBuilderView();
                
                IdBuilderController controller = new IdBuilderController(model, view);
                controller.centerView();
                controller.showView();
            }
        });
    }
    
}
