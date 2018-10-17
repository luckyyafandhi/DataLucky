<?php

include "koneksi.php";

$Nama	= $_POST['Nama'];
$sex		= $_POST['sex'];
$bulan		= $_POST['tgl'];
$Telp		= $_POST['Telp'];
$Email		= $_POST['Email'];
$Alamat		= $_POST['Alamat'];
$Kota		= $_POST['Kota'];
$Kode_Pos	= $_POST['Kode_Pos'];
$Catetan	= $_POST['Catetan'];
$id			= getAutoId('id','form','idmbr');

$query = "INSERT INTO `dbuts`.`form`
			(`id`, `Nama`, `sex`, `tgl`,`Telp`,`Email`,`Alamat`,`Kota`,`Kode_Pos`,`Catetan`)
			VALUES ('$id', '$Nama', '$sex', '$tgl', '$telp','$email','$alamat','$kota','$kode_pos','$Catetan')";
			

mysql_query ($query);

header ("location:list.php");
?>