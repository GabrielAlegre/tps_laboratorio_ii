Create database NetComSucursales;
GO
use NetComSucursales;
GO
create table Sucursales(
idSucursal int identity primary key,
provincia varchar(50) not null,
localidad varchar(50) not null,
direccion varchar(50) not null,
telefono varchar(12) not null
)

INSERT INTO Sucursales (provincia, localidad, direccion, telefono) 
VALUES 
('Catamarca', 'Kempes', 'Tristan Malbran 2356', '1134568796'),
('Cordoba', 'Lagos', 'Calle Falsa 123', '1124578765'),
('Buenos Aires', 'Villa dominico', 'Chascomus 2356', '1135678190'),
('Chaco', 'Dock sud', 'Pieri 878', '1143568790'),
('Corrientes', 'Azul', 'California 464', '1145675957'),
('Chubut', 'Crucesita', 'San martin 2689', '1146789875'),
('Entre rios', 'Barracas', 'Irala 1346', '1187567897'),
('Formosa', 'Pilcomayo', 'Brandsen 124', '1123456789'),
('Jujuy', 'Cochinoca', 'Cerri 654', '1145765456'),
('La pampa', 'Hucal', 'Cnel Salvadores 3243', '1198757345'),
('Mendoza', 'San Rafael', 'Rio cuarto 4649', '1135677676'),
('Misiones', 'Iguazu', 'Suarez 356', '1156896533'),
('Neuquen', 'Catan Lil', 'Arenales 879', '1166878877'),
('Rio negro', 'Pichi Mahuida', 'Gral Paz 223', '1146789875'),
('Salta', 'Anta', 'French 454', '1198752345'),
('San Juan', 'Caucete', 'Lavalle 4256', '1134578975'),
('San Luis', 'Dupuy', 'Ameghino 232', '1157987649'),
('Santa Cruz', 'Ayacucho', 'Av. Roca 578', '1198676464'),
('Santa Fe', 'Ceres', 'Mones de Oca 986', '1187907556'),
('Santiago Del Estero', 'San Carlos', 'Helguera 234', '1123644567'),
('Tierra del Fuego', 'Reconquista', 'Talpaque 976', '1123644567'),
('Tucuman', 'Monteros', 'Gutierrez 1212', '1123644567');

SELECT * FROM Sucursales;
