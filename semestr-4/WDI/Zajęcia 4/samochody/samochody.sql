SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Table structure for table `samochody`
--

CREATE TABLE IF NOT EXISTS `samochody` (
  `id` int(11) NOT NULL auto_increment,
  `marka` varchar(50) NOT NULL,
  `model` varchar(100) NOT NULL,
  `rok` int(11) NOT NULL,
  `pojemnosc` float NOT NULL,
  `typ_silnika` enum('benzyna','diesel') NOT NULL,
  `liczba_poduszek` int(11) NOT NULL,
  `abs` enum('tak','nie') NOT NULL,
  `esp` enum('tak','nie') NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `samochody`
--

INSERT INTO `samochody` (`id`, `marka`, `model`, `rok`, `pojemnosc`, `typ_silnika`, `liczba_poduszek`, `abs`, `esp`) VALUES
(1, 'Fiat', 'Punto', 1995, 1.2, 'benzyna', 0, 'nie', 'nie'),
(2, 'Volkswagen', 'Passat', 2002, 1.9, 'diesel', 4, 'tak', 'tak'),
(3, 'Mazda', '626', 1997, 2, 'diesel', 1, 'tak', 'nie'),
(4, 'Skoda', 'Fabia', 2000, 1.4, 'benzyna', 2, 'tak', 'nie');

-- --------------------------------------------------------

--
-- Table structure for table `uzytkownicy`
--

CREATE TABLE IF NOT EXISTS `uzytkownicy` (
  `id` int(11) NOT NULL auto_increment,
  `login` varchar(20) NOT NULL,
  `haslo` varchar(255) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `uzytkownicy`
--

INSERT INTO `uzytkownicy` (`id`, `login`, `haslo`) VALUES
(1, 'test', 'test');
