<!--
[![Build and Tests](https://github.com/gsoTH/Wuerfelspiel/actions/workflows/build-and-test.yml/badge.svg?branch=master)](https://github.com/gsoTH/Wuerfelspiel/actions/workflows/build-and-test.yml)
-->
#### Ziele/Kompetenzen :seedling:
1. Objektorientierte Analyse und Modellierung einsetzen, indem Sie 
- die die zu implementierenden Strukturen (d.h. die Architektur, den Aufbau) als UML-Klassendiagramm darstellen
- Vorhandene Klassen wiederverwenden (Vererbung einsetzen, z.B. Spezialwürfel einbauen)
2. Testgetriebene Entwicklung betreiben, indem Sie 
- das Verhalten der Klassen als Unit Tests beschreiben
- UnitTests für alle Klassen/Methoden/Eigenschaften entwickeln, bevor Sie diese implementieren
3. Logik und Darstellung trennen, indem Sie
- Wiederverwendbare GUI-Elemente einsetzen (UserControls)
- keine Logik in der GUI zu implementieren, sondern alles in spezialisierte Klassen auslagern
4. Versionskontrolle betreiben, indem Sie
- git und github einsetzen um Ihre Ergebnisse zu sichern
- nach jedem logischen Entwicklungsschritt einen commit durchführen
___

# Wuerfelspiel
![Kniffel](https://i.pinimg.com/236x/47/cc/5e/47cc5e1c3d139196e10c98fc81727561.jpg)

## Anforderungen :dart: 
In diesem Repository soll ein Würfelspiel entwickelt werden.
1. Falls Sie kein eigenes Spiel entworfen haben, soll das Spiel [Kniffel](https://de.wikipedia.org/wiki/Kniffel) nachgebaut werden. 
2. Die entwickelte Spiellogik soll in Konsolen-Programmen und in Windows-Forms-Programmen genutzt werden können. Das bedeutet, dass die Logik in eigenen Klassen, nicht innerhalb z.B. der Programm.cs oder Form1.cs liegt. In der Programm.cs bzw. Form1.cs soll die Spiellogik nur eingebunden werden.
3. Alle Klassen sollen so aufgebaut sein, dass das Programm erweiterungsfähig ist, so dass ein ähnliches Spiel wie [Balut](https://de.wikipedia.org/wiki/Balut_(W%C3%BCrfelspiel)#Spielregeln) leicht umgesetzt werden kann. 

### Abgrenzungen :no_entry:
- Vorerst nur die wichtigsten Würfel umsetzen: W6, W8, W10, W12, W20. Keine Bildwürfel (:hearts:, :clubs:, :diamonds:, :spades:, :pineapple: o.ä.)


## Fachliche Beschreibungen :memo:
Diese fachlichen Beschreibungen sollen die Entwicklung steuern und sind daher nicht ungebdint vollständig. Machen Sie sich - wie im echten Leben - eigene Gedanken. 

Kniffel ist ein Würfelspiel mit fünf Würfeln, einem Würfelbecher und einem speziellen Spielblock.

### Würfel
- Würfel haben eine unterschiedliche Anzahl an Seiten (w). Falls keine Anzahl angegeben wird, geht man von einem W6 aus, also ein Würfel mit 6 Seiten.
- Einen Würfel kann man würfeln, wodurch eine zufälliger Wert erzeugt wird. Das Ergebnis des letzten Wurfes muss abgefragt werden können, ohne es automatisch neu zu würfeln. Für viele Spiele kann man Würfel "sichern", wodurch sie beim nächsten Wurf nicht mit berücksichtigt werden (bspw. bei Kniffel).

### Spielblock
- Der Spielblock besteht bei Kniffel aus einem oberen Block und einem unteren Block.
- Der [obere Block](https://de.wikipedia.org/wiki/Kniffel#Oberer_Block) besitzt Felder aus deren Wert sich eine  Zwischensumme berechnet. Auf die Zwischensumme kann unter Umständen ein Bonus aufgeschlagen werden. Zwischensumme + Bonus ergibt die Summe des oberen Blocks.
- Der [untere Block](https://de.wikipedia.org/wiki/Kniffel#Unterer_Block) besitzt Felder aus deren Wert sich die Summe des unteren Blocks berechnet.

### Feld und Wurf
- Jedes Feld kann einen Wurf entgegennehmen. 
- Ein Wurf ist eine Sammlung aus 5 Würfeln. Je nach Feld werden nur bestimmte Würfel gezählt (z.B. "nur einser zählen") oder Punkte nur vergeben, wenn bestimmte Vorrausetzungen erfüllt sind (z.B. Full-House: zwei gleiche Würfel + drei gleiche Würfel). 
- Wenn ein ungültiger Wurf in ein Feld eingefügt wird, wird das Feld "gestrichen".

<!---
Platzhalter 
fürs Auskommentieren von Inhalten
-->
