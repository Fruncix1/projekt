# Lista Zadań

## Opis aplikacji
Aplikacja Lista Zadań służy do organizowania codziennych obowiązków. Umożliwia dodawanie, edytowanie, usuwanie i filtrowanie zadań, a także ustawianie przypomnień na określone daty oraz nadawanie im priorytetów.

## Cel aplikacji
Aplikacja pomaga użytkownikowi skutecznie zarządzać zadaniami poprzez:

- Przypomnienia o ważnych zadaniach, aby użytkownik nie zapomniał o terminach.
- Priorytetyzację obowiązków, by najważniejsze zadania były wyróżnione.
- Łatwość organizacji – intuicyjny interfejs pozwala szybko dodawać, edytować i usuwać zadania.

## Zasada działania
Aplikacja działa jako lista zadań, w której użytkownik może dodawać i zarządzać zadaniami z przypomnieniami i sortowaniem według priorytetu oraz daty.

## Główne funkcje aplikacji
- ✅ **Dodawanie zadania** – użytkownik może wpisać nazwę zadania, ustawić priorytet oraz opcjonalnie dodać przypomnienie na wybraną datę i godzinę.
- ✅ **Sortowanie** – zadania są automatycznie układane według priorytetu (Krytyczny, Wysoki, Średni, Niski), a następnie według daty przypomnienia.
- ✅ **Usuwanie zadań** – możliwość szybkiego usunięcia zadania po jego wykonaniu.
- ✅ **Edycja zadań** – użytkownik może edytować nazwę, datę przypomnienia i priorytet już dodanego zadania.
- ✅ **Powiadomienia** – aplikacja sprawdza co 2 sekundy, czy nadszedł czas przypomnienia i wyświetla komunikat.
- ✅ **Eksport zadań** – użytkownik może zapisać aktualną listę zadań do pliku `.txt`.
- ✅ **Filtrowanie zadań** – możliwość wyświetlania tylko zadań o wybranym priorytecie lub w określonym przedziale dat (planowane).

## Interakcja z użytkownikiem
Interfejs aplikacji został stworzony w Windows Presentation Foundation (WPF), dzięki czemu użytkownik korzysta z aplikacji w sposób intuicyjny.

### Dodawanie zadania:
1. Wprowadzenie nazwy zadania.
2. Opcjonalne ustawienie daty i godziny przypomnienia.
3. Wybranie priorytetu (Niski, Średni, Wysoki, Krytyczny).
4. Kliknięcie przycisku „Dodaj zadanie”.

### Edytowanie zadania:
1. Wybranie istniejącego zadania z listy.
2. Wprowadzenie nowych danych w formularzu.
3. Kliknięcie przycisku „Edytuj zadanie”.

### Eksportowanie zadań:
1. Kliknięcie przycisku „Eksportuj zadania”.
2. Wybranie lokalizacji i zapisanie pliku `.txt`.

## Najnowsze zmiany
- 🆕 **Dodano możliwość edycji zadań** (nazwa, data, priorytet).
- 🆕 **Dodano możliwość eksportu zadań do pliku `.txt`**.
- ✅ Powiadomienia o przypomnieniach – aplikacja sprawdza listę co 2 sekundy i wyświetla komunikat, jeśli nadeszła godzina przypomnienia.
- ✅ Obsługa priorytetów – użytkownik może określić priorytet zadania, a aplikacja automatycznie sortuje listę.
- ✅ Lepsza organizacja kodu – kod został zoptymalizowany zgodnie z zasadami Clean Code (KISS, DRY, SOLID).
