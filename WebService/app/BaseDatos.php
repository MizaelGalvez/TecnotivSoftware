<?php
/**
 * archivo para la coneccion a la base de datos
 * POO
 * @author MizaelGalvez y Suzuma
 */
require_once '../app/config.php';

class BaseDatos {
    public static $db=null;
    private static $pdo;
    
    final public function __construct() {
       try{
           self::getDB();
       }catch(PDOException $ex){
           //manejar los errores
       }
    }
    
    public function getDB(){
        if (self::$pdo==null) {
            self::$pdo=new PDO("mysql:host=".HOSTNAME.";dbname=".DATABASE.";charset=utf8",USERNAME,PASSWOED,
                    array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8")
                    );
            self::$pdo ->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        }
        return self::$pdo;
    }
    
    public static function getInstance(){
        if (self::$db==null) {
            self::$db=new self();
        }
        return self::$db;
    }
    
    final protected function __clone() {}
    function __destruct() {
        self::$pdo=null;
    }
    
}
