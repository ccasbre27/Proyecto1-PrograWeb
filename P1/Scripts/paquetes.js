function CargarPrecios(primerCarga) {



    var precioNormal = $("#txtPrecio").val();
    var descuento = "0." + $("#txtDescuento").val();

    var precioDescuento = precioNormal - (precioNormal * parseFloat(descuento));

    if (isNaN(precioDescuento)) {
        $("#alertResultadoClase").removeClass("alert-success");
        $("#alertResultadoClase").addClass("alert-danger");

        $("#alertDescripcion").text("Sólo se permiten números, verifique el valor ingresado e intente de nuevo");

    }
    else {

        $("#precioNormal").text(precioNormal);
        $("#precioDescuento").text(precioDescuento);

        $("#alertResultadoClase").removeClass("alert-danger");
        $("#alertResultadoClase").addClass("alert-success");

        $("#alertDescripcion").text("El nuevo precio ha sido aplicado exitosamente");
    }
      

    if (primerCarga) {
        $("#alertResultadoClase").addClass("hidden");
        
    }
    else {
        $("#alertResultadoClase").show();
        $("#alertResultadoClase").removeClass("hidden");
    }
   
  
}

