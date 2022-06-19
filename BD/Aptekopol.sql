-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2022 at 03:48 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aptekopol`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `ID` int(11) NOT NULL,
  `Login` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Firstname` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Surname` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Is_company` tinyint(1) NOT NULL,
  `Name` varchar(50) COLLATE utf32_polish_ci DEFAULT NULL,
  `NIP` varchar(50) COLLATE utf32_polish_ci DEFAULT NULL,
  `City` varchar(50) COLLATE utf32_polish_ci DEFAULT NULL,
  `Address` varchar(50) COLLATE utf32_polish_ci DEFAULT NULL,
  `Phone` varchar(50) COLLATE utf32_polish_ci DEFAULT NULL,
  `Email` varchar(50) COLLATE utf32_polish_ci DEFAULT NULL,
  `Password` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Password_last_change` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`ID`, `Login`, `Firstname`, `Surname`, `Is_company`, `Name`, `NIP`, `City`, `Address`, `Phone`, `Email`, `Password`, `Password_last_change`) VALUES
(1, 'bdolohunty0', 'Beau', 'Dolohunty', 0, NULL, NULL, 'Newark', '4 Lillian Circle', '272-268-978', NULL, 'kngcAF', '2022-03-15 17:05:35'),
(2, 'abeades1', 'Anestassia', 'Beades', 1, 'Zoovu', '455-633-96-02', NULL, NULL, NULL, 'abeades1@stumbleupon.com', 'xRYt28xF', '2022-02-24 14:09:48'),
(3, 'mmerriott2', 'Morissa', 'Merriott', 1, 'Youspan', '889-773-14-32', NULL, NULL, NULL, 'mmerriott2@hatena.ne.jp', '4IEokGRR', '2022-01-20 22:43:53'),
(4, 'tbedder3', 'Thorndike', 'Bedder', 0, NULL, NULL, 'Pushchino', '53 Clarendon Trail', '978-989-910', 'tbedder3@bandcamp.com', 'jhCDsDbOYGiy', '2022-05-21 13:54:18'),
(5, 'tswanton4', 'Tyrone', 'Swanton', 0, NULL, NULL, 'Shuyuan Zhen', '7755 Little Fleur Crossing', NULL, 'tswanton4@ezinearticles.com', 'Bp9NEZSK', '2021-08-18 11:48:02'),
(6, 'bchampniss6', 'Vitoria', 'Hegg', 1, 'Jaxspan', '110-721-53-76', 'Ishqoshim', '900 Scoville Street', NULL, NULL, 'WYELstf6e', '2021-07-08 17:43:06'),
(7, 'bchampniss6', 'Boony', 'Champniss', 1, 'Browsebug', '718-173-52-42', NULL, NULL, '698-221-628', 'bchampniss6@macromedia.com', 'XHk3BcX4Y2F', '2021-09-28 13:56:09'),
(8, 'gbentham7', 'Georgeta', 'Bentham', 1, 'Buzzdog', '685-766-31-54', 'Nantes', '4 Waxwing Drive', '201-958-369', 'gbentham7@booking.com', '70QWZxbaw', '2022-01-27 05:42:55'),
(9, 'ytrayling8', 'Yevette', 'Trayling', 0, NULL, NULL, NULL, NULL, NULL, 'ytrayling8@nsw.gov.au', 'dxscjLdkeoEi', '2022-04-13 19:45:46'),
(10, 'bricks9', 'Bertha', 'Ricks', 1, 'Omba', '000-371-75-28', 'Dapdap', '32238 Kennedy Trail', '929-433-216', 'bricks9@about.com', 'a9WHCAJqFV', '2022-01-19 12:53:46'),
(11, 'imelloya', 'Iago', 'Melloy', 1, 'Shuffledrive', '595-835-60-86', 'Gyamco', '29068 Oak Center', '043-950-522', 'imelloya@stumbleupon.com', 'wtvcecgn', '2022-03-01 00:08:16'),
(12, 'egoadsbyb', 'Eddy', 'Goadsby', 0, NULL, NULL, 'Shangqing', '0411 Stone Corner Way', NULL, 'egoadsbyb@theglobeandmail.com', 'O4ReAZjtpE', '2022-03-03 10:37:54'),
(13, 'bgrimwadc', 'Burke', 'Grimwad', 1, 'Dynabox', '885-494-26-82', 'Obama', '0608 3rd Terrace', '912-397-646', 'bgrimwadc@surveymonkey.com', 'vof4mJZgi', '2022-04-07 07:40:04'),
(14, 'jdefewd', 'Jorie', 'Defew', 0, NULL, NULL, 'Nakano', '9459 Arapahoe Point', NULL, 'jdefewd@dyndns.org', 'NNqwHcGHQ', '2022-02-22 05:13:58'),
(15, 'ccheverse', 'Corabella', 'Chevers', 1, 'Skalith', '198-463-31-19', NULL, NULL, NULL, 'ccheverse@bigcartel.com', 'MAFX7LgK', '2021-07-05 09:49:15'),
(16, 'jblewittf', 'Janette', 'Blewitt', 1, 'Izio', '318-660-58-47', 'Enriquillo', '241 Kingsford Hill', '941-958-604', 'jblewittf@scribd.com', 'Y1KvAC', '2021-08-08 07:07:34'),
(17, 'jproshg', 'Joanne', 'Prosh', 1, 'Geba', '915-186-35-35', 'Neya', '2690 Anhalt Court', '404-657-829', 'jproshg@springer.com', 'Dxkw7XwOCn', '2021-12-18 06:41:35'),
(18, 'lmerigeauh', 'Lynne', 'Merigeau', 1, 'Janyx', '921-742-42-21', 'Songbai', '72954 Mifflin Park', '919-284-292', 'lmerigeauh@sfgate.com', 'jtkNrbK3', '2022-05-15 18:43:29'),
(19, 'ptomneyi', 'Pebrook', 'Tomney', 0, NULL, NULL, 'Daur', '850 Oriole Road', '452-607-118', 'ptomneyi@blogs.com', 'maOmIlusTE', '2021-05-24 01:16:55'),
(20, 'dpiscoj', 'Damara', 'Pisco', 0, NULL, NULL, 'Zhukeng', '2333 Rowland Junction', '636-766-008', 'dpiscoj@aboutads.info', 'X7Z0K7Hb5iQ', '2021-06-30 14:34:27'),
(21, 'kbaswallk', 'Kelcy', 'Baswall', 1, 'Dynabox', '369-942-41-62', 'Kungälv', '915 Portage Avenue', '547-494-331', NULL, 'mQ2SHkK7qq', '2022-03-14 17:56:18'),
(22, 'dcrookalll', 'Demetrius', 'Crookall', 0, NULL, NULL, 'Qingyang', '79695 Logan Point', '763-372-649', 'dcrookalll@boston.com', 'up3pdKEi', '2022-06-02 13:12:47'),
(23, 'breedsm', 'Bonita', 'Reeds', 1, 'Skinix', '861-120-79-73', NULL, NULL, '621-992-687', 'breedsm@baidu.com', 'VeFjaZqSby', '2022-04-03 14:42:40'),
(24, 'lmartinon', 'Lenette', 'Martino', 0, NULL, NULL, 'Majalengka', '40 Cody Road', '977-201-269', 'lmartinon@nba.com', '8GAgDwUUDfuV', '2021-09-29 12:55:58'),
(25, 'jhayleyo', 'Jedd', 'Hayley', 1, 'Kazu', '565-392-66-50', 'Cabeço de Vide', '2370 Clarendon Plaza', NULL, NULL, 'frHgcJWgip', '2021-05-23 23:12:36'),
(26, 'apyfordp', 'Ashlen', 'Pyford', 1, 'Tazzy', '884-989-21-04', 'Rio Branco do Sul', '55178 Merchant Park', '612-769-752', 'apyfordp@merriam-webster.com', 'WGIvzVy', '2021-10-23 05:40:03'),
(27, 'bgriffittsq', 'Bernhard', 'Griffitts', 1, 'Edgetag', '080-426-76-94', 'Saint-Ouen', '00 Ludington Parkway', '063-126-199', 'bgriffittsq@loc.gov', 'Ul0X3el7', '2022-01-24 20:12:45'),
(28, 'lparcallr', 'Lelia', 'Parcall', 0, NULL, NULL, 'Mogi das Cruzes', '16239 Washington Road', NULL, NULL, 'fwPpNrT', '2021-07-21 05:37:31'),
(29, 'lscotfords', 'Lynnea', 'Scotford', 0, NULL, NULL, NULL, NULL, '285-185-651', 'lscotfords@guardian.co.uk', 'cqxiTY', '2021-10-17 03:45:18'),
(30, 'vvargat', 'Valida', 'Varga', 0, NULL, NULL, 'Ingå', '9 4th Center', NULL, 'vvargat@hubpages.com', 'swehiOu93j1', '2021-06-29 23:27:33'),
(31, 'amundenu', 'Ansel', 'Munden', 1, 'Jatri', '816-929-66-09', 'Miratejo', '34549 Main Street', NULL, 'amundenu@sohu.com', 'eqJBsg4RrPf', '2021-10-24 10:33:22'),
(32, 'hcassiusv', 'Harmon', 'Cassius', 1, 'Photofeed', '644-739-61-17', 'Kawakawa', '23 Emmet Circle', '861-206-763', 'hcassiusv@de.vu', 'iaTNR1Neg4', '2022-05-02 05:01:41'),
(33, 'lfraanchyonokw', 'Letta', 'Fraanchyonok', 1, 'Buzzdog', '759-483-63-21', 'Hongdun', '277 Annamark Place', '643-940-326', 'lfraanchyonokw@cbsnews.com', 'SYlbov', '2021-09-24 21:02:35'),
(34, 'ledwinsonx', 'Linzy', 'Edwinson', 0, NULL, NULL, 'Vilarinho das Cambas', '85 Victoria Road', '425-258-588', 'ledwinsonx@gmpg.org', 'DlwIIO0cIo', '2022-02-05 23:16:09'),
(35, 'jsomerliey', 'Jehanna', 'Somerlie', 1, 'Meembee', '120-457-42-98', NULL, NULL, NULL, 'jsomerliey@ca.gov', 'iMFYJhNb9M', '2021-11-25 11:42:05'),
(36, 'nzanolliz', 'Nicholas', 'Zanolli', 0, NULL, NULL, 'Masaran', '658 Lake View Park', '902-342-906', 'nzanolliz@icq.com', 'upZQuGLF5', '2022-04-25 16:13:38'),
(37, 'dipsgrave10', 'Drusi', 'Ipsgrave', 0, NULL, NULL, NULL, NULL, '391-350-519', 'dipsgrave10@yelp.com', 'gxr2xdgQb', '2022-04-09 07:33:32'),
(38, 'smantripp11', 'Sinclair', 'Mantripp', 0, NULL, NULL, 'Al Manshāh', '01 Erie Park', NULL, 'smantripp11@admin.ch', 'pkdwZqs', '2022-05-23 03:12:26'),
(39, 'vbraybrookes12', 'Valle', 'Braybrookes', 1, 'Chatterbridge', '360-990-60-08', 'Khudāydād Khēl', '79 Vahlen Place', '300-556-464', 'vbraybrookes12@disqus.com', 'Ji6RQsp', '2021-11-21 22:39:15'),
(40, 'moliver13', 'Marin', 'Oliver', 0, NULL, NULL, 'Hukvaldy', '1424 Weeping Birch Circle', '449-971-863', NULL, '0nw0mGBjeOHQ', '2022-05-30 22:48:28'),
(41, 'dbreagan14', 'Dionne', 'Breagan', 1, 'Vinte', '078-774-05-31', NULL, NULL, '319-153-932', 'dbreagan14@pen.io', '77azrV7E', '2021-11-09 14:53:46'),
(42, 'cdefilippi15', 'Claudina', 'De Filippi', 0, NULL, NULL, 'Jaworzyna Śląska', '196 Delaware Drive', '368-955-692', 'cdefilippi15@php.net', 'CEl5Jd6hJ9Ve', '2021-06-26 05:57:27'),
(43, 'amacturlough16', 'Alec', 'MacTurlough', 0, NULL, NULL, 'Ancona', '52924 Anderson Hill', '925-511-459', NULL, 'Aby9pUM7Ii', '2022-02-15 10:48:16'),
(44, 'ahrynczyk17', 'Albertina', 'Hrynczyk', 0, NULL, NULL, 'Plewiska', '92571 Colorado Crossing', NULL, 'ahrynczyk17@livejournal.com', 'ihczQMPK9gCU', '2021-10-30 11:23:14'),
(45, 'sgrzegorzewski18', 'Solly', 'Grzegorzewski', 1, 'Aivee', '670-156-96-29', 'Pawak', '2 Prairieview Place', NULL, 'sgrzegorzewski18@jugem.jp', 'ulWfH6Q', '2022-06-10 04:25:34'),
(46, 'pburdess19', 'Phyllis', 'Burdess', 0, NULL, NULL, 'Patao', '825 Holy Cross Junction', '814-487-503', 'pburdess19@scribd.com', 'WLuvDF', '2021-12-31 16:37:49'),
(47, 'cmaynell1a', 'Cole', 'Maynell', 0, NULL, NULL, 'Jawl al Majma‘', '06 Debs Way', '113-060-468', 'cmaynell1a@ca.gov', 'gGCbECgPmn', '2022-05-25 00:46:21'),
(48, 'agiblin1b', 'Arte', 'Giblin', 0, NULL, NULL, 'Zhoutou', '7827 Mandrake Pass', NULL, 'agiblin1b@craigslist.org', 'P5clcWaCRjB', '2022-04-29 11:41:16'),
(49, 'rmccarver1c', 'Roddy', 'McCarver', 0, NULL, NULL, 'Berlin', '85 Thierer Hill', '345-446-522', 'rmccarver1c@techcrunch.com', '0j9K75eM1Wy9', '2021-09-05 14:31:15'),
(50, 'aeede1d', 'Abelard', 'Eede', 1, 'Shufflebeat', '026-737-86-55', 'Cerkvenjak', '0042 Northfield Crossing', NULL, 'aeede1d@artisteer.com', 'MfBwJzq8TKsB', '2021-06-10 18:32:14');

-- --------------------------------------------------------

--
-- Table structure for table `contracts`
--

CREATE TABLE `contracts` (
  `ID` int(11) NOT NULL,
  `Worker_ID` int(11) NOT NULL,
  `Shop_ID` int(11) NOT NULL,
  `Contract_number` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Signing_date` datetime NOT NULL,
  `Expiration_date` datetime NOT NULL,
  `Salary` int(11) NOT NULL,
  `Job_title` enum('Kierownik regionalny','Kierownik sklepu','Sprzedawca') COLLATE utf32_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `contracts`
--

INSERT INTO `contracts` (`ID`, `Worker_ID`, `Shop_ID`, `Contract_number`, `Signing_date`, `Expiration_date`, `Salary`, `Job_title`) VALUES
(1, 1, 1, '0593zt/39', '2020-02-10 09:33:58', '2022-07-10 00:44:02', 8704, 'Kierownik regionalny'),
(2, 2, 6, '4985x2/32', '2022-05-08 08:40:37', '2022-07-07 03:40:16', 6740, 'Sprzedawca'),
(3, 3, 2, '2780np/22', '2021-07-05 14:11:15', '2022-07-17 14:35:47', 9418, 'Kierownik regionalny'),
(4, 4, 6, '23979o/76', '2021-04-26 15:38:56', '2022-10-31 06:55:04', 9092, 'Kierownik sklepu'),
(5, 5, 3, '1848c6/26', '2021-12-11 13:49:59', '2022-12-16 14:01:35', 5329, 'Sprzedawca'),
(6, 6, 9, '5834em/27', '2021-05-25 15:48:34', '2022-12-06 22:16:44', 9873, 'Kierownik sklepu'),
(7, 7, 4, '9175qr/50', '2020-03-14 17:07:34', '2022-10-09 01:31:51', 7915, 'Kierownik regionalny'),
(8, 8, 6, '01758y/49', '2022-05-21 04:26:19', '2022-10-17 01:00:11', 7665, 'Sprzedawca'),
(9, 9, 6, '4114t6/49', '2021-10-08 20:03:43', '2022-08-29 21:55:55', 5451, 'Sprzedawca'),
(10, 10, 1, '0133vr/29', '2021-02-02 11:55:38', '2022-07-11 07:04:57', 4850, 'Sprzedawca'),
(11, 11, 6, '8940mx/30', '2020-07-24 12:30:52', '2022-07-16 14:43:07', 8479, 'Sprzedawca'),
(12, 12, 4, '9195fp/79', '2021-07-05 23:59:46', '2022-08-10 10:33:36', 3703, 'Sprzedawca'),
(13, 13, 4, '6835ds/91', '2021-12-21 07:31:56', '2022-12-03 01:21:08', 7390, 'Sprzedawca'),
(14, 14, 7, '9511xd/66', '2022-03-28 11:45:08', '2022-11-28 20:29:15', 5704, 'Kierownik sklepu'),
(15, 15, 8, '4225so/80', '2022-05-10 15:21:59', '2022-09-13 02:08:09', 8953, 'Kierownik sklepu'),
(16, 16, 9, '6961dr/56', '2020-06-06 07:29:43', '2022-09-12 09:23:37', 5890, 'Sprzedawca'),
(17, 17, 10, '2612a3/11', '2020-01-16 10:57:32', '2022-11-07 11:11:10', 6341, 'Kierownik sklepu'),
(18, 18, 5, '9920lb/62', '2021-05-26 16:39:19', '2022-07-02 13:57:09', 9165, 'Kierownik sklepu'),
(19, 19, 4, '30656l/98', '2021-07-04 23:26:06', '2022-12-02 06:34:41', 6174, 'Kierownik sklepu'),
(20, 20, 1, '1148z9/16', '2020-12-21 04:14:37', '2022-07-05 19:12:14', 3213, 'Sprzedawca'),
(21, 21, 1, '5933xh/63', '2020-08-16 14:59:35', '2022-12-08 02:28:16', 9870, 'Sprzedawca'),
(22, 22, 9, '4149bl/27', '2021-07-21 16:06:38', '2022-11-28 16:12:43', 6264, 'Sprzedawca'),
(23, 23, 3, '6084es/97', '2020-01-29 13:46:36', '2022-11-13 22:54:23', 3405, 'Kierownik regionalny'),
(24, 24, 1, '5028xg/29', '2021-01-23 19:39:58', '2022-09-06 03:20:50', 5686, 'Kierownik sklepu'),
(25, 25, 9, '974327/66', '2021-06-17 02:26:04', '2022-07-08 00:19:06', 3274, 'Kierownik regionalny'),
(26, 26, 2, '856564/90', '2021-05-30 19:06:48', '2022-12-18 03:14:08', 8296, 'Kierownik sklepu'),
(27, 27, 5, '7000f8/14', '2021-05-15 09:01:30', '2022-12-22 19:42:37', 4764, 'Sprzedawca'),
(28, 28, 2, '05742j/77', '2020-08-06 00:12:56', '2022-08-19 08:04:49', 5531, 'Sprzedawca'),
(29, 29, 6, '4336pb/83', '2022-02-12 15:44:56', '2022-11-29 14:28:38', 8590, 'Kierownik regionalny'),
(30, 30, 4, '4549jm/73', '2022-03-01 00:52:56', '2022-12-08 04:18:00', 3882, 'Sprzedawca');

-- --------------------------------------------------------

--
-- Table structure for table `delivery`
--

CREATE TABLE `delivery` (
  `ID` int(11) NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Supplier_ID` int(11) NOT NULL,
  `Price` decimal(5,2) NOT NULL,
  `Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `delivery`
--

INSERT INTO `delivery` (`ID`, `Product_ID`, `Supplier_ID`, `Price`, `Amount`) VALUES
(1, 41, 3, '78.98', 23),
(2, 18, 6, '105.09', 14),
(3, 48, 10, '181.76', 5),
(4, 4, 8, '28.68', 34),
(5, 50, 6, '68.61', 11),
(6, 37, 7, '76.38', 9),
(7, 11, 5, '73.35', 37),
(8, 4, 2, '176.02', 29),
(9, 43, 2, '60.69', 22),
(10, 44, 8, '172.19', 23),
(11, 32, 2, '126.20', 45),
(12, 37, 2, '168.89', 23),
(13, 38, 5, '143.68', 36),
(14, 41, 4, '190.85', 1),
(15, 47, 10, '68.90', 47),
(16, 44, 2, '46.50', 49),
(17, 6, 2, '107.92', 20),
(18, 16, 2, '64.26', 48),
(19, 38, 3, '128.86', 45),
(20, 5, 8, '186.45', 37),
(21, 50, 10, '165.50', 6),
(22, 6, 5, '66.03', 1),
(23, 37, 10, '187.42', 30),
(24, 1, 3, '151.03', 39),
(25, 10, 8, '107.96', 23),
(26, 50, 1, '32.44', 42),
(27, 13, 3, '173.02', 20),
(28, 34, 2, '55.00', 12),
(29, 33, 10, '82.20', 45),
(30, 21, 4, '42.68', 2),
(31, 10, 4, '78.91', 5),
(32, 12, 6, '143.89', 2),
(33, 33, 6, '126.01', 47),
(34, 45, 3, '34.11', 35),
(35, 32, 1, '176.26', 22),
(36, 22, 4, '69.61', 48),
(37, 33, 9, '153.63', 10),
(38, 39, 9, '64.06', 12),
(39, 13, 10, '39.33', 36),
(40, 49, 10, '61.20', 6),
(41, 5, 6, '59.94', 27),
(42, 38, 2, '52.31', 49),
(43, 35, 8, '127.14', 27),
(44, 8, 2, '130.36', 25),
(45, 2, 4, '80.01', 39),
(46, 49, 2, '87.30', 5),
(47, 24, 2, '184.26', 22),
(48, 11, 3, '49.41', 50),
(49, 28, 6, '107.17', 26),
(50, 14, 2, '108.50', 35),
(51, 8, 3, '175.09', 40),
(52, 9, 1, '66.16', 21),
(53, 16, 10, '84.08', 24),
(54, 36, 6, '199.83', 42),
(55, 50, 1, '102.83', 26),
(56, 4, 7, '185.71', 25),
(57, 33, 7, '92.50', 22),
(58, 33, 6, '101.72', 40),
(59, 34, 3, '117.55', 2),
(60, 21, 1, '132.84', 28),
(61, 10, 5, '96.31', 14),
(62, 17, 2, '157.40', 27),
(63, 22, 3, '175.94', 49),
(64, 21, 10, '40.26', 40),
(65, 6, 10, '132.67', 35),
(66, 11, 5, '57.89', 39),
(67, 11, 8, '104.78', 36),
(68, 20, 1, '136.20', 14),
(69, 4, 10, '79.53', 8),
(70, 23, 2, '154.40', 25),
(71, 14, 8, '40.87', 16),
(72, 43, 5, '81.84', 10),
(73, 24, 3, '41.80', 3),
(74, 22, 2, '28.03', 27),
(75, 24, 5, '150.71', 1),
(76, 32, 9, '162.69', 19),
(77, 5, 2, '32.49', 35),
(78, 24, 10, '147.57', 4),
(79, 5, 8, '62.21', 43),
(80, 11, 3, '54.58', 21),
(81, 25, 9, '157.43', 7),
(82, 30, 1, '147.31', 2),
(83, 36, 1, '81.08', 21),
(84, 34, 9, '192.90', 44),
(85, 50, 7, '30.51', 16),
(86, 12, 4, '42.56', 27),
(87, 1, 4, '118.78', 27),
(88, 7, 3, '54.28', 47),
(89, 10, 9, '133.49', 41),
(90, 14, 1, '36.69', 29),
(91, 6, 4, '33.99', 26),
(92, 28, 1, '83.70', 35),
(93, 24, 8, '99.35', 43),
(94, 9, 2, '100.61', 37),
(95, 50, 9, '104.25', 12),
(96, 23, 1, '77.61', 25),
(97, 4, 8, '192.19', 34),
(98, 24, 9, '161.47', 18),
(99, 3, 5, '188.67', 4),
(100, 30, 9, '112.57', 15);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `Order_ID` int(11) NOT NULL,
  `Client_ID` int(11) NOT NULL,
  `Shop_ID` int(11) NOT NULL,
  `Worker_ID` int(11) NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Order_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`Order_ID`, `Client_ID`, `Shop_ID`, `Worker_ID`, `Product_ID`, `Quantity`, `Order_date`) VALUES
(1, 32, 5, 5, 14, 15, '2022-05-10 04:03:01'),
(2, 2, 4, 30, 25, 3, '2021-12-03 07:07:42'),
(3, 16, 10, 13, 42, 9, '2022-01-10 14:12:51'),
(4, 23, 6, 19, 37, 10, '2021-07-14 09:17:19'),
(5, 12, 7, 17, 24, 10, '2021-07-02 08:45:06'),
(6, 44, 4, 26, 36, 12, '2022-03-07 12:08:59'),
(7, 39, 9, 13, 40, 11, '2021-12-28 13:26:11'),
(8, 39, 2, 22, 7, 16, '2021-06-20 13:13:03'),
(9, 3, 6, 30, 40, 12, '2022-05-17 16:50:20'),
(10, 9, 10, 12, 36, 13, '2021-07-24 08:49:39'),
(11, 7, 8, 30, 9, 2, '2021-09-03 19:23:56'),
(12, 29, 4, 13, 32, 5, '2021-09-08 18:55:12'),
(13, 12, 5, 26, 19, 7, '2022-01-05 23:42:51'),
(14, 32, 6, 3, 5, 11, '2022-06-07 07:02:20'),
(15, 28, 2, 8, 45, 14, '2022-03-31 12:28:18'),
(16, 17, 3, 23, 30, 8, '2021-11-06 13:48:26'),
(17, 4, 6, 21, 14, 13, '2022-01-07 01:26:44'),
(18, 6, 8, 11, 13, 11, '2022-06-05 03:28:32'),
(19, 50, 3, 26, 29, 8, '2022-01-29 02:53:11'),
(20, 16, 3, 20, 48, 7, '2021-09-14 09:39:34'),
(21, 8, 1, 16, 31, 10, '2022-03-18 23:38:00'),
(22, 18, 8, 28, 47, 2, '2021-08-06 01:16:31'),
(23, 25, 3, 7, 19, 11, '2022-05-20 06:54:47'),
(24, 5, 8, 27, 33, 4, '2022-06-12 15:57:33'),
(25, 24, 1, 11, 47, 14, '2021-08-31 16:40:22'),
(26, 14, 8, 24, 20, 6, '2021-12-01 19:09:12'),
(27, 44, 5, 16, 10, 6, '2021-08-15 06:00:23'),
(28, 34, 2, 13, 35, 1, '2022-02-05 00:02:11'),
(29, 7, 2, 27, 1, 9, '2021-12-04 15:39:04'),
(30, 18, 1, 26, 18, 15, '2022-01-26 17:44:41'),
(31, 35, 10, 9, 43, 16, '2021-09-18 19:06:42'),
(32, 50, 1, 23, 19, 10, '2022-04-07 23:28:35'),
(33, 7, 4, 13, 5, 11, '2021-10-05 05:23:54'),
(34, 27, 9, 20, 28, 14, '2021-07-30 23:39:43'),
(35, 29, 6, 21, 45, 9, '2021-07-09 01:53:42'),
(36, 14, 7, 14, 29, 15, '2022-05-16 17:30:32'),
(37, 27, 3, 17, 48, 1, '2021-08-08 21:58:41'),
(38, 3, 4, 13, 41, 5, '2022-01-15 10:08:08'),
(39, 28, 10, 20, 12, 6, '2021-12-18 14:33:29'),
(40, 21, 9, 6, 28, 2, '2021-12-14 02:34:14'),
(41, 40, 6, 11, 24, 6, '2021-12-02 01:09:29'),
(42, 10, 4, 28, 30, 15, '2022-01-18 02:24:20'),
(43, 5, 6, 30, 14, 9, '2022-04-06 11:42:22'),
(44, 42, 10, 3, 12, 15, '2022-01-07 14:01:15'),
(45, 20, 9, 25, 44, 8, '2021-07-09 17:10:15'),
(46, 20, 8, 3, 45, 4, '2021-11-23 20:24:12'),
(47, 11, 4, 24, 21, 2, '2021-08-05 07:49:23'),
(48, 1, 1, 26, 15, 13, '2022-03-02 07:16:06'),
(49, 12, 5, 22, 22, 15, '2022-03-28 03:14:34'),
(50, 46, 4, 9, 22, 4, '2022-05-26 14:36:40'),
(51, 14, 8, 19, 6, 15, '2021-07-01 01:19:07'),
(52, 12, 1, 12, 45, 3, '2021-08-16 08:47:57'),
(53, 18, 8, 7, 36, 2, '2021-10-13 14:28:12'),
(54, 11, 8, 14, 37, 4, '2022-02-05 04:32:43'),
(55, 49, 5, 25, 11, 16, '2021-12-13 11:05:22'),
(56, 13, 9, 20, 36, 15, '2021-07-09 14:00:52'),
(57, 44, 7, 30, 47, 14, '2022-03-12 13:31:09'),
(58, 39, 7, 5, 42, 14, '2021-12-19 15:32:42'),
(59, 8, 4, 15, 20, 12, '2022-06-01 20:27:17'),
(60, 10, 3, 4, 8, 10, '2021-08-22 04:07:14'),
(61, 5, 5, 10, 15, 10, '2021-12-20 03:16:59'),
(62, 50, 10, 4, 40, 4, '2022-06-13 09:57:49'),
(63, 13, 8, 20, 45, 11, '2022-01-28 10:05:16'),
(64, 49, 3, 28, 25, 9, '2021-08-17 06:25:20'),
(65, 24, 6, 18, 50, 1, '2021-11-20 14:45:58'),
(66, 32, 10, 25, 1, 2, '2021-07-17 05:08:01'),
(67, 32, 6, 11, 38, 15, '2021-07-03 03:16:43'),
(68, 25, 10, 10, 7, 2, '2021-10-08 14:43:36'),
(69, 7, 8, 18, 30, 11, '2022-05-18 00:01:25'),
(70, 27, 9, 22, 29, 13, '2022-04-04 02:13:41'),
(71, 29, 7, 30, 16, 3, '2022-01-26 05:29:06'),
(72, 44, 3, 24, 19, 9, '2021-12-10 20:25:31'),
(73, 13, 10, 20, 12, 9, '2021-10-27 05:20:40'),
(74, 49, 10, 28, 25, 3, '2021-10-23 04:52:06'),
(75, 32, 10, 22, 7, 7, '2022-05-09 00:27:17'),
(76, 41, 2, 14, 20, 4, '2022-01-23 12:23:40'),
(77, 13, 10, 22, 22, 15, '2021-10-23 17:45:03'),
(78, 11, 9, 5, 4, 6, '2022-02-18 07:24:01'),
(79, 6, 8, 24, 13, 1, '2021-12-24 09:26:12'),
(80, 27, 3, 6, 50, 8, '2022-03-03 21:14:55'),
(81, 1, 4, 4, 32, 1, '2021-07-13 06:22:55'),
(82, 39, 2, 27, 35, 5, '2021-12-12 12:27:07'),
(83, 47, 2, 4, 8, 7, '2021-08-20 13:10:42'),
(84, 16, 7, 10, 38, 7, '2021-12-17 12:47:17'),
(85, 21, 8, 26, 26, 2, '2021-09-22 11:51:20'),
(86, 12, 10, 9, 13, 8, '2021-09-28 23:58:57'),
(87, 32, 1, 25, 42, 2, '2022-03-16 19:01:55'),
(88, 48, 2, 22, 39, 2, '2022-06-04 00:59:33'),
(89, 27, 4, 3, 38, 3, '2022-05-03 04:11:21'),
(90, 37, 4, 29, 38, 4, '2022-06-11 21:59:27'),
(91, 7, 8, 4, 14, 1, '2021-07-14 11:51:33'),
(92, 29, 10, 9, 16, 7, '2021-09-30 12:07:44'),
(93, 22, 1, 6, 43, 14, '2021-07-21 07:54:46'),
(94, 13, 9, 10, 47, 6, '2022-01-18 19:50:58'),
(95, 33, 6, 11, 7, 1, '2022-02-20 07:30:07'),
(96, 11, 6, 22, 2, 12, '2021-08-29 17:27:50'),
(97, 8, 9, 26, 7, 6, '2022-01-26 18:51:39'),
(98, 1, 7, 20, 40, 4, '2022-03-12 11:01:31'),
(99, 28, 10, 17, 44, 2, '2022-05-09 08:49:16'),
(100, 35, 7, 24, 25, 13, '2021-12-10 09:26:49');

-- --------------------------------------------------------

--
-- Stand-in structure for view `ordersview`
-- (See below for the actual view)
--
CREATE TABLE `ordersview` (
`orderID` int(11)
,`clientLogin` varchar(50)
,`orderDate` datetime
,`productName` varchar(50)
,`quantity` int(11)
,`unitPrice` decimal(5,2)
,`totalPrice` decimal(15,2)
,`shop` varchar(50)
,`assignedTo` varchar(22)
);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Description` text COLLATE utf32_polish_ci NOT NULL,
  `Price` decimal(5,2) NOT NULL,
  `Remarks` text COLLATE utf32_polish_ci NOT NULL,
  `Category` text COLLATE utf32_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ID`, `Name`, `Description`, `Price`, `Remarks`, `Category`) VALUES
(1, 'Modafinil', 'External constriction of part of breast, left breast, subsequent encounter', '396.00', 'Hyperosmolality and/or hypernatremia', 'Upper arm reattachment'),
(2, 'Oxcarbazepine', 'Displaced comminuted fracture of right patella, subsequent encounter for closed fracture with malunion', '80.23', 'Retracted nipple associated with childbirth, delivered, with or without mention of antepartum condition', 'Bone graft, patella'),
(3, 'Risperidone', 'Laceration with foreign body of oral cavity', '52.32', 'Causalgia of lower limb', 'Electroretinogram [ERG]'),
(4, 'ThatZit Acne Treatment', 'Fatigue fracture of vertebra, site unspecified, sequela of fracture', '308.28', 'Injury to kidney with open wound into cavity, laceration', 'Incision of peritoneum'),
(5, 'Thiamine', 'Nondisplaced oblique fracture of shaft of unspecified radius, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing', '353.19', 'Poisoning by posterior pituitary hormones', 'Electroretinogram [ERG]'),
(6, 'CITALOPRAM', 'Fracture of unspecified part of right clavicle, subsequent encounter for fracture with routine healing', '177.66', 'Benign neoplasm of brain', 'Upper arm reattachment'),
(7, 'CK one 3-in-1 face makeup', 'Displaced fracture of unspecified ulna styloid process, sequela', '224.00', 'Other sickle-cell disease with crisis', 'Upper arm reattachment'),
(8, 'Calcarea Phos Kit Refill', 'Benign neoplasm of male genital organs', '274.70', 'Need for prophylactic vaccination and inoculation against diptheria-tetanus- pertussis with poliomyelitis [DTP + polio]', 'Upper arm reattachment'),
(9, 'SALIX NIGRA POLLEN', 'Dislocation of tooth, sequela', '349.96', 'Suicide and self-inflicted poisoning by corrosive and caustic substances', 'Occupational therapy'),
(10, 'Jet Lag and Shift Change', 'Stable burst fracture of unspecified thoracic vertebra, initial encounter for closed fracture', '121.90', 'Gingival recession, unspecified', 'Teleradiotherapy using photons'),
(11, 'Mexiletine Hydrochloride', 'Damage to pelvic organs following complete or unspecified spontaneous abortion', '71.04', 'Tuberculosis of unspecified bones and joints, unspecified', 'Bone graft, patella'),
(12, 'Allergy', 'Stress fracture, hip, unspecified, subsequent encounter for fracture with malunion', '305.00', 'Dysplasia of prostate', 'Diagnostic aspiration of orbit'),
(13, 'Modesa anti-bacterial hand gel', 'Laceration of ovary', '379.40', 'Unspecified alcohol-induced mental disorders', 'Electroretinogram [ERG]'),
(14, 'Cherry', 'Subperiosteal abscess of mastoid', '256.41', 'Endodontic underfill', 'Upper arm reattachment'),
(15, 'Tolnaftate', 'Chronic inflammation of postmastoidectomy cavity', '360.00', 'Personal history, urinary (tract) infection', 'Upper arm reattachment'),
(16, 'EFFET PARFAIT', 'Rheumatoid nodule, elbow', '287.79', 'Congenital factor XI deficiency', 'Upper arm reattachment'),
(17, 'Amitriptyline Hydrochloride', 'Malignant neoplasm of anal canal', '255.26', 'Polyp of vocal cord or larynx', 'Diagnostic aspiration of orbit'),
(18, 'Diethylpropion HydrochlorideER', 'Peripheral tear of medial meniscus, current injury, right knee', '155.31', 'Disruption of cesarean wound, delivered, with mention of postpartum complication', 'Diagnostic aspiration of orbit'),
(19, 'MUCOR PLUMBEUS', 'Other secondary chronic gout, unspecified hip, without tophus (tophi)', '252.88', 'Chylocele of tunica vaginalis', 'Pelvic gas contrast radiography'),
(20, 'KGP Flush', 'Strain of flexor muscle, fascia and tendon of right middle finger at forearm level, initial encounter', '173.69', 'Closed fracture of unspecified part of neck of femur', 'Diagnostic aspiration of orbit'),
(21, 'Aplicare Povidone-iodine Scrub', 'Nondisplaced fracture of distal phalanx of right lesser toe(s), subsequent encounter for fracture with routine healing', '364.69', 'Other ill-defined heart diseases', 'Diagnostic aspiration of orbit'),
(22, 'Etodolac', 'Nondisplaced fracture of medial malleolus of right tibia', '121.32', 'Kayser-Fleischer ring', 'Teleradiotherapy using photons'),
(23, 'Levetiracetam', 'Poisoning by unspecified systemic anti-infective and antiparasitics, assault, initial encounter', '371.96', 'Secondary syphilitic periostitis', 'Upper arm reattachment'),
(24, 'AUREOBASIDIUM PULLULANS VAR PULLULANS', 'Lesion of sciatic nerve, bilateral lower limbs', '282.24', 'Benign neoplasm of major salivary glands', 'Electroretinogram [ERG]'),
(25, 'Promethazine Hydrochloride', 'Photokeratitis, unspecified eye', '453.47', 'Cutaneous hemorrhage of fetus or newborn', 'Teleradiotherapy using photons'),
(26, 'Up and Up Nicotine', 'Unspecified open wound of thumb without damage to nail', '482.59', 'Tuberculous pleurisy in primary progressive tuberculosis, tubercle bacilli not found by bacteriological examination, but tuberculosis confirmed histologically', 'Occupational therapy'),
(27, 'Pollens - Trees, Pine Mix', 'Displaced fracture of posterior wall of unspecified acetabulum, subsequent encounter for fracture with routine healing', '110.55', 'Other complications due to nervous system device, implant, and graft', 'Pelvic gas contrast radiography'),
(28, 'Methimazole', 'Unspecified fracture of upper end of right radius, subsequent encounter for open fracture type I or II with routine healing', '84.18', 'Contracture of joint, shoulder region', 'Incision of peritoneum'),
(29, 'XOLIDO', 'Toxic effect of fusel oil, undetermined, subsequent encounter', '50.21', 'Mechanical entropion', 'Biopsy of bone, scapula, clavicle, and thorax [ribs and sternum]'),
(30, 'Amoxicillin and Clavulanate Potassium', 'Age-related reticular degeneration of retina, right eye', '258.64', 'Tuberculosis of other male genital organs, bacteriological or histological examination unknown (at present)', 'Exploratory verbal psychotherapy'),
(31, 'Dicloxacillin Sodium', 'Partial traumatic metacarpophalangeal amputation of right little finger, subsequent encounter', '458.71', 'Hypertonic, incoordinate, or prolonged uterine contractions, antepartum condition or complication', 'Bone graft, patella'),
(32, 'Salt Grass', 'Transient ischemic deafness, unspecified ear', '205.71', 'Malignant neoplasm of head of pancreas', 'Bone graft, patella'),
(33, 'Divalproex Sodium', 'Laceration of deep palmar arch of right hand', '245.77', 'Closed fracture of patella', 'Incision of peritoneum'),
(34, 'Sesame Seed', 'Clubbing of fingers', '255.10', 'Aftercare for healing traumatic fracture of vertebrae', 'Bone graft, patella'),
(35, 'Lisinopril', 'Stable burst fracture of T9-T10 vertebra, subsequent encounter for fracture with nonunion', '404.97', 'Congenital cytomegalovirus infection', 'Electroretinogram [ERG]'),
(36, 'Atenolol', 'Sedative, hypnotic or anxiolytic dependence, uncomplicated', '173.67', 'Streptococcal septicemia', 'Pelvic gas contrast radiography'),
(37, 'Hydrochlorothiazide', 'Person boarding or alighting a three-wheeled motor vehicle injured in collision with railway train or railway vehicle, subsequent encounter', '303.51', 'Orbital osteomyelitis', 'Other kidney transplantation'),
(38, 'Trimethobenzamide Hydrochloride', 'Breakdown (mechanical) of intraperitoneal dialysis catheter, sequela', '168.02', 'Acute nonparalytic poliomyelitis, poliovirus, unspecified type', 'Implantation or replacement of mechanical kidney'),
(39, 'Zyclara', 'Maternal care for excessive fetal growth, third trimester, fetus 5', '262.14', 'Calculus of bile duct with acute cholecystitis, without mention of obstruction', 'Pelvic gas contrast radiography'),
(40, 'CITALOPRAM', 'Unspecified car occupant injured in collision with pedal cycle in nontraffic accident, subsequent encounter', '219.45', 'Inadvertent exposure of patient to radiation during medical care', 'Other kidney transplantation'),
(41, 'Tolnaftate', 'Displaced fracture of medial cuneiform of unspecified foot, sequela', '406.68', 'Adhesive pericarditis', 'Electroretinogram [ERG]'),
(42, 'good neighbor pharmacy pain relief', 'Leakage of femoral arterial graft (bypass)', '262.44', 'Other specified disorders of penis', 'Implantation or replacement of mechanical kidney'),
(43, 'isosorbide mononitrate', 'Other and unspecified effects of other external causes', '405.09', 'Impetigo herpetiformis', 'Teleradiotherapy using photons'),
(44, 'fiber laxative', '36 weeks gestation of pregnancy', '282.05', 'Other and unspecified angina pectoris', 'Revision of fenestration of inner ear'),
(45, 'Azathioprine', 'Unspecified occupant of heavy transport vehicle injured in collision with two- or three-wheeled motor vehicle in traffic accident', '207.30', 'Glaucomatous flecks (subcapsular)', 'Electroretinogram [ERG]'),
(46, 'IOPE BRIGHTGEN', 'Laceration of other extensor muscle, fascia and tendon at forearm level, left arm, sequela', '377.97', 'Tuberculous meningitis, unspecified', 'Other kidney transplantation'),
(47, 'VALTREX', 'Seborrheic keratosis', '305.89', 'Acute tracheitis without mention of obstruction', 'Implantation or replacement of mechanical kidney'),
(48, 'COLIC DIARRHEA', 'Injury of nerves and spinal cord at thorax level', '167.61', 'Climacteric arthritis, lower leg', 'Implantation or replacement of mechanical kidney'),
(49, 'Leader 12 Hour Nasal Decongestant', 'Unspecified fracture of upper end of unspecified radius, subsequent encounter for open fracture type I or II with delayed healing', '349.90', 'Renal agenesis and dysgenesis', 'Revision of fenestration of inner ear'),
(50, 'Cold Remedy Gan Mao Ling', 'Burn of third degree of left ear [any part, except ear drum]', '486.90', 'Closed fracture of multiple ribs, unspecified', 'Revision of fenestration of inner ear');

-- --------------------------------------------------------

--
-- Stand-in structure for view `productssuppliers`
-- (See below for the actual view)
--
CREATE TABLE `productssuppliers` (
`deliveryID` int(11)
,`productName` varchar(50)
,`supplierName` varchar(50)
,`price` decimal(5,2)
,`amount` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `shops`
--

CREATE TABLE `shops` (
  `ID` int(11) NOT NULL,
  `City` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Address` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Phone` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Email` varchar(50) COLLATE utf32_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `shops`
--

INSERT INTO `shops` (`ID`, `City`, `Address`, `Phone`, `Email`) VALUES
(1, 'Warsaw', '55381 3rd Lane', '939 077 720', 'Warsaw@aptekopol.pl'),
(2, 'Paris', '5330 Packers Way', '708 226 396', 'Paris@aptekopol.pl'),
(3, 'Berlin', '3 Village Green Place', '801 835 184', 'Berlin@aptekopol.pl'),
(4, 'London', '03964 Corben Drive', '352 370 373', 'London@aptekopol.pl'),
(5, 'Brussels', '4962 Brickson Park Parkway', '847 316 993', 'Brussels@aptekopol.pl'),
(6, 'Vienna', '8 Kensington Place', '504 764 634', 'Vienna@aptekopol.pl'),
(7, 'Zagreb', '251 Dayton Point', '096 621 836', 'Zagreb@aptekopol.pl'),
(8, 'Athens', '00 Arizona Pass', '784 414 493', 'Athens@aptekopol.pl'),
(9, 'Madrid', '0018 Myrtle Parkway', '881 295 606', 'Madrid@aptekopol.pl'),
(10, 'Amsterdam', '29091 Dexter Pass', '278 950 888', 'Amsterdam@aptekopol.pl');

-- --------------------------------------------------------

--
-- Table structure for table `shop_storage_status`
--

CREATE TABLE `shop_storage_status` (
  `ID` int(11) NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Shop_ID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `shop_storage_status`
--

INSERT INTO `shop_storage_status` (`ID`, `Product_ID`, `Shop_ID`, `Quantity`) VALUES
(1, 28, 4, 29),
(2, 49, 1, 23),
(3, 40, 7, 5),
(4, 37, 1, 36),
(5, 37, 7, 41),
(6, 27, 9, 17),
(7, 44, 9, 14),
(8, 50, 8, 1),
(9, 13, 7, 46),
(10, 42, 7, 35),
(11, 20, 4, 47),
(12, 6, 10, 35),
(13, 43, 4, 10),
(14, 11, 9, 23),
(15, 5, 9, 24),
(16, 4, 10, 50),
(17, 7, 5, 8),
(18, 30, 4, 11),
(19, 9, 10, 49),
(20, 16, 8, 11),
(21, 42, 4, 44),
(22, 21, 9, 42),
(23, 30, 10, 43),
(24, 34, 7, 48),
(25, 7, 9, 41),
(26, 26, 7, 30),
(27, 32, 7, 11),
(28, 4, 2, 11),
(29, 12, 3, 50),
(30, 38, 3, 2),
(31, 32, 10, 44),
(32, 19, 10, 21),
(33, 34, 4, 30),
(34, 42, 5, 25),
(35, 19, 6, 49),
(36, 43, 10, 10),
(37, 45, 1, 32),
(38, 40, 1, 5),
(39, 2, 6, 46),
(40, 46, 4, 27),
(41, 20, 3, 16),
(42, 38, 5, 10),
(43, 29, 9, 34),
(44, 22, 6, 49),
(45, 11, 8, 20),
(46, 34, 4, 48),
(47, 29, 7, 42),
(48, 49, 2, 39),
(49, 13, 5, 28),
(50, 39, 3, 36),
(51, 1, 10, 23),
(52, 14, 7, 25),
(53, 21, 10, 34),
(54, 29, 4, 6),
(55, 22, 10, 1),
(56, 11, 10, 32),
(57, 31, 4, 26),
(58, 39, 7, 40),
(59, 12, 6, 15),
(60, 26, 4, 21),
(61, 24, 9, 34),
(62, 16, 9, 37),
(63, 45, 3, 32),
(64, 47, 1, 25),
(65, 27, 8, 9),
(66, 3, 2, 46),
(67, 44, 3, 14),
(68, 9, 8, 31),
(69, 9, 3, 44),
(70, 24, 3, 6),
(71, 48, 5, 28),
(72, 27, 1, 7),
(73, 34, 9, 37),
(74, 5, 8, 9),
(75, 18, 10, 27),
(76, 20, 3, 36),
(77, 28, 3, 8),
(78, 16, 10, 31),
(79, 31, 2, 17),
(80, 43, 4, 11),
(81, 41, 4, 29),
(82, 41, 3, 13),
(83, 47, 3, 7),
(84, 28, 9, 27),
(85, 46, 8, 28),
(86, 4, 5, 39),
(87, 45, 8, 43),
(88, 16, 5, 8),
(89, 21, 8, 31),
(90, 47, 5, 33),
(91, 43, 7, 5),
(92, 33, 3, 8),
(93, 46, 10, 41),
(94, 34, 7, 41),
(95, 21, 5, 26),
(96, 45, 5, 18),
(97, 46, 7, 34),
(98, 45, 9, 22),
(99, 27, 3, 45),
(100, 20, 10, 40);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `City` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Address` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Phone` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Email` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `NIP` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Remarks` text COLLATE utf32_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`ID`, `Name`, `City`, `Address`, `Phone`, `Email`, `NIP`, `Remarks`) VALUES
(1, 'Bayer HealthCare Consumer Care', 'Oubei', '549 Shasta Drive', '668 122 104', 'fvonderempten0@dyndns.org', '395-603-78-25', 'Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt.'),
(2, 'Nelco Laboratories, Inc.', 'Kiuola', '1 Kim Terrace', '610 178 787', 'kbudnk1@photobucket.com', '434-129-00-78', 'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis.'),
(3, 'Physicians Total Care, Inc.', 'Dłutów', '0 Bayside Center', '204 283 172', 'asutty2@soup.io', '118-191-26-91', 'Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.'),
(4, 'Lake Erie Medical DBA Quality Care Products LLC', 'Selce', '59 Pond Center', '897 666 029', 'tyggo3@exblog.jp', '454-421-92-72', 'Donec posuere metus vitae ipsum. Aliquam non mauris.'),
(5, 'Wakefern Food Corporation', 'Changsha', '9 Declaration Alley', '252 414 063', 'ksherman4@bloomberg.com', '371-573-43-65', 'Nullam varius.'),
(6, 'Nelco Laboratories, Inc.', 'San Agustin', '28 Doe Crossing Point', '024 461 912', 'hturner5@apple.com', '743-449-77-30', 'Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.'),
(7, 'The Mentholatum Company', 'Sapol', '71881 Portage Park', '420 878 998', 'wmuston6@wikipedia.org', '497-071-68-79', 'Fusce posuere felis sed lacus.'),
(8, 'Medline Industries, Inc.', 'Altanbulag', '9 Fieldstone Center', '683 451 526', 'emulqueen7@cbsnews.com', '554-700-91-65', 'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.'),
(9, 'Combe Incorporated', 'Jeziorzany', '5 Quincy Pass', '767 194 060', 'dbirth8@java.com', '358-753-68-84', 'Maecenas ut massa quis augue luctus tincidunt.'),
(10, 'CVS Pharmacy', 'Ladushkin', '823 Hermina Point', '679 871 821', 'xcobain9@histats.com', '203-229-07-98', 'Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est.');

-- --------------------------------------------------------

--
-- Table structure for table `workers`
--

CREATE TABLE `workers` (
  `ID` int(11) NOT NULL,
  `Firstname` varchar(9) COLLATE utf32_polish_ci NOT NULL,
  `Surname` varchar(12) COLLATE utf32_polish_ci NOT NULL,
  `City` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Address` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Phone` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Email` varchar(27) COLLATE utf32_polish_ci NOT NULL,
  `PESEL` varchar(11) COLLATE utf32_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `workers`
--

INSERT INTO `workers` (`ID`, `Firstname`, `Surname`, `City`, `Address`, `Phone`, `Email`, `PESEL`) VALUES
(1, 'Guenevere', 'Lowe', 'Banyuurip', '742 Almo Way', '184 784 579', 'glowe0@de.vu', '56600914566'),
(2, 'Dynah', 'Dislee', 'Rouen', '5960 Orin Parkway', '829 471 951', 'ddislee1@technorati.com', '76849867867'),
(3, 'Andy', 'Rainton', 'Liugong', '12 Carpenter Circle', '472 157 293', 'arainton2@wikimedia.org', '76047898732'),
(4, 'Roderic', 'Lovekin', 'Guararé', '0 Hooker Crossing', '860 225 482', 'rlovekin3@deliciousdays.com', '67462588267'),
(5, 'Hervey', 'Braddon', 'Winnica', '872 Bunker Hill Junction', '345 136 148', 'hbraddon4@wunderground.com', '69610581562'),
(6, 'Roxine', 'Mooney', 'Wilwerwiltz', '44 Farragut Pass', '763 195 962', 'rmooney5@state.gov', '45450380298'),
(7, 'Nevsa', 'Peaseman', 'Sigu', '01028 Huxley Park', '239 343 913', 'npeaseman6@slashdot.org', '20588024624'),
(8, 'Kermit', 'Riteley', 'Wewoloe', '9 Crownhardt Court', '034 115 987', 'kriteley7@exblog.jp', '29294454994'),
(9, 'Carmine', 'Franzettoini', '‘Abasān al Kabīrah', '6263 Melvin Pass', '849 379 690', 'cfranzettoini8@ocn.ne.jp', '05668980914'),
(10, 'Marsiella', 'Yosifov', 'Yangdang', '9669 Ridgeview Crossing', '719 700 982', 'myosifov9@hc360.com', '38193511599'),
(11, 'Baudoin', 'O\'Calleran', 'Memphis', '9564 Sommers Plaza', '678 344 700', 'bocallerana@topsy.com', '74797384497'),
(12, 'Atlanta', 'Swaddle', 'Burao', '0 Eastlawn Crossing', '256 917 588', 'aswaddleb@telegraph.co.uk', '61039012851'),
(13, 'Cleopatra', 'Caney', 'Jingzhou', '56 Londonderry Hill', '917 350 351', 'ccaneyc@csmonitor.com', '80940924771'),
(14, 'Rich', 'Satch', 'Gouqi', '6 Shopko Street', '797 718 150', 'rsatchd@vinaora.com', '57540155883'),
(15, 'Gale', 'Jacson', 'Jianxi', '7 Service Alley', '958 645 508', 'gjacsone@wufoo.com', '60625634329'),
(16, 'Shaun', 'Whalley', 'Ibarreta', '52 Warbler Parkway', '301 703 755', 'swhalleyf@wired.com', '74505547558'),
(17, 'Chicky', 'Rittmeier', 'Solna', '61483 Hovde Junction', '172 053 894', 'crittmeierg@soup.io', '24567751622'),
(18, 'Tabor', 'Sheer', 'Dorotea', '46020 Rusk Pass', '466 717 894', 'tsheerh@wikispaces.com', '75367436350'),
(19, 'Ignacio', 'Piatkow', 'Kissidougou', '685 Melvin Park', '858 835 507', 'ipiatkowi@sphinn.com', '99916293810'),
(20, 'Emma', 'Bradforth', 'Mospyne', '6 Karstens Lane', '429 354 897', 'ebradforthj@sbwire.com', '40994745722'),
(21, 'Flem', 'Reddick', 'Qobustan', '32644 Huxley Court', '045 945 348', 'freddickk@1688.com', '86955683870'),
(22, 'Si', 'Sabin', 'Quiriquire', '27036 Dexter Lane', '574 409 097', 'ssabinl@ehow.com', '40542243135'),
(23, 'Hastie', 'Bollins', 'Ledeč nad Sázavou', '829 Nobel Alley', '474 341 425', 'hbollinsm@howstuffworks.com', '44910005580'),
(24, 'Shanta', 'Camoletto', 'Balingoan', '94 Fairview Road', '582 137 259', 'scamoletton@newyorker.com', '83916123348'),
(25, 'Gaylord', 'Bumpas', 'Aulnay-sous-Bois', '0923 Sutherland Drive', '639 325 727', 'gbumpaso@ezinearticles.com', '50540048897'),
(26, 'Reena', 'Perrycost', 'Cuenca', '8 Derek Point', '685 435 952', 'rperrycostp@photobucket.com', '92595913418'),
(27, 'Giacobo', 'Cockin', 'Olovyannaya', '7851 North Court', '073 495 564', 'gcockinq@salon.com', '69477295923'),
(28, 'Conrado', 'Roalfe', 'Rimouski', '0182 Park Meadow Lane', '435 029 141', 'croalfer@princeton.edu', '00081786615'),
(29, 'Shara', 'MacElroy', 'Weishui', '545 Rigney Pass', '320 814 319', 'smacelroys@fastcompany.com', '86606906768'),
(30, 'Sapphire', 'Pole', 'Kaparéllion', '63 Kim Circle', '920 817 729', 'spolet@facebook.com', '63204854481');

-- --------------------------------------------------------

--
-- Table structure for table `workers_authentication`
--

CREATE TABLE `workers_authentication` (
  `ID` int(11) NOT NULL,
  `Worker_ID` int(11) NOT NULL,
  `Login` varchar(14) COLLATE utf32_polish_ci NOT NULL,
  `Password` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `Password_last_change` datetime NOT NULL,
  `UUID` varchar(50) COLLATE utf32_polish_ci NOT NULL,
  `RFID` varchar(4) COLLATE utf32_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_polish_ci;

--
-- Dumping data for table `workers_authentication`
--

INSERT INTO `workers_authentication` (`ID`, `Worker_ID`, `Login`, `Password`, `Password_last_change`, `UUID`, `RFID`) VALUES
(1, 1, 'glowe0', 'fWJVcCuvo', '2022-01-07 07:06:19', 'e4le7b0s-2mu1-cm34-2jic-lrtmva2swqjh', '0092'),
(2, 2, 'ddislee1', 'E6BH1jdlweMc', '2022-04-09 02:55:47', 'c652vlwg-52os-uy11-pxtp-vhgvj7o2rip0', '2440'),
(3, 3, 'arainton2', '409odurRiMJB', '2021-11-21 03:07:58', 'mh1yla1a-gg7a-x2c3-u4jn-6teihk2ytmix', '2773'),
(4, 4, 'rlovekin3', 'tSlIuN0l5U', '2021-12-23 18:53:16', 'b2g1ufvd-6ove-6wk4-mpfs-a0pg9jxey5nf', '1222'),
(5, 5, 'hbraddon4', '6zpajjOoO', '2022-02-05 01:59:55', 'qv5ift0c-jm7m-81xj-yxpc-o58okx1gppt4', '7994'),
(6, 6, 'rmooney5', 'Haua675', '2021-08-19 00:24:49', 'y6ch29k1-1v5w-ctfm-wgfx-w2esxaiikre9', '3401'),
(7, 7, 'npeaseman6', 'CZSkBv5', '2022-06-12 15:23:39', 'ssj4ehag-9xis-v5hd-foj8-vmjywa25b5r7', '4715'),
(8, 8, 'kriteley7', '9yA8WqtS', '2021-09-01 12:00:06', 'pisvrpgq-dq8k-ijbk-gzvr-bb2zez7yrob0', '7012'),
(9, 9, 'cfranzettoini8', '5ubhDYW0PV', '2021-07-23 07:30:54', '9jr06edl-74j7-61u7-zwcl-ocm0b9iixjke', '6898'),
(10, 10, 'myosifov9', 'H8YTFQL4', '2021-08-25 04:39:38', '6jjhtkj3-bt4v-81i7-l01k-eoeo5n574vtn', '2538'),
(11, 11, 'bocallerana', 'wTMwnxi1vVW9', '2021-12-11 06:18:38', 'b6tarvwx-b9gz-tufq-usbo-obq2g372dzfr', '9043'),
(12, 12, 'aswaddleb', 'US9Vrb', '2021-08-01 14:37:08', 'dyfxr68o-cnul-qeyj-9dws-lfs66yyz71jz', '4033'),
(13, 13, 'ccaneyc', 'S2SaegxEjd8G', '2022-01-23 20:38:39', 'c6t38229-lxfn-87mq-io00-69pelf1pwlp4', '6235'),
(14, 14, 'rsatchd', 'LVoGOYYNIpi', '2021-10-03 01:54:11', 'fwy2yk07-7ump-7yd7-q3a6-uwvb7jf0vzil', '7114'),
(15, 15, 'gjacsone', 'wcRckTXyJ7', '2022-02-12 05:37:42', 'k1ruiaep-twzk-850x-mdcq-th0d7unqlf9r', '7387'),
(16, 16, 'swhalleyf', 'OJqNX5OH', '2021-05-11 21:59:54', 'os9h74yr-ylqf-9zyi-cwry-jq93t3tyhx1c', '1053'),
(17, 17, 'crittmeierg', '43iJ3PquoGl', '2022-06-01 18:42:32', 'g6mcl37o-cgsk-ar2c-lkeq-ctawptpcby0w', '8741'),
(18, 18, 'tsheerh', 'jjgR0JkBeF', '2021-12-03 15:16:11', 'o171suy1-019n-xiac-okha-kamei86hlec0', '6011'),
(19, 19, 'ipiatkowi', 'P2H6JP', '2022-04-04 19:17:21', 'uprbrquc-lbed-rhqw-qs21-bbu9odwt3zxx', '7986'),
(20, 20, 'ebradforthj', 'T96uY2', '2022-01-23 17:24:39', 'r1gxtj1h-yzl7-hpvn-zqu1-9e4u9d0wzah2', '0697'),
(21, 21, 'freddickk', 'FBdwbAj4', '2021-07-22 23:13:33', 'bik1gl8c-vu6g-87hf-l0n4-qxjebyoultmr', '3983'),
(22, 22, 'ssabinl', '09wfDy', '2021-10-24 16:00:52', 'v2ghxbcs-meqc-zj4m-5pc6-f1it6q6uqhh2', '5555'),
(23, 23, 'hbollinsm', 'lW3X0fP', '2021-10-08 04:50:28', 'jvar7l2o-wjc2-lemg-8hma-hm1hfsfsxnkh', '4886'),
(24, 24, 'scamoletton', '06Ye3LilV', '2021-08-16 10:27:10', 'o9tc0w84-kh98-mw5i-7ocq-ljtyoq460nmn', '3384'),
(25, 25, 'gbumpaso', 'AZG80wLn', '2022-02-25 07:46:39', 'jkfd0kcq-nloc-cu8w-kow2-lymojjv4r0sm', '8037'),
(26, 26, 'rperrycostp', 'gfoRBnheRTS', '2021-12-30 14:20:50', 'ieuybzw0-3qdh-hdxo-hewk-ay0jc72hvqpv', '8190'),
(27, 27, 'gcockinq', 'OhuBgGRstjbG', '2021-12-09 14:47:34', 'p79x3srj-rm6o-17g5-nd6n-8kk6ljao2cwz', '8890'),
(28, 28, 'croalfer', 'HD3fciOX', '2021-12-20 08:35:55', '87safnbn-h49q-hlmj-yp5p-bxai9dlnosu7', '9054'),
(29, 29, 'smacelroys', 'dqdGK61t8B', '2021-12-13 09:58:59', 'zyhxf8f3-genf-3c67-0kyx-ac428df9vj9j', '9814');

-- --------------------------------------------------------

--
-- Stand-in structure for view `zamówienia`
-- (See below for the actual view)
--
CREATE TABLE `zamówienia` (
`ID Zamówienia` int(11)
,`Login Klienta` varchar(50)
,`Sklep` varchar(50)
,`Pracownik` varchar(22)
,`Nazwa Produktu` varchar(50)
,`Ilość` int(11)
);

-- --------------------------------------------------------

--
-- Structure for view `ordersview`
--
DROP TABLE IF EXISTS `ordersview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ordersview`  AS SELECT `orders`.`Order_ID` AS `orderID`, `clients`.`Login` AS `clientLogin`, `orders`.`Order_date` AS `orderDate`, `products`.`Name` AS `productName`, `orders`.`Quantity` AS `quantity`, `products`.`Price` AS `unitPrice`, `orders`.`Quantity`* `products`.`Price` AS `totalPrice`, `shops`.`City` AS `shop`, concat(`workers`.`Firstname`,' ',`workers`.`Surname`) AS `assignedTo` FROM ((((`orders` join `clients`) join `products`) join `shops`) join `workers`) WHERE `orders`.`Client_ID` like `clients`.`ID` AND `orders`.`Shop_ID` like `shops`.`ID` AND `orders`.`Worker_ID` like `workers`.`ID` AND `orders`.`Product_ID` like `products`.`ID``ID`  ;

-- --------------------------------------------------------

--
-- Structure for view `productssuppliers`
--
DROP TABLE IF EXISTS `productssuppliers`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `productssuppliers`  AS SELECT `delivery`.`ID` AS `deliveryID`, `products`.`Name` AS `productName`, `suppliers`.`Name` AS `supplierName`, `delivery`.`Price` AS `price`, `delivery`.`Amount` AS `amount` FROM ((`delivery` join `products`) join `suppliers`) WHERE `delivery`.`Product_ID` like `products`.`ID` AND `delivery`.`Supplier_ID` like `suppliers`.`ID``ID`  ;

-- --------------------------------------------------------

--
-- Structure for view `zamówienia`
--
DROP TABLE IF EXISTS `zamówienia`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `zamówienia`  AS SELECT `orders`.`Order_ID` AS `ID Zamówienia`, `clients`.`Login` AS `Login Klienta`, `shops`.`City` AS `Sklep`, concat(`workers`.`Firstname`,' ',`workers`.`Surname`) AS `Pracownik`, `products`.`Name` AS `Nazwa Produktu`, `orders`.`Quantity` AS `Ilość` FROM ((((`orders` join `clients`) join `shops`) join `workers`) join `products`) WHERE `orders`.`Client_ID` like `clients`.`ID` AND `orders`.`Shop_ID` like `shops`.`ID` AND `orders`.`Worker_ID` like `workers`.`ID` AND `orders`.`Product_ID` like `products`.`ID``ID`  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `contracts`
--
ALTER TABLE `contracts`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Worker_ID` (`Worker_ID`,`Shop_ID`),
  ADD KEY `Contracts_Shop_ID` (`Shop_ID`);

--
-- Indexes for table `delivery`
--
ALTER TABLE `delivery`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Delivery_Product_ID` (`Product_ID`),
  ADD KEY `Delivery_Supplier_ID` (`Supplier_ID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD UNIQUE KEY `Order_ID_2` (`Order_ID`),
  ADD KEY `Order_ID` (`Order_ID`),
  ADD KEY `Worker_ID` (`Worker_ID`),
  ADD KEY `Orders_Client_ID` (`Client_ID`),
  ADD KEY `Orders_Product_ID` (`Product_ID`),
  ADD KEY `Orders_Shop_ID` (`Shop_ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `shops`
--
ALTER TABLE `shops`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `shop_storage_status`
--
ALTER TABLE `shop_storage_status`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Shop_Storage_Status_Product_ID` (`Product_ID`),
  ADD KEY `Shop_Storage_Status_Shop_ID` (`Shop_ID`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `workers`
--
ALTER TABLE `workers`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `workers_authentication`
--
ALTER TABLE `workers_authentication`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Worker_ID` (`Worker_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `contracts`
--
ALTER TABLE `contracts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `delivery`
--
ALTER TABLE `delivery`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `shops`
--
ALTER TABLE `shops`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `shop_storage_status`
--
ALTER TABLE `shop_storage_status`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `workers`
--
ALTER TABLE `workers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `workers_authentication`
--
ALTER TABLE `workers_authentication`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `contracts`
--
ALTER TABLE `contracts`
  ADD CONSTRAINT `Contracts_Shop_ID` FOREIGN KEY (`Shop_ID`) REFERENCES `shops` (`ID`),
  ADD CONSTRAINT `Contracts_Worker_ID` FOREIGN KEY (`Worker_ID`) REFERENCES `workers` (`ID`);

--
-- Constraints for table `delivery`
--
ALTER TABLE `delivery`
  ADD CONSTRAINT `Delivery_Product_ID` FOREIGN KEY (`Product_ID`) REFERENCES `products` (`ID`),
  ADD CONSTRAINT `Delivery_Supplier_ID` FOREIGN KEY (`Supplier_ID`) REFERENCES `suppliers` (`ID`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `Orders_Client_ID` FOREIGN KEY (`Client_ID`) REFERENCES `clients` (`ID`),
  ADD CONSTRAINT `Orders_Product_ID` FOREIGN KEY (`Product_ID`) REFERENCES `products` (`ID`),
  ADD CONSTRAINT `Orders_Shop_ID` FOREIGN KEY (`Shop_ID`) REFERENCES `shops` (`ID`),
  ADD CONSTRAINT `Orders_Worker_ID` FOREIGN KEY (`Worker_ID`) REFERENCES `workers` (`ID`);

--
-- Constraints for table `shop_storage_status`
--
ALTER TABLE `shop_storage_status`
  ADD CONSTRAINT `Shop_Storage_Status_Product_ID` FOREIGN KEY (`Product_ID`) REFERENCES `products` (`ID`),
  ADD CONSTRAINT `Shop_Storage_Status_Shop_ID` FOREIGN KEY (`Shop_ID`) REFERENCES `shops` (`ID`);

--
-- Constraints for table `workers_authentication`
--
ALTER TABLE `workers_authentication`
  ADD CONSTRAINT `Workers_Authentication_Worker_ID` FOREIGN KEY (`Worker_ID`) REFERENCES `workers` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
