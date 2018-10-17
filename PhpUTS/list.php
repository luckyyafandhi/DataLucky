<?php include "koneksi.php";?>
<div class="container">
  <center><h2>Tabel</h2>
  <p>Daftar Yang Telah Terinput</p>                                                                                      
         </center>
  <table width=85% border="3" align="center">
    <thead>
      <tr>
        <th >No</th>
        <th>Nama lengkap</th>
		<th>Telepon</th>
        <th>E-mail</th>
        <th>Alamat</th>
		<th>Action</th>
      </tr>
    </thead>
    <tbody>
	
	<?php 
	$query ="select * from form";
	$res = mysql_query($query);
	$no=1;
	while($row=mysql_fetch_array($res)){
	?>
      <tr>
        <td align="center"><?php echo $row['id'];?></td>
        <td align="center"><?php echo $row['Nama'];?> </td>
        <td align="center"><?php echo $row['Telp'];?></td>
        <td align="center"><?php echo $row['Email'];?></td>
		<td align="center"><?php echo $row['Alamat'];?></td>
        <td align="center"><a href="edit.php?&id=<?php echo $row['id'];?>"> edit</a> |<a href="deleteform.php? &id=<?php echo $row['id'];?>"> delete</a></td>
      </tr>
	<?php } ?>
	
	
    </tbody>
  </table><br><center>
  <button><a href="index.php">back</a></button>  </center>
  </div>
</div>