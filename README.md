```plaintext
                +----------------------+
                |      Pojazd         |
                +----------------------+
                | - id: int           |
                | - rejestracja: String |
                | - marka: String     |
                | - model: String     |
                | - rok_produkcji: int|
                +----------------------+
                         ▲
                         │  <<extends>>
                         │
                +----------------------+
                |         Bus         |
                +----------------------+
                | - liczba_miejsc: int|
                | - status: StatusBusu|
                +----------------------+

        1                         1
   +-------------------------+   ─────────────   +--------------------------+
   |         Podróż         |◄──────────────────►|           Bus            |
   +-------------------------+    (używa)        +--------------------------+
   | - id: int              |                    | (dziedziczy z Pojazd)    |
   | - data_wyjazdu: Date   |
   | - data_powrotu: Date   |
   | - status: StatusPodróży|
   | - bus: Bus             |
   | - trasa: Trasa         |
   | - kierowca: Kierowca   |
   +-------------------------+
              ▲
              │ 1
              │
       +------------+
       |  Kierowca  |
       +------------+
       | - id: int  |
       | - imie: String
       | - nazwisko: String
       | - numer_licencji: String
       | - przydzielone_podróże:
       |   List<Podróż>
       +------------+
           0..* ▲
                │
                │ przypisuje
                │
                ▼ 1
      +-------------------------+
      |        Trasa           |◄────────── (przypisana do Podróż)
      +-------------------------+
      | - id: int              |
      | - nazwa: String        |
      | - lista_przystanków:   |
      |   List<Przystanek>     |
      +-------------------------+
              │
              │ 1..*
              ▼
      +----------------------+
      |     Przystanek       |
      +----------------------+
      | - id: int            |
      | - nazwa: String      |
      | - lokalizacja: String|
      | - czas_postoju: int  |
      +----------------------+

                    1
                    │
                    │ wskazuje aktualną
                    │ lokalizację
                    ▼
         +--------------------------+
         |    LokalizacjaBusu       |
         +--------------------------+
         | - bus: Bus               |
         | - szerokość_geo: double  |
         | - długość_geo: double    |
         | - czas_aktualizacji: Date|
         +--------------------------+
