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

class Dekorator : public Gra {

	public:
		virtual string about() {
			return "Main Level";
		}
};


int main() {

}