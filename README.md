# Softver za dječji vrtić


## Projektni tim

Ime i prezime | E-mail adresa (FOI) |    JMBAG   | Github korisničko ime
------------  | ------------------- | ---------- | ---------------------
Kaja Bobek    | kbobek22@foi.hr     | 0016162684 | kbobek22
Lana Golubić  | lgolubic22@foi.hr   | 0016160723 | LANAG7
Vili Horvat   | vhorvat22@foi.hr    | 0016160905 | vhorvat22

## Opis domene
Problemska domena ovog projekta obuhvaća upravljanje administrativnim i operativnim procesima u malom, privatnom dječjem vrtiću. Vrtić trenutno koristi papirnatu dokumentaciju i Excel tablice za vođenje evidencije, što otežava pretraživanje podataka, upravljanje zaposlenicima i djecom te generiranje izvještaja. Cilj projekta je razvoj desktop aplikacije koja će omogućiti digitalizaciju i automatizaciju ključnih procesa te poboljšati učinkovitost rada ravnateljice i odgojiteljica. Softver će koristiti ravnateljica i odgojiteljice vrtića, kojima će biti dodijeljene različite razine ovlasti. Ravnateljici će biti omogućeno upravljanje popisom prijavljene djece za upis u 2025/2026 godinu. Nakon završetka upisa, prijave će se rangirati prema broju bodova, dok će ravnateljica moći upisati djecu u skupine u kojima postoje slobodna mjesta. Djeca koja ne ostvare dovoljan broj bodova za upis ostaju na listi čekanja do oslobođenja mjesta u skupini ili brisanja s liste. Upis djece vršit će se u 4 skupine, a to su jaslička (1 - 3 godine), mlađa skupina (3 - 4), srednja skupina (4 – 5 godina) i starija skupina (6 – 7 godina). U jasličku skupinu bit će moguće upisati do 12 djece, u mlađu skupinu do 14, u srednju skupinu do 16, a u stariju do 20 djece. Osim kreiranja dječjih skupina, ravnateljici vrtića će biti omogućen pregled podataka o skupinama, ažuriranje i brisanje. Ravnateljica će u svakom trenutku moći raspolagati s popisom djece koja pohađaju vrtić te će imati omogućeno filtriranje prema različitim kriterijima (npr.prezime). Popis upisane djece sadržavat će djetetovo ime i prezime, datum rođenja, ime i prezime roditelja, kontakt podatke roditelja, alergije, upisanu dječju skupinu, napomene te da li ima poteškoće sa razvojem. Osim upravljanja podacima o djeci, ravnateljica će imati mogućnost upravljanja rasporedom rada zaposlenika i upravljanja njihovim podacima, u što spada pregled, izmjena i brisanje osnovnih podataka te dodjela uloga (odgojiteljica, spremačica, kuharica) te će joj biti omogućeno generiranje računa za roditelje. Odgojiteljice će imati mogućnost pregleda popisa djece u skupini prema imenu i prezimenu, mogućnost dodavanja bilješke o napretku svakog djeteta iz skupine, unosa plana aktivnosti za sljedeći mjesec te označavanje stavki plana kao realiziranih. Planovi aktivnosti mogu uključivati aktivnosti koje će biti provedene s djecom te posebne događaje poput poludnevnih izleta ili roditeljskog sastanka, o kojima će moći obavijestiti roditelje putem e-maila. Odgojiteljicama će također biti omogućena evidencija dolazaka djece kako bi se roditeljima umanjila cijena vrtića za dane kada dijete nije bilo prisutno. 

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Zaduženi
------ | ----- | ----------- | --------
F01 | Login | Omogućava prijavu korisnika (ravnateljice ili odgojiteljice) u sustav putem korisničkog imena i lozinke. | Kaja
F02 | Upravljanje djecom | Ravnateljica može dodavati, ažurirati i brisati podatke o djeci, uključujući ime, datum rođenja, podatke o roditeljima, alergije i upisanu skupinu. | Lana
F03 | Upravljanje skupinama | Ravnateljica može pregledavati skupine, dodavati djecu u skupine prema dostupnim mjestima te ažurirati i brisati podatke o skupinama. | Vili
F04 | Evidencija dolazaka djece | Odgojiteljice mogu evidentirati dolaske djece u skupinu, što omogućuje automatsko umanjenje računa za izostanak. | Kaja
F05 | Generiranje računa | Sustav automatski izračunava i generira račune za roditelje, uz mogućnost umanjenja cijene za dane izostanka djeteta. | Lana
F06 | Upravljanje zaposlenicima | Ravnateljica može pregledavati, ažurirati i brisati podatke o zaposlenicima te im dodjeljivati uloge i smjene rada. | Vili
F07 | Bilješke o napretku djece | Odgojiteljice mogu unositi i pregledavati bilješke o napretku djece u skupini. | Vili
F08 | Planiranje aktivnosti | Odgojiteljice mogu unositi plan aktivnosti za sljedeći mjesec te označavati realizirane stavke. | Lana
F09 | Slanje obavijesti roditeljima | Odgojiteljice mogu slati e-mail obavijesti roditeljima o aktivnostima i događajima u skupini. | Kaja
F10 | Prikaz statističkih podataka | Ravnateljica može generirati statističke izvještaje o upisima, dolascima djece i popunjenosti skupina. | Vili


## Tehnologije i oprema
Kod implementacije rješenja i verzioniranja koda koristit će se .NET Framework razvojni okvir u kombinaciji s WinForms, Visual Studio Code 2022, Git i Github. Pisanje i priprema dokumentacije odvijat će se putem GitHub Wiki, dok će projektni zadaci biti isplanirani i praćeni u alatu GitHub projects. Za izradu skica zaslona aplikacije koristit će se Canva, za izradu ERA modela draw.io, dok za izradu gantograma OnlineGantt.

