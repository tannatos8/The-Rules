-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: business_rules
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `business_rules`
--

DROP TABLE IF EXISTS `business_rules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `business_rules` (
  `idbusiness_rules` int(11) NOT NULL AUTO_INCREMENT,
  `rules_name` varchar(45) NOT NULL,
  `models_idmodels` int(11) NOT NULL,
  PRIMARY KEY (`idbusiness_rules`),
  KEY `fk_business_rules_models1_idx` (`models_idmodels`),
  CONSTRAINT `fk_business_rules_models1` FOREIGN KEY (`models_idmodels`) REFERENCES `models` (`idmodels`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `business_rules`
--

LOCK TABLES `business_rules` WRITE;
/*!40000 ALTER TABLE `business_rules` DISABLE KEYS */;
INSERT INTO `business_rules` VALUES (1,'Rela numero 1',1),(2,'Rela numero 2',1),(3,'Rela numero 3',1),(4,'Regla numero 4',1),(5,'Regla numero 5',1),(6,'Rela numero 6',1);
/*!40000 ALTER TABLE `business_rules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `idcategories` int(11) NOT NULL AUTO_INCREMENT,
  `field_specfic` tinyint(4) DEFAULT NULL,
  `relationship_specific` tinyint(4) DEFAULT NULL,
  `type_idtype` int(11) NOT NULL,
  PRIMARY KEY (`idcategories`),
  KEY `fk_categories_type1_idx` (`type_idtype`),
  CONSTRAINT `fk_categories_type1` FOREIGN KEY (`type_idtype`) REFERENCES `type` (`idtype`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,1,0,1),(2,1,0,2),(3,1,0,3),(4,1,0,4),(5,0,1,5),(6,0,1,6);
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logical_elements`
--

DROP TABLE IF EXISTS `logical_elements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logical_elements` (
  `idlogical_elements` int(11) NOT NULL AUTO_INCREMENT,
  `key_type` tinyint(4) DEFAULT NULL,
  `key_structure` tinyint(4) DEFAULT NULL,
  `uniqueness` tinyint(4) DEFAULT NULL,
  `null_support` tinyint(4) DEFAULT NULL,
  `values_entered_by` tinyint(4) DEFAULT NULL,
  `required_value` tinyint(4) DEFAULT NULL,
  `default_value` tinyint(4) DEFAULT NULL,
  `ranges_of_values` tinyint(4) DEFAULT NULL,
  `comparisons_allowed` tinyint(4) DEFAULT NULL,
  `operations_allowed` tinyint(4) DEFAULT NULL,
  `edit_rule` tinyint(4) DEFAULT NULL,
  `business_rules_idbusiness_rules` int(11) NOT NULL,
  PRIMARY KEY (`idlogical_elements`),
  KEY `fk_logical_elements_business_rules1_idx` (`business_rules_idbusiness_rules`),
  CONSTRAINT `fk_logical_elements_business_rules1` FOREIGN KEY (`business_rules_idbusiness_rules`) REFERENCES `business_rules` (`idbusiness_rules`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logical_elements`
--

LOCK TABLES `logical_elements` WRITE;
/*!40000 ALTER TABLE `logical_elements` DISABLE KEYS */;
INSERT INTO `logical_elements` VALUES (1,0,1,0,0,1,0,0,0,0,0,1,1),(2,0,0,1,0,1,0,0,0,0,1,0,2),(3,0,1,0,0,0,1,0,0,0,1,0,3),(4,0,0,1,0,1,0,0,0,0,0,1,4),(5,0,1,0,0,0,1,0,0,0,0,1,5),(6,0,1,0,0,0,0,1,0,0,1,0,6);
/*!40000 ALTER TABLE `logical_elements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `models`
--

DROP TABLE IF EXISTS `models`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `models` (
  `idmodels` int(11) NOT NULL AUTO_INCREMENT,
  `project_name` varchar(60) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `project_description` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `users_idusers` int(11) NOT NULL,
  PRIMARY KEY (`idmodels`),
  UNIQUE KEY `project_name_UNIQUE` (`project_name`),
  KEY `fk_models_users_idx` (`users_idusers`),
  CONSTRAINT `fk_models_users` FOREIGN KEY (`users_idusers`) REFERENCES `users` (`idusers`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `models`
--

LOCK TABLES `models` WRITE;
/*!40000 ALTER TABLE `models` DISABLE KEYS */;
INSERT INTO `models` VALUES (1,'Proyecto de bases de datos','el proyecto consiste en el filtrado de datos almacenados en mysql',1);
/*!40000 ALTER TABLE `models` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `physical_elements`
--

DROP TABLE IF EXISTS `physical_elements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `physical_elements` (
  `idphysical_elements` int(11) NOT NULL AUTO_INCREMENT,
  `data_type` tinyint(4) DEFAULT NULL,
  `length` tinyint(4) DEFAULT NULL,
  `decimal_places` tinyint(4) DEFAULT NULL,
  `character_support` tinyint(4) DEFAULT NULL,
  `input_mask` tinyint(4) DEFAULT NULL,
  `display_format` tinyint(4) DEFAULT NULL,
  `business_rules_idbusiness_rules` int(11) NOT NULL,
  PRIMARY KEY (`idphysical_elements`),
  KEY `fk_physical_elements_business_rules1_idx` (`business_rules_idbusiness_rules`),
  CONSTRAINT `fk_physical_elements_business_rules1` FOREIGN KEY (`business_rules_idbusiness_rules`) REFERENCES `business_rules` (`idbusiness_rules`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `physical_elements`
--

LOCK TABLES `physical_elements` WRITE;
/*!40000 ALTER TABLE `physical_elements` DISABLE KEYS */;
INSERT INTO `physical_elements` VALUES (1,1,0,0,1,1,0,1),(2,1,0,0,1,1,0,2),(3,1,0,1,0,0,1,3),(4,0,1,1,0,0,1,4),(5,1,0,1,0,1,1,5),(6,1,0,0,1,0,1,6);
/*!40000 ALTER TABLE `physical_elements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relationship_characteristics_affected`
--

DROP TABLE IF EXISTS `relationship_characteristics_affected`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `relationship_characteristics_affected` (
  `idrelationship_characteristics_affected` int(11) NOT NULL AUTO_INCREMENT,
  `deletion_rule` tinyint(4) DEFAULT NULL,
  `type_of_participation` tinyint(4) DEFAULT NULL,
  `degree_of_participati` tinyint(4) DEFAULT NULL,
  `business_rules_idbusiness_rules` int(11) NOT NULL,
  PRIMARY KEY (`idrelationship_characteristics_affected`),
  KEY `fk_relationship_characteristics_affected_business_rules1_idx` (`business_rules_idbusiness_rules`),
  CONSTRAINT `fk_relationship_characteristics_affected_business_rules1` FOREIGN KEY (`business_rules_idbusiness_rules`) REFERENCES `business_rules` (`idbusiness_rules`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relationship_characteristics_affected`
--

LOCK TABLES `relationship_characteristics_affected` WRITE;
/*!40000 ALTER TABLE `relationship_characteristics_affected` DISABLE KEYS */;
INSERT INTO `relationship_characteristics_affected` VALUES (1,0,1,1,1),(2,0,1,0,2),(3,0,1,1,3),(4,1,1,0,4),(5,0,0,1,5),(6,0,1,1,6);
/*!40000 ALTER TABLE `relationship_characteristics_affected` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rule_information_text_boxs`
--

DROP TABLE IF EXISTS `rule_information_text_boxs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rule_information_text_boxs` (
  `idrule_information_text_boxs` int(11) NOT NULL AUTO_INCREMENT,
  `statement` varchar(120) DEFAULT NULL,
  `constraints` varchar(120) DEFAULT NULL,
  `field_names` varchar(64) DEFAULT NULL,
  `table_names` varchar(64) DEFAULT NULL,
  `action_taken` varchar(120) DEFAULT NULL,
  `business_rules_idbusiness_rules` int(11) NOT NULL,
  PRIMARY KEY (`idrule_information_text_boxs`),
  KEY `fk_rule_information_text_boxs_business_rules1_idx` (`business_rules_idbusiness_rules`),
  CONSTRAINT `fk_rule_information_text_boxs_business_rules1` FOREIGN KEY (`business_rules_idbusiness_rules`) REFERENCES `business_rules` (`idbusiness_rules`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rule_information_text_boxs`
--

LOCK TABLES `rule_information_text_boxs` WRITE;
/*!40000 ALTER TABLE `rule_information_text_boxs` DISABLE KEYS */;
INSERT INTO `rule_information_text_boxs` VALUES (1,'hola mundo','pruebas','hola mundo','hola mundo','hola mundo',1),(2,'hsdffds','fdsfsd','sdfsdfsf','sdfsdfs','fdsgh',2),(3,'dsfdg','fsdgfsd','sfdgfsd','dfgdsf','fdsgsfdgdfs',3),(4,'gfdsh','hfghdfgd','hfhdgfhd','gfhfdhgfd','gfhfdghfdgh',4),(5,'segfdsg','fgdfsger','dsgerge','gerwgewr','rehyerwh',5),(6,'fhfdsh','gfhgfdh','fghdfgdh','hgfdhfgd','dfgdfshfds',6);
/*!40000 ALTER TABLE `rule_information_text_boxs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test_on`
--

DROP TABLE IF EXISTS `test_on`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `test_on` (
  `idtest_on` int(11) NOT NULL AUTO_INCREMENT,
  `inserts` tinyint(4) DEFAULT NULL,
  `updates` tinyint(4) DEFAULT NULL,
  `deletes` tinyint(4) DEFAULT NULL,
  `type_idtype` int(11) NOT NULL,
  PRIMARY KEY (`idtest_on`),
  KEY `fk_test_on_type1_idx` (`type_idtype`),
  CONSTRAINT `fk_test_on_type1` FOREIGN KEY (`type_idtype`) REFERENCES `type` (`idtype`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test_on`
--

LOCK TABLES `test_on` WRITE;
/*!40000 ALTER TABLE `test_on` DISABLE KEYS */;
INSERT INTO `test_on` VALUES (1,1,1,0,1),(2,0,1,1,2),(3,0,0,1,3),(4,1,0,0,4),(5,1,0,0,5),(6,0,0,1,6);
/*!40000 ALTER TABLE `test_on` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type`
--

DROP TABLE IF EXISTS `type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type` (
  `idtype` int(11) NOT NULL AUTO_INCREMENT,
  `data_base_oriented` tinyint(4) DEFAULT NULL,
  `application_oriented` tinyint(4) DEFAULT NULL,
  `business_rules_idbusiness_rules` int(11) NOT NULL,
  PRIMARY KEY (`idtype`),
  KEY `fk_type_business_rules1_idx` (`business_rules_idbusiness_rules`),
  CONSTRAINT `fk_type_business_rules1` FOREIGN KEY (`business_rules_idbusiness_rules`) REFERENCES `business_rules` (`idbusiness_rules`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type`
--

LOCK TABLES `type` WRITE;
/*!40000 ALTER TABLE `type` DISABLE KEYS */;
INSERT INTO `type` VALUES (1,1,0,1),(2,1,0,2),(3,0,1,3),(4,1,0,4),(5,1,1,5),(6,0,1,6);
/*!40000 ALTER TABLE `type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `idusers` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `password_confirmation` varchar(45) NOT NULL,
  PRIMARY KEY (`idusers`),
  UNIQUE KEY `user_name_UNIQUE` (`user_name`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin','admin','admin@gmail.con','123456789','123456789');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-30 11:39:22
