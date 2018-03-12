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

	virtual double cena() {
		return koszt;
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
		gra = "RPG ";
		koszt = 149;
	}
};

class FPS : public Gra {

public:
	FPS() :Gra() {
		gra = "FPS ";
		koszt = 189;
	}
};

//DLC do gry
class ExtraLevel : public Dekorator {
	Gra *game;

public: ExtraLevel(Gra *gra) :Dekorator() {
	game = gra;
}

		string about() {
			return game->about() + " Dodatkowa mapa!";
	}

		double cena() {
			return game->cena() + 20;
		}
};

class ExtraWeapon : public Dekorator {
	Gra *game;

public: ExtraWeapon(Gra *gra) :Dekorator() {
	game = gra;
}

		string about() {
			return game->about() + " Dodatkowa broñ!";
		}

		double cena() {
			return game->cena() + 10;
		}
};

int main() {

	Gra *g1 = new RPG();
	Gra *g2 = new FPS();

	cout << g1->about() << " " << g1->cena() << endl;
	cout << g2->about() << " " << g2->cena() << endl;

	g1 = new ExtraLevel(g1);
	g2 = new ExtraLevel(g2);

	g2 = new ExtraWeapon(g2);

	cout << g1->about() << " " << g1->cena() << endl;
	cout << g2->about() << " " << g2->cena() << endl;

}