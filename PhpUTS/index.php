<?php
$id = "";
$Nama = "";
$sex = "";
$tgl = "";
$Telp = "";
$Email = "";
$Alamat = "";
$Kota = "";
$Kode_Pos = "";
$Catetan = "";
$action = "form_add.php";
if (isset($_GET['id'])){
	$id = $_GET['id'];
	include"koneksi1.php";
	$query = "select * from produk
			where produkid ='" .$id."'";
			$row = mysql_query($query);
			$res = mysql_fetch_array($row);
			$Nama = $res['Nama'];
			$sex = $res['sex'];
			$tgl = $res['tgl'];
			$Telp = $res['Telp'];
			$Alamat = $res['Alamat'];
			$Kota = $res['Kota'];
			$Kode_Pos = $res['Kode_Pos'];
			$Catetan = $res['Catetan'];
			$action ="form_update.php";
}

?>

<form method= "POST" action="form_add.php" enctype="multipart/form-data" action="<?php echo $action; ?>">
<input type="hidden" value=<?php echo $id; ?> name="id">
<table align="center">
<tr>
<td> Nama Lengkap </td>
<td> <input type ="text" name = "Nama" value=<?php echo $Nama; ?> > </td>
</tr>
<tr>
<td> Jenis Kelamin </td>
<td> <input type = "radio" name="sex" value= "Laki-Laki" value=<?php echo $sex; ?> >Laki-Laki <br>
 <input type = "radio" name="sex" value= "Perempuan" value=<?php echo $sex; ?> >Perempuan </td>
</tr>
<tr>
<td>Tanggal Lahir </td>
<td> <input type="date" name="tgl" value=<?php echo $tgl; ?>> </td>
</tr>
<tr>
<td>Telepon</td>
<td><input type = "text" name="Telp" value=<?php echo $Telp; ?> ></td>
</tr>
<tr>
<td>Email</td>
<td><input type = "text" name="Email" value=<?php echo $Email; ?> ></td>
</tr>
<tr>
<td>Alamat</td>
<td><textarea name="Alamat" cols="30" rows="5" id="Alamat" value=<?php echo $Alamat; ?>></textarea></td>
</tr>
<tr>
<td>Kota</td>
<td><input type = "text" name="Kota" value=<?php echo $Kota; ?> ></td>
</tr>
<tr>
<td>Kode Pos</td>
<td><input type = "text" name="Kode_Pos" value=<?php echo $Kode_Pos; ?> ></td>
</tr>
<tr>
<td>catetan</td>
<td><input type = "text" name="Catetan" value=<?php echo $Catetan; ?> ></td>
</tr>
<tr>
<td> </td>
<td><button type="submit" class="btn btn-outline-primary"> Save</button> &nbsp <button type="submit" class="btn btn-outline-primary">Cancel </button>
</td>
</tr>
</form>
</table>
