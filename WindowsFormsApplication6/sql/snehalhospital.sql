-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 10, 2020 at 08:05 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `snehalhospital`
--

-- --------------------------------------------------------

--
-- Table structure for table `billpayment`
--

CREATE TABLE `billpayment` (
  `bid` int(11) NOT NULL,
  `pid` int(11) NOT NULL,
  `roomrent` int(11) DEFAULT NULL,
  `medicinecharges` int(11) DEFAULT NULL,
  `doctorcharges` int(11) DEFAULT NULL,
  `reportcharges` int(11) DEFAULT NULL,
  `othercharges` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `billpayment`
--

INSERT INTO `billpayment` (`bid`, `pid`, `roomrent`, `medicinecharges`, `doctorcharges`, `reportcharges`, `othercharges`, `total`) VALUES
(1, 1, 5000, 1000, 2000, 3000, 4000, 15000);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `userid` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`userid`, `password`, `firstname`, `lastname`) VALUES
('snc', 'snc', 'snehal', 'chauhan');

-- --------------------------------------------------------

--
-- Table structure for table `patientinfo`
--

CREATE TABLE `patientinfo` (
  `pid` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `gender` varchar(100) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `disease` varchar(100) DEFAULT NULL,
  `Date` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patientinfo`
--

INSERT INTO `patientinfo` (`pid`, `name`, `gender`, `age`, `address`, `disease`, `Date`) VALUES
(1, 'vipul', 'Male', 29, 'mehsana', 'cough', '9-3-2020');

-- --------------------------------------------------------

--
-- Table structure for table `roombooking`
--

CREATE TABLE `roombooking` (
  `roomno` int(11) NOT NULL,
  `roomtype` varchar(100) DEFAULT NULL,
  `price` int(11) NOT NULL,
  `startdate` varchar(100) DEFAULT NULL,
  `enddate` varchar(100) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `pid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `roombooking`
--

INSERT INTO `roombooking` (`roomno`, `roomtype`, `price`, `startdate`, `enddate`, `status`, `pid`) VALUES
(203, 'Delux', 5000, '10 March 2020', '12 March 2020', 'Occupied', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billpayment`
--
ALTER TABLE `billpayment`
  ADD PRIMARY KEY (`bid`),
  ADD KEY `billpayment_fk` (`pid`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `patientinfo`
--
ALTER TABLE `patientinfo`
  ADD PRIMARY KEY (`pid`);

--
-- Indexes for table `roombooking`
--
ALTER TABLE `roombooking`
  ADD PRIMARY KEY (`roomno`),
  ADD KEY `roombooking_fk` (`pid`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `billpayment`
--
ALTER TABLE `billpayment`
  ADD CONSTRAINT `billpayment_fk` FOREIGN KEY (`pid`) REFERENCES `patientinfo` (`pid`);

--
-- Constraints for table `roombooking`
--
ALTER TABLE `roombooking`
  ADD CONSTRAINT `roombooking_fk` FOREIGN KEY (`pid`) REFERENCES `patientinfo` (`pid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
