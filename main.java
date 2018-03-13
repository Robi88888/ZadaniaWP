package java;

class main {
	static void main(String[] args) {
		singleton.getObject().add("1");
		singleton.getObject().add("2");
		singleton.getObject().add("3");
		System.out.println(singleton.getObject().getList());
		singleton.getObject().remove(0);
		System.out.println(singleton.getObject().getList());
                singleton.getObject().add("4");
                System.out.println(singleton.getObject().getList());  
	}
}