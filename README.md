# Projekt-obiektowe-bazy
 Projekt aplikacji do zarządzania siecią aptek, aplikacja napisana w języku C# z wykorzystaniem silnika WPF oraz wzorca MVVM. Baza danych zawiera podstawowe informacje pozwalające na zarządzanie sklepem. 

Aplikacja znajduje się w folderze **Aptekopol/**

W folderze BD znajdują się pliki bazy danych, główny plik to **BD/Aptekopol.sql**

Domyślny użytkownik: **root**
hasło: **brak**

Przed uruchomieniem bazy danych należy wykonać komendy w sql'u, tworzące dwa widoki niezbędne do uruchomienia aplikacji i poprawnego połączenia z bazą danych:

```
CREATE VIEW `ordersview`  AS SELECT `orders`.`Order_ID` AS `orderID`, `clients`.`Login` AS `clientLogin`, `orders`.`Order_date` AS `orderDate`, `products`.`Name` AS `productName`, `orders`.`Quantity` AS `quantity`, `products`.`Price` AS `unitPrice`, `orders`.`Quantity`* `products`.`Price` AS `totalPrice`, `shops`.`City` AS `shop`, concat(`workers`.`Firstname`,' ',`workers`.`Surname`) AS `assignedTo` FROM ((((`orders` join `clients`) join `products`) join `shops`) join `workers`) WHERE `orders`.`Client_ID` like `clients`.`ID` AND `orders`.`Shop_ID` like `shops`.`ID` AND `orders`.`Worker_ID` like `workers`.`ID` AND `orders`.`Product_ID` like `products`.`ID`
```

```
CREATE VIEW `productssuppliers`  AS SELECT `delivery`.`ID` AS `deliveryID`, `products`.`Name` AS `productName`, `suppliers`.`Name` AS `supplierName`, `delivery`.`Price` AS `price`, `delivery`.`Amount` AS `amount` FROM ((`delivery` join `products`) join `suppliers`) WHERE `delivery`.`Product_ID` like `products`.`ID` AND `delivery`.`Supplier_ID` like `suppliers`.`ID`
```

