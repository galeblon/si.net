# Plan na wyklad nr 3 i pewnie 4
0. Pokazanie reguły routingu z własnym warunkiem na parametr -> MyRouteConstraint
1. Poprawna odpowiedź na pytanie zadane na poprzednim wykładzie w routingu - Kontroller Routing -> GetProduct
2. Prezentacja możliwości przyjecia danych z formularza z automatycznym wiązaniem wskazanych parametrów
3. Prezentacja możliwości przyjęcia danych w formacie JSON i zamiany ich na obiekt
4. Prezentacja właściwości klasy bazowej Controller -> ModelState - weryfikacja statusu walidacji
5. Prezentacja klasy z oznaczonymi metodami walidacji
6. Automatyczna serializacja danych na widoku do formatu JSON (csproj, startup, akcja) -> CatalogJson
7. Automatyczna serializacja danych na widoku do formatu XML (csproj, startup, klasa do serializacji, akcja) -> CatalogXml
8. Dynamiczne wskazywanie typu serializacji
9. Powrót do kontrollera "Ciasteczka" -> rozbudowa go do pełnego kontrolera dziedziczącego po Controller (Startup -> DI)
10. Zabawa w Routing dla akcji Reksio
---
11. Nachodzenie nazw kontrollerów - co zrobić? -> własny atrybut -> zmiana konwencji
12. Wreszcie jaka będzie nazwa akcji w kontrolerze zagnieżdżonym. Porównaj z SecondController
13. Może kiedyś uda się poprawić zmienną Catalog w RoutingController -> żeby zachowywała swój stan pomiędzy akcjami
14. Prosty sposób na filtrowanie akcji w kontrolerze: zbudujmy FilterController
15. Domyślne fabryki dostawców wartości - skąd mogą być czerpane wartości dla atrybutów (po nazwie)
16. Własna fabryka dostawców wartości - cookies (dostawca wartości -> fabryka -> startup)
17. Istniejące modele automatycznego wiązania -> sposób zamiany wartości z fabryk dostawców wartości na parametry akcji
18. Testowanie wiązania modeli
19. Token anulowania żądania asynchronicznego (przykład -> zadanie dodatkowe)
---
20. Różne typy predefiniowanych odpowiedzi IActionResult
21. Wersjonowanie API -> dependency, ApiVersion, Włączenie nagłówków startup/włączenie url, testy
22. Dodawanie automatycznie generowanej dokumentacji do API (OpenAPI) -> Dependencies (csproj), DI -> configureServices, modyfikacja middleware - poprawa projektu - -> uwaga!!
23. Zagadka (OpenAPI - API Versioning bez zmiany nazw) -> /swagger lub /swagger/v1/swagger.json 
24. Ręczne definiowanie parametrów Cache / Korzystanie z predefiniowanego profilu
25. Cookies
26. Sesja - włączenie - użycie
27. Cache odpowiedzi: DI -> dodanie instancji; middleware - dodanie komponentu 
28. Pamięć podręczna IMemoryCache
---
29. Pamięć podręczna IDistributedCache - włączenie Redis / włączenie SqlServer