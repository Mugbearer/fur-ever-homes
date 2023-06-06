-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 06, 2023 at 07:17 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fureverhomes_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `account_id` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `first_name` varchar(30) NOT NULL,
  `last_name` varchar(30) NOT NULL,
  `contact_num` varchar(15) NOT NULL,
  `email_address` varchar(50) NOT NULL,
  `is_admin` varchar(10) NOT NULL DEFAULT 'false'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`account_id`, `username`, `password`, `first_name`, `last_name`, `contact_num`, `email_address`, `is_admin`) VALUES
(6, 'user123', 'password', 'Emma', 'Johnson', '45345224', 'emma.johnson@example.com', 'true'),
(7, 'coolguy82', 'password', 'Michael', 'Davis', '34535452523414', 'michael.davis@example.com', 'false'),
(8, 'superuser', 'password', 'Jennifer', 'Smith', '57352451123', 'jennifer.smith@example.com', 'false');

-- --------------------------------------------------------

--
-- Table structure for table `adoptions`
--

CREATE TABLE `adoptions` (
  `adoption_id` int(11) NOT NULL,
  `pet_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `date` varchar(30) NOT NULL,
  `status` varchar(15) NOT NULL DEFAULT 'pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `adoptions`
--

INSERT INTO `adoptions` (`adoption_id`, `pet_id`, `account_id`, `date`, `status`) VALUES
(7, 16, 7, 'March 11, 2023', 'pending'),
(8, 17, 7, 'March 11, 2023', 'pending'),
(9, 20, 8, 'March 11, 2023', 'pending'),
(10, 21, 8, 'March 11, 2023', 'pending'),
(11, 24, 6, 'March 11, 2023', 'pending'),
(13, 25, 6, 'March 11, 2023', 'pending'),
(15, 16, 6, '2023/06/06', 'pending');

-- --------------------------------------------------------

--
-- Table structure for table `pets`
--

CREATE TABLE `pets` (
  `pet_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `sex` varchar(15) NOT NULL,
  `birthdate` varchar(30) NOT NULL,
  `breed` varchar(30) NOT NULL,
  `image_url` varchar(100) NOT NULL,
  `description` varchar(255) NOT NULL,
  `date_registered` varchar(30) NOT NULL,
  `status` varchar(15) NOT NULL DEFAULT 'unconfirmed'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pets`
--

INSERT INTO `pets` (`pet_id`, `account_id`, `name`, `sex`, `birthdate`, `breed`, `image_url`, `description`, `date_registered`, `status`) VALUES
(16, 6, 'Max', 'Male', 'January 5, 2018', 'Labrador Retriever', 'https://i3.lensdump.com/i/6ls5zx.png', 'Friendly and playful. Loves to fetch.', 'March 10, 2018', 'confirmed'),
(17, 6, 'Luna', 'Female', 'April 12, 2019', 'Golden Retriever', 'https://i3.lensdump.com/i/6ls5zx.png', 'Energetic and affectionate. Enjoys long walks.', 'June 18, 2019', 'confirmed'),
(19, 6, 'Bella\r\n', 'Female', 'July 8, 2020', 'Poodle', 'https://i3.lensdump.com/i/6ls5zx.png', 'Elegant and smart. Non-shedding coat.', 'September 15, 2020', 'unconfirmed'),
(20, 7, 'Rocky\r\n', 'Male', 'March 21, 2016', 'Boxer', 'https://i3.lensdump.com/i/6ls5zx.png', 'Playful and strong. Great with kids.', 'May 2, 2016', 'confirmed'),
(21, 7, 'Daisy\r\n', 'Female', 'February 14, 2019', 'Beagle', 'https://i3.lensdump.com/i/6ls5zx.png', 'Curious and friendly. Loves to sniff around.', 'April 1, 2019', 'confirmed'),
(22, 7, 'Cooper\r\n', 'Male', 'September 19, 2015', 'Bulldog', 'https://i3.lensdump.com/i/6ls5zx.png', 'Easygoing and loyal. Enjoys lounging around.', 'November 5, 2015', 'unconfirmed'),
(23, 7, 'Lucy\r\n', 'Female', 'June 10, 2017', 'Siberian Husky', 'https://i3.lensdump.com/i/6ls5zx.png', 'Playful and adventurous. Requires plenty of exercise.', 'August 2, 2017', 'unconfirmed'),
(24, 8, 'Oliver\r\n', 'Male', 'December 2, 2021', 'French Bulldog', 'https://i3.lensdump.com/i/6ls5zx.png', 'Cute and affectionate. Enjoys cuddling.', 'January 15, 2022', 'confirmed'),
(25, 8, 'Coco\r\n', 'Female', 'May 3, 2018', 'Shih Tzu', 'https://i3.lensdump.com/i/6ls5zx.png', 'Gentle and loving. Requires regular grooming.', 'July 10, 2018', 'confirmed'),
(26, 8, 'Milo\r\n', 'Male', 'August 17, 2020', 'Dalmatian', 'https://i3.lensdump.com/i/6ls5zx.png', 'Playful and energetic. Has distinctive spots.', 'October 5, 2020', 'unconfirmed'),
(27, 8, 'Lily\r\n', 'Female', 'November 28, 2019', 'Ragdoll', 'https://i3.lensdump.com/i/6ls5zx.png', 'Calm and affectionate. Known for its soft coat.', 'January 10, 2020', 'unconfirmed');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`account_id`);

--
-- Indexes for table `adoptions`
--
ALTER TABLE `adoptions`
  ADD PRIMARY KEY (`adoption_id`),
  ADD KEY `adoptions_ibfk_2` (`pet_id`),
  ADD KEY `adoptions_ibfk_1` (`account_id`);

--
-- Indexes for table `pets`
--
ALTER TABLE `pets`
  ADD PRIMARY KEY (`pet_id`),
  ADD KEY `pets_ibfk_1` (`account_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `account_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `adoptions`
--
ALTER TABLE `adoptions`
  MODIFY `adoption_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `pets`
--
ALTER TABLE `pets`
  MODIFY `pet_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `adoptions`
--
ALTER TABLE `adoptions`
  ADD CONSTRAINT `adoptions_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `adoptions_ibfk_2` FOREIGN KEY (`pet_id`) REFERENCES `pets` (`pet_id`) ON DELETE CASCADE;

--
-- Constraints for table `pets`
--
ALTER TABLE `pets`
  ADD CONSTRAINT `pets_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
