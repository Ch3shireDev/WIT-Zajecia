package pl.wit.lab6;

import java.util.ArrayList;
import java.util.Collection;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.Set;
import java.util.TreeSet;

public class CollectionsTutorial {
	private Collection<String> collection = null;
	
	public CollectionsTutorial() {
		this.collection = new ArrayList<String>();
		
		for(int i=0;i<100000;i++) {
			collection.add("item_"+((i+1)%10000));
		}
	}
	
	public Set<String> getSet(){
		return null;
	}
	
	public List<String> getOnlyEvenItems(){
		return null;
	}
	
	public LinkedHashSet<String> getSetWithOrder(){
		return null;
	}
	
	public TreeSet<String> getEvery3ElementAsSortedSet(){
		return null;
	}
}
