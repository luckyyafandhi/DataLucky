<?php
include "koneksi.php";
// menyimpan data id kedalam variabel
$id   = $_GET['id'];
// query SQL untuk insert data
$query="DELETE from produk WHERE form='$id'";
mysql_query($query);
// mengalihkan ke halaman index.php
header("location:list.php");
?>