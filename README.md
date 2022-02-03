# IS-Gradjevinskog-preduzeca

U ovom radu se nalaze sve potrebne informacije za razumevanje informacionog sistema gradjevinskog preduzeća. U te informacije se ubrajaju potrebni dijagrami, opisi procesa, tokovi podataka kao i praktična realizacija. 

## Dijagrami tokova podataka
### Kontekst dijagram

Na kontekst dijagramu (dijagram nultog nivoa) vidi se interakcija informacionog sistem sa spoljnim entitetima, kao i nazivi tokova podataka koji se ovde razmenjuju.

![Kontekst dijagram](https://user-images.githubusercontent.com/98473818/152313650-99eea497-57de-4b20-bdda-98df48374650.png)

### Dijagram toka prvi nivo

Dijagram toka prvog nivoa predstavlja prvi korak u razlaganju informacionog sistema na njegove procese. Na ovom dijagramu se vide ključni procesi u sistemu.

![Dijagram toka Prvi nivo](https://user-images.githubusercontent.com/98473818/152314509-bd8fa555-cca7-4ef2-91f8-8b76acb52842.png)

### Dijagram toka drugi nivo - Nabavka

Ovaj proces se u sistemu bavi nabavkom svih potrebnih materijala i alata za rad. Komunicira sa dobavljačima kao i sa tehničkom službom kako bi poručene elemente sačuvao u magacinu.

![Dijagram toka Drugi nivo Nabavka](https://user-images.githubusercontent.com/98473818/152318885-7c0cb1de-7387-457f-93f5-76d9bb2ce4cf.png)

#### Rečnik podataka

<strong>  Prema „Dobavljac“ </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Zahtev za nabavku: <Kolicina, Naziv robe, Tip robe> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Katalog proizvoda: <{<ID robe, Naziv robe, Tip robe, Karakteristike, Proizvodjac, Cena>}> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Narudzbenica: <Podaci firme, Podaci dobavljaca, Broj narudzbenice, Datum, Mesto isporuke,{<Naziv robe,Tip robe, Kolicina>}> <br>
* Podaci firme: < Naziv firme, Adresa firme, PIB firme, Maticni broj firme,Telefon firme, e-mail firme, Racun firme> <br>
* Podaci dobavljaca: < Naziv dobavljaca, Adresa dobavljaca, PIB dobavljaca, Maticni broj dobavljaca, Telefon dobavljaca, e-mail dobavljaca, Racun dobavljaca> <br>
Otprmenica i faktura:
* Faktura: <Broj Fakture, Podaci firme, Podaci dobavljaca, Datum fakturisanja, {<Redni broj, Naziv robe, Tip robe, Kolicina, Cena>},Iznos fakutre>
* Otprmenica: <Broj Otprmenice,Podaci firme, Mesto iskoruke, Datum isporuke, {< Redni broj, Naziv robe, Tip robe, Kolicina >}>
Uplata:<Podaci firme, Svrha uplate, Podaci dobavljca, Iznos, Racun dobavljaca, Odobrenje, Datum uplate>

<strong> Između procesa </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Zahtev za nabavku: <Kolicina, Naziv robe, Tip robe> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Obavestenje o prispecu: <Kolicina, Naziv robe, Tip robe, Status prispeca> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Signalizacija greske: <Broj otprmenice, Naziv robe, Opis greske> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Lagerovanje: <Mesto lagera, Naziv robe, Kolicina> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Obavestnje o lageru: < Mesto lagera, Naziv robe, Kolicina , Status lagera> <br>

<strong> Prema skladištima </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Zahtev za sredstima: <Broj zahteva, Opis zahteva, Broj fakutre, Kolcina sredstava> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Sredstva za placanje: <Broj zahteva, Status zahteva> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Faktura: < Broj Fakture, Podaci firme, Podaci dobavljaca, Datum fakturisanja, {<Redni broj, Naziv robe, Tip robe, Kolicina, Cena>},Iznos fakutre > <br>

<strong> Skladišta </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Zahtev za sredstima: <Broj zahteva, Opis zahteva, Broj fakutre, Kolcina sredstava> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Sredstva za placanje: <Broj zahteva, Status zahteva> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Faktura: < Broj Fakture, Podaci firme, Podaci dobavljaca, Datum fakturisanja, {<Redni broj, Naziv robe, Tip robe, Kolicina, Cena>},Iznos fakutre > <br>


### Dijagram toka drugi nivo - Tehnička služba

Zadatak ovog procesa je da, odnosno tehničara kao čoveka koji upravlja njime, odnosno korisnika krajnjeg softvera, jeste da: <br>

* Dodaje nove projekte u softver (Komunicira sa entitetom „Investitor“) <br>
* Dodaje nove radnike u softver kao da iste raspoređuje po projektima <br>
* Upravlja radom magacina <br>

![Dijagram toka Drugi nivo](https://user-images.githubusercontent.com/98473818/152315881-e2ef64d9-4cd4-4ab4-bad5-10310ae6912e.png)

#### Rečnik podataka

<strong> Prema „Investitor“ </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Ponuda: <Naziv projekta, Lokacija, Tip, Rok, Suma> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Ugovor: <Naziv projekta, Lokacija, Tip, Rok, Suma, Podaci firme, Podaci investitora, Mib, Žiro računi, Datum, Potpisnici> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Glavni projekt: <Naziv projekta, Lokacija, Tip, Rok, Spratnost, Investitor, Suma, Datum, Dokumenta> <br>

<strong> Prema „Projektni biro“ </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Zahtev za dozvolom: <Naziv projekta, Lokacija, Tip, Dokumenta o vlasniku, Datum, Potvrde o uplati> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Dokumentacija: <Dozvola, Projekat, Datum> <br>

<strong> Prema skladištu „Dokumentacija“ </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Neimenovani tok: upisuju se i čitaju svi podaci u ovom skladištu <br>
&nbsp;&nbsp;&nbsp;&nbsp; Ugovor u zaposlenju: <Ime prezime radnika, Adresa, JMBG, Broj telefona, Delatnost> <br>

<strong> Prema skladištu „Radnici“ </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Neimenovani tok: upisuju se i čitaju svi podaci u ovom skladištu <br>

<strong> Prema skladištu „Projketi“ </strong> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Podaci o projektu: <Naziv projekta, Lokacija> <br>
&nbsp;&nbsp;&nbsp;&nbsp; Neimenovani tok: upisuju se i čitaju svi podaci u ovom skladištu <br>

## Tabela polja

Tabela polja predstavlja jedinstvenu tabelu koja u sebi sadrži nazive svih podataka u rečniku ali i njihov tip. Taj tip se koristi kasnije u razvoju softvera kao definicija tipa promenljive za taj podatak.

![Tabela polja](https://user-images.githubusercontent.com/98473818/152317864-02276827-5cdb-4159-96a1-237523e15b82.png)

## Opisi procesa

Zadatak procesa je da prime određene podatke, da ih obrade, zatim proslede dalje. Nekom drugom procesu ili skladištu na čuvanje.








