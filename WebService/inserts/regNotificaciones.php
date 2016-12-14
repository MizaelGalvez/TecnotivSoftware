<?php

$Usuario=$_REQUEST["txtUsuario"]; // nombre de la varieable del input que queremos tomar por el post
$idAlimento=$_REQUEST["idAlimento"];
$txtAlimento=$_REQUEST["txtAlimento"];
$idActividad=$_REQUEST["idActividad"];
$txtActividad=$_REQUEST["txtActividad"]; // nombre de la varieable del input que queremos tomar por el post
$idTexto=$_REQUEST["idTexto"];
$txtTexto=$_REQUEST["txttexto"];

require '../app/app.php';
tecnotiv::insert($Usuario, $idAlimento, $txtAlimento, $idActividad, $txtActividad, $idTexto, $txtTexto);

?>

