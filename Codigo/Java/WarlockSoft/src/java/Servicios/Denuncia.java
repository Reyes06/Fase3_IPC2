/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicios;

import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;

/**
 *
 * @author Eddy
 */
@WebService(serviceName = "Denuncia")
public class Denuncia {

    @WebMethod(operationName = "obtenerPubDenunciadas")
    public String[] obtenerPubDenuncias() {
        Conexion c = new Conexion();
        try {
            return c.obtenerPubDenunciadas();
        } catch (SQLException ex) {
            Logger.getLogger(Denuncia.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    @WebMethod(operationName = "obtenerComDenunciadas")
    public String[] obtenerComDenuncias() {
        Conexion c = new Conexion();
        try {
            return c.obtenerComDenunciadas();
        } catch (SQLException ex) {
            Logger.getLogger(Denuncia.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    @WebMethod(operationName = "obtenerProDenunciadas")
    public String[] obtenerProDenuncias() {
        Conexion c = new Conexion();
        try {
            return c.obtenerProDenunciadas();
        } catch (SQLException ex) {
            Logger.getLogger(Denuncia.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    @WebMethod(operationName = "obtenerTarDenunciadas")
    public String[] obtenerTarDenuncias() {
        Conexion c = new Conexion();
        try {
            return c.obtenerTarDenunciadas();
        } catch (SQLException ex) {
            Logger.getLogger(Denuncia.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
}
