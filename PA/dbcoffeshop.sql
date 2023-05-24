-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2023 at 11:47 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbcoffeshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbaccount`
--

CREATE TABLE `tbaccount` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `fullName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phoneNumber` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbaccount`
--

INSERT INTO `tbaccount` (`id`, `username`, `password`, `fullName`, `email`, `phoneNumber`, `address`, `role`) VALUES
(1, 'admin', 'admin', 'Admin', 'admin@gmail.com', '0', '-', 'admin'),
(2, 'dinda', '061', 'Dinda Nur Afifah', 'dinda@gmail.com', '0', '-', 'admin'),
(3, 'eko', '068', 'Muhammad Dhimas Eko Wiyono', 'eko@gmail.com', '0', '-', 'admin'),
(4, 'muchlis', '069', 'Muhammad Muchlis Abimanyu', 'muchlis@gmail.com', '0', '-', 'admin'),
(5, 'bagas', '071', 'Dhimas Pramudya Tridharma', 'bagas@gmail.com', '0', '-', 'admin'),
(6, 'user', 'user', 'User', 'user@gmail.com', '0', '-', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `tbmenu`
--

CREATE TABLE `tbmenu` (
  `id` int(11) NOT NULL,
  `image` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `price` int(11) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbmenu`
--

INSERT INTO `tbmenu` (`id`, `image`, `name`, `price`, `description`) VALUES
(1, 'Americano.jpg', 'Americano', 25000, 'Americano is a coffee beverage made from espresso and hot water. Therefore, its contents consist of caffeine, antioxidants, and other compounds found in coffee beans, such as chlorogenic acid, caffeic acid, and trigonelline.'),
(2, 'Espresso.jpg', 'Espresso', 13000, 'Espresso is a concentrated coffee beverage that is made by forcing hot water through finely ground coffee beans.'),
(3, 'Cappucino.jpg', 'Cappucino', 17000, 'Cappuccino is a type of espresso-based coffee drink that originated in Italy. The drink is traditionally made with equal parts of espresso, steamed milk, and milk foam.');

-- --------------------------------------------------------

--
-- Table structure for table `tborder`
--

CREATE TABLE `tborder` (
  `id` int(11) NOT NULL,
  `menuName` varchar(255) NOT NULL,
  `menuPrice` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `customerFullName` varchar(255) NOT NULL,
  `customerAddress` varchar(255) NOT NULL,
  `customerPhoneNumber` varchar(255) NOT NULL,
  `paymentSlip` varchar(255) NOT NULL,
  `bankAccount` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tborder`
--

INSERT INTO `tborder` (`id`, `menuName`, `menuPrice`, `quantity`, `total`, `customerFullName`, `customerAddress`, `customerPhoneNumber`, `paymentSlip`, `bankAccount`, `status`) VALUES
(2, 'Americano', 25000, 10, 250000, 'User', '-', '0', 'PaymentSlipIdOrder = 2.jpg', '232', 'Paid'),
(9, 'Cappucino', 17000, 1, 17000, 'User', '-', '0', '-', '2323', 'Unpaid');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbaccount`
--
ALTER TABLE `tbaccount`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbmenu`
--
ALTER TABLE `tbmenu`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `tborder`
--
ALTER TABLE `tborder`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbaccount`
--
ALTER TABLE `tbaccount`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbmenu`
--
ALTER TABLE `tbmenu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tborder`
--
ALTER TABLE `tborder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
