SELECT 
ART.idArticulo AS IdArticulo,
ART.descripcionArticulo AS DescripcionArticulo,
CL.descripcionClasificacion AS Clasificacion,
PR.descripcionPresentacion AS Presentacion,
ART.disponible AS Disponible,
ART.costoUnitario AS CostoUnitario,
ART.precioVenta AS PrecioVenta

FROM tb_cat_articulo ART

LEFT JOIN tb_cat_clasificacion_art CL ON ART.idClasificacion=CL.idClasificacion
LEFT JOIN tb_cat_presentacion_art PR ON ART.idPresentacion=PR.idPresentacion
