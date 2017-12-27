CREATE DATABASE  IF NOT EXISTS `ControlDeAccesosMagnetico` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ControlDeAccesosMagnetico`;
-- MySQL dump 10.13  Distrib 5.6.23, for Win64 (x86_64)
--
-- Host: localhost    Database: ControlDeAccesos
-- ------------------------------------------------------
-- Server version	5.7.7-rc-log

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
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `alias` varchar(4) NOT NULL,
  `login` varchar(10) NOT NULL,
  `password` varchar(45) NOT NULL,
  `acceso` tinyint NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `codigosAcceso`
--

DROP TABLE IF EXISTS `codigosacceso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `codigosAcceso` (
  `idCodigoAcceso` int(11) NOT NULL AUTO_INCREMENT,
  `codigoDeAcceso` varchar(45) NOT NULL,
  `descripcionAcceso` varchar(30) NOT NULL,
  `pTodos` bool NOT NULL,
  
  PRIMARY KEY (`idCodigoAcceso`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `codigosAcceso`
--

LOCK TABLES `codigosacceso` WRITE;
/*!40000 ALTER TABLE `codigosacceso` DISABLE KEYS */;
/*!40000 ALTER TABLE `codigosacceso` ENABLE KEYS */;
UNLOCK TABLES;

----
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `idDepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  `idCodigoAcceso` int(11) NOT NULL,
  PRIMARY KEY (`idDepartamento`),
  KEY `fkDepart_acceso_idx` (`idCodigoAcceso`),
  CONSTRAINT `fkDepartAcces` FOREIGN KEY (`idCodigoAcceso`) REFERENCES `codigosAcceso` (`idCodigoAcceso`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `idEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL, 
  `fechaNacto` date NULL,
  `dni` varchar(10) NOT NULL, 
  `funcion` varchar(45) NOT NULL, 
  `telefono` varchar(20) NULL, 
  `email` varchar(45) NULL, 
  `fechaEntrada` date NULL,
  `salario` double NOT NULL,
  `sexo` tinytext NULL,
  `foto` mediumblob NULL,
  `idDepartamento` int(11) NOT NULL,
  `idUsuario` int(11) NULL,
  `activo` bool NOT NULL,
  PRIMARY KEY (`idEmpleado`),
  KEY `fkDepart_Empleados_idx` (`idDepartamento`),
  KEY `fkUsuario_Empleados_idx` (`idUsuario`),
  CONSTRAINT `fkDepartEmpleados` FOREIGN KEY (`idDepartamento`) REFERENCES `departamentos` (`idDepartamento`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fkUsuarioEmpleado` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Table structure for table `accesosEmpleados`
--

DROP TABLE IF EXISTS `accesosempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accesosEmpleados` (
  `idAccesosEmpleados` int(11) NOT NULL AUTO_INCREMENT,
  `idEmpleado` int(11) NOT NULL,
  `idCodigoAcceso` int(11) NOT NULL,
  `fechaEntrada` timestamp NOT NULL,
  PRIMARY KEY (`idAccesosEmpleados`),
  KEY `fk_empleado` (`idEmpleado`),
  KEY `fk_codigoAcceso` (`idCodigoAcceso`),
  CONSTRAINT `fk_empleado1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`idEmpleado`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_codigoAcceso1` FOREIGN KEY (`idCodigoAcceso`) REFERENCES `codigosAcceso` (`idCodigoAcceso`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accesosEmpleados`
--

LOCK TABLES `accesosempleados` WRITE;
/*!40000 ALTER TABLE `accesosempleados` DISABLE KEYS */;
/*!40000 ALTER TABLE `accesosempleados` ENABLE KEYS */;
UNLOCK TABLES;

----
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `logs` (
  `idLog` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  `fechaLog` timestamp NOT NULL,
  `idUsuario` int(11) NOT NULL,
  PRIMARY KEY (`idLog`),
  KEY `fkLogs_Usuario_idx` (`idUsuario`),
  CONSTRAINT `fkLogs_Usuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 02-11-2017 11:46:19