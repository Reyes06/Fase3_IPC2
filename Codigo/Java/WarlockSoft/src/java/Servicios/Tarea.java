
package Servicios;

import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Eddy
 */
@WebService(serviceName = "Tarea")
public class Tarea {

    @WebMethod(operationName = "agregarTarea")
    public boolean agregarTarea(@WebParam(name = "nombre") String nombre,
                        @WebParam(name="descripcion") String descripcion,
                        @WebParam(name="diaIni") int diaIni,
                        @WebParam(name="mesIni") int mesIni,
                        @WebParam(name="anoIni") int anoIni,
                        @WebParam(name="diaFin") int diaFin,
                        @WebParam(name="mesFin") int mesFin,
                        @WebParam(name="anoFin") int anoFin,
                        @WebParam(name="precio") double precio,
                        @WebParam(name="cantidadParticipantes") int cantidadParticipantes,
                        @WebParam(name="estado") String estado,
                        @WebParam(name="id_usuario") int id_usuario,
                        @WebParam(name="conocimientos") String[] conocimientos
                        ) {
        Conexion c = new Conexion();
        try {
            return c.agregarTarea(nombre, descripcion, diaIni, mesIni, anoIni, diaFin, mesFin, anoFin, precio, cantidadParticipantes, estado, id_usuario, conocimientos);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    
    @WebMethod(operationName="obtenerTareasIndividuales")
    public String[] obtenerTareasIndividuales(){
        Conexion conexion = new Conexion();
        try {
            return conexion.obtenerTareasIndividuales();
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
    @WebMethod(operationName="obtenerMisTareasIndividuales")
    public String[] obtenerMisTareasIndividuales(@WebParam(name="id_usuario") int id_usuario){
        Conexion conexion = new Conexion();
        try {
            return conexion.obtenerMisTareasIndividuales(id_usuario);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
    @WebMethod(operationName="obtenerDatosTarea")
    public String[] obtenerDatosTarea(@WebParam(name= "id_tarea") int id_tarea){
        Conexion conexion = new Conexion();
        try {
            return conexion.obtenerTarea(id_tarea);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
    @WebMethod(operationName="cambiarEstado")
    public boolean CambiarEstadoTarea(@WebParam(name= "id_tarea") int id_tarea,
                                 @WebParam(name= "estado") String estado){
        Conexion conexion = new Conexion();
        try {
            return conexion.cambiarEstadoTarea(id_tarea, estado);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    
    @WebMethod(operationName="agregarMiembrosPorTarea")
    public boolean agregarMiembrosPorTarea(@WebParam(name= "id_tarea") int id_tarea,
                                           @WebParam(name= "id_usuario") int id_usuario){
        Conexion conexion = new Conexion();
        try {
            return conexion.agregarMiembrosPorTarea(id_tarea, id_usuario);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    
    @WebMethod(operationName="obtenerMiembrosParticipantesPorTarea")
    public String[] obtenerMiembrosParticipantesPorTarea(@WebParam(name= "id_tarea") int id_tarea){
        Conexion conexion = new Conexion();
        try {
            return conexion.obtenerMiembrosParticipantesPorTarea(id_tarea);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
    @WebMethod(operationName="obtenerMiembrosInscritosPorTarea")
    public String[] obtenerMiembrosInscritosPorTarea(@WebParam(name= "id_tarea") int id_tarea){
        Conexion conexion = new Conexion();
        try {
            return conexion.obtenerMiembrosInscritosPorTarea(id_tarea);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
    
    @WebMethod(operationName="elegirParticipanteTarea")
    public boolean elegirParticipanteTarea(@WebParam(name= "id_usuario") int id_usuario, 
            @WebParam(name= "id_tarea") int id_tarea){
        Conexion conexion = new Conexion();
        try {
            return conexion.elegirParticipanteTarea(id_usuario, id_tarea);
        } catch (SQLException ex) {
            Logger.getLogger(Tarea.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
}
