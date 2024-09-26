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

/*Table structure for table `family_planning` */

DROP TABLE IF EXISTS `family_planning`;

CREATE TABLE `family_planning` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` varchar(255) DEFAULT NULL,
  `given_name` varchar(255) DEFAULT NULL,
  `middle_initial` varchar(5) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `educ_attain` varchar(255) DEFAULT NULL,
  `occupation` varchar(255) DEFAULT NULL,
  `address_no` varchar(100) DEFAULT NULL,
  `address_street` varchar(100) DEFAULT NULL,
  `address_barangay` varchar(100) DEFAULT NULL,
  `address_mun/city` varchar(100) DEFAULT NULL,
  `address_prov` varchar(100) DEFAULT NULL,
  `contact_number` varchar(25) DEFAULT NULL,
  `civil_status` varchar(100) DEFAULT NULL,
  `religion` varchar(100) DEFAULT NULL,
  `spouse_last_name` varchar(255) DEFAULT NULL,
  `spouse_given_name` varchar(255) DEFAULT NULL,
  `spouse_middle_inital` varchar(5) DEFAULT NULL,
  `spouse_dob` date DEFAULT NULL,
  `spouse_age` int(11) DEFAULT NULL,
  `spouse_occupation` varchar(255) DEFAULT NULL,
  `living_children` int(11) DEFAULT NULL,
  `plan_more_children` tinyint(1) DEFAULT '0',
  `average_monthly_income` decimal(12,2) DEFAULT NULL,
  `type_of_client` enum('New Acceptor','Current User') DEFAULT NULL,
  `reason_for_FP` enum('spacing','limiting','others') DEFAULT NULL,
  `others` varchar(255) DEFAULT NULL,
  `current_user_type` enum('Changing Method','Changing Clinic','Dropout/Restart') DEFAULT NULL,
  `changin_method_resaon` enum('medical condition','side_effects') DEFAULT NULL,
  `side_effects` varchar(255) DEFAULT NULL,
  `currently_used_changing_methods` enum('COC','POP','Injectable','Implant','IUD-Internal','IUD-Post-Partum','Condom','BOM/CMM','BBT','STM','SDM','LAM','others') DEFAULT NULL,
  `changing_method_others` varchar(255) DEFAULT NULL,
  `medical_history` text,
  `med_history_specify` varchar(255) DEFAULT NULL,
  `pregnancies_G` int(11) DEFAULT NULL,
  `pregnancies_P` int(11) DEFAULT NULL,
  `pregnancy_full_term` int(11) DEFAULT NULL,
  `pregnancy_abortion` int(11) DEFAULT NULL,
  `pregnancy_premature` int(11) DEFAULT NULL,
  `pregnancy_living` int(11) DEFAULT NULL,
  `date_last_delivery` date DEFAULT NULL,
  `type_last_delivery` enum('Vaginal','Cesarean Section') DEFAULT NULL,
  `last_menstrual_period` date DEFAULT NULL,
  `previous_mentrual_period` date DEFAULT NULL,
  `menstrual_flow` enum('Scanty','moderate','heavy') DEFAULT NULL,
  `dysmenorrhea` tinyint(1) DEFAULT '0',
  `hydatidiform_mole` tinyint(1) DEFAULT '0',
  `ectopitic_pregnancy` tinyint(1) DEFAULT '0',
  `sexually_transmitted_infections_risk` text,
  `genital_area_yes` tinyint(1) DEFAULT '0',
  `VAW` text,
  `referred_to` text,
  `weight` decimal(12,2) DEFAULT NULL,
  `height` decimal(12,2) DEFAULT NULL,
  `bp` varchar(20) DEFAULT NULL,
  `pulse_rate` int(11) DEFAULT NULL,
  `skin` text,
  `conjunctiva` text,
  `neck` text,
  `breast` text,
  `abdomen` text,
  `extremities` text,
  `pelvic_examination` text,
  `cervical_abnormalities` text,
  `cervical_consistency` text,
  `uterine_position` text,
  `uterine_depth` decimal(12,2) DEFAULT NULL,
  `added_by` int(11) DEFAULT NULL,
  `added_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `family_planning` */

/*Table structure for table `maternal_health_record` */

DROP TABLE IF EXISTS `maternal_health_record`;

CREATE TABLE `maternal_health_record` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(11) NOT NULL DEFAULT '0',
  `name` varchar(255) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `height` decimal(12,2) DEFAULT NULL,
  `husband_name` varchar(255) DEFAULT NULL,
  `occupation` varchar(255) DEFAULT NULL,
  `address` text,
  `contact_no` varchar(25) DEFAULT NULL,
  `no_children_born_alive` int(11) DEFAULT NULL,
  `living_children` int(11) DEFAULT NULL,
  `abortion` int(11) NOT NULL DEFAULT '0',
  `fetal_deaths` int(11) NOT NULL DEFAULT '0',
  `type_last_delivery` varchar(255) DEFAULT NULL,
  `largebabies` int(11) NOT NULL DEFAULT '0' COMMENT '8lbs',
  `diabetes` varchar(255) DEFAULT NULL,
  `previous_illness` varchar(255) DEFAULT NULL,
  `allergy` varchar(255) DEFAULT NULL,
  `previous_hospitalization` varchar(255) DEFAULT NULL,
  `gravida` varchar(50) DEFAULT NULL,
  `PARA` varchar(50) DEFAULT NULL,
  `A` varchar(50) DEFAULT NULL,
  `stillbirth` varchar(50) DEFAULT NULL,
  `LMP` varchar(50) DEFAULT NULL,
  `EDC` varchar(50) DEFAULT NULL,
  `where_to_deliver` varchar(255) DEFAULT NULL,
  `attended_by` varchar(255) DEFAULT NULL,
  `new_born_screening_plan` varchar(255) DEFAULT NULL,
  `risk_codes` enum('A','B','C','D','E') DEFAULT NULL,
  `tt1` date DEFAULT NULL,
  `tt2` date DEFAULT NULL,
  `tt3` date DEFAULT NULL,
  `tt4` date DEFAULT NULL,
  `tt5` date DEFAULT NULL,
  `urinalysis` varchar(255) DEFAULT NULL,
  `hbs_antigen` varchar(255) DEFAULT NULL,
  `CBC` varchar(25) DEFAULT NULL,
  `RPR` varchar(25) DEFAULT NULL,
  `blood_typing` varchar(25) DEFAULT NULL,
  `HIV` varchar(25) DEFAULT NULL,
  `prev_pregnancy_complic` text,
  `checklist` text,
  `vit_a_date_given` date DEFAULT NULL,
  `vit_a_prescribed` varchar(50) DEFAULT NULL,
  `iron_folic_4` date DEFAULT NULL,
  `iron_folic_5` date DEFAULT NULL,
  `iron_folic_6` date DEFAULT NULL,
  `iron_folic_7` date DEFAULT NULL,
  `iron_folic_8` date DEFAULT NULL,
  `iron_folic_9` date DEFAULT NULL,
  `added_by` int(11) DEFAULT NULL,
  `added_on` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `maternal_health_record` */

insert  into `maternal_health_record`(`id`,`patient_id`,`name`,`age`,`dob`,`height`,`husband_name`,`occupation`,`address`,`contact_no`,`no_children_born_alive`,`living_children`,`abortion`,`fetal_deaths`,`type_last_delivery`,`largebabies`,`diabetes`,`previous_illness`,`allergy`,`previous_hospitalization`,`gravida`,`PARA`,`A`,`stillbirth`,`LMP`,`EDC`,`where_to_deliver`,`attended_by`,`new_born_screening_plan`,`risk_codes`,`tt1`,`tt2`,`tt3`,`tt4`,`tt5`,`urinalysis`,`hbs_antigen`,`CBC`,`RPR`,`blood_typing`,`HIV`,`prev_pregnancy_complic`,`checklist`,`vit_a_date_given`,`vit_a_prescribed`,`iron_folic_4`,`iron_folic_5`,`iron_folic_6`,`iron_folic_7`,`iron_folic_8`,`iron_folic_9`,`added_by`,`added_on`) values (1,0,'asdf',21,'1999-05-28','158.00','asdf','asdf','asdf','asdf',1,1,0,0,NULL,0,'asdf','asdf','asdf','asdf','asdf','asdf','asdf',NULL,'asdf','asdf','asdf','asdf','asdf','','1999-05-28','1999-05-28','1999-05-28','1999-05-28','1999-05-28','asdf','asdf','asdf','asdf','asdf','asdf','asdf','asdf','1999-05-28','asdf','1999-05-28','1999-05-28','1999-05-28','1999-05-28','1999-05-28','1999-05-28',1,'2024-09-08 14:42:12'),(2,0,'erw',13,'2024-09-03','23.00','asdf','zxcv','asdf','zxc',1,2,3,4,NULL,5,'zxcv','asdf','qwe','uioy','j','k','l',NULL,'hj',';','78g','hfj','fvbnm','A','2024-09-03','2024-09-11','2024-09-10','2024-10-03','2024-09-30','asd','czx','dfsa','xcvz','zxvc','asdf','szxcv','Vaginal Bleeding, Severe Headache','2024-09-18','azxc','2024-09-10','2024-10-01','2024-09-19','2024-09-10','2024-09-11','2024-09-03',1,'2024-09-14 16:03:20'),(3,0,'asfd',2,'2024-08-30','12.00','axc','xcv','cvb','xcvb',2,2,23,3,'2',1,'2','x','df','g','vc','asdf','32','ew','zcx','af','nm,',',.b','jry','','2024-09-18','2024-08-28','2024-09-23','2024-09-19','2024-09-16','1','asd','bn','scxv','nm','vbm','xcbv','Breast abnormalities','2024-08-26','scv','2024-09-04','2024-09-02','2024-09-18','2024-09-10','2024-09-07','2024-09-18',1,'2024-09-21 23:25:51');

/*Table structure for table `out_patient` */

DROP TABLE IF EXISTS `out_patient`;

CREATE TABLE `out_patient` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `purok_no` int(11) NOT NULL,
  `name_of_child` varchar(255) NOT NULL,
  `birthdate` date NOT NULL,
  `age_in_months` int(11) NOT NULL,
  `height` decimal(12,2) DEFAULT NULL,
  `weight` decimal(12,2) DEFAULT NULL,
  `nutritional_status` varchar(255) DEFAULT NULL,
  `added_by` int(11) DEFAULT NULL,
  `transdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `out_patient` */

insert  into `out_patient`(`id`,`purok_no`,`name_of_child`,`birthdate`,`age_in_months`,`height`,`weight`,`nutritional_status`,`added_by`,`transdate`) values (1,3,'test Edit','2024-06-30',2,'13.00','24.20','abniormal',1,'2024-09-18 21:50:38'),(3,2,'Testing Name','2024-09-10',23,'56.00','123.00','Normal',1,'2024-09-19 21:23:44');

/*Table structure for table `patient_details` */

DROP TABLE IF EXISTS `patient_details`;

CREATE TABLE `patient_details` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` varchar(255) DEFAULT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `name_extension` varchar(50) DEFAULT NULL,
  `middle_name` varchar(255) DEFAULT NULL,
  `maiden_last_name` varchar(255) DEFAULT NULL,
  `maiden_first_name` varchar(255) DEFAULT NULL,
  `maiden_name_extension` varchar(50) DEFAULT NULL,
  `maiden_middle_name` varchar(255) DEFAULT NULL,
  `birthdate` date DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `place_of_birth` text,
  `sex` enum('Male','Female') DEFAULT NULL,
  `civil_status` enum('Single','Married','Widow(er)','Habitation') DEFAULT NULL,
  `religion` varchar(255) DEFAULT NULL,
  `blood_type` varchar(25) DEFAULT NULL,
  `contact_number` varchar(15) DEFAULT NULL,
  `address_purok` varchar(255) DEFAULT NULL,
  `address_barangay` varchar(255) DEFAULT NULL,
  `address_mun` varchar(255) DEFAULT NULL,
  `address_province` varchar(255) DEFAULT NULL,
  `address_country` varchar(255) DEFAULT NULL,
  `address_zip_code` varchar(25) DEFAULT NULL,
  `educational_attainment` varchar(255) NOT NULL,
  `employment_status` varchar(255) DEFAULT NULL,
  `TIN` varchar(50) DEFAULT NULL,
  `ph_stat` enum('With PHIC','No PHIC') DEFAULT NULL,
  `phic_id_no` varchar(100) DEFAULT NULL,
  `phic_status_type` enum('Member','Dependent') DEFAULT NULL,
  `is_4p` tinyint(1) DEFAULT '0',
  `4p_id_no` varchar(100) DEFAULT NULL,
  `4p_status_type` enum('Member','Dependent') DEFAULT NULL,
  `membership_cat` enum('NHTS-PR','Govt-Permanent Regular','Govt-Contractual/Project Based','Govt-Casual','Private','Self-Earning','Migrant Worker (Land)','Migrant Worker (Sea)','Enterprise Owner','Senior Citizen','Sponsored: LGU','Sponsored: NGA','Retiree: Pensioner','Others') DEFAULT NULL,
  `partner_last_name` varchar(255) DEFAULT NULL,
  `partner_first_name` varchar(255) DEFAULT NULL,
  `partner_name_extension` varchar(50) DEFAULT NULL,
  `partner_middle_name` varchar(255) DEFAULT NULL,
  `partner_birthdate` date DEFAULT NULL,
  `partner_sex` enum('Male','Female') DEFAULT NULL,
  `partner_phic_id` varchar(50) DEFAULT NULL,
  `father_last_name` varchar(255) DEFAULT NULL,
  `father_first_name` varchar(255) DEFAULT NULL,
  `father_name_extension` varchar(50) DEFAULT NULL,
  `father_middle_name` varchar(255) DEFAULT NULL,
  `father_birthdate` date DEFAULT NULL,
  `father_disability` varchar(255) DEFAULT NULL,
  `father_phic_id` varchar(50) DEFAULT NULL,
  `mother_last_name` varchar(255) DEFAULT NULL,
  `mother_first_name` varchar(255) DEFAULT NULL,
  `mother_name_extension` varchar(50) DEFAULT NULL,
  `mother_middle_name` varchar(255) DEFAULT NULL,
  `mother_birthdate` date DEFAULT NULL,
  `mother_disability` varchar(255) DEFAULT NULL,
  `mother_phic_id` varchar(50) DEFAULT NULL,
  `added_by` int(11) DEFAULT NULL,
  `added_on` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `patient_details` */

/*Table structure for table `purok` */

DROP TABLE IF EXISTS `purok`;

CREATE TABLE `purok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `purok_name` varchar(255) NOT NULL,
  `added_by` int(11) NOT NULL,
  `added_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `purok` */

insert  into `purok`(`id`,`purok_name`,`added_by`,`added_on`) values (1,'Purok 1',1,'2024-09-11 21:24:25'),(3,'Purok 2',1,'2024-09-01 21:48:24');

/*Table structure for table `purok_family_members` */

DROP TABLE IF EXISTS `purok_family_members`;

CREATE TABLE `purok_family_members` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `purok_members_id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `added_by` int(11) DEFAULT NULL,
  `added_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `purok_family_members` */

insert  into `purok_family_members`(`id`,`purok_members_id`,`name`,`added_by`,`added_on`) values (1,1,'Father',1,'2024-09-10 23:26:39'),(2,1,'Family Head 234',1,'2024-09-10 23:36:08'),(4,2,'Father3',1,'2024-09-11 00:07:05');

/*Table structure for table `purok_members` */

DROP TABLE IF EXISTS `purok_members`;

CREATE TABLE `purok_members` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `purok_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `added_by` int(11) NOT NULL,
  `added_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `purok_members` */

insert  into `purok_members`(`id`,`purok_id`,`name`,`added_by`,`added_on`) values (1,1,'test',1,'2024-09-01 21:46:31'),(2,1,'Family Head',1,'2024-09-10 23:36:21');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `users` */

insert  into `users`(`id`,`username`,`password`,`firstname`,`middlename`,`lastname`,`is_active`,`role`,`added_by`,`added_on`) values (1,'admin','*4ACFE3202A5FF5CF467898FC58AAB1D615029441','admin','admin','admin',1,'Admin',0,'2024-07-27 19:43:44');

/* Procedure structure for procedure `sp_family_planning_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_family_planning_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_family_planning_add`(
	_last_name varchar (255),
	_given_name varchar (255),
	_middle_initial varchar (25),
	_dob date,
	_age int (11),
	_educ_attain varchar(255),
	_occupation varchar(255),
	_address_no varchar (50),
	_address_street varchar (50),
	_address_barangay varchar (50),
	_address_muncity varchar (50),
	_address_prov varchar (50),
	_contact_number varchar (15),
	_civil_status varchar (50),
	_religion varchar (100),
	_spouse_last_name varchar (255),
	_spouse_given_name varchar (255),
	_spouse_middle_inital varchar (25),
	_spouse_dob date,
	_spouse_age int (11),
	_spouse_occupation varchar (255),
	_living_children int (11),
	_plan_more_children int (1),
	_average_monthly_income decimal (12,2),
	_type_of_client varchar (255),
	_reason_for_FP varchar (255),
	_others varchar (255),
	_current_user_type varchar (255),
	_changin_method_resaon varchar (255),
	_side_effects varchar (255),
	_currently_used_changing_methods varchar (255),
	_changing_method_others varchar (255),
	_medical_history text,
	_med_history_specify varchar (255),
	_pregnancies_G int (11),
	_pregnancies_P int (11),
	_pregnancy_full_term int (11),
	_pregnancy_abortion int (11),
	_pregnancy_premature int (11),
	_pregnancy_living int (11),
	_date_last_delivery date,
	_type_last_delivery varchar (255),
	_last_menstrual_period date,
	_previous_mentrual_period date,
	_menstrual_flow varchar (255),
	_dysmenorrhea int (1),
	_hydatidiform_mole int (1),
	_ectopitic_pregnancy int (1),
	_sexually_transmitted_infections_risk text,
	_genital_area_yes int (1),
	_VAW text,
	_referred_to text,
	_weight decimal(12,2),
	_height decimal (12,2),
	_bp varchar (255),
	_pulse_rate int (11),
	_skin text,
	_conjunctiva text,
	_neck text,
	_breast text,
	_abdomen text,
	_extremities text,
	_pelvic_examination text,
	_cervical_abnormalities text,
	_cervical_consistency text,
	_uterine_position text,
	_uterine_depth decimal (12,2),
	_added_by int (11)
    )
BEGIN
INSERT INTO `family_planning`
            (`last_name`,
             `given_name`,
             `middle_initial`,
             `dob`,
             `age`,
             `educ_attain`,
             `occupation`,
             `address_no`,
             `address_street`,
             `address_barangay`,
             `address_mun/city`,
             `address_prov`,
             `contact_number`,
             `civil_status`,
             `religion`,
             `spouse_last_name`,
             `spouse_given_name`,
             `spouse_middle_inital`,
             `spouse_dob`,
             `spouse_age`,
             `spouse_occupation`,
             `living_children`,
             `plan_more_children`,
             `average_monthly_income`,
             `type_of_client`,
             `reason_for_FP`,
             `others`,
             `current_user_type`,
             `changin_method_resaon`,
             `side_effects`,
             `currently_used_changing_methods`,
             `changing_method_others`,
             `medical_history`,
             `med_history_specify`,
             `pregnancies_G`,
             `pregnancies_P`,
             `pregnancy_full_term`,
             `pregnancy_abortion`,
             `pregnancy_premature`,
             `pregnancy_living`,
             `date_last_delivery`,
             `type_last_delivery`,
             `last_menstrual_period`,
             `previous_mentrual_period`,
             `menstrual_flow`,
             `dysmenorrhea`,
             `hydatidiform_mole`,
             `ectopitic_pregnancy`,
             `sexually_transmitted_infections_risk`,
             `genital_area_yes`,
             `VAW`,
             `referred_to`,
             `weight`,
             `height`,
             `bp`,
             `pulse_rate`,
             `skin`,
             `conjunctiva`,
             `neck`,
             `breast`,
             `abdomen`,
             `extremities`,
             `pelvic_examination`,
             `cervical_abnormalities`,
             `cervical_consistency`,
             `uterine_position`,
             `uterine_depth`,
             `added_by`)
VALUES (_last_name,
        _given_name,
        _middle_initial,
        _dob,
        _age,
        _educ_attain,
        _occupation,
        _address_no,
        _address_street,
        _address_barangay,
        _address_muncity,
        _address_prov,
        _contact_number,
        _civil_status,
        _religion,
        _spouse_last_name,
        _spouse_given_name,
        _spouse_middle_inital,
        _spouse_dob,
        _spouse_age,
        _spouse_occupation,
        _living_children,
        _plan_more_children,
        _average_monthly_income,
        _type_of_client,
        _reason_for_FP,
        _others,
        _current_user_type,
        _changin_method_resaon,
        _side_effects,
        _currently_used_changing_methods,
        _changing_method_others,
        _medical_history,
        _med_history_specify,
        _pregnancies_G,
        _pregnancies_P,
        _pregnancy_full_term,
        _pregnancy_abortion,
        _pregnancy_premature,
        _pregnancy_living,
        _date_last_delivery,
        _type_last_delivery,
        _last_menstrual_period,
        _previous_mentrual_period,
        _menstrual_flow,
        _dysmenorrhea,
        _hydatidiform_mole,
        _ectopitic_pregnancy,
        _sexually_transmitted_infections_risk,
        _genital_area_yes,
        _VAW,
        _referred_to,
        _weight,
        _height,
        _bp,
        _pulse_rate,
        _skin,
        _conjunctiva,
        _neck,
        _breast,
        _abdomen,
        _extremities,
        _pelvic_examination,
        _cervical_abnormalities,
        _cervical_consistency,
        _uterine_position,
        _uterine_depth,
        _added_by);
    END */$$
DELIMITER ;

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

/* Procedure structure for procedure `sp_maternal_health_record_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_maternal_health_record_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_maternal_health_record_add`(
    	_patient_id INT (11),
    	_name varchar (255),
    	_age int (11),
    	_dob date,
    	_height	decimal (12,2),
	_husband_name VARCHAR (255),
	_occupation VARCHAR (255),
	_address TEXT,
	_contact_no VARCHAR (25),
	_no_children_born_alive INT (11),
	_living_children INT (11),
	_abortion INT (11),
	_fetal_deaths INT (11),
	_type_last_delivery varchar (255),
	_largebabies INT (11),
	_diabetes VARCHAR (255),
	_previous_illness VARCHAR (255),
	_allergy VARCHAR (255),
	_previous_hospitalization VARCHAR (255),
	_gravida VARCHAR (50),
	_PARA VARCHAR (50),
	_A VARCHAR (50),
	_stillbirth varchar (50),
	_LMP VARCHAR (50),
	_EDC VARCHAR (50),
	_where_to_deliver VARCHAR (255),
	_attended_by VARCHAR (255),
	_new_born_screening_plan VARCHAR (255),
	_risk_codes VARCHAR (25),
	_tt1 DATE,
	_tt2 DATE,
	_tt3 DATE,
	_tt4 DATE,
	_tt5 DATE,
	_urinalysis VARCHAR (255),
	_hbs_antigen VARCHAR (255),
	_CBC VARCHAR (25),
	_RPR VARCHAR (25),
	_blood_typing VARCHAR (25),
	_HIV VARCHAR (25),
	_prev_pregnancy_complic TEXT,
	_checklist TEXT,
	_vit_a_date_given DATE,
	_vit_a_prescribed VARCHAR (50),
	_iron_folic_4 DATE,
	_iron_folic_5 DATE,
	_iron_folic_6 DATE,
	_iron_folic_7 DATE,
	_iron_folic_8 DATE,
	_iron_folic_9 DATE,
	_added_by INT (11)
    )
BEGIN
INSERT INTO `maternal_health_record`
            (`patient_id`,
             `name`,
             `age`,
             `dob`,
             `height`,
             `husband_name`,
             `occupation`,
             `address`,
             `contact_no`,
             `no_children_born_alive`,
             `living_children`,
             `abortion`,
             `fetal_deaths`,
             `type_last_delivery`,
             `largebabies`,
             `diabetes`,
             `previous_illness`,
             `allergy`,
             `previous_hospitalization`,
             `gravida`,
             `PARA`,
             `A`,
             `stillbirth`,
             `LMP`,
             `EDC`,
             `where_to_deliver`,
             `attended_by`,
             `new_born_screening_plan`,
             `risk_codes`,
             `tt1`,
             `tt2`,
             `tt3`,
             `tt4`,
             `tt5`,
             `urinalysis`,
             `hbs_antigen`,
             `CBC`,
             `RPR`,
             `blood_typing`,
             `HIV`,
             `prev_pregnancy_complic`,
             `checklist`,
             `vit_a_date_given`,
             `vit_a_prescribed`,
             `iron_folic_4`,
             `iron_folic_5`,
             `iron_folic_6`,
             `iron_folic_7`,
             `iron_folic_8`,
             `iron_folic_9`,
             `added_by`)
VALUES (_patient_id,
    	_name,
    	_age,
    	_dob,
    	_height,
	_husband_name,
	_occupation,
	_address,
	_contact_no,
	_no_children_born_alive,
	_living_children,
	_abortion,
	_fetal_deaths,
	_type_last_delivery,
	_largebabies,
	_diabetes,
	_previous_illness,
	_allergy,
	_previous_hospitalization,
	_gravida,
	_PARA,
	_A,
	_stillbirth,
	_LMP,
	_EDC,
	_where_to_deliver,
	_attended_by,
	_new_born_screening_plan,
	_risk_codes,
	_tt1,
	_tt2,
	_tt3,
	_tt4,
	_tt5,
	_urinalysis,
	_hbs_antigen,
	_CBC,
	_RPR,
	_blood_typing,
	_HIV,
	_prev_pregnancy_complic ,
	_checklist,
	_vit_a_date_given,
	_vit_a_prescribed,
	_iron_folic_4,
	_iron_folic_5,
	_iron_folic_6,
	_iron_folic_7,
	_iron_folic_8,
	_iron_folic_9,
	_added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_maternal_health_record_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_maternal_health_record_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_maternal_health_record_get`()
BEGIN
SELECT DATE_FORMAT(m.`dob`, "%M %d,%Y") format_birthdate, m.*  FROM `maternal_health_record` m;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_out_patient_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_out_patient_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_out_patient_add`(
	_purok_no int (11),
	_name_of_child varchar (255),
	_birthdate date,
	_age_in_months int (11),
	_height decimal(12,2),
	_weight decimal(12,2),
	_nutritional_status varchar (255),
	_added_by int (11)
    )
BEGIN
INSERT INTO `out_patient`
            (`purok_no`,
             `name_of_child`,
             `birthdate`,
             `age_in_months`,
             `height`,
             `weight`,
             `nutritional_status`,
             `added_by`)
VALUES (_purok_no,
        _name_of_child,
        _birthdate,
        _age_in_months,
        _height,
        _weight,
        _nutritional_status,
        _added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_out_patient_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_out_patient_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_out_patient_edit`(
	_purok_no INT (11),
	_name_of_child VARCHAR (255),
	_birthdate DATE,
	_age_in_months INT (11),
	_height DECIMAL(12,2),
	_weight DECIMAL(12,2),
	_nutritional_status VARCHAR (255),
	_id INT (11)
    )
BEGIN
	UPDATE `out_patient`
	SET `purok_no` = _purok_no,
	  `name_of_child` = _name_of_child,
	  `birthdate` = _birthdate,
	  `age_in_months` = _age_in_months,
	  `height` = _height,
	  `weight` = _weight,
	  `nutritional_status` = _nutritional_status
	WHERE `id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_out_patient_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_out_patient_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_out_patient_get`()
BEGIN
SELECT DATE_FORMAT(op.`birthdate`, "%M %d,%Y") Formatbirthdate,op.* FROM `out_patient` op;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_patient_details_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_patient_details_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_patient_details_add`(
	_last_name varchar (255),
	_first_name VARCHAR (255),
	_name_extension VARCHAR (50),
	_middle_name VARCHAR (255),
	_maiden_last_name VARCHAR (255),
	_maiden_first_name VARCHAR (255),
	_maiden_name_extension VARCHAR (50),
	_maiden_middle_name VARCHAR (255),
	_birthdate date,
	_age int (11),
	_place_of_birth text,
	_sex VARCHAR (50),
	_civil_status VARCHAR (255),
	_religion VARCHAR (255),
	_blood_type VARCHAR (255),
	_contact_number VARCHAR (15),
	_address_purok VARCHAR (255),
	_address_barangay VARCHAR (255),
	_address_mun VARCHAR (255),
	_address_province VARCHAR (255),
	_address_country VARCHAR (255),
	_address_zip_zode VARCHAR (25),
	_educational_attainment VARCHAR (255),
	_employment_status VARCHAR (255),
	_TIN VARCHAR (50),
	_ph_stat VARCHAR (255),
	_phic_id_no VARCHAR (100),
	_phic_status_type VARCHAR (255),
	_is_4p int (11),
	_4p_id_no VARCHAR (100),
	_4p_status_type VARCHAR (255),
	_membership_cat VARCHAR (255),
	_partner_last_name VARCHAR (255),
	_partner_first_name VARCHAR (255),
	_partner_name_extension VARCHAR (50),
	_partner_middle_name VARCHAR (255),
	_partner_birthdate date,
	_partner_sex VARCHAR (50),
	_partner_phic_id VARCHAR (50),
	_father_last_name VARCHAR (255),
	_father_first_name VARCHAR (255),
	_father_name_extension VARCHAR (50),
	_father_middle_name VARCHAR (255),
	_father_birthdate DATE,
	_father_disability VARCHAR (255),
	_father_phic_id VARCHAR (50),
	_mother_last_name VARCHAR (255),
	_mother_first_name VARCHAR (255),
	_mother_name_extension VARCHAR (50),
	_mother_middle_name VARCHAR (255),
	_mother_birthdate DATE,
	_mother_disability VARCHAR (255),
	_mother_phic_id VARCHAR (50),
	_added_by int (11)
    )
BEGIN
INSERT INTO `patient_details`
            (`last_name`,
             `first_name`,
             `name_extension`,
             `middle_name`,
             `maiden_last_name`,
             `maiden_first_name`,
             `maiden_name_extension`,
             `maiden_middle_name`,
             `birthdate`,
             `age`,
             `place_of_birth`,
             `sex`,
             `civil_status`,
             `religion`,
             `blood_type`,
             `contact_number`,
             `address_purok`,
             `address_barangay`,
             `address_mun`,
             `address_province`,
             `address_country`,
             `address_zip_zode`,
             `educational_attainment`,
             `employment_status`,
             `TIN`,
             `ph_stat`,
             `phic_id_no`,
             `phic_status_type`,
             `is_4p`,
             `4p_id_no`,
             `4p_status_type`,
             `membership_cat`,
             `partner_last_name`,
             `partner_first_name`,
             `partner_name_extension`,
             `partner_middle_name`,
             `partner_birthdate`,
             `partner_sex`,
             `partner_phic_id`,
             `father_last_name`,
             `father_first_name`,
             `father_name_extension`,
             `father_middle_name`,
             `father_birthdate`,
             `father_disability`,
             `father_phic_id`,
             `mother_last_name`,
             `mother_first_name`,
             `mother_name_extension`,
             `mother_middle_name`,
             `mother_birthdate`,
             `mother_disability`,
             `mother_phic_id`,
             `added_by`)
VALUES (_last_name,
        _first_name,
        _name_extension,
        _middle_name,
        _maiden_last_name,
        _maiden_first_name,
        _maiden_name_extension,
        _maiden_middle_name,
        _birthdate,
        _age,
        _place_of_birth,
        _sex,
        _civil_status,
        _religion,
        _blood_type,
        _contact_number,
        _address_purok,
        _address_barangay,
        _address_mun,
        _address_province,
        _address_country,
        _address_zip_zode,
        _educational_attainment,
        _employment_status,
        _TIN,
        _ph_stat,
        _phic_id_no,
        _phic_status_type,
        _is_4p,
        _4p_id_no,
        _4p_status_type,
        _membership_cat,
        _partner_last_name,
        _partner_first_name,
        _partner_name_extension,
        _partner_middle_name,
        _partner_birthdate,
        _partner_sex,
        _partner_phic_id,
        _father_last_name,
        _father_first_name,
        _father_name_extension,
        _father_middle_name,
        _father_birthdate,
        _father_disability,
        _father_phic_id,
        _mother_last_name,
        _mother_first_name,
        _mother_name_extension,
        _mother_middle_name,
        _mother_birthdate,
        _mother_disability,
        _mother_phic_id,
        _added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_patient_details_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_patient_details_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_patient_details_get`()
BEGIN
	SELECT IF(pd.`name_extension` = "",CONCAT(pd.`first_name`, " ",pd.`middle_name`," ",pd.`last_name`), CONCAT(pd.`first_name`, " ",pd.`middle_name`," ",pd.`last_name`, " ", pd.`name_extension`))patient_name,
	IF(pd.`maiden_name_extension` = "",CONCAT(pd.`maiden_first_name`, " ",pd.`maiden_middle_name`," ",pd.`maiden_last_name`),
	CONCAT(pd.`maiden_first_name`, " ",pd.`maiden_middle_name`," ",pd.`maiden_last_name`, " ", pd.`maiden_name_extension`)) maiden_name,
	DATE_FORMAT(pd.`birthdate`, "%M %d,%Y") format_birthdate, 
	CONCAT_WS(" ",pd.`address_purok`, pd.`address_barangay`,pd.`address_mun`,pd.`address_province`, pd.`address_country`, pd.`address_zip_code`) address,
	IF(pd.`partner_name_extension` = "",CONCAT(pd.`partner_first_name`, " ",pd.`partner_middle_name`," ",pd.`partner_last_name`),
	CONCAT(pd.`partner_first_name`, " ",pd.`partner_middle_name`," ",pd.`partner_last_name`, " ", pd.`partner_name_extension`)) partner_name,
	IF(pd.`father_name_extension` = "",CONCAT(pd.`father_first_name`, " ",pd.`father_middle_name`," ",pd.`father_last_name`),
	CONCAT(pd.`father_first_name`, " ",pd.`father_middle_name`," ",pd.`father_last_name`, " ", pd.`father_name_extension`)) father_name,
	IF(pd.`mother_name_extension` = "",CONCAT(pd.`mother_first_name`, " ",pd.`mother_middle_name`," ",pd.`mother_last_name`),
	CONCAT(pd.`mother_first_name`, " ",pd.`mother_middle_name`," ",pd.`mother_last_name`, " ", pd.`mother_name_extension`)) mother_name,
	pd.* FROM `patient_details` pd;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_add`(
    _purok_name varchar (255),
    _added_by int (11)
    )
BEGIN
	INSERT INTO `purok`
		    (`purok_name`,
		     `added_by`)
	VALUES (_purok_name, _added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_delete` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_delete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_delete`(
	_id int (11)
    )
BEGIN
DELETE
FROM `purok`
WHERE `id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_edit`(
	_purok_name varchar (255),
	_id int (11)
    )
BEGIN
UPDATE `purok` p SET p.`purok_name` = _purok_name WHERE p.`id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_family_members_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_family_members_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_family_members_get`(
	_purok_members_id int (11)
)
BEGIN
SELECT * FROM `purok_family_members` p where p.`purok_members_id` = _purok_members_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_family_member_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_family_member_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_family_member_add`(
     _purok_members_id INT (11),
     _name VARCHAR (255),
     _added_by INT (11)    
    )
BEGIN
	INSERT INTO `purok_family_members`
		    (`purok_members_id`,
		     `name`,
		     `added_by`)
	VALUES (_purok_members_id,
		_name,
		_added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_family_member_delete` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_family_member_delete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_family_member_delete`(
	_id int (11)
    )
BEGIN
DELETE FROM `purok_family_members` WHERE id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_family_member_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_family_member_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_family_member_edit`(
	_name varchar (255),
	_id int (11)
    )
BEGIN
UPDATE `purok_family_members` p SET p.`name` = _name WHERE p.`id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_get`()
BEGIN
	SELECT
	  `id`,
	  `purok_name`,
	  `added_by`,
	  `added_on`
	FROM `purok`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_members_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_members_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_members_add`(
     _purok_id int (11),
     _name varchar (255),
     _added_by int (11)
    )
BEGIN
INSERT INTO `purok_members`
            (`purok_id`,
             `name`,
             `added_by`)
VALUES (_purok_id,
	_name,
	_added_by);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_members_delete` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_members_delete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_members_delete`(
    _id int(11)
    )
BEGIN
DELETE
FROM `purok_members`
WHERE `id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_members_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_members_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_members_edit`(
	_name varchar (255),
	_id int (11)
    )
BEGIN
UPDATE `purok_members` p SET p.`name` = _name WHERE p.`id` = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purok_members_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purok_members_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purok_members_get`(
    _purok_id int (11)
    )
BEGIN
SELECT
*
FROM `purok_members` WHERE `purok_id` = _purok_id;
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
