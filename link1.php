<?php
session_start();
$link = mysql_connect("localhost", "root", "zakaz791"); // MySQL Host , Username and password
$db_selected = mysql_select_db('1v1', $link); // MySQL Database
mysql_query("SET NAMES utf8");

function fetchinfo($rowname,$tablename,$finder,$findervalue)
{
	if($finder == "1") $result = mysql_query("SELECT $rowname FROM $tablename");
	else $result = mysql_query("SELECT $rowname FROM $tablename WHERE `$finder`='$findervalue'");
	$row = mysql_fetch_assoc($result);
	return $row[$rowname];
}
?>