/*
Sesion de un usuario Sistema bravo
author: Ciro - Lucio

 */

 public class Sesion{

     //att
    private DateTime fechaDesde;
    private DateTime fechaHasta;

    private Usuario user;
     //const
    public Sesion(){

        this.fechaDesde = DateTime.Now;

    }

     //mth

    public Usuario GetUsuario(){

        return this.user;

    }



 }