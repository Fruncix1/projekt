# Lista Zadań

## Opis aplikacji
Aplikacja Lista Zadań służy do zarządzania zadaniami użytkownika oraz planowania przypomień. Umożliwia dodawanie, edytowanie, usuwanie i filtrowanie zadań, a także ustawianie przypomień na wybrane daty oraz priorytetów zadań.

## Cel aplikacji
Celem aplikacji jest ułatwienie zarządzania codziennymi zadaniami, przypominanie użytkownikowi o nadchodzących terminach oraz organizacja zadań według priorytetów. Pomaga osobom, które mają wiele zadań do wykonania i potrzebują skutecznego systemu przypomnień.

## Zasada działania
Aplikacja działa na zasadzie listy zadań, do której użytkownik może dodawać zadania wraz z przypomnieniami na określoną datę oraz określać ich priorytety. Główne funkcje obejmują:
- Dodawanie nowego zadania z opcjonalnym przypomnieniem oraz priorytetem (niski, średni, wysoki, krytyczny).
- Edytowanie zadań.
- Usuwanie zadań.
- Filtrowanie zadań według daty oraz priorytetu.
- Powiadamianie użytkownika o nadchodzących zadaniach w dniu przypomnienia.
- Automatyczne sortowanie zadań według priorytetu, aby najważniejsze zadania pojawiały się na górze listy.

## Interakcja z użytkownikiem
Interakcja z użytkownikiem odbywa się przez intuicyjny graficzny interfejs użytkownika (GUI) oparty na technologii WPF (Windows Presentation Foundation). Użytkownik ma dostęp do następujących elementów interfejsu:
1. Użytkownik wpisuje nazwę zadania.
2. Użytkownik wybiera datę i godzinę, kiedy chce otrzymać przypomnienie o zadaniu.
3. Użytkownik może przypisać zadaniu priorytet (niski, średni, wysoki, krytyczny).
4. Przycisk "Dodaj zadanie" umożliwia dodanie nowego zadania do listy.
5. Użytkownik widzi wszystkie dodane zadania, które są sortowane według priorytetu oraz może je edytować lub usuwać.
6. Użytkownik może filtrować zadania według priorytetu oraz daty przypomnienia.
7. System automatycznie sprawdza przypomnienia co 10 sekund i wyświetla powiadomienia o nadchodzących zadaniach.

## Najnowsze zmiany
- Wprowadzono mechanizm przypomnień za pomocą `DispatcherTimer`, który sprawdza zadania co 10 sekund i wyświetla powiadomienia o zbliżającym się terminie.
- Rozszerzono metodę `Add_Task`, aby akceptowała nie tylko datę przypomnienia, ale także godzinę.
- Dodano obsługę priorytetów zadań, umożliwiając wybór jednego z czterech poziomów priorytetu.
- Zadania są automatycznie sortowane według priorytetu, dzięki czemu najważniejsze pojawiają się na górze listy.
- Naprawiono błąd związany z nieprawidłowym odświeżaniem listy po dodaniu nowego zadania.

