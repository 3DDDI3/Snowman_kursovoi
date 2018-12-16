CREATE DATABASE  IF NOT EXISTS `snowman_kursovoi` /*!40100 DEFAULT CHARACTER SET cp1251 */;
USE `snowman_kursovoi`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: snowman_kursovoi
-- ------------------------------------------------------
-- Server version	5.5.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `area`
--

DROP TABLE IF EXISTS `area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `area` (
  `idArea` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID области',
  `Area` varchar(45) DEFAULT NULL COMMENT 'Наименование области',
  PRIMARY KEY (`idArea`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` VALUES (1,'Ленинградская Область');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `autorization_datas`
--

DROP TABLE IF EXISTS `autorization_datas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `autorization_datas` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `password1` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autorization_datas`
--

LOCK TABLES `autorization_datas` WRITE;
/*!40000 ALTER TABLE `autorization_datas` DISABLE KEYS */;
INSERT INTO `autorization_datas` VALUES (1,'asd','asd',NULL),(2,'a','a',NULL),(3,'asd','a',NULL),(4,'asd','1aaf86284b4b8905671b14e16ea2','asd'),(5,'aaa','74e16417d6499cc68e1f5e123ca4a62','aaa');
/*!40000 ALTER TABLE `autorization_datas` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `snowman_kursovoi`.`autorization_datas_BEFORE_INSERT` BEFORE INSERT ON `autorization_datas` FOR EACH ROW
BEGIN
	if(new.login=(select login 
				from autorization_datas
                where new.login=login))then
    signal sqlstate '50000'
    set message_text='Такой логин уже существует';
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `cities`
--

DROP TABLE IF EXISTS `cities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cities` (
  `idCity` int(11) NOT NULL COMMENT 'ID города',
  `city` varchar(45) DEFAULT NULL COMMENT 'Город',
  PRIMARY KEY (`idCity`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cities`
--

LOCK TABLES `cities` WRITE;
/*!40000 ALTER TABLE `cities` DISABLE KEYS */;
INSERT INTO `cities` VALUES (1,'Санкт-Петербург');
/*!40000 ALTER TABLE `cities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clients` (
  `idClient` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID клиента',
  `surname` varchar(45) NOT NULL COMMENT 'Фамилия',
  `name` varchar(45) NOT NULL COMMENT 'Имя',
  `lastname` varchar(45) NOT NULL COMMENT 'Отчество',
  `adres` varchar(255) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL COMMENT 'Телефон',
  `isDeleted` tinyint(1) NOT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Филатов','Валерьян','Тихонович','г. Ярково, ул. Базовская, д. 92, кв. 98','85139738966',0),(2,'Дмитриев','Станислав','Парфеньевич','г. Саяногорск, ул. Барвихинская, д. 29, кв. 179','86212593539',0),(3,'Григорьева','Феврония','Станиславовна','г. Луговое, ул. Беговая 2-я, д. 94, кв.12','77174831349',0),(4,'Суханова','Евгения','Демьяновна','г. Гвардейское, ул. Журавлева, д. 53, кв. 14','888888888',0),(5,'Фокин','Геласий','Куприянович','г. Липняки, ул. Абельмановкая, д. 30, кв. 201','87866707692',0),(6,'Александрова','Лора','Фёдоровна','г. Маяковская, ул. Байкальская, д. 52, кв. 206','81061246715',0),(7,'Турова','валеря','Ильяовна','г. Пудож ул. Башиловская, д. 40, кв. 5','88727295438',0),(8,'Константинова','Анжелика','Никитевна','г. Пенза, ул. Сталина, д. 63, кв. 82','81144637835',0),(9,'Марков','Протасий','Леонидович','г. Ровное ул. Сталина, д. 22, кв. 67','84216458988',0),(10,'aasda','asd','asd','asd','123',0);
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contracts`
--

DROP TABLE IF EXISTS `contracts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contracts` (
  `idContact` int(11) NOT NULL,
  `idProperty` int(11) NOT NULL COMMENT 'ID недвижимости',
  `idPerson` int(11) NOT NULL COMMENT 'ID сотрудника',
  `idClient` int(11) NOT NULL COMMENT 'ID клиента',
  `idOwner` int(11) NOT NULL,
  `date` date NOT NULL COMMENT 'дата покупки',
  `begDate` date DEFAULT NULL COMMENT 'Дата начала аренды',
  `endDate` date DEFAULT NULL COMMENT 'Дата окончания аренды',
  `price` decimal(10,0) NOT NULL COMMENT 'цена продажи/аренды',
  `buy/rent` tinyint(1) NOT NULL COMMENT 'покупка/продажа',
  `status` tinyint(1) NOT NULL,
  PRIMARY KEY (`idProperty`),
  KEY `person_idx` (`idPerson`),
  KEY `client_idx` (`idClient`),
  KEY `owner_idx` (`idOwner`),
  CONSTRAINT `client` FOREIGN KEY (`idClient`) REFERENCES `clients` (`idClient`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `person` FOREIGN KEY (`idPerson`) REFERENCES `persons` (`idPerson`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `properties` FOREIGN KEY (`idProperty`) REFERENCES `property` (`idProperty`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contracts`
--

LOCK TABLES `contracts` WRITE;
/*!40000 ALTER TABLE `contracts` DISABLE KEYS */;
INSERT INTO `contracts` VALUES (1,1,3,2,2,'2018-10-10',NULL,NULL,50000,0,1);
/*!40000 ALTER TABLE `contracts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `district`
--

DROP TABLE IF EXISTS `district`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `district` (
  `idDistrict` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID района',
  `district` varchar(45) DEFAULT NULL COMMENT 'Район',
  PRIMARY KEY (`idDistrict`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `district`
--

LOCK TABLES `district` WRITE;
/*!40000 ALTER TABLE `district` DISABLE KEYS */;
INSERT INTO `district` VALUES (1,'Московский'),(2,'Адмиралтейский'),(3,'Василеостровский'),(4,'Выборгский'),(5,'Калининский'),(6,'Кировский'),(7,'Колпинский'),(8,'Красногвардейский'),(9,'Кронштадский'),(10,'Курортный'),(11,'Невский'),(12,'Петроградский'),(13,'Петродворцовский'),(14,'Пушкинский'),(15,'Приморский'),(16,'Фрунзенский'),(17,'Центральный');
/*!40000 ALTER TABLE `district` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `owners`
--

DROP TABLE IF EXISTS `owners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `owners` (
  `idOwner` int(11) NOT NULL COMMENT 'id Владельца',
  `surname` varchar(45) NOT NULL COMMENT 'Фамилия',
  `name` varchar(45) NOT NULL COMMENT 'Имя',
  `lastname` varchar(45) NOT NULL COMMENT 'Отчество',
  `adres` varchar(255) NOT NULL,
  `phone` varchar(45) NOT NULL,
  PRIMARY KEY (`idOwner`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `owners`
--

LOCK TABLES `owners` WRITE;
/*!40000 ALTER TABLE `owners` DISABLE KEYS */;
INSERT INTO `owners` VALUES (1,'Васютин','Прокл ','Юрьевич','',''),(2,'Баландина ','Каролина','Викторовна','',''),(3,'Городнова','Валентина','Иосифовна','',''),(4,'Волков ','Ашот ','Аркадьевич','г. Узловое, ул. Беговая 4-я, д. 46, кв. 272','89533692297'),(5,'Качеткова','Агриппина','Игоревна','г. Поспелиха, ул. Бауманская,  д.33, кв. 237 ','89694883315'),(6,'Соболев','Ким','Ильич','г. Усть-Ординский, ул. Батинская, д.12, кв. 52','89605277982'),(7,'Чаурин ','Афанасий','Русланович','г. Тульский, ул.Байдукова, д. 32, кв. 72','89369588290'),(8,'Покровский ','Игорь','Михайлович','г. Углич, ул. Барминовская, д. 19, кв. 83','89274839131'),(9,'Леонтьев','Твердислав','Генадьевич','г. Севское, ул. Батюнская,  д. 10,  кв. 298','89564483993'),(10,'Быкова','Лина','Яковлевна','г. Усть-Ординский, ул. Акадимическая, д. 97,  кв. 94','89287066190');
/*!40000 ALTER TABLE `owners` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persons`
--

DROP TABLE IF EXISTS `persons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persons` (
  `idPerson` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id Сотрудника',
  `idUser` int(11) DEFAULT NULL,
  `idSpecial` int(11) NOT NULL COMMENT 'Код должности',
  `surname` varchar(45) NOT NULL COMMENT 'Фамилия',
  `name` varchar(45) NOT NULL COMMENT 'Имя',
  `lastname` varchar(45) NOT NULL COMMENT 'Отчество',
  `dateReceipt` date NOT NULL COMMENT 'Дата приема',
  `dateDismissal` date DEFAULT NULL COMMENT 'Дата увольнения',
  `isDeleted` tinyint(1) NOT NULL,
  `adres` varchar(255) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idPerson`),
  KEY `special_idx` (`idSpecial`),
  KEY `user_idx` (`idUser`),
  CONSTRAINT `special` FOREIGN KEY (`idSpecial`) REFERENCES `specials` (`idSpecial`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `user` FOREIGN KEY (`idUser`) REFERENCES `autorization_datas` (`idUser`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persons`
--

LOCK TABLES `persons` WRITE;
/*!40000 ALTER TABLE `persons` DISABLE KEYS */;
INSERT INTO `persons` VALUES (3,NULL,14,'Мухин','Павел','Вадимович','1998-05-11',NULL,0,NULL,NULL),(4,NULL,12,'Некрасова','Евдокия','Руслановна','1999-03-29',NULL,0,NULL,NULL),(5,NULL,14,'Путин','Тихон','Аристархович','1999-10-17',NULL,0,NULL,NULL),(6,NULL,14,'Юдина','Жанна','Андреевна','1980-04-25','1999-04-09',0,NULL,NULL),(7,NULL,13,'Самойлов','Анатолий','Демьянович','1985-12-30',NULL,0,NULL,NULL),(8,NULL,14,'Исаков','Мстислав','Игоревич','2010-05-11','2017-12-02',0,NULL,NULL),(9,NULL,15,'Дьячков','Мстислав','Анатольевич','2015-12-22',NULL,0,NULL,NULL),(10,NULL,15,'Никонова','Евгения','Витальевна','2016-09-19',NULL,0,NULL,NULL);
/*!40000 ALTER TABLE `persons` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `snowman_kursovoi`.`persons_BEFORE_INSERT` BEFORE INSERT ON `persons` FOR EACH ROW
BEGIN
	if new.dateReceipt>now() then
		signal sqlstate '50000'
        set message_text='Дата приема не может быть больше текущей';
	end if;
    if new.dateDismissal>now() then
		signal sqlstate '50000'
        set message_text='Дата увольнения не может быть больше текущей';
	end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `property`
--

DROP TABLE IF EXISTS `property`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `property` (
  `idProperty` int(11) NOT NULL COMMENT 'id Недвижимости',
  `type` int(11) DEFAULT NULL COMMENT 'Тип недвижимости(Вторичная/Новострока) // 1-Вторичка, 0-Новостройка',
  `idOwner` int(11) NOT NULL COMMENT 'ID владельца',
  `idCity` int(11) DEFAULT NULL COMMENT 'ID города',
  `idArea` int(11) DEFAULT NULL,
  `idUndergroundStation` int(11) DEFAULT NULL COMMENT 'ID метро',
  `idDistrict` int(11) DEFAULT NULL COMMENT 'ID района',
  `buyRent` tinyint(1) DEFAULT NULL COMMENT 'Продажа/аренда',
  `isLoggia` tinyint(1) DEFAULT NULL COMMENT 'Наличие лоджии',
  `countRoom` int(11) DEFAULT NULL COMMENT 'Кол-во комнат',
  `isFloor` int(11) DEFAULT NULL COMMENT 'Этаж',
  `countFloor` int(11) DEFAULT NULL COMMENT 'Кол-во этажей',
  `countArandPropety` int(11) DEFAULT NULL COMMENT 'кол-во арендумыемых/продаваемых этажей\n',
  `arandFloor` varchar(45) DEFAULT NULL COMMENT 'номера арендуемых/покупаемых этажей\n',
  `isRemoveBuyRent` tinyint(1) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `price` decimal(30,0) NOT NULL,
  PRIMARY KEY (`idProperty`),
  KEY `owner_idx` (`idOwner`),
  KEY `city_idx` (`idCity`),
  KEY `district_idx` (`idDistrict`),
  KEY `area_idx` (`idArea`),
  KEY `undergroundStation_idx` (`idUndergroundStation`),
  KEY `type` (`type`),
  CONSTRAINT `owner` FOREIGN KEY (`idOwner`) REFERENCES `owners` (`idOwner`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `area` FOREIGN KEY (`idArea`) REFERENCES `area` (`idArea`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `city` FOREIGN KEY (`idCity`) REFERENCES `cities` (`idCity`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `district` FOREIGN KEY (`idDistrict`) REFERENCES `district` (`idDistrict`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `type` FOREIGN KEY (`type`) REFERENCES `type` (`idType`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `undergroundStation` FOREIGN KEY (`idUndergroundStation`) REFERENCES `undergroundstations` (`idUndergroundStation`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `property`
--

LOCK TABLES `property` WRITE;
/*!40000 ALTER TABLE `property` DISABLE KEYS */;
INSERT INTO `property` VALUES (1,1,2,1,NULL,2,2,0,0,3,5,5,NULL,NULL,0,NULL,500000);
/*!40000 ALTER TABLE `property` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `showcontracts`
--

DROP TABLE IF EXISTS `showcontracts`;
/*!50001 DROP VIEW IF EXISTS `showcontracts`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `showcontracts` AS SELECT 
 1 AS `idContact`,
 1 AS `idProperty`,
 1 AS `idPerson`,
 1 AS `idOwner`,
 1 AS `idClient`,
 1 AS `date`,
 1 AS `begDate`,
 1 AS `endDate`,
 1 AS `price`,
 1 AS `buy/rent`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `specials`
--

DROP TABLE IF EXISTS `specials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `specials` (
  `idSpecial` int(11) NOT NULL COMMENT 'ID должности',
  `special` varchar(45) NOT NULL COMMENT 'Должность',
  PRIMARY KEY (`idSpecial`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specials`
--

LOCK TABLES `specials` WRITE;
/*!40000 ALTER TABLE `specials` DISABLE KEYS */;
INSERT INTO `specials` VALUES (1,'Риэлтор'),(12,'Консультат по недвижимости'),(13,'Менеджер по продаже недвижимости'),(14,'Помощник менеджера'),(15,'Стажер');
/*!40000 ALTER TABLE `specials` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type`
--

DROP TABLE IF EXISTS `type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `type` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `idTypeProperty` int(11) NOT NULL,
  `type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idType`,`idTypeProperty`),
  KEY `typeProperty_idx` (`idTypeProperty`),
  CONSTRAINT `typeProperty` FOREIGN KEY (`idTypeProperty`) REFERENCES `typeproperty` (`idTypeProperty`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type`
--

LOCK TABLES `type` WRITE;
/*!40000 ALTER TABLE `type` DISABLE KEYS */;
INSERT INTO `type` VALUES (1,2,'Городское'),(2,2,'Загородное'),(3,3,'Офисное'),(4,3,'Торговое'),(5,3,'Складское'),(6,3,'Промышленное');
/*!40000 ALTER TABLE `type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typeproperty`
--

DROP TABLE IF EXISTS `typeproperty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `typeproperty` (
  `idTypeProperty` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID типа недвижимости',
  `typeProperty` varchar(45) DEFAULT NULL COMMENT 'Тип недвижимости',
  PRIMARY KEY (`idTypeProperty`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typeproperty`
--

LOCK TABLES `typeproperty` WRITE;
/*!40000 ALTER TABLE `typeproperty` DISABLE KEYS */;
INSERT INTO `typeproperty` VALUES (1,'Земля'),(2,'Жилье'),(3,'Нежилое помещение');
/*!40000 ALTER TABLE `typeproperty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `undergroundstation_distinct`
--

DROP TABLE IF EXISTS `undergroundstation_distinct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `undergroundstation_distinct` (
  `idundergroundStation` int(11) NOT NULL,
  `idDistrict` int(11) NOT NULL,
  PRIMARY KEY (`idundergroundStation`,`idDistrict`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `undergroundstation_distinct`
--

LOCK TABLES `undergroundstation_distinct` WRITE;
/*!40000 ALTER TABLE `undergroundstation_distinct` DISABLE KEYS */;
/*!40000 ALTER TABLE `undergroundstation_distinct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `undergroundstations`
--

DROP TABLE IF EXISTS `undergroundstations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `undergroundstations` (
  `idUndergroundStation` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID метро',
  `undergroundStation` varchar(45) NOT NULL COMMENT 'станция метро',
  PRIMARY KEY (`idUndergroundStation`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `undergroundstations`
--

LOCK TABLES `undergroundstations` WRITE;
/*!40000 ALTER TABLE `undergroundstations` DISABLE KEYS */;
INSERT INTO `undergroundstations` VALUES (2,'Страя деревня'),(3,'Крестовский остров'),(4,'Чкаловская'),(5,'Спортивная'),(6,'Садовая'),(7,'Звенигородская'),(8,'Обводный канал 1'),(9,'Волковская'),(10,'Бухаресткая'),(11,'Международная'),(12,'Купчино'),(13,'Звездная '),(14,'Московская'),(15,'Парк победы'),(16,'Электросила'),(17,'Московские ворота'),(18,'Фрунзенская'),(19,'Сенная площадь'),(20,'Невский проспект'),(21,'Горьковская'),(22,'Петроградская'),(23,'Чёрная речка'),(24,'Пионерская'),(25,'Удельная'),(26,'Озерки'),(27,'Проспект просвещения'),(28,'Парнас');
/*!40000 ALTER TABLE `undergroundstations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'snowman_kursovoi'
--

--
-- Dumping routines for database 'snowman_kursovoi'
--
/*!50003 DROP PROCEDURE IF EXISTS `checkPassword` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkPassword`(in password varchar(48), login varchar(48))
BEGIN
	if password ='' or login='' then
		signal sqlstate '50000'
        set message_text='Логин или пароль не может быть пустым';
	end if;
    if CHAR_LENGTH(password)<6 then 
		signal sqlstate '50000'
		set message_text='Пароль не может быть меньше 6 символов';
    end if;
    if password not regexp '@[a-zA-Z\d]{1,}' and password regexp '@[_]{2,}' then
    	signal sqlstate '50000'
        set message_text='Некорректный пароль';
	end if;
    if char_length(login)>48 then
		signal sqlstate '50000'
		set message_text='Слишком длинный логин';
	end if;
    if char_length(password)>48 then
		signal sqlstate '50000'
		set message_text='Слишком длинный пароль';
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `theMostProductiveEmployee` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `theMostProductiveEmployee`()
BEGIN
	select concat(persons.surname, ' ', left(persons.name,1),'. ', left(persons.lastname,1),'.'), idContact, sum(property.price)
    from contracts
    left join persons on persons.idPerson=contracts.idPerson
    left join property on property.idProperty=contracts.idProperty
    group by concat(persons.surname, ' ', left(persons.name,1),'. ', left(persons.lastname,1),'.')
    order by 2 desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `showcontracts`
--

/*!50001 DROP VIEW IF EXISTS `showcontracts`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `showcontracts` AS select `contracts`.`idContact` AS `idContact`,`contracts`.`idProperty` AS `idProperty`,concat(`persons`.`surname`,' ',left(`persons`.`name`,1),'.',left(`persons`.`lastname`,1),'.') AS `idPerson`,concat(`owners`.`surname`,' ',left(`owners`.`name`,1),'.',left(`owners`.`lastname`,1),'.') AS `idOwner`,concat(`clients`.`surname`,' ',left(`clients`.`name`,1),'.',left(`clients`.`lastname`,1),'.') AS `idClient`,`contracts`.`date` AS `date`,`contracts`.`begDate` AS `begDate`,`contracts`.`endDate` AS `endDate`,`contracts`.`price` AS `price`,if((`contracts`.`buy/rent` = 1),'На продажу','На аренду') AS `buy/rent`,(case `contracts`.`status` when 0 then 'Договор не подтвержден' when 1 then 'Договор на подтверждении' when 2 then 'Договор подтвержден' end) AS `status` from (((`contracts` left join `persons` on((`contracts`.`idPerson` = `persons`.`idPerson`))) left join `clients` on((`contracts`.`idClient` = `clients`.`idClient`))) left join `owners` on((`contracts`.`idOwner` = `owners`.`idOwner`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-15 12:27:02
