USE [SysLibreria]
GO
/****** Object:  StoredProcedure [dbo].[ReporteVenta]    Script Date: 13/03/2021 09:23:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------ TABLA DETALLEVENTA -------------------------
ALTER PROCEDURE [dbo].[ReporteVenta]
@fecha date
AS
SELECT v.VentaId AS VentaID, v.Fecha, p.NombreProducto AS ProductoVendido, dv.Cantidad, dv.Total
FROM DetalleVenta AS dv INNER JOIN Producto AS p 
ON dv.ProductoId = p.ProductoId INNER JOIN Venta AS v
ON dv.VentaId = v.VentaId where v.Fecha=@fecha
