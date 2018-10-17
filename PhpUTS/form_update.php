<?php
include"koneksi1.php"
$id 		= $_POST['id'];
$namaproduk = $_POST['nama'];
$harga		= $_POST['harga'];
$qty 		= $_POST['qty'];

$query = "UPDATE produk SET
		namaproduk='$namaproduk',
		harga=$harga,
		qty=$qty
		WHERE produkid='$id'"
mysql_query($query);

		header("location:../index.php?mod=list");