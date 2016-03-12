# ethereal

## Članovi tima:

1. Medina Mališević
2. Ena Muratspahić
3. Emina Omanović
4. Anja Miletić

##### Opis teme

Sistem za online kupovinu karata i rezervacije slobodnih mjesta ili čitavih sala, uz mogućnosti plaćanja karticom ili gotovinom na licu mjesta. Provjera se vrši pomoću jedinstvenog koda koji se pri rezervaciji šalje na korisnikov mail. Bit će implementirana i zaštita od zlonamjernih korisnika. U cilju promovisanja filmske industrije i umjetnika u usponu, korisnicima se nudi mogućnost pregledanja detaljnog opisa svakog filma u ponudi, a također je moguće i naručivanje filma. U slučaju dovoljne potražnje, film se stavlja u ponudu.
		
Sistem omogućava uštedu vremena i pomaže korisniku u izboru usluga. Korisnik nije ograničen radnim vremenom multipleksa. Prednost je i obavještavanje korisnika o novim filmovima i popustima putem maila koji unesu pri rezervaciji.

Sistem je prihvatljiv na tržištu jer je jednostavan za korištenje korisnicima različitih profila, uvijek je dostupan, pouzdan i brz. 

##### Procesi

Glavni proces je postupak **rezervacija** karata ili sala. 

*Fizičko lice*
Korisnik prvo bira film sa repertoara, te ima mogućnost da pregleda detalje o filmu (trailer, kritike, synopsis). Zatim korisnik bira salu i mjesta. Na kraju korisnik unosi lične podatke (ime, prezime, broj telefona i e-mail adresu) pri čemu su sva polja su obavezna te bira način plaćanja. Korisniku se nakon verifikacije izdaje jedinstveni kod koji on koristi da bi preuzeo karte.  

*Pravno lice*
Korisnik prvo bira salu, zatim se izjašnjava da li želi projekciju vlastitog filma ili nekog filma u ponudi multiplexa. Nakon toga unosi podatke o pravnom licu i podatke odgovorne osobe te prelazi na sljedeći korak, plaćanje, gdje ima mogućnost da plati 50% ukupne cijene ili cijeli iznos unaprijed. Plaćanje se vrši preko transakcijskog računa pravnog lica.

Kroz proces **verifikacije** se korisniku daje potvrda rezervacije. Na korisnikov mail se šalje link koji korisnika obavještava o uspješnoj verifikaciji. Nakon toga se korisniku šalje mail sa jedinstvenim kodom za preuzimanje karata.

Repertoar multiplexa se **ažurira** svakih sedam dana. 

Podaci za detaljni **pregled informacija o filmovima** se preuzimaju sa imdb.com. Bit će onemogućena rezervacija za period u kojem nije sigurno da će se odabrani film prikazivati.

##### Funkcionalnosti

- mogućnost rezervacije karata i sala
- mogućnost odabira mjesta u sali
- mogućnost odabira filma
- mogućnost projekcije vlastitog filma
- pregled informacija o filmovima
- mogućnost plaćanja karticom ili gotovinom
- mogućnost otkazivanja rezervacije korištenjem jedinstvenog koda
- zabrana korištenja aplikacije zlonamjernim korisnicima (hellban)
- korištenje mail servisa za potvrdu rezervacije i slanje jedinstvenog koda
- praćenje rezervacija za svakog korisnika u bazi podataka (jer nema korisničkih naloga

##### Akteri

1. Korisnik usluga (fizičko lice, pravno lice) je osoba koja ima mogućnost rezervacije karata ili sala i odabira filma.
2. Uposlenik je osoba radi za multiplex koja izdaje karte. U slučaju da se radi o fizičkom licu provjerava ispravnost koda i ako je ispravan izdaje karte. Ako se radi o pravnom licu, tada pravno lice daje svoju ličnu kartu i ako je potrebno vrši doplatu rezervacije te mu se izdaje dozvola za korištenje sale.
3. Menadžer je osoba koja ažurira repertoar i bazu podataka.




