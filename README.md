# Informacioni sistem građevinskog preduzeća

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

Zadatak procesa je da prime određene podatke, da ih obrade, zatim proslede dalje. Nekom drugom procesu ili skladištu na čuvanje. U nastavku ćemo dati prikaz opisa procesa sa dijagrama toka podataka drugog nivoa. Opisi su dati u pseudo kodu i cilj im je da prikažu osnovnu logiku rada ovih procesa.

### Naručivanje

![Narucivanje](https://user-images.githubusercontent.com/98473818/152321216-2103a303-8057-490c-9477-e7043963d852.png)

### Prijem

![Prijem](https://user-images.githubusercontent.com/98473818/152321452-729e8700-5122-4594-bb3d-3a95f3ac2940.png)

### Lager

![Lager](https://user-images.githubusercontent.com/98473818/152321739-aa143bbb-1ac5-42e5-a270-d44616ee7bd9.png)

### Kreiranje zahteva

![Kreiranje zahteva](https://user-images.githubusercontent.com/98473818/152322393-6104f038-821b-44b9-b586-3cfc36e5aeb7.png)

### Dodavanje projekta

![Dodavanje projekta](https://user-images.githubusercontent.com/98473818/152322732-9a49bc57-59fd-49f4-97be-e605084cd58c.png)

### Dodavanje radnika

![dODAVANJE  RADNIKA](https://user-images.githubusercontent.com/98473818/152323700-50bacfba-3223-495d-9392-2fe929bd6127.png)

### Upravljanje magacinom

![Upravaljanje magacinom](https://user-images.githubusercontent.com/98473818/152323864-f54bed52-db3b-4294-88be-b659d9809c5f.png)

## Modelovanje
### UML model

![UML](https://user-images.githubusercontent.com/98473818/152324303-24d3b94b-3f44-42d9-901a-201d4a5b0d05.png)

### Dijagram toka interfejsa

Dijagram toka interfejsa služi da na jednom mestu korisniku pokaže koje sve prozore aplikacija poseduje i kako da ih korisnik aktivira. Takođe se na dijagramu može pronaći i uslov za neke prozore kao i greške.

![Dijagram toka interfejsa](https://user-images.githubusercontent.com/98473818/152324692-1aff4f90-01eb-4acc-b7eb-2e6e389ef0d1.png)

## Implementacija

U ovom delu rada bavićemo se implementacijom specifikacije odnosno programiranje same aplikacija. Aplikacije je isprogramirana C# programskim jezikom kao WPF aplikacija. Namenjena je trenutno samo Windows platformi. <br>

Tokom programiranja pored C# korišćene su i dodatne biblioteke. Pa je tako izgled aplikacije urađen u skladu sa MaterialDesigne pravcem, podaci se čuvaju u lokalnoj SQLite bazi podataka. Korisnici se loguju i dodaju preko Google Firebasa a za validaciju svih polja u klasa koristi se Fluent Validation paket. 

### Osnovni prozor aplikacije

Glavni prozor je podeljen u tri segmenta. Zaglavlje u kom se nalazi naslov aplikacije na sredini a sa krajenje desne strane dodatni meni. Drugi segment je navigacija sa leve strane koja u zatvorenom položaju prikazuje ikonice opcija i logo aplikacije. Kada korisnik aktivira burger meni, navigacija se otvara, prikazuju se i nazivi opcija ali i ceo logo. Taj deo aplikacije je animiran. Treći segment zauzima najveću površinu aplikacije. U pitanju je prazan grid koji će se pounjavati user controlama korisnika.

![Osnovni prozor](https://user-images.githubusercontent.com/98473818/152325811-4e2cbee9-f652-4f81-915b-cfc4d5ed57a0.png)

### Prijava

Aplikacija poseduje sistem za prijavljivanje kreiran uz pomoć Google Firebase platforme. Aplikacija je povezana na projekat na Firebase-u i prilikom prijavljivanja ili registracije novog korisnika, podaci se povlače ili šalju na taj projekat. Da bi ste se prijavili u aplikaciju kao admin, potrebno je uneti sledeće podatke:
* Korisničko ime: admin
* Lozinka: admin123

![Login](https://user-images.githubusercontent.com/98473818/152326153-741e1b9b-7106-4777-975f-f5fc91748b3b.png)

Tokom procesa prijave vrši se validacija unetih podataka. Ako je neki od podataka neispravan i ne postoji na serveru, korisnik će biti obavešten o tome.

### Dodavanje projekta

Dodavanje projekta je jedna od osnovnih opcija ove aplikacije. Projekte mogu da dodaju korisnici sa pravom „Admin“ ili „Radnik“. Da bi to učinili potrebno je da iz navigacije izaberu opciju „Projekti“ a zatim da kliknu na taster „Dodaj“.

![Dodavanje projekta 1](https://user-images.githubusercontent.com/98473818/152326544-fb5ca7ad-41cd-4e42-b05e-c78495992a08.png)

Kada uspešno popune sve podatke, korisnik može dodati i dokumente u .pdf ili .docx formatu. Zarad uštede prostora u bazi podataka, dokumenti će se prekopirati u folder „doc“ koji se nalazi u instalacionom folderu aplikacije a u bazu podataka će se upisati referenca na dokumenta. Odnosno putanja do istih.
U sličaju bilo kakve greške, aplikacija će obavestiti korisnika.

### Pregled i brisanje projekta

Pregled i brisanje projekata se vrši veoma intuitivno i praktično. Odabirom opcije „Projekti“ iz burger menija, korisniku će se odmah učitati „data grid“ koji će biti popunjen podacima o raznim projketima. Podaci se povlače iz SQLite baze podataka i automatski dodaju u grid. <br>

Pored svakog projekta nalaze se tasteri za detaljni pregled ili brisanje istog iz baze. 

![Pregled 1](https://user-images.githubusercontent.com/98473818/152327075-486fa659-3701-4a74-b6fe-aea13aa1dfe7.png)

![Pregled 2](https://user-images.githubusercontent.com/98473818/152327126-acbfdf19-2249-46a4-a274-038e205a4dde.png)

### Dodavanje stavki u magacin

Dodavanje stavki u magacin i manipulisanje istim je druga osnovna opcija ove aplikacije. Cilj je da se korisniku omogući pregled robe u magacinu, dodavanje nove ali i raspoređivanje iste na različite projekte tačnije gradilišta.

Da bi korisnik dodao novu stavku u magacin, potrebno je da iz navigacije izabere opciju „Magacin“ i klikne na taster za dodavanje. U tom trenutku mu se otvara novi prozor koji popunjava podacima. 

![Magacin](https://user-images.githubusercontent.com/98473818/152327420-c1b18366-deda-43ad-8046-758b41aa25fc.png)

### Pregled, brisanje i raspodela stavki iz magacina

Pregled i brisanje stavki iz magacina vrši se sličnom logikom kao i za projekte. Kada korisnik na glavnom prozoru iz navigacije izabere opciju za magacin, učitaće mu se data grid sa podacima o svim stavkama u magacinu.

Podaci se povlače iz SQLite baze i prikazuju kao lista. Pored svakog podatka nalaze se tri tastera. Prvi je za brisanje, drugi za izmenu a treći za raspodelu stavke. Raspodela se koristi da bi se određena količina stavki raspodelila na jedno od gradilišta.

![Magacin 1](https://user-images.githubusercontent.com/98473818/152327767-756fee30-eb1a-4c9e-af84-61e2cf584c16.png)

U ovom trenutku vidimo da je drugi deo prozora prazan, odnosno nemamo raspoređenih stavki. Kao primer raspodelićemo jednaku količinu „Metalnih žileta za šalovanje“ na tri različita projekta

![Magacin 2](https://user-images.githubusercontent.com/98473818/152327948-728c68ed-92be-4f6a-85ae-d382b4c1f99e.png)

Kao rezultat vidimo raspoređenu količinu stavki na različita gradilišta a broj dostupnih nam se smanjio na nulu. Kada bi stavku izbrisali iz raspodele, vratili bi je u magacin.

### Izmena stavki iz magacina

Izmena podataka o stavkama u magacinu vrši se sličnom logikom kao i za projekte a kasnije i za radnike. Iz navigacije biram opciju magacin. Zatim biramo koju stavku želimo da izmenimo klikom na taster u data gridu.

![Magacin Izmena stavki](https://user-images.githubusercontent.com/98473818/152328284-ea56582c-9658-406b-8104-b8f57b8e126b.png)


### Dodavanje radnika

Dodavanje radnika je treća ključna opcija ove aplikacije. Rad sa radnicima nam generalno služi da vlasnik preduzeća uvek zna gde mu se koji radnik nalazi, tj na kom gradilištu, kao i da na jednom mestu ima podatke o njemu.

Da bi korisnik dodao radnika potrebno je da na glavnom prozoru u navigaciji izabere treću opciju „Radnici“, zatim da klikne na taster za dodavanje.

![Dodavanje radnika](https://user-images.githubusercontent.com/98473818/152328494-2f6d1b62-de13-4f28-bff3-2f3c69422736.png)

Ovde je važno napomenuti da su polja „Delatnost“ i „Angažovan na“ combo box-evi koji se automatski popunjavaju sa podacima iz baze. Ako za polje „Delatnost“ nedostaje neka, ili je neke potrebno ukloniti, to se može učiti kroz admin panel.

### Pregled i brisanje radnika

Pregled i brisanje radnika se ponovo odvija sličnom logikom kao i za prethodne dve opcije softvera. Kada korisnik iz navigacija izabere opciju za radnika, učitaće mu se data grid koji sadrži listu svih radnika u bazi. Pored svakog radnika nalaze se dva tastera za brisanje ili za izmenu.

![Pregled i brisanje radnika](https://user-images.githubusercontent.com/98473818/152328710-d355500d-741a-4384-bce7-25fac72fac11.png)

### Izmena radnika

Izmena radnika se vrši pritiskom na taster za izmenu određenog radnika. Otvara se prozor sličan kao i za dodavanje, samo što se popunjava već postojećim podacima koje korisnik treba da izmeni.

![Izmena radnika](https://user-images.githubusercontent.com/98473818/152328900-d421875f-0a70-457a-b920-70002acb7277.png)

### Administriranje - Dodavanje korisnika aplikacije

Za svrhu administracije kreiran je admin panel, koji je namenjen korisnicima koji su registrovani kao admini. Ovaj prozor im pruža mogućnost da registruju nove korisnike kao i da dodaju ali i brišu „Delatnosti i tipove“.

Ovaj panel se nalazi u meniju na zaglavlju aplikacije. Aplikacija će javiti grešku ako korisnik koji nema admin prava pokuša da ga aktivira.

![admin](https://user-images.githubusercontent.com/98473818/152329101-0e8401e7-3028-47c9-a560-5a57c2cb2d45.png)

Ova mogućnost da se dodaju novi korisnici realizovana je drugačije od ostalih opcija. Novi korisnici i podaci o njima se ne čuvaju u SQLite bazi, već u RealTime bazi podataka na Firebasu. To znači da su podaci o korisnicima aplikacije uvek dostupni i korisnici se mogu prijaviti sa bilo koje lokacije.

To takođe znači da je potrebno imati pristup internetu kako bi se korisnik prijavio u aplikaciju. Razlog ovakve realizacije dodavanja korisnika kao i prijava u aplikaciju je integracija RealTime baze sa softverima drugog tipa. Na ovaj način je moguće napraviti aplikacije za druge platforme koje će se spajati na jedan te isti projekat na Firebase-u.

### Administriranje - Dodavanje delatnosti i tipa

Pored dodavanja korisnika, admin panel pruža opciju manipulacije sa delatnostima i tipovima. U pitanju su podaci koji se učitavaju u combo-boxeve prilikom dodavanja radnika ili projekata.

![admin 1](https://user-images.githubusercontent.com/98473818/152329561-a8d97274-6317-4d40-8b47-ceebb7d2ff0e.png)

### Profil korisnika

Profil korisnika je opcija koja se nalazi u meniju u zaglavlju aplikacije i namenjena je svim korisnicima aplikacije. Pokretanjem iste korisnik dobija prikaz podataka koji se čuvaju o njemu ali i mogućnost da iste izmeni.

![admin 2](https://user-images.githubusercontent.com/98473818/152329744-997ab7e9-198a-49aa-b2be-afadd182d96b.png)

### Realizacija prečica

Prečice su veoma važan deo svakog softvera. Iskusnim korisnicima istog daju mogućnost da ga još brže i spretnije koriste.Ova aplikacija poseduje isprogramirane prečice. Da bi korisnik video kombinaciju tastera za prečicu, potrebno je da mišem prekrije taster. Data će mu se pored imena samog tastera, prikazati i kombinacija za prečicu.Generalne prečice za potvrđivanje akcije i prekid iste su „Enter“ i „Esc“, a za sve ostale postoji posebna kombinacija. Prečice se isprogramirane preko objekta „RoutedCommand“ klase.

![precice](https://user-images.githubusercontent.com/98473818/152329974-658b9bde-e5f5-407a-9ae7-75be6012c17c.png)

### Odjava

Odjava je poslednja opcija koju pruža ova aplikacija. Nalazi se u meniju u zaglavlju i klikom na istu, korisnik će biti odjavljen. Tada dolazi do restartovanja promenljivih  u aplikaciji, prekid rada sa bazom i odjavljivanje sesija.

Aplikacije se vraća na početni prozor, tačnije na login prozor.



























