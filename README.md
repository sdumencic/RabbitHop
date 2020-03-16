# Eglas_zadatak1

VEZANO ZA PROJEKT:
Kod buildanja, za "Platform" je odabran "PC, Mac & Linux Standalone", target platform: Windows

Ukoliko se kod otvaranja projekta u Unity-u pojave errori i warnings vezani za TextMeshPro,
potrebno je obrisati cache od tog dodatka, nakon toga se sve normalno builda i radi bez ikakvih problema

potrebno je obrisati ovu mapu: com.unity.test-framework@1.1.11<br/>
Ta mapa se nalazi na putu: Eglas_zadatak1\Library\PackageCache

U mapi Eglas_zadatak nalazi se cijeli projekt + exe datoteka u mapi: Build_PC_Mac_Linux
Radi bržeg snalaženja, mapa sa svime potrebnime za pokrenuti igru, uključujući .exe file nalazi se i izvan mape u kojoj se nalazi projekt. U mapi u kojoj se nalazi projekt se za svaki slučaj nalaze svi paketi asset-ova sa svim datotekama (kako je originalno skinuto).

VEZANO ZA IGRU:
Kontrole za igru:<br/>
kretanje: <br/>
	lijevo - strelica u lijevo<br/>
	desno - strelica u desno<br/>
	gore - strelica za gore<br/>
	dolje - strelica za dolje<br/>
pauza - p<br/><br/>

Cilj:<br/>
	sakupiti što više random spawnane hrane za zeca<br/>
	ako pčela dotakne zeca - game over<br/><br/>

Pravila: <br/>
	sakupljanje gljiva - poveća zeca, ali nosi 100 bodova<br/>
	sakupljanje salate(listovi) - smanji zeca, nosi 50 bodova<br/>
	sakupljanje mrkve i kupusa - 50 bodova<br/>
	ako se dotakne pčelu, igra je gotova, vraća se na start menu<br/>

Na većini isprobanih laptopa/računala, sve radi normalno, međutim na jednom laptopu na kojem sam isprobala
zec može prolaziti kroz ogradu/travu i nema animacije skakanja. Nisam uspjela pronaći razlog tog problema 
s obzirom da je na svim uređajima gdje je isprobana igra bio Windows 10, također isprobano je i sa zippanom
i unzippanom mapom u kojoj se sve nalazi. No nadam se da se kod Vas neće pojaviti navedeni problem.
