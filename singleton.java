package java;

import java.util.ArrayList;

public final class singleton {

	private final static singleton singletonInstance = new singleton();
	private ArrayList<String> list = null;
	
	public static singleton getInstance() {
		return singletonInstance;
	}
	
	private singleton() {
		list = new ArrayList<String>();
	}
        
        public ArrayList<String> getList() {
		return this.list;
	}
	
	public void addToList(String element) {
		list.add(element);
	}
	
	public void removeFromList(int elementIndex) {
		list.remove(elementIndex);
	}

}