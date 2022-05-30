package pl.wit.lab6;

import java.util.HashMap;
import java.util.Map;

public class CounterMultiThread {
	//Mapa globalna prechowuje nr katalogu i aktualną liczbę plików wewnątrz
	public static Map<Integer,Integer> mapFolders =new HashMap<Integer,Integer>();
	//Numer folderu
	protected int folderNo;
	//Folder główny od którego startuje program
	private String mainFolder;
	
	public CounterMultiThread(String mainFolder,int folderNo) {
		this.folderNo=folderNo;
		this.mainFolder = mainFolder;
	}
	
}
