<?php

$Usuario=$_REQUEST["txtUsuario"]; // nombre de la varieable del input que queremos tomar por el post
$Contraseña=$_REQUEST["txtContraseña"];

require '../app/app.php';
tecnotiv::insertUsuario($Usuario, $Contraseña);

?>

