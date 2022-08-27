-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 08, 2022 at 06:10 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studen`
--

-- --------------------------------------------------------

--
-- Table structure for table `student_tabel`
--

CREATE TABLE `student_tabel` (
  `ID` int(11) NOT NULL,
  `Name` varchar(60) NOT NULL,
  `Reg` varchar(60) NOT NULL,
  `Class` varchar(60) NOT NULL,
  `Section` varchar(60) NOT NULL,
  `CreateArt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student_tabel`
--

INSERT INTO `student_tabel` (`ID`, `Name`, `Reg`, `Class`, `Section`, `CreateArt`) VALUES
(6, 'as', 'lubu', 'dddd', 'bbbb', '2022-07-07 07:07:19'),
(7, 'dddd', 'bismillah', 'ddddd', 'dddd', '2022-07-07 07:15:10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student_tabel`
--
ALTER TABLE `student_tabel`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `student_tabel`
--
ALTER TABLE `student_tabel`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
