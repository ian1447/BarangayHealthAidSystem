/*
SQLyog Ultimate v9.62 
MySQL - 5.6.37-log : Database - barangay_aid
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`barangay_aid` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `barangay_aid`;

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `firstname` varchar(255) DEFAULT NULL,
  `middlename` varchar(255) DEFAULT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `role` enum('User','Admin') NOT NULL DEFAULT 'User',
  `added_by` int(11) NOT NULL,
  `added_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `users` */

insert  into `users`(`id`,`username`,`password`,`firstname`,`middlename`,`lastname`,`is_active`,`role`,`added_by`,`added_on`) values (1,'admin','*4ACFE3202A5FF5CF467898FC58AAB1D615029441','admin','admin','admin',1,'Admin',0,'2024-07-27 19:43:44');

/* Procedure structure for procedure `sp_get_users` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_get_users` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_get_users`()
BEGIN
SELECT u.id,CONCAT_WS(" ", u.`firstname`,u.`middlename`, u.`lastname`) `name`, u.`username`,u.`role`,
DATE_FORMAT(u.`added_on`, "%M %d, %Y") `added_on`,u.`is_active`,CONCAT_WS(" ", u2.`firstname`,u2.`middlename`, u2.`lastname`) `added_by`,
u.`firstname`,u.`middlename`,u.`lastname` FROM users u
INNER JOIN users u2 ON u2.id = u.id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_add`(
	in _username varchar (255),
	in _password varchar (255),
	in _firstname varchar (255),
	in _middlename varchar (255),
	in _lastname varchar (255),
	in _added_by int (11)
    )
BEGIN
	INSERT INTO `users`
		    (`username`,
		     `password`,
		     `firstname`,
		     `middlename`,
		     `lastname`,
		     `added_by`)
	VALUES (_username,
		Password(_password),
		_firstname,
		_middlename,
		_lastname,
		_added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_deactivate` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_deactivate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_deactivate`(
	in _id int (11)
    )
BEGIN
	UPDATE `barangay_aid`.`users`
	SET `is_active` = !`is_active`
	WHERE `id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_edit`(
	IN _username VARCHAR (255),
	IN _password VARCHAR (255),
	IN _firstname VARCHAR (255),
	IN _middlename VARCHAR (255),
	IN _lastname VARCHAR (255),
	in _id int (11)
    )
BEGIN
	if _password != "" then
		UPDATE `barangay_aid`.`users`
		SET`username` = _username,
		  `password` = PASSWORD(_password),
		  `firstname` = _firstname,
		  `middlename` = _middlename,
		  `lastname` = _lastname
		WHERE `id` = _id;
	else
		UPDATE `barangay_aid`.`users`
		SET`username` = _username,
		  `firstname` = _firstname,
		  `middlename` = _middlename,
		  `lastname` = _lastname
		WHERE `id` = _id;
	end if;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_login` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_login` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_login`(
	_username VARCHAR (255),
	_password VARCHAR (255))
BEGIN
SELECT * FROM `users` u WHERE u.`username` = _username AND u.`password` = PASSWORD(_password);
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
