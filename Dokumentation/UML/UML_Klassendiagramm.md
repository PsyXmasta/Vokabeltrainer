# UML-Klassendiagramm

Folgende Klassen wurden für das Projekt geplant:

- Vokabel
- VokabelVerwaltung
- DatenService
- Training

Beziehungen:

- Eine VokabelVerwaltung verwaltet mehrere Vokabeln (1:n).
- Der DatenService verwendet die VokabelVerwaltung zum Speichern und Laden der Daten.
- Die Klasse Training verwendet die VokabelVerwaltung für den Zugriff auf die vorhandenen Vokabeln.