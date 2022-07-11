Analiza czasu Jest to jeden z pięciu programów które tworzą całość. Pozostałe programy znajdują się na tym githubie. Nazwy pozostałych repozytoriów to:

*  Keylogger
*  Tłumacz 
*  Analiza 
*  Analiza-czasu

Program ma na celu sprawdzać działalność użytkownika na komputerze. 
Dokładnie ma sprawdzić czy nie dochodzi do zaburzeń wprowadzania wybranych ciągów czyli odchylenie od wzorca może wynosić średnia +- odchylenie standardowe. 
Czy nie są otwierane niedozwolone aplikacje oraz czy nie dochodzi do zbyt częstych przerw w pisaniu. 
W momencie wykrycia któregoś z tych odchyleń system jest automatycznie blokowany

## Instrukcja ##

* Ścieżka do pliku i do aplikacji jest wybierana po naciśnięciu guzika
Ścieżka do pliku musi zawierać plik csv w którym znajdują się tylko czas średni oraz odchylenie standardowe (Wynik programu analiza-czasu).
Plik z dozwolonymi aplikacjami musi zawierać tylko nazwy aplikacji i musi być w formacie csv.
* Następnie należy załadować plik.
* Czas do uznania za przerwę w pisaniu należy podać w milisekundach 
* Ile dopuszczalnych błedów w ciągu 1h – jest to ilość nieudanych weryfikacji z załadowanym wzorcem.
* Ile dozwolonych zmian fokusa w 5 min – jest to ilość zmian okienka głównego
* Ile dopuszczalnych przerw w pisania- po ilu razach jak zostanie wykryta przerwa w pisaniu uruchomi się zabezpieczenie.
* Następnie naciskamy załaduj .
* Na koniec należy wcisnąć przycisk uruchom.
Po wykonaniu wszystkich kroków terminal zniknie i program rozpocznie prace. Aby zatrzymać program i wyświetlić ponownie interfejs należy trzy razy szybko wcisnąć Ctrl.
