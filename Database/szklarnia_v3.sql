-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Lip 10, 2025 at 10:42 AM
-- Wersja serwera: 8.3.0
-- Wersja PHP: 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `szklarnia_v3`
--

DELIMITER $$
--
-- Procedury
--
DROP PROCEDURE IF EXISTS `AddAlarmParameters`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddAlarmParameters` (IN `userId` INT, IN `deviceId` INT)   BEGIN
    -- Dodaj trzy rekordy do tabeli parametry_alarmu dla nowego urządzenia
    INSERT INTO parametry_alarmu (User_Id, Device_Id, Parameter, Min_value, Max_value)
    VALUES (userId, deviceId, 'Temperature', NULL, NULL);
    
    INSERT INTO parametry_alarmu (User_Id, Device_Id, Parameter, Min_value, Max_value)
    VALUES (userId, deviceId, 'Humidity', NULL, NULL);
    
    INSERT INTO parametry_alarmu (User_Id, Device_Id, Parameter, Min_value, Max_value)
    VALUES (userId, deviceId, 'Insolation', NULL, NULL);
END$$

DROP PROCEDURE IF EXISTS `ChangeDeviceDescription`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ChangeDeviceDescription` (IN `user_token` INT, IN `device_serial_number` VARCHAR(255), IN `new_description` VARCHAR(255))   BEGIN
    DECLARE user_id INT;
    DECLARE user_exists BOOLEAN DEFAULT FALSE;

    -- Sprawdzenie, czy użytkownik o podanym tokenie i statusie 1 istnieje
    SELECT Id INTO user_id
    FROM ogrodnik
    WHERE Token = user_token AND Status = 1
    LIMIT 1;

    IF user_id IS NOT NULL THEN
        SET user_exists = TRUE;
    END IF;

    -- Jeśli użytkownik istnieje, zaktualizuj opis urządzenia o podanym numerze seryjnym
    IF user_exists THEN
        UPDATE urzadzenie
        SET Description = new_description
        WHERE Serial_number = device_serial_number;
        
        IF ROW_COUNT() > 0 THEN
            SELECT 'Device description updated successfully' AS Message;
        ELSE
            SELECT 'Device with specified serial number not found' AS Error;
        END IF;
    ELSE
        -- Jeśli użytkownik nie istnieje lub ma status inny niż 1, zwróć błąd
        SELECT 'User does not exist or is inactive' AS Error;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `ChangeUserCredentials`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ChangeUserCredentials` (IN `user_token` INT, IN `user_login` VARCHAR(255), IN `new_password` VARCHAR(255), IN `new_description` VARCHAR(255))   BEGIN
    DECLARE user_id INT;
    DECLARE user_exists BOOLEAN DEFAULT FALSE;

    -- Sprawdzenie, czy użytkownik o podanym tokenie i statusie 1 istnieje
    SELECT Id INTO user_id
    FROM ogrodnik
    WHERE Token = user_token AND Status = 1
    LIMIT 1;

    IF user_id IS NOT NULL THEN
        SET user_exists = TRUE;
    END IF;

    -- Jeśli użytkownik istnieje, zaktualizuj hasło i opis użytkownika o podanym loginie
    IF user_exists THEN
        UPDATE ogrodnik
        SET Password = new_password, Description = new_description
        WHERE Login = user_login;
        
        IF ROW_COUNT() > 0 THEN
            SELECT 'Credentials updated successfully' AS Message;
        ELSE
            SELECT 'User with specified login not found' AS Error;
        END IF;
    ELSE
        -- Jeśli użytkownik nie istnieje lub ma status inny niż 1, zwróć błąd
        SELECT 'User does not exist or is inactive' AS Error;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `CheckAndAddAlarm`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CheckAndAddAlarm` ()   BEGIN
    DECLARE last_pomiar_id INT;
    DECLARE last_device_id INT;
    DECLARE last_temperature FLOAT;
    DECLARE last_humidity FLOAT;
    DECLARE last_insolation FLOAT;
    DECLARE alarm_id INT;
    DECLARE alarm_device_id INT;

    -- Pobranie ostatniego pomiaru
    SELECT ID, Device_id, Temperature, Humidity, Insolation
    INTO last_pomiar_id, last_device_id, last_temperature, last_humidity, last_insolation
    FROM pomiar
    ORDER BY ID DESC
    LIMIT 1;

    -- Sprawdzenie alarmów dla Temperature
    SET alarm_id = NULL;
    SET alarm_device_id = NULL;
    SELECT Id, Device_Id INTO alarm_id, alarm_device_id
    FROM parametry_alarmu
    WHERE Parameter = 'Temperature' 
      AND (last_temperature < Min_value OR last_temperature > Max_value)
      AND Device_Id = last_device_id
    LIMIT 1;
    
    IF alarm_id IS NOT NULL THEN
        INSERT INTO alarm (Parametry_Alarmu_Id, Pomiar_Id)
        VALUES (alarm_id, last_pomiar_id);
    END IF;

    -- Sprawdzenie alarmów dla Humidity
    SET alarm_id = NULL;
    SET alarm_device_id = NULL;
    SELECT Id, Device_Id INTO alarm_id, alarm_device_id
    FROM parametry_alarmu
    WHERE Parameter = 'Humidity' 
      AND (last_humidity < Min_value OR last_humidity > Max_value)
      AND Device_Id = last_device_id
    LIMIT 1;

    IF alarm_id IS NOT NULL THEN
        INSERT INTO alarm (Parametry_Alarmu_Id, Pomiar_Id)
        VALUES (alarm_id, last_pomiar_id);
    END IF;

    -- Sprawdzenie alarmów dla Insolation
    SET alarm_id = NULL;
    SET alarm_device_id = NULL;
    SELECT Id, Device_Id INTO alarm_id, alarm_device_id
    FROM parametry_alarmu
    WHERE Parameter = 'Insolation' 
      AND (last_insolation < Min_value OR last_insolation > Max_value)
      AND Device_Id = last_device_id
    LIMIT 1;

    IF alarm_id IS NOT NULL THEN
        INSERT INTO alarm (Parametry_Alarmu_Id, Pomiar_Id)
        VALUES (alarm_id, last_pomiar_id);
    END IF;

END$$

DROP PROCEDURE IF EXISTS `CreateNewDevice`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateNewDevice` (IN `userToken` INT, IN `serialNumber` INT, IN `deviceDescription` TEXT)   BEGIN
    DECLARE userId INT;
    DECLARE deviceId INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma status=1
    SELECT Id INTO userId FROM ogrodnik WHERE token = userToken AND status = 1;
    
    IF userId IS NOT NULL THEN
        -- Utwórz nowe urządzenie
        INSERT INTO urzadzenie (serial_number, description,status) VALUES (serialNumber, deviceDescription,1);
        SET deviceId = LAST_INSERT_ID(); -- Pobierz ID ostatnio wstawionego urządzenia
		
        -- Wywołaj drugą procedurę do dodawania parametrów alarmowych dla tego urządzenia
        CALL AddAlarmParameters(userId, serialNumber);

        SELECT 'Nowe urządzenie zostało dodane.' AS message;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `CreateNewUser`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateNewUser` (IN `userToken` INT, IN `userLogin` VARCHAR(50), IN `userPassword` VARCHAR(50), IN `userDescription` TEXT)   BEGIN
    DECLARE userCount INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma odpowiednie uprawnienia
    SELECT COUNT(*) INTO userCount FROM ogrodnik WHERE token = userToken AND status = 1;

    IF userCount > 0 THEN
        -- Utwórz nowego użytkownika
        INSERT INTO ogrodnik (login, password, description)
        VALUES (userLogin, userPassword, userDescription);

        SELECT 'Nowy użytkownik został utworzony.' AS message;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `GetAlarmParametersByTokenAndDeviceId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAlarmParametersByTokenAndDeviceId` (IN `user_token` INT, IN `device_id` INT)   BEGIN
    DECLARE user_id INT DEFAULT NULL;

    -- Sprawdzenie czy użytkownik istnieje i pobranie jego Id
    SELECT Id INTO user_id
    FROM ogrodnik
    WHERE token = user_token
    LIMIT 1;

    -- Jeśli użytkownik nie istnieje, zakończ procedurę
    IF user_id IS NULL THEN
        SELECT 'User not found' AS message;
    ELSE
        -- Zwrócenie parametrów alarmu dla danego device_id i użytkownika,
        -- gdzie Min_value i Max_value nie są NULL
        SELECT *
        FROM parametry_alarmu
        WHERE User_Id = user_id 
          AND Device_Id = device_id
          AND Min_value IS NOT NULL
          AND Max_value IS NOT NULL;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `GetAllDevices`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllDevices` (IN `userToken` INT)   BEGIN
    DECLARE userCount INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma status=1
    SELECT COUNT(*) INTO userCount FROM ogrodnik WHERE token = userToken AND status = 1;

    IF userCount > 0 THEN
        -- Pobierz listę wszystkich urządzeń
        SELECT * FROM urzadzenie;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `GetAllUsersExceptCaller`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllUsersExceptCaller` (IN `userToken` INT)   BEGIN
    DECLARE callerCount INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma status=1
    SELECT COUNT(*) INTO callerCount FROM ogrodnik WHERE token = userToken AND status = 1;

    IF callerCount > 0 THEN
        -- Pobierz wszystkich użytkowników, z wyjątkiem użytkownika wywołującego procedurę
        SELECT * FROM ogrodnik WHERE token <> userToken;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `GetLatestMeasurementByDeviceId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLatestMeasurementByDeviceId` (IN `userToken` INT, IN `deviceId` INT)   BEGIN
    DECLARE userCount INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma odpowiednie uprawnienia
    SELECT COUNT(*) INTO userCount FROM ogrodnik WHERE token = userToken AND status = 1;

    IF userCount > 0 THEN
        -- Pobierz najnowszy pomiar dla określonego Device_Id
        SELECT * FROM pomiar WHERE Device_Id = deviceId ORDER BY date_time DESC LIMIT 1;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `GetMeasurementsByDeviceId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetMeasurementsByDeviceId` (IN `userToken` INT, IN `deviceId` INT)   BEGIN
    DECLARE userCount INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma odpowiednie uprawnienia
    SELECT COUNT(*) INTO userCount FROM ogrodnik WHERE token = userToken AND status = 1;

    IF userCount > 0 THEN
        -- Pobierz pomiary dla określonego Device_Id
        SELECT * FROM pomiar WHERE Device_Id = deviceId;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `GetUserAlarmsByDevice`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUserAlarmsByDevice` (IN `user_token` INT, IN `device_id` INT)   BEGIN
    DECLARE user_id INT;
    DECLARE user_exists BOOLEAN DEFAULT FALSE;

    -- Sprawdzenie, czy użytkownik o podanym tokenie i statusie 1 istnieje
    SELECT Id INTO user_id
    FROM ogrodnik
    WHERE Token = user_token AND Status = 1
    LIMIT 1;

    IF user_id IS NOT NULL THEN
        SET user_exists = TRUE;
    END IF;

    -- Jeśli użytkownik istnieje, zwróć alarmy zdefiniowane przez tego użytkownika
    IF user_exists THEN
        SELECT a.*
        FROM alarm a
        JOIN parametry_alarmu p ON a.Parametry_Alarmu_Id = p.Id
        WHERE p.User_Id = user_id AND p.Device_Id = device_id AND a.Status = 1;
    ELSE
        -- Jeśli użytkownik nie istnieje, zwróć pusty wynik
        SELECT 'User does not exist or is inactive' AS ErrorMessage;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `LoginUser`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoginUser` (IN `loginParam` VARCHAR(50), IN `passwordParam` VARCHAR(50))   BEGIN
    -- Deklaracja zmiennej do przechowywania statusu i tokena
    DECLARE userStatus INT;
    DECLARE tokenVal INT;

    -- Sprawdź czy użytkownik jest już zalogowany
    SELECT `status` INTO userStatus FROM ogrodnik WHERE `login` = loginParam;

    IF userStatus = 1 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Użytkownik jest już zalogowany.';
    ELSE
        -- Sprawdź czy istnieje użytkownik o podanym loginie i haśle
        IF EXISTS (SELECT 1 FROM ogrodnik WHERE `login` = loginParam AND `password` = passwordParam) THEN
            -- Ustaw status na 1 dla zalogowanego użytkownika
            UPDATE ogrodnik SET `status` = 1 WHERE `login` = loginParam;

            -- Wygeneruj losowy token jako liczba z zakresu 1-99999
            SET tokenVal = FLOOR(RAND() * 99999) + 1;

            -- Zaktualizuj token dla zalogowanego użytkownika
            UPDATE ogrodnik SET token = tokenVal WHERE `login` = loginParam;

            -- Zwróć token do aplikacji
            SELECT tokenVal AS token;
        ELSE
            -- Jeśli nie ma użytkownika o podanych danych, zwróć komunikat błędu
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Niepoprawny login lub hasło.';
        END IF;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `ResetUserStatusByToken`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ResetUserStatusByToken` (IN `userToken` INT)   BEGIN
    DECLARE userCount INT;

    -- Sprawdź czy istnieje użytkownik o podanym tokenie
    SELECT COUNT(*) INTO userCount FROM ogrodnik WHERE token = userToken;

    IF userCount > 0 THEN
        -- Zresetuj status dla użytkownika o podanym tokenie
        UPDATE ogrodnik SET `status` = 0 WHERE token = userToken;
        SELECT 'Status zresetowany dla użytkownika o podanym tokenie.' AS message;
    ELSE
        SELECT 'Brak użytkownika o podanym tokenie.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `UpdateAlarmParameters`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateAlarmParameters` (IN `userToken` INT, IN `serialNumber` INT, IN `parameterName` VARCHAR(50), IN `downValue` INT, IN `topValue` INT)   BEGIN
    DECLARE userId INT;
    DECLARE deviceId INT;

    -- Sprawdź czy użytkownik o podanym tokenie istnieje i ma status=1
    SELECT Id INTO userId FROM ogrodnik WHERE token = userToken AND status = 1;
    
    IF userId IS NOT NULL THEN
        -- Pobierz ID urządzenia na podstawie serial_number
        SELECT Id INTO deviceId FROM urzadzenie WHERE serial_number = serialNumber;

        IF deviceId IS NOT NULL THEN
            -- Aktualizuj Min_value oraz Max_value w tabeli parametry_alarmu
            UPDATE parametry_alarmu SET Min_value = downValue, Max_value = topValue 
            WHERE Device_Id = serialNumber AND Parameter = parameterName;

            SELECT 'Parametry alarmowe zostały zaktualizowane.' AS message;
        ELSE
            SELECT 'Nie znaleziono urządzenia o podanym numerze seryjnym.' AS message;
        END IF;
    ELSE
        SELECT 'Brak uprawnień lub niepoprawny token.' AS message;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `UpdateAlarmStatusByTokenAndDeviceId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateAlarmStatusByTokenAndDeviceId` (IN `user_token` INT, IN `device_id` INT)   BEGIN
    DECLARE user_id INT DEFAULT NULL;

    -- Sprawdzenie czy użytkownik istnieje i pobranie jego Id oraz status
    SELECT Id INTO user_id
    FROM ogrodnik
    WHERE token = user_token AND status = 1
    LIMIT 1;

    -- Jeśli użytkownik nie istnieje lub jego status nie jest równy 1, zakończ procedurę
    IF user_id IS NULL THEN
        SELECT 'User not found or inactive' AS message;
    ELSE
        -- Aktualizacja statusu alarmów dla danego device_id
        UPDATE alarm
        SET Status = 0
        WHERE Parametry_Alarmu_Id IN (
            SELECT Id
            FROM parametry_alarmu
            WHERE Device_Id = device_id
        );
        SELECT 'Alarms updated' AS message;
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `alarm`
--

DROP TABLE IF EXISTS `alarm`;
CREATE TABLE IF NOT EXISTS `alarm` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Parametry_Alarmu_Id` int NOT NULL,
  `Pomiar_Id` int NOT NULL,
  `Status` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  KEY `alarm_to_parametry` (`Parametry_Alarmu_Id`),
  KEY `alarm_to_pomiar` (`Pomiar_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=190 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `alarm`
--

INSERT INTO `alarm` (`Id`, `Parametry_Alarmu_Id`, `Pomiar_Id`, `Status`) VALUES
(65, 31, 65, 0),
(66, 32, 65, 0),
(67, 33, 65, 0),
(68, 32, 66, 0),
(69, 33, 66, 0),
(70, 32, 67, 0),
(71, 33, 67, 0),
(72, 32, 68, 0),
(73, 33, 68, 0),
(74, 33, 69, 0),
(75, 33, 70, 0),
(76, 33, 71, 0),
(77, 33, 72, 0),
(78, 33, 73, 0),
(79, 33, 74, 0),
(80, 33, 75, 0),
(81, 33, 76, 0),
(82, 32, 77, 0),
(83, 33, 77, 0),
(84, 32, 78, 0),
(85, 33, 78, 0),
(86, 32, 79, 0),
(87, 33, 79, 0),
(88, 32, 80, 0),
(89, 33, 80, 0),
(90, 32, 81, 0),
(91, 33, 81, 0),
(92, 32, 82, 0),
(93, 33, 82, 0),
(94, 32, 83, 0),
(95, 33, 83, 0),
(96, 32, 84, 0),
(97, 33, 84, 0),
(98, 32, 85, 0),
(99, 33, 85, 0),
(100, 32, 86, 0),
(101, 33, 86, 0),
(102, 32, 87, 0),
(103, 33, 87, 0),
(104, 32, 88, 0),
(105, 33, 88, 0),
(106, 32, 89, 0),
(107, 33, 89, 0),
(108, 32, 90, 0),
(109, 33, 90, 0),
(110, 32, 91, 0),
(111, 33, 91, 0),
(112, 31, 92, 0),
(113, 32, 92, 0),
(114, 33, 92, 0),
(115, 31, 93, 0),
(116, 32, 93, 0),
(117, 33, 93, 0),
(118, 31, 94, 0),
(119, 32, 94, 0),
(120, 33, 94, 0),
(121, 31, 95, 0),
(122, 32, 95, 0),
(123, 33, 95, 0),
(124, 31, 96, 0),
(125, 32, 96, 0),
(126, 33, 96, 0),
(127, 31, 97, 0),
(128, 32, 97, 0),
(129, 33, 97, 0),
(130, 31, 98, 0),
(131, 32, 98, 0),
(132, 33, 98, 0),
(133, 31, 99, 0),
(134, 32, 99, 0),
(135, 33, 99, 0),
(136, 31, 100, 0),
(137, 32, 100, 0),
(138, 33, 100, 0),
(139, 31, 101, 0),
(140, 32, 101, 0),
(141, 33, 101, 0),
(142, 31, 102, 0),
(143, 32, 102, 0),
(144, 33, 102, 0),
(145, 31, 103, 0),
(146, 32, 103, 0),
(147, 33, 103, 0),
(148, 31, 104, 0),
(149, 32, 104, 0),
(150, 33, 104, 0),
(151, 31, 105, 0),
(152, 32, 105, 0),
(153, 33, 105, 0),
(154, 31, 106, 0),
(155, 32, 106, 0),
(156, 33, 106, 0),
(157, 31, 107, 0),
(158, 32, 107, 0),
(159, 33, 107, 0),
(160, 31, 108, 0),
(161, 32, 108, 0),
(162, 33, 108, 0),
(163, 31, 109, 0),
(164, 32, 109, 0),
(165, 33, 109, 0),
(166, 31, 110, 0),
(167, 32, 110, 0),
(168, 33, 110, 0),
(169, 31, 111, 0),
(170, 32, 111, 0),
(171, 33, 111, 0),
(172, 31, 112, 0),
(173, 32, 112, 0),
(174, 33, 112, 0),
(175, 31, 113, 1),
(176, 32, 113, 1),
(177, 33, 113, 1),
(178, 31, 114, 1),
(179, 32, 114, 1),
(180, 33, 114, 1),
(181, 31, 115, 1),
(182, 32, 115, 1),
(183, 33, 115, 1),
(184, 31, 116, 1),
(185, 32, 116, 1),
(186, 33, 116, 1),
(187, 31, 117, 1),
(188, 32, 117, 1),
(189, 33, 117, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ogrodnik`
--

DROP TABLE IF EXISTS `ogrodnik`;
CREATE TABLE IF NOT EXISTS `ogrodnik` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `login` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '0',
  `token` int NOT NULL,
  `Description` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `login` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `ogrodnik`
--

INSERT INTO `ogrodnik` (`Id`, `login`, `password`, `status`, `token`, `Description`) VALUES
(1, 'prime', 'admin', 0, 85327, ''),
(2, 'test', '123', 0, 33846, 'fajnie'),
(3, 'kuba', '2121', 0, 62710, ''),
(4, 'wojtek', '', 0, 0, '');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `parametry_alarmu`
--

DROP TABLE IF EXISTS `parametry_alarmu`;
CREATE TABLE IF NOT EXISTS `parametry_alarmu` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `User_Id` int NOT NULL,
  `Device_Id` int NOT NULL,
  `Parameter` varchar(50) NOT NULL,
  `Min_value` float DEFAULT NULL,
  `Max_value` float DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `alarm_to_user` (`User_Id`),
  KEY `alarm_to_device` (`Device_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `parametry_alarmu`
--

INSERT INTO `parametry_alarmu` (`Id`, `User_Id`, `Device_Id`, `Parameter`, `Min_value`, `Max_value`) VALUES
(31, 3, 1234, 'Temperature', 20, 25),
(32, 3, 1234, 'Humidity', 20, 30),
(33, 3, 1234, 'Insolation', 20, 30),
(34, 1, 1234, 'Temperature', 20, 25),
(35, 1, 1234, 'Humidity', NULL, NULL),
(36, 1, 1234, 'Insolation', NULL, NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pomiar`
--

DROP TABLE IF EXISTS `pomiar`;
CREATE TABLE IF NOT EXISTS `pomiar` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Device_id` int NOT NULL,
  `date_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Temperature` float NOT NULL,
  `Humidity` float NOT NULL,
  `Insolation` float NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `device_to_pomiar` (`Device_id`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `pomiar`
--

INSERT INTO `pomiar` (`Id`, `Device_id`, `date_time`, `Temperature`, `Humidity`, `Insolation`) VALUES
(17, 1, '2024-05-16 14:26:12', 26.2, 30, 0),
(18, 1, '2024-05-16 14:26:33', 26.7, 29, 0),
(19, 1, '2024-05-16 14:26:53', 26.7, 29, 0),
(20, 1, '2024-05-16 14:27:14', 27.1, 29, 0),
(21, 1, '2024-05-16 14:27:34', 27.1, 29, 0),
(22, 1, '2024-05-16 14:27:55', 27.6, 29, 0),
(23, 1, '2024-05-16 14:28:15', 27.6, 29, 0),
(24, 1, '2024-05-16 14:28:35', 27.6, 28, 0),
(25, 1, '2024-05-16 14:28:56', 28, 27, 0),
(26, 1, '2024-05-16 14:29:16', 28, 26, 0),
(27, 1, '2024-05-16 14:29:36', 28, 27, 0),
(28, 1, '2024-05-16 14:29:57', 28.2, 27, 0),
(29, 1, '2024-05-16 14:30:17', 28.5, 27, 0),
(30, 1, '2024-05-16 14:30:37', 28.5, 27, 0),
(31, 1, '2024-05-16 14:30:58', 28.5, 26, 0),
(32, 1, '2024-05-16 14:31:19', 28.5, 26, 0),
(33, 1, '2024-05-16 14:31:39', 28.5, 26, 0),
(36, 1234, '2024-05-25 17:28:08', 26.2, 45, 1179),
(37, 1234, '2024-05-25 17:28:30', 26.2, 46, 1205.2),
(38, 1234, '2024-05-25 17:28:51', 26.2, 46, 1205.2),
(39, 1234, '2024-05-25 17:29:12', 26.2, 46, 1205.2),
(40, 1234, '2024-05-25 17:29:34', 26.7, 51, 1361.7),
(41, 1234, '2024-05-25 17:29:55', 26.7, 48, 1281.6),
(42, 1234, '2024-05-25 17:30:16', 26.7, 47, 1254.9),
(43, 1234, '2024-05-25 17:30:37', 40, 46, 1228.2),
(44, 1234, '2024-05-25 17:30:59', 26.7, 46, 1228.2),
(45, 1234, '2024-05-25 17:31:23', 26.7, 45, 1201.5),
(46, 1234, '2024-05-25 17:31:48', 26.2, 45, 1179),
(47, 1234, '2024-05-25 17:32:09', 26.2, 45, 1179),
(48, 1234, '2024-05-25 17:32:31', 26.2, 45, 1179),
(49, 1234, '2024-05-25 17:32:52', 26.2, 45, 1179),
(50, 1234, '2024-05-25 17:33:13', 26.2, 45, 1179),
(51, 1234, '2024-05-25 17:33:38', 26.2, 45, 1179),
(52, 1234, '2024-05-25 17:34:01', 26.2, 46, 1205.2),
(53, 1234, '2024-05-25 17:34:22', 26.2, 46, 1205.2),
(54, 1234, '2024-05-25 17:34:43', 26.2, 46, 1205.2),
(55, 1234, '2024-05-25 17:35:05', 26.2, 46, 1205.2),
(56, 1234, '2024-05-25 17:35:29', 26.2, 46, 1205.2),
(57, 1234, '2024-05-25 17:35:54', 26.2, 46, 1205.2),
(58, 1234, '2024-05-25 17:36:15', 26.2, 46, 1205.2),
(59, 1234, '2024-05-25 17:36:36', 26.2, 46, 1205.2),
(60, 1234, '2024-05-25 17:36:58', 26.2, 46, 1205.2),
(61, 1234, '2024-05-25 17:37:22', 26.2, 46, 1205.2),
(62, 1234, '2024-05-25 17:37:43', 26.2, 46, 1205.2),
(63, 1234, '2024-05-25 17:57:12', 26.2, 47, 1231.4),
(64, 1234, '2024-05-25 17:57:33', 26.2, 47, 1231.4),
(65, 1234, '2024-05-25 17:57:55', 40, 46, 1205.2),
(66, 1234, '2024-05-27 16:21:51', 27.6, 31, 855.6),
(67, 1234, '2024-05-27 16:22:12', 27.6, 31, 855.6),
(68, 1234, '2024-05-27 16:22:33', 27.6, 31, 855.6),
(69, 1234, '2024-05-27 16:22:55', 27.6, 30, 828),
(70, 1234, '2024-05-27 16:23:16', 27.6, 30, 828),
(71, 1234, '2024-05-27 16:23:37', 27.6, 30, 828),
(72, 1234, '2024-05-27 16:24:01', 27.6, 30, 828),
(73, 1234, '2024-05-27 16:24:26', 27.6, 30, 828),
(74, 1234, '2024-05-27 16:24:49', 27.6, 30, 828),
(75, 1234, '2024-05-27 16:31:25', 27.6, 30, 828),
(76, 1234, '2024-05-27 16:44:51', 27.6, 30, 828),
(77, 1234, '2024-05-30 15:55:04', 25.8, 43, 1109.4),
(78, 1234, '2024-05-30 15:55:25', 25.8, 43, 1109.4),
(79, 1234, '2024-05-30 15:55:46', 26.2, 42, 1100.4),
(80, 1234, '2024-05-30 15:56:08', 26.2, 42, 1100.4),
(81, 1234, '2024-05-30 15:56:29', 26.2, 42, 1100.4),
(82, 1234, '2024-05-30 15:56:50', 26.2, 42, 1100.4),
(83, 1234, '2024-05-30 15:57:12', 26.2, 42, 1100.4),
(84, 1234, '2024-05-30 15:57:33', 26.7, 42, 1121.4),
(85, 1234, '2024-06-06 18:52:05', 28.5, 47, 1339.5),
(86, 1234, '2024-06-06 18:52:28', 28.5, 47, 1339.5),
(87, 1234, '2024-06-06 18:52:50', 28.5, 47, 1339.5),
(88, 1234, '2024-06-06 18:53:12', 28.9, 72, 2080.8),
(89, 1234, '2024-06-06 18:53:33', 29.3, 72, 2109.6),
(90, 1234, '2024-06-06 18:53:54', 29.3, 57, 1670.1),
(91, 1234, '2024-06-06 18:54:16', 28.9, 49, 1416.1),
(92, 1234, '2024-06-06 19:08:14', 28, 47, 1316),
(93, 1234, '2024-06-06 19:08:35', 28, 47, 1316),
(94, 1234, '2024-06-06 19:08:57', 28, 48, 1344),
(95, 1234, '2024-06-06 19:09:19', 28, 47, 1316),
(96, 1234, '2024-06-06 19:09:40', 28, 46, 1288),
(97, 1234, '2024-06-06 19:10:02', 28, 47, 1316),
(98, 1234, '2024-06-06 19:10:23', 28, 47, 1316),
(99, 1234, '2024-06-06 19:10:45', 28, 47, 1316),
(100, 1234, '2024-06-06 19:11:06', 28.5, 48, 1368),
(101, 1234, '2024-06-06 19:11:28', 28.5, 47, 1339.5),
(102, 1234, '2024-06-06 19:11:49', 28.5, 46, 1311),
(103, 1234, '2024-06-06 19:12:10', 28.5, 46, 1311),
(104, 1234, '2024-06-06 19:12:34', 28.2, 46, 1297.2),
(105, 1234, '2024-06-06 19:12:56', 28.5, 46, 1311),
(106, 1234, '2024-06-06 19:13:17', 28.5, 46, 1311),
(107, 1234, '2024-06-06 19:13:38', 28.5, 46, 1311),
(108, 1234, '2024-06-06 19:14:00', 28.5, 46, 1311),
(109, 1234, '2024-06-06 19:14:13', 28.5, 46, 1311),
(110, 1234, '2024-06-06 19:14:34', 28.5, 46, 1311),
(111, 1234, '2024-06-06 19:14:55', 28.5, 46, 1311),
(112, 1234, '2024-06-06 19:15:17', 28.5, 45, 1282.5),
(113, 1234, '2024-06-06 19:15:38', 28.5, 45, 1282.5),
(114, 1234, '2024-06-06 19:15:59', 28.5, 46, 1311),
(115, 1234, '2024-06-06 19:16:21', 28.5, 45, 1282.5),
(116, 1234, '2024-06-06 19:16:42', 28.5, 46, 1311),
(117, 1234, '2024-06-06 19:17:03', 28.5, 46, 1311);

--
-- Wyzwalacze `pomiar`
--
DROP TRIGGER IF EXISTS `CHECK ALARM`;
DELIMITER $$
CREATE TRIGGER `CHECK ALARM` AFTER INSERT ON `pomiar` FOR EACH ROW CALL CheckAndAddAlarm()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `urzadzenie`
--

DROP TABLE IF EXISTS `urzadzenie`;
CREATE TABLE IF NOT EXISTS `urzadzenie` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `serial_number` int NOT NULL,
  `status` tinyint(1) NOT NULL,
  `Description` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `serial_number` (`serial_number`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `urzadzenie`
--

INSERT INTO `urzadzenie` (`Id`, `serial_number`, `status`, `Description`) VALUES
(5, 1, 1, 'dziala'),
(12, 2, 1, 'blablabla'),
(13, 3, 1, 'blabla'),
(14, 1234, 1, 'nowa wersja');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `alarm`
--
ALTER TABLE `alarm`
  ADD CONSTRAINT `alarm_to_parametry` FOREIGN KEY (`Parametry_Alarmu_Id`) REFERENCES `parametry_alarmu` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `alarm_to_pomiar` FOREIGN KEY (`Pomiar_Id`) REFERENCES `pomiar` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Constraints for table `parametry_alarmu`
--
ALTER TABLE `parametry_alarmu`
  ADD CONSTRAINT `alarm_to_device` FOREIGN KEY (`Device_Id`) REFERENCES `urzadzenie` (`serial_number`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `alarm_to_user` FOREIGN KEY (`User_Id`) REFERENCES `ogrodnik` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Constraints for table `pomiar`
--
ALTER TABLE `pomiar`
  ADD CONSTRAINT `device_to_pomiar` FOREIGN KEY (`Device_id`) REFERENCES `urzadzenie` (`serial_number`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
