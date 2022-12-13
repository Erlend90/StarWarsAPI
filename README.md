# StarWarsAPI
 
Jeg valgte å forsøke meg på API-oppgaven.

Jeg føler egentlig ikke at jeg har klart å få frem veldig godt tingene jeg er best på. Som nevnt i epost-utvekslingen med Sjur så føler jeg meg ikke ekstremt stødig i React, så jeg valgte bort denne oppgaven og valgte heller å prøve å lage en API. Jeg har egentlig heller ikke jobbet i .NET/C# før, eller jobbet noe særlig med API'er, så denne var også utfordrende. Jeg har derfor måttet prøve meg frem litt vha. diverse tutorials etc. Jeg håper likevel jeg er på begynnelsen av sporet på noe. Da var unnskyldingene unnagjort.

Første steg var selvsagt å få satt opp prosjektet i Visual Studio og sørge for at jeg hadde siste versjon .NET SDK. Dette var ganske rett fram.

Deretter utforsket jeg API'en jeg skulle hente eksterne data fra, for å forstå hvordan denne virket, noe som også i seg selv var ganske enkelt.

Jeg forsøkte deretter å lage en slags smørbrødliste av hva som krevdes av API'en for at den skulle kunne levere det som er kravet:

<ul>
 <li>Den må kunne hente data fra ekstern datakilde om:
  <ul>
   <li>Planeter</li>
   <li>Filmer</li>
   <li>Beboere</li>
  </ul>
 </li>
 <li>Den må kunne behandle disse dataene:
 <ul>
  <li>Hente ut data fra Json som mottas</li>
  <li>Velge de dataene som listes i oppgaven</li>
  <li>Slå sammen data fra planet-, film- og beboerinformasjon, slik at alt kan presenteres i en Json</li>
 </ul>
 <li>Ha endpoints som trigger kall på metodene som skal hente og behandle data</li>
 </ul>
 
 Jeg begynte med å lage modeller for hver av de tre kategoriene av data som skulle hentes. Deretter forsøkte jeg å sette opp kall til ekstern datakilde for å hente dataene som trengs.
 
 På grunn av mangelen på erfaring og at jeg har måttet lese meg gjennom en del turorials for å finne ut hvordan jeg skulle gjøre ting, så har tiden gått fortere enn jeg håpte, og det er så langt jeg har kommet foreløpig.
 
 Neste steg ville bli å behandle dataene, og sette sammen data om planet, beboere og filmer til en samlet Json. Deretter ville jeg forsøkt å sette opp en endpoint med url som ville blitt "localhost:port/planet/{id}" hvor denne kunne hentes av bruker.
 
 Alt i alt sikkert ikke ekstremt imponerende, men det var i alle fall det beste jeg fikk til i dette tilfellet. :-)
 
 Erlend
