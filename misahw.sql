/*
 Navicat Premium Data Transfer

 Source Server         : mariadb
 Source Server Type    : MariaDB
 Source Server Version : 100604
 Source Host           : localhost:3306
 Source Schema         : misahw

 Target Server Type    : MariaDB
 Target Server Version : 100604
 File Encoding         : 65001

 Date: 03/09/2021 17:46:21
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for employees
-- ----------------------------
DROP TABLE IF EXISTS `employees`;
CREATE TABLE `employees`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `Gender` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `DateOfBirth` datetime NULL DEFAULT NULL,
  `CMND` int(11) NULL DEFAULT NULL,
  `Position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `Department` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `STK` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `BankName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  `ChiNhanhNH` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 17 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_vietnamese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employees
-- ----------------------------
INSERT INTO `employees` VALUES (1, 'Code_01', 'Pham Nhu Canh', 'Nu', '2021-08-31 21:53:46', 123456789, 'GIAMDOC', 'HR', '123456789', 'VCB', 'Ha noi');
INSERT INTO `employees` VALUES (6, 'string323456', 'string3123456', 'N?', '2021-09-01 16:35:35', 0, 'string', 'TAICHINH', 'string', 'string', 'string');
INSERT INTO `employees` VALUES (7, 'Code_02', 'Canh', 'nam', '2021-09-03 10:32:40', 123684785, 'NHANVIEN', 'IT', '987654321', 'MB', 'HA NOI');
INSERT INTO `employees` VALUES (8, 'Test', 'Test', 'N?', '2021-09-01 16:35:35', 0, 'string', 'IT', 'string', 'string', 'string');
INSERT INTO `employees` VALUES (9, 'Code_02', 'string', 'N?', '2021-09-03 08:56:34', 0, 'string', 'string', 'string', 'string', 'string');
INSERT INTO `employees` VALUES (10, 'string', 'string', 'string', '2021-09-03 08:51:47', 0, 'string', 'string', 'string', 'string', 'string');
INSERT INTO `employees` VALUES (11, 'Code_6', '123456789', 'Nam', '2021-09-03 08:51:47', 1234567, '123456', 'HR', '', '', '');
INSERT INTO `employees` VALUES (12, 'Code_7', '12345678', 'Nam', '2021-09-03 08:51:47', 0, '12345r', 'LETAN', '', '', '');
INSERT INTO `employees` VALUES (13, 'Code_7', '12345678', 'N?', '2021-09-03 08:51:47', 0, '12345r', 'LETAN', '', '', '');
INSERT INTO `employees` VALUES (14, 'Code_9', '23456', 'Nam', '2021-09-03 08:51:47', 123456, '12345', 'TAICHINH', '', '', '');
INSERT INTO `employees` VALUES (15, 'Code_10', 'Tesst', 'Nam', '2021-09-03 08:51:47', 12345, '', 'IT', '', '', '');
INSERT INTO `employees` VALUES (16, 'Code_11', '1234567', 'Nam', '2021-09-03 08:51:47', 0, '1234567', 'IT', '', '', '');

SET FOREIGN_KEY_CHECKS = 1;
