package java;
import java.util.ArrayList;

final class singleton {

	private final static singleton singletonInstance = new singleton();
	private ArrayList<String> list = null;
	
	static singleton getInstance() {
		return singletonInstance;
	}

        void add(String element) {
		list.add(element);
	}
	
	void remove(int elementIndex) {
		list.remove(elementIndex);
	}
        
        ArrayList<String> getList() {
		return this.list;
	}
        
	private singleton() {
		list = new ArrayList<String>();
	}    
}