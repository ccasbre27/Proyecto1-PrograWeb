function CargarPrecioBeginner(primerCarga) {

    try {

        var precioNormal = $("#txtPrecio").val();

        var precioDescuento = precioNormal - (precioNormal * 0.15);

        $("#costoLJ").text(precioNormal);
        $("#costoMS").text(precioDescuento);

        $("#alertResultadoClase").removeClass("alert-danger");
        $("#alertResultadoClase").addClass("alert-success");

        $("#alertDescripcion").text("El nuevo precio ha sido aplicado exitosamente");

    } catch (e) {

        $("#alertResultadoClase").removeClass("alert-success");
        $("#alertResultadoClase").addClass("alert-danger");

        $("#alertDescripcion").text("Ha ocurrido un errorr. Sólo se permiten números, verifique el valor ingresado e intente de nuevo");
      
    }

    if (primerCarga) {
        $("#alertResultadoClase").addClass("hidden");
        
    }
    else {
        $("#alertResultadoClase").show();
        $("#alertResultadoClase").removeClass("hidden");
    }
   
  
}

