<?php

$Usuario=$_REQUEST["txtUsuario"]; 
$idAlimento=$_REQUEST["idAlimento"];
$txtAlimento=$_REQUEST["txtAlimento"];
$idActividad=$_REQUEST["idActividad"];
$txtActividad=$_REQUEST["txtActividad"]; 
$idTexto=$_REQUEST["idTexto"];
$txtTexto=$_REQUEST["txttexto"];


require '../app/app.php';
tecnotiv::update($idAlimento, $txtAlimento, $idActividad, $txtActividad, $idTexto, $txtTexto, $Usuario);

?>

<h1>Perfecto</h1>
