CREATE DATABASE  IF NOT EXISTS `login` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `login`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: login
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `correo` varchar(250) NOT NULL,
  `telefono` char(10) NOT NULL,
  `fecha_nacimiento` datetime NOT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `usuario` (`usuario`),
  UNIQUE KEY `nombre` (`nombre`),
  UNIQUE KEY `apellidos` (`apellidos`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Carlos Alexis','Abrego Nuñez','charlitos','955082495e5c7e4845407289c56e812630d9a2b0','carlosA@gmail.com','4451110991','2005-06-21 00:00:00'),(2,'Alexis Josue','Perez Martinez','alexis','19cb6a181ab7c25bd966b8a47140afef6b8461e6','rtxlaqw1@gmail.com','4451110991','2005-06-21 00:00:00'),(3,'Ana Victoria','Martínez Rojas','anavmr','9b6be4e376dab392f8f94c2ece45d187c0a445b7','ana.victoria@gmail.com','5540027819','2005-01-08 00:00:00'),(4,'María Fernanda','López García','mafer01','e02bb19592091e10c0f9737864d50e28a9ecc778','m.fernanda@gmail.com','5538291045','2004-03-15 00:00:00'),(5,'José Antonio','Ramírez Torres','joseRT','2eff8c5c3ccc7b6e817eeaf11914ea442c3f1267','j.ramirez@gmail.com','4421189033','2003-12-02 00:00:00'),(6,'Fernanda Sofía','Hernández Cruz','sofiaHC','0091c41cb2357f6d1d52145b2a205d8ba614e404','fernanda.sofia@gmail.com','5582210944','2005-09-10 00:00:00'),(7,'Luis Eduardo','Santos Medina','luisSM','d692753717cb3ce475ce5bac3b20f8a428e8ef24','luis.santos@gmail.com','4498892341','2004-11-29 00:00:00');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-02 23:31:18
