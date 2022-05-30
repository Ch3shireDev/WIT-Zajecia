package pl.wit.lab6;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.PriorityQueue;
import java.util.Queue;
import java.util.Set;
import java.util.SortedSet;
import java.util.TreeSet;

public class MyCollections {
	private List<String> list = null;
	private Queue<String> queue = null;
	private Set<String> set = null;
	private SortedSet<String> sortedSet = null;
	private Collection<String> collection = null;
	
	public MyCollections(String[] items) {
		list = new ArrayList<String>(Arrays.asList(items));
		String[] a=new String[] {};
		list.toArray(a);
		queue = new PriorityQueue<String>(Arrays.asList(items));
		set = new HashSet<String>(Arrays.asList(items));
		sortedSet = new TreeSet<String>(Arrays.asList(items));
		collection = new LinkedHashSet<String>(Arrays.asList(items));
	}
	
	public void iterateWithItAll() {
		Iterator<String> it = list.iterator();
		String item;
		System.out.println("Iterowanie listy:");
		while(it.hasNext()) {
			item=it.next();
			System.out.print(item+",");
		}
		System.out.println("");
		Iterator<String> it2 = queue.iterator();
		System.out.println("Iterowanie kolejki:");
		while(it2.hasNext()) {
			item=it2.next();
			System.out.print(item+",");
		}
		System.out.println("");
		Iterator<String> it3 = set.iterator();
		System.out.println("Iterowanie zbioru:");
		while(it3.hasNext()) {
			item=it3.next();
			System.out.print(item+",");
		}
		System.out.println("");
		Iterator<String> it4 = sortedSet.iterator();
		System.out.println("Iterowanie zbioru sortowanego:");
		while(it4.hasNext()) {
			item=it4.next();
			System.out.print(item+",");
		}
		System.out.println("");
		Iterator<String> it5 = collection.iterator();
		System.out.println("Iterowanie kolekcji:");
		while(it5.hasNext()) {
			item=it5.next();
			System.out.print(item+",");
		}
	}
	
	public void iterateWithForEach() {
		
		System.out.println("Iterowanie listy:");
		for(String item:list)
			System.out.print(item+",");
		System.out.println("");
		System.out.println("Iterowanie kolejki:");
		for(String item:queue)
			System.out.print(item+",");
		System.out.println("");
		System.out.println("Iterowanie zbioru:");
		for(String item:set)
			System.out.print(item+",");
		System.out.println("");
		System.out.println("Iterowanie zbioru sortowanego:");
		for(String item:sortedSet)
			System.out.print(item+",");
		System.out.println("");
		System.out.println("Iterowanie kolekcji:");
		for(String item:collection)
			System.out.print(item+",");
	}
}
