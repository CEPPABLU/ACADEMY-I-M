# Programma per inventario edicola

Il Programma presenta una classe **Edicola** che funge da contenitore,
una classe astratta **Pubblicazioni** che permette alle classi **Rivista** e **Giornale** di ereditare le proprietà _Codice_ e _Stock_.
La classe **Giornale** ha al suo interno:
- la proprietà redazione 
- il costruttore parametrico che prenderà in ingresso i vari parametri che verranno inseriti in ingresso dall'utente
-  _l'override_ del metodo stampaDettagli() per printare a monitor i vari attributi

La classe **Rivista** ha al suo interno:
- la proprietà titolo
- la proprietà categoria
- il costruttore parametrico che prenderà in ingresso i vari parametri
- _l'override_ del metodo stampaDettagli() per printare a monitor i vari attributi.

La classe **Pubblicazioni** ha al suo interno:
- la proprietà codice
- la proprietà stock
- la proprietà vendite
- il metodo astratto stampaDettagli()

Il contenitore **Edicola** ha al suo interno:
- la proprietà nome
- la proprietà indirizzo
- la lista pubblicazioni 
- il costruttore con i parametri 
- il metodo aggiungiMag() per aggiungere il giornale o la rivista creata in input dall'utente
- il metodo rimuoviMag() per rimuovere la pubblicazione dalla lista
- il metodo stampaElenco() per printare l'elenco totale delle pubblicazioni
- il metodo aggiornaStock() per aggiornare la quantità in stock della pubblicazione specifica
- il metodo updateVendite() per inserire le unità vendute, aggiornare lo stock in relazione alla vendita e il numero delle vendite



