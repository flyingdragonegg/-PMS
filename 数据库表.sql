/*
SQLyog Ultimate v10.00 Beta1
MySQL - 5.7.21-log : Database - db_companypms
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_companypms` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `db_companypms`;

/*Table structure for table `attenceinfo` */

DROP TABLE IF EXISTS `attenceinfo`;

CREATE TABLE `attenceinfo` (
  `id` int(11) DEFAULT NULL,
  `userid` int(11) DEFAULT NULL,
  `attencetype` varchar(20) DEFAULT NULL,
  `attencedate` datetime DEFAULT NULL,
  `attencetime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `attenceinfo` */

/*Table structure for table `deptinfo` */

DROP TABLE IF EXISTS `deptinfo`;

CREATE TABLE `deptinfo` (
  `id` int(1) NOT NULL AUTO_INCREMENT,
  `deptname` varchar(20) DEFAULT NULL,
  `deptinfo` varchar(50) DEFAULT NULL,
  `deptleader` varchar(20) DEFAULT NULL,
  `deptunum` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

/*Data for the table `deptinfo` */

insert  into `deptinfo`(`id`,`deptname`,`deptinfo`,`deptleader`,`deptunum`) values (1,'技术部','技术部','张三',1),(3,'吃饭部','吃饭部','李四',1);

/*Table structure for table `rewardsinfo` */

DROP TABLE IF EXISTS `rewardsinfo`;

CREATE TABLE `rewardsinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userid` int(11) DEFAULT NULL,
  `uname` varchar(20) DEFAULT NULL,
  `本次薪资` decimal(18,3) DEFAULT '0.000',
  `总共资产` decimal(18,3) DEFAULT '0.000',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `rewardsinfo` */

insert  into `rewardsinfo`(`id`,`userid`,`uname`,`本次薪资`,`总共资产`) values (4,4,'zr','20.000','21.000');

/*Table structure for table `rewardsinfo_copy` */

DROP TABLE IF EXISTS `rewardsinfo_copy`;

CREATE TABLE `rewardsinfo_copy` (
  `id` int(11) DEFAULT NULL,
  `userid` int(11) DEFAULT NULL,
  `rewardstype` varchar(20) DEFAULT NULL,
  `rewardsprice` decimal(18,3) DEFAULT NULL,
  `rewardsmonth` int(11) DEFAULT NULL,
  `addate` datetime DEFAULT NULL,
  `uname` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `rewardsinfo_copy` */

/*Table structure for table `userfileinfo` */

DROP TABLE IF EXISTS `userfileinfo`;

CREATE TABLE `userfileinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `姓名` varchar(255) DEFAULT NULL,
  `民族` varchar(255) DEFAULT NULL,
  `文化程度` varchar(255) DEFAULT NULL,
  `成员码` int(11) DEFAULT NULL,
  `filename` varchar(20) DEFAULT NULL,
  `工作经验` varchar(2000) DEFAULT NULL,
  `专业技能` varchar(2000) DEFAULT NULL,
  `联系电话` varchar(2000) DEFAULT NULL,
  `联系邮箱` varchar(255) DEFAULT NULL,
  `性别` varchar(255) DEFAULT NULL,
  `所属派系` varchar(255) DEFAULT NULL,
  `联系地址` varchar(255) DEFAULT NULL,
  `所属省份` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `userfileinfo` */

insert  into `userfileinfo`(`id`,`姓名`,`民族`,`文化程度`,`成员码`,`filename`,`工作经验`,`专业技能`,`联系电话`,`联系邮箱`,`性别`,`所属派系`,`联系地址`,`所属省份`) values (2,'zzz','汉族','本科',4408,NULL,'睡觉第一名','吃喝拉撒睡','11111111111','@','男','睡觉部','test','广东省'),(3,'rrr','汉族','本科',4408,NULL,'五年游玩工作者','玩玩玩玩玩','22222222222','@','女','游乐部','test','广东省'),(4,'zr','汉族','本科',4408,NULL,'睡觉第二名','吃喝睡','11111111111','@','男','睡觉部','test','广door省');

/*Table structure for table `userinfo` */

DROP TABLE IF EXISTS `userinfo`;

CREATE TABLE `userinfo` (
  `id` int(1) NOT NULL AUTO_INCREMENT,
  `uname` varchar(20) DEFAULT NULL,
  `upass` varchar(20) DEFAULT NULL,
  `utel` varchar(11) DEFAULT NULL,
  `uemail` varchar(20) DEFAULT NULL,
  `uaddress` varchar(50) DEFAULT NULL,
  `deptid` int(11) DEFAULT NULL,
  `upower` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

/*Data for the table `userinfo` */

insert  into `userinfo`(`id`,`uname`,`upass`,`utel`,`uemail`,`uaddress`,`deptid`,`upower`) values (1,'admin','123456','13300001111','1411090538@qq.com','测试',1,'员工\n添加，员工管理'),(2,'sisi','123456','123456','2070322017@qq.com','test',2,NULL),(3,'xiaowu','123456','13922573478','2070322017@qq.com','test',3,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
