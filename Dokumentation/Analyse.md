# Analyse

## Projektidee

Es soll eine Desktop-Anwendung zur Verwaltung und zum Lernen von deutschen und englischen Vokabeln entwickelt werden.

Der Benutzer kann neue Vokabeln anlegen, bearbeiten und löschen. Zusätzlich können die Vokabeln im Rahmen eines kleinen Trainings abgefragt werden.

Die Daten werden dauerhaft gespeichert, sodass sie auch nach dem Neustart der Anwendung weiterhin verfügbar sind.

---

## Projektziel

Ziel des Projekts ist die Entwicklung eines einfach bedienbaren deutsch-englischen Vokabeltrainers.

Der Benutzer soll eigene Vokabeln verwalten und regelmäßig üben können. Durch die Speicherung der Daten bleiben alle Einträge dauerhaft erhalten.

---

## User Story

Als Benutzer möchte ich meine deutschen und englischen Vokabeln verwalten und trainieren können, damit ich meinen Wortschatz verbessern und neue Wörter leichter lernen kann.

---

## Geplante Hauptklassen

### Vokabel

Speichert eine einzelne Vokabel.

**Attribute:**
- Deutsch
- Englisch
- Kategorie

### VokabelVerwaltung

Verwaltet alle vorhandenen Vokabeln.

**Aufgaben:**
- Vokabel hinzufügen
- Vokabel bearbeiten
- Vokabel löschen
- Vokabelliste bereitstellen

### DatenService

Speichert und lädt die Daten.

**Aufgaben:**
- Speichern
- Laden

### Training

Steuert den Trainingsmodus.

**Aufgaben:**
- Zufällige Vokabel auswählen
- Antwort überprüfen
- Punkte zählen