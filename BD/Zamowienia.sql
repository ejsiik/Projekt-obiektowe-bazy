-- phpMyAdmin SQL Dump
-- version 4.9.5deb2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Czas generowania: 16 Cze 2022, 16:54
-- Wersja serwera: 10.3.34-MariaDB-0ubuntu0.20.04.1
-- Wersja PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `Aptekopol`
--

-- --------------------------------------------------------

--
-- Struktura widoku `Zamówienia`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`v3rs`@`localhost` SQL SECURITY DEFINER VIEW `Zamówienia`  AS  select `Orders`.`Order_ID` AS `ID Zamówienia`,`Clients`.`Login` AS `Login Klienta`,`Shops`.`City` AS `Sklep`,concat(`Workers`.`Firstname`,' ',`Workers`.`Surname`) AS `Pracownik`,`Products`.`Name` AS `Nazwa Produktu`,`Orders`.`Quantity` AS `Ilość` from ((((`Orders` join `Clients`) join `Shops`) join `Workers`) join `Products`) where `Orders`.`Client_ID` like `Clients`.`ID` and `Orders`.`Shop_ID` like `Shops`.`ID` and `Orders`.`Worker_ID` like `Workers`.`ID` and `Orders`.`Product_ID` like `Products`.`ID` ;

--
-- VIEW  `Zamówienia`
-- Dane: Żaden
--

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
