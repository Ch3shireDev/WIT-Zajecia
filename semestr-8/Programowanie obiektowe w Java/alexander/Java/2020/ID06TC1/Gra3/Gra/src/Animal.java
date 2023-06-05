import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.OutputStream;
import java.util.logging.Level;
import java.util.logging.Logger;
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author bylina
 */
public class Animal {
    private String text;
    private Animal[] answers = null;
    public Animal(String text){
        this.text = text;
    }
    public String getText() {
        return text;
    }
    public String getQuestion(){
        /*if(answers == null){
            return text + "?";
        }
        else{
            return "Czy to jest" + text + "?";
        }*/
        return (answers != null ? "Czy to jest " : "") + text + "?";
    }
    public boolean isQuestion(){
        return answers != null;
    }
    public Animal[] getAnswers() {
        return answers;
    }
    
    public void ReplaceWithQuestion(String question, String newAnimal, boolean yesno){
        String oldAnimal = text;
        text = question;
        if(yesno){
            answers = new Animal[]{new Animal(newAnimal),new Animal(oldAnimal)};
        }
        else{
            answers = new Animal[]{new Animal(oldAnimal),new Animal(newAnimal)};
        }
    }
    
    public void SaveToFile(String Filename){
        try {
            ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream(new File (Filename)));
            SaveToStream (out);
        } catch (Exception ex) {
        }
    }
    public void LoadFromFile(String Filename){
        try {
            ObjectInputStream out = new ObjectInputStream(new FileInputStream(new File (Filename)));
            LoadFromStream (out);
        } catch (Exception ex) {
            text = "Kot";
        }
    }
    private void SaveToStream(ObjectOutputStream out) {
        try {
            out.writeObject(text);
            boolean haveanswers = (answers != null);
            out.writeBoolean(haveanswers);
            if(haveanswers){
                for (int i=0; i < answers.length; i++){
                    answers[i].SaveToStream(out);
                }
            }
        } catch (Exception ex) {
        }
    }
    private void LoadFromStream(ObjectInputStream input) {
        try {
            text = (String)input.readObject();
            boolean haveanswers = input.readBoolean();
            if(haveanswers){
                answers = new Animal[2];
                for (int i=0; i < answers.length; i++){
                    answers[i].LoadFromStream(input);
                }
            }
        } catch (Exception ex) {
        }
    }
    
}