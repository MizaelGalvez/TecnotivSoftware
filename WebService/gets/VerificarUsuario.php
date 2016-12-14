<?php

$usuario=$_REQUEST["user"];
$contraseña=$_REQUEST["pass"];// nombre de la varieable del input que queremos tomar por el post

require '../app/app.php';
$datos = tecnotiv::verificarbActive($usuario, $contraseña);
if ($datos) {
    $res=$datos;
    print json_encode($res, JSON_UNESCAPED_UNICODE);
}else  {
    $res='[{"bActivo":"0"}]';
    
print $res;
}
?>
