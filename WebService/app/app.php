<?php
require_once '../app/BaseDatos.php';  // es necesario requerir una sola ves la clase base de datos

class tecnotiv {
    //put your code here
    function __construct() {
    }
    
    
    ///////////////////////////////////////////////////////////////////////////
    
    public static function getByid($id){
        $query="SELECT * FROM Notificador WHERE Usuario=?";
        return self::ejecutarConsultaParametro($query,array($id));
    }
    public static function verificarbActive($usuario,$contraseña){
        $query="SELECT * FROM Credenciales WHERE Usuario=? AND Contraseña=?";
        return self::ejecutarConsultaParametro($query,array($usuario,$contraseña));
    }
    
    ///////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////
    
    
    public static function insert($Usuario,$idAlimento,$txtAlimento,$idActividad,$txtActividad,$idTexto, $txtTexto){
        $query="INSERT INTO Notificador (Usuario,idAlimento,txtAlimento,idActividad,txtActividad,idTexto, txtTecto) VALUES (?, ?, ?, ?, 1);";
         try{
            
            $comando= BaseDatos::getInstance()->getDB()->prepare($query);
            $comando->execute(
                    array(
                        $Usuario,
                        $idAlimento,
                        $txtAlimento,
                        $idActividad,
                        $txtActividad,
                        $idTexto,
                        $txtTexto
                    )
                    );
            
        }catch(PDOException $ex){
            //manejar el mensaje de error
            print_r($ex);
            return FALSE;
        }
    }
    
    public static function insertUsuario($Usuario,$Contraseña){
        $query="INSERT INTO Credenciales (Usuario, Contraseña, bActivo) VALUES (?, ?, 1);";
         try{
            
            $comando= BaseDatos::getInstance()->getDB()->prepare($query);
            $comando->execute(
                    array(
                        $Usuario,
                        $Contraseña
                    )
                    );
            
        }catch(PDOException $ex){
            //manejar el mensaje de error
            print_r($ex);
            return FALSE;
        }
    }
    
    public static function update($idAlimento,$txtAlimento,$idActividad,$txtActividad,$idTexto, $txtTexto, $Usuario){
        $query="UPDATE Notificador SET idAlimento=?, txtAlimento=?, idActividad=?, txtActividad=?, idTexto=?, txtTecto=?  WHERE Usuario=?;";
         try{
            $comando= BaseDatos::getInstance()->getDB()->prepare($query);
            $comando->execute(
                    array(
                        $idAlimento,
                        $txtAlimento,
                        $idActividad,
                        $txtActividad,
                        $idTexto,
                        $txtTexto,
                        $Usuario
                    )
                    );
            
        }catch(PDOException $ex){
            //manejar el mensaje de error
            print_r($ex);
            return FALSE;
        }
    }
    
    ///////////////////////////////////////////////////////////////////////////
    ///////////////funciones para consultar con y sin parametros///////////////
    
    public static function ejecutarConsultaParametro($query,$valores){
        try{
            
            $comando= BaseDatos::getInstance()->getDB()->prepare($query);
            $comando->execute($valores);
            return $comando->fetchALL(PDO::FETCH_ASSOC);
        }catch(PDOException $ex){
            
            //manejar el mensaje de error
            return $ex;
        }
    }
    public static function ejecutarConsulta($query) {
        try{
            
            $comando= BaseDatos::getInstance()->getDB()->prepare($query);
            $comando->execute();
            return $comando->fetchALL(PDO::FETCH_ASSOC);
        }catch(PDOException $ex){
            //manejar el mensaje de error
            return FALSE;
        }
    }
}
