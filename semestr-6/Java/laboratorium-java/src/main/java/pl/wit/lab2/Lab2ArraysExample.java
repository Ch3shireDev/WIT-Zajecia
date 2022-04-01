package pl.wit.lab2;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;

import java.util.Arrays;
import java.util.stream.Collectors;
import java.util.stream.Stream;


/**
 * Przykładowa klasa implementująca operacje na tablicach.
 */
public class Lab2ArraysExample {

    protected static final Logger log = LogManager.getLogger(Lab2ArraysExample.class.getName());
    private int intNumbers[] = null;
    private String stringElements[];
    private Boolean boolElements[];


    /**
     * Domyślny konstruktor.
     */
    private Lab2ArraysExample() {
        intNumbers = new int[0];
        stringElements = new String[0];
        boolElements = new Boolean[0];
    }


    /**
     * Konstruktor tworzący tablicę z jedną wartością typu int.
     * @param intValue
     */
    public Lab2ArraysExample(int intValue) {
        this();
        intNumbers = Arrays.copyOf(intNumbers, 1);
        intNumbers[0] = intValue;
    }

    /**
     * Konstruktor tworzący tablicę z jedną wartością typu bool.
     * @param boolValue
     */
    public Lab2ArraysExample(boolean boolValue) {
        this();
        boolElements = Arrays.copyOf(boolElements, 1);
        boolElements[0] = boolValue;
    }


    /**
     * Konstruktor tworzący tablicę z jedną wartością typu string.
     * @param stringValue
     */
    public Lab2ArraysExample(String stringValue) {
        this();
        stringElements = Arrays.copyOf(stringElements, 1);
        stringElements[0] = stringValue;
    }



    public int[] getIntNumbers() {
        return intNumbers;
    }

    public void setIntNumbers(int[] intNumbers) {
        this.intNumbers = intNumbers;
    }

    public String[] getStringElements() {
        return stringElements;
    }

    public void setStringElements(String[] stringElements) {
        this.stringElements = stringElements;
    }

    public Boolean[] getBoolElements() {
        return boolElements;
    }

    public void setBoolElements(Boolean[] boolElements) {
        this.boolElements = boolElements;
    }


    /**
     * Drukuje zawartość wszystkich tablic do logów. Pomija tablicę jeśli ma wartość null.
     */
    public void printArraysToLog() {
        if (intNumbers != null)
            log.info(Stream.of(intNumbers).map(String::valueOf).collect(Collectors.joining(", ")));
        if (stringElements != null)
            log.info(Stream.of(stringElements).map(String::valueOf).collect(Collectors.joining(", ")));
        if (boolElements != null)
            log.info(Stream.of(boolElements).map(String::valueOf).collect(Collectors.joining(", ")));

    }

    /**
     * Dodaje element typu int do tablicy.
     * @param element
     */
    public void addElement(int element) {
        intNumbers = Arrays.copyOf(intNumbers, intNumbers.length + 1);
        intNumbers[intNumbers.length - 1] = element;
    }

    /**
     * Dodaje element typu String do tablicy.
     * @param element
     */
    public void addElement(String element) {
        stringElements = Arrays.copyOf(stringElements, stringElements.length + 1);
        stringElements[stringElements.length - 1] = element;
    }


    /**
     * Dodaje element typu boolean do tablicy.
     * @param element
     */
    public void addElement(boolean element) {
        boolElements = Arrays.copyOf(boolElements, boolElements.length + 1);
        boolElements[boolElements.length - 1] = element;
    }

    /**
     * Zwraca rozmiar tablicy int.
     * @return
     */
    int getIntArraySize(){
        if(intNumbers==null)return -1;
        return intNumbers.length;
    }

    /**
     * Zwraca rozmiar tablicy string.
     * @return
     */
    int getStringArraySize(){
        if(stringElements==null)return -1;
        return stringElements.length;
    }


    /**
     * Zwraca rozmiar tablicy boolean.
     * @return
     */
     int getBooleanArraySize(){
        if(boolElements==null)return -1;
        return boolElements.length;
    }


    /**
     * Zwraca wartość typu int o podanym indeksie, lub -1 jeśli wykroczyliśmy poza zakres.
     * @param index
     * @return
     */
    public int getIntArrayElement(int index){
        if (intNumbers != null && index < intNumbers.length && index >= 0) {
            return intNumbers[index];
        }
        else {
            return -1;
        }
    }
    /**
     * Zwraca wartość typu string o podanym indeksie, lub pusty string jeśli wykroczyliśmy poza zakres.
     * @param index
     * @return
     */
    public String getStringArrayElement(int index){
        if (stringElements != null && index < stringElements.length && index >= 0) {
            return stringElements[index];
        }
        else {
            return "";
        }
    }


    /**
     * Zwraca wartość typu boolean o podanym indeksie, lub fałsz jeśli wykroczyliśmy poza zakres.
     * @param index
     * @return
     */
    public boolean getBooleanArrayElement(int index){
        if (boolElements != null && index < boolElements.length && index >= 0) {
            return boolElements[index];
        }
        else {
            return false;
        }
    }

}
