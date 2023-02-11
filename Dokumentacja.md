### Wersja Visual Studio: 2022  
### Wersja .NET: 6.0  
### Frameworki :  
  - Obsługa plików JSON: [System.Text.Json](https://www.nuget.org/packages/System.Text.Json)
  - Tests: NUNIT

### Jak kompilować:
  - Projekt nie posiada wiele zewnętrznych zależności.
  - W przypadku braku pliku data.json, plik sotanie stworzony i wypełniony przykładowymi danymi.
  - Jeśli coś pójdzie nie tak, skopiowanie plików (data.json i ids.json) z folderu SampleData do folderu z plikiem .exe powinno wczytać przykładowe dane. 
  
### Objaśnienie funkcjonalności:
  - Dane przechowywane są w pliku data.json
  - Dane przedstawione są po lewej stronie za pomocą obiektu TreeView
  - Szczegółowe dane dotyczące obiektu wyświetlane są po prawej stronie
  - Rozwinięcie i klikanie po elementach TreeView powoduje przeładowanie widoku szczegółowego obiektu
  
  - Edycja Obiektu:
    - Zmiana wartości pól obiektu
    - Wciśnięcie przycisku SaveChanges
    - (przycisk DiscardChanges powoduje powrót do stanu sprzed edycji)

  - Tworzenie nowych obiektów:
    - Przyciski AddChildren dodają obiekty do drzewa, tworzony jest wtedy pusty plik dodawany do drzewa.
    - Przycisk AddGalaxy dodaje nową galaxy do drzewa (akcja jest osobna ze względu na konieczność odania do elementu "root" drzewa)
    
  - Usuwanie obiektów:
    - Przycisk Delete usuwa obecnie aktywny obiekt
    
