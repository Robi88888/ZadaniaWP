public class main {

	public static void main(String[] args) {
		
		singleton.getInstance().addToList("1");
		singleton.getInstance().addToList("2");
		singleton.getInstance().addToList("3");
		singleton.getInstance().addToList("4");
		System.out.println(singleton.getInstance().getList());
		singleton.getInstance().removeFromList(0);
		System.out.println(singleton.getInstance().getList());
		
	}

}
