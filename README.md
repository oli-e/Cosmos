# Katalog obiektów astronomicznych

## Kategorie

  - galaktyki:
    - gwiazdy: typy (pulsary/neutronowe/żółte karły etc.)
      - systemy planetarne:
        - planety: typy (karłowate/planety)
          - księżyce
      - pasy asteroid
    - planety bez słońca

\+ podstawowe informacje o obiektach:  
  - rozmiary,
  - masa,
  - odległosci,

[dane do testowania muszą być dowolne, program ma przyjmować input od userów]

- Model oparty na plikach lub DB

- GUI:
  - odczytywanie / wyświetlanie danych,
  - segregowanie /
  - sensowne rozmieszczenie


- UWP/ WPS -> MUS, biblioteka musi być (Raider w JetBrains)

- testy jednostkowe:
  - testowanie operacji dodawania/usuwania wpisów etc.
  - MUnit, jakies Microsoftowe rzeczy
  - testy zewnętrznymi narzedziami dopuszczone (np. Selenium)

- Dokumentacja:
  - wersja Visual Studio
  - framweworki wykozystane (.Net etc.)
  - biblioteki do testów jednostkowych
  - jak kompilować / build process
  - tutorial/objaśnienie funkcjonalności:
    - technicznie: który plik jest wejściem?
    - jak się posługiwać -> instrukcja


# 18.12.2022

## Podział zadanek (research phase)

### Przemek:

  - zapis danych, format danych,
  - przesył danych do warstwy frontu (schemat, implementacja do sprawdzenia)
  - Fasadkę na DB ops
  
### Olena:

  - rozrysować interfejs (sprawdzić dostępność narzędzi i bibliotek)
  - zewnętrzne narzędzia do tworzenia interfejsów (nie zapamietałem dokładnie ale bylo powiedziane, że istnieje [Web Based])
  - sprawdzić w czym się będzie najlepiej pisało testy (MUnit vs. Selenium) (DEMO)
 
### Wojtek:  
 
  - dynamiczne tworzenie obiektów interfejsu (DEMO)
  - sprawidzć jak to przemyśleć architektonicznie [MVC](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc) vs. [MVVM](https://learn.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm)
  - sprawdzić w czym się będzie najlepiej pisało testy (MUnit vs. Selenium) (DEMO)
  
## Dyskusja:

  - widoki:
    - główny,
    - szczegółowy,
    - edytuj,
    - dodaj element
    
## Narzędzia / Knowledge dump    
  - mocking framework for C# [link](https://www.telerik.com/products/mocking.aspx)
  - tree view [link](https://learn.microsoft.com/pl-pl/dotnet/desktop/wpf/controls/treeview-overview?view=netframeworkdesktop-4.8)
  - schemat repo (powiedzcie mi czy to głupie czy nie):
    - main branch,
    - staging branch,
    - brache imienne,
    - workflow:
      - checkout zawsze z main,
      - push zawsze na staging,
      - ze stagingu na main, tylko gdy testy zaakceptowane

# Następne spotkanie: środa 21.12.2022 19:30

### Przezroczysty czajnik w tle

# 21.12.2022 

  - Tests: NUnit
    - https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/
  - Podstawowy Model:
    - końcowa hierarchia obiektów,
    - save/load functionality,
    
  - Ma wyglądać typowo Windowsowo: Total Commander
  
  - Co pozostaje:
    - Datatypes, generator -> P
    - MVVM, -> W 
    - TreeView, Tests -> O
    
# 30.12.2022

### MVVM reference:   
   - MVVM / WPF Overview: https://www.youtube.com/watch?v=anAMoDbqWKk  
   - Repo z tego filmiku: https://github.com/PanNiebieski/WPF-MVVM-SimpeExample  
  
### MVVM z microsoftu: https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm  
  - generalnie olać pierwsze dwa rozdziały
  - najważniejsze chapter 3, (4/5 te takie są specyficzne), 6
  
### Relay Command:  
  - https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/relaycommand
  - generalnie traktuje się eventy typu on click jako osobne metody, podpinając ich niezależne definicje do infterfejsu, zamiast uzależniać klasy od widoku.  
  
### Do ogarnięcia:
  - przełączanie widoków w zależności od contextu
    
