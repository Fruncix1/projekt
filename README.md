# Lista Zadań

## Opis aplikacji
Aplikacja Lista Zadań służy do organizowania codziennych obowiązków. Umożliwia dodawanie, edytowanie, usuwanie i filtrowanie zadań, a także ustawianie przypomnień na określone daty oraz nadawanie im priorytetów.

## Cel aplikacji
Aplikacja pomaga użytkownikowi skutecznie zarządzać zadaniami poprzez:

Przypomnienia o ważnych zadaniach, aby użytkownik nie zapomniał o terminach.

Priorytetyzację obowiązków, by najważniejsze zadania były wyróżnione.

Łatwość organizacji – intuicyjny interfejs pozwala szybko dodawać, edytować i usuwać zadania.

## Zasada działania
Aplikacja działa jako lista zadań, w której użytkownik może dodawać i zarządzać zadaniami.

## Główne funkcje aplikacji
 Dodawanie zadania – użytkownik może wpisać nazwę zadania, ustawić priorytet oraz opcjonalnie dodać przypomnienie na wybraną datę i godzinę.
 Sortowanie – zadania są automatycznie układane według priorytetu (Krytyczny, Wysoki, Średni, Niski).
 Usuwanie zadań – możliwość szybkiego usunięcia zadania po jego wykonaniu.
 Powiadomienia – aplikacja sprawdza co 2 sekundy, czy jest zadanie do przypomnienia i wyświetla komunikat.
 Filtrowanie zadań – użytkownik może wyświetlać tylko zadania o określonym priorytecie lub w wybranym zakresie dat.

## Interakcja z użytkownikiem
Interfejs aplikacji został stworzony w Windows Presentation Foundation (WPF), dzięki czemu użytkownik korzysta z aplikacji w sposób intuicyjny.

### Dodawanie zadania:

Wprowadzenie nazwy zadania.

Opcjonalne ustawienie daty i godziny przypomnienia.

Wybranie priorytetu (Niski, Średni, Wysoki, Krytyczny).

Kliknięcie przycisku „Dodaj zadanie”.

### Zarządzanie listą zadań:

Zadania wyświetlane są w kolejności priorytetów.

Kliknięcie w zadanie pozwala je usunąć.

System automatycznie sprawdza przypomnienia i wyświetla powiadomienia.

## Najnowsze zmiany
 Dodano powiadomienia o przypomnieniach – aplikacja sprawdza listę co 2 sekundy i wyświetla komunikat, jeśli nadeszła godzina przypomnienia.
 Obsługa priorytetów – użytkownik może określić priorytet zadania, a aplikacja automatycznie sortuje listę.
 Lepsza organizacja kodu – kod został zoptymalizowany zgodnie z zasadami Clean Code (KISS, DRY, SOLID).

## Plany na przyszłość
 Edycja zadań – możliwość zmiany nazwy, daty i priorytetu bez konieczności usuwania zadania.
 Sortowanie według daty przypomnienia – aby najbliższe zadania były wyświetlane jako pierwsze.
 Eksport listy zadań – możliwość zapisania zadań do pliku tekstowego lub CSV, aby można je było udostępnić lub przenieść na inne urządzenie.
