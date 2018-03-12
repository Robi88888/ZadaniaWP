#include <iostream>;
#include <string>;
using namespace std;


// Standardowa gra
class Gra {
	protected:
		string gra;
		double koszt;

public:
	Gra() {
		gra = "Wersja podstawowa";
		koszt = 0;
	}

	virtual string about() {
		return gra;
	}
};

//dekorator
class Dekorator : public Gra {

	public:
		virtual string about() {
			return "Main Level";
		}
};

//przyk³adowe gry
class RPG : public Gra {

	public:
		RPG() :Gra() {
			Gra = "RPG";
			koszt = 149;
		}
};

class FPS : public Gra {

public:
	FPS() :Gra() {
		Gra = "FPS";
		koszt = 189;
	}
};

int main() {

}