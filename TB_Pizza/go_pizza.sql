-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jan 04, 2023 at 09:20 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tb_pesanpizza`
--

-- --------------------------------------------------------

--
-- Table structure for table `go_pizza`
--

CREATE TABLE `go_pizza` (
  `p_id` int(11) NOT NULL,
  `p_nama_pizza` text NOT NULL,
  `p_promo_mode` varchar(30) NOT NULL,
  `p_harga` int(11) NOT NULL,
  `p_gambar` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `go_pizza`
--

INSERT INTO `go_pizza` (`p_id`, `p_nama_pizza`, `p_promo_mode`, `p_harga`, `p_gambar`) VALUES
(1, 'Pizza Pepperoni', 'Hot!', 60000, '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `go_pizza`
--
ALTER TABLE `go_pizza`
  ADD PRIMARY KEY (`p_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `go_pizza`
--
ALTER TABLE `go_pizza`
  MODIFY `p_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
