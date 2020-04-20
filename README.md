# RabbitHop

Ukoliko se kod otvaranja projekta u Unity-u pojave errori i warnings vezani za TextMeshPro,
potrebno je obrisati cache od tog dodatka, nakon toga se sve normalno builda i radi bez ikakvih problema

potrebno je obrisati ovu mapu: com.unity.test-framework@1.1.11<br/>
Ta mapa se nalazi na putu: RabbitHop\Library\PackageCache

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
