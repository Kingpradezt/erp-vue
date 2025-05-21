-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2025 at 05:21 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `luaren_erp`
--

-- --------------------------------------------------------

--
-- Table structure for table `app_users`
--

CREATE TABLE `app_users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `email_address` varchar(100) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `user_role` varchar(50) NOT NULL,
  `mobile_number` varchar(20) NOT NULL,
  `account_status` varchar(50) NOT NULL,
  `last_login_at` varchar(50) NOT NULL,
  `created_at` varchar(50) NOT NULL,
  `updated_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `app_users`
--

INSERT INTO `app_users` (`user_id`, `username`, `password_hash`, `email_address`, `full_name`, `user_role`, `mobile_number`, `account_status`, `last_login_at`, `created_at`, `updated_at`) VALUES
(1, 'luaren', 'password', 'luaren@info.com', 'Luaren ', 'Admin', '091234567890', 'Active', '2', '2', '2');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(11) NOT NULL,
  `sku` varchar(50) NOT NULL,
  `product_name` varchar(50) NOT NULL,
  `brand_id` varchar(50) NOT NULL,
  `category_id` varchar(50) NOT NULL,
  `order_date` varchar(50) NOT NULL,
  `arrival_date` varchar(50) NOT NULL,
  `expiry_date` varchar(50) NOT NULL,
  `quantity_in_stock` varchar(50) NOT NULL,
  `cost_price` varchar(50) NOT NULL,
  `srp_price` varchar(50) NOT NULL,
  `wholesale_price` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `is_active` varchar(50) NOT NULL,
  `created_at` varchar(50) NOT NULL,
  `updated_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `sku`, `product_name`, `brand_id`, `category_id`, `order_date`, `arrival_date`, `expiry_date`, `quantity_in_stock`, `cost_price`, `srp_price`, `wholesale_price`, `description`, `is_active`, `created_at`, `updated_at`) VALUES
(1, '1', 'Liptint ', '1', '1', '1', '1', '1', '100', '599', '650', '620', '', '1', '1', '1'),
(2, '2', 'Lipstick', '2', '2', '2', '2', '2', '200', '200', '300', '250', 'Liptint + Lipstick', '1', '2', '2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `app_users`
--
ALTER TABLE `app_users`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `app_users`
--
ALTER TABLE `app_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
