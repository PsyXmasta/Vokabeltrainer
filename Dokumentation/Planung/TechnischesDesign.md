# Technisches Design

## Datenmodell

Für die Speicherung der Vokabeln wird das JSON-Format verwendet.

Jede Vokabel besteht aus folgenden Eigenschaften:

- Deutsch
- Englisch
- Kategorie

Beispiel:

{
    "Deutsch": "Haus",
    "Englisch": "House",
    "Kategorie": "Alltag"
}

## Datenfluss

1. Der Benutzer gibt eine Vokabel ein.
2. Die Vokabel wird der Vokabelliste hinzugefügt.
3. Die Liste wird gespeichert.
4. Beim Programmstart werden die Daten geladen.
5. Das Training verwendet die gespeicherten Vokabeln.

## Fehlerbehandlung

Folgende Fehlerfälle werden berücksichtigt:

- Leere Eingabefelder
- Fehlende JSON-Datei
- Ungültige Eingaben
- Doppelte Vokabeleinträge

Der Benutzer erhält entsprechende Hinweismeldungen.

## Technische Komponenten

Programmiersprache:
- C#

Framework:
- WPF

Datenspeicherung:
- JSON

Versionsverwaltung:
- Git/GitHub

Entwicklungsumgebung:
- Visual Studio 2022

## Klassenstruktur

Modelle:

- Vokabel

Services:

- DatenService
- Training

Verwaltung:

- VokabelVerwaltung