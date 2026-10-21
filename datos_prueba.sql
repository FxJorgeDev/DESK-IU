USE SoporteTecnicoDB;
GO

-- DATOS DE PRUEBA
-- (ejecutar cuantas veces se quiera, los INSERT estan protegidos)

-- 1. CATEGORIAS
MERGE CATEGORIA AS target
USING (VALUES
    ('Hardware',      'Problemas fisicos: PC, teclado, monitor, impresora'),
    ('Software',      'Problemas de programas, SO, licencias'),
    ('Redes',         'Problemas de conectividad, WiFi, VPN'),
    ('Accesos',       'Problemas de cuentas, permisos, credenciales'),
    ('Correo',        'Problemas con Outlook, webmail, firmas')
) AS source (Nombre, Descripcion)
ON target.Nombre = source.Nombre
WHEN NOT MATCHED THEN
    INSERT (Nombre, Descripcion, Activo, FechaCreacion, CreadoPor)
    VALUES (source.Nombre, source.Descripcion, 1, GETDATE(), 'sistema');
GO

-- 2. TECNICOS
MERGE TECNICO AS target
USING (VALUES
    ('Carlos','Quispe','carlos.quispe@empresa.com','Hardware'),
    ('Lucia','Torres','lucia.torres@empresa.com','Software'),
    ('Miguel','Chavez','miguel.chavez@empresa.com','Accesos y Red'),
    ('Ana','Flores','ana.flores@empresa.com','Accesos y Red'),
    ('Elias','Bolanos','elias.bolanos@empresa.com','Hardware')
) AS source (Nombre, Apellido, Correo, Especialidad)
ON target.Correo = source.Correo
WHEN NOT MATCHED THEN
    INSERT (Nombre, Apellido, Correo, Especialidad, Disponibilidad, FechaDisponibilidad, Activo, FechaCreacion, CreadoPor)
    VALUES (source.Nombre, source.Apellido, source.Correo, source.Especialidad, 'Disponible', GETDATE(), 1, GETDATE(), 'sistema');
GO

-- 3. USUARIOS (20)
MERGE USUARIO AS target
USING (VALUES
    ('Juan','Perez','juan.perez@empresa.com','999111001','Docente'),
    ('Maria','Lopez','maria.lopez@empresa.com','999111002','Docente'),
    ('Pedro','Garcia','pedro.garcia@empresa.com','999111003','Estudiante'),
    ('Rosa','Martinez','rosa.martinez@empresa.com','999111004','Estudiante'),
    ('Luis','Rodriguez','luis.rodriguez@empresa.com','999111005','Administrativo'),
    ('Carmen','Diaz','carmen.diaz@empresa.com','999111006','Docente'),
    ('Jose','Sanchez','jose.sanchez@empresa.com','999111007','Estudiante'),
    ('Sofia','Ramirez','sofia.ramirez@empresa.com','999111008','Administrativo'),
    ('Diego','Torres','diego.torres@empresa.com','999111009','Docente'),
    ('Valeria','Morales','valeria.morales@empresa.com','999111010','Estudiante'),
    ('Andres','Ortiz','andres.ortiz@empresa.com','999111011','Estudiante'),
    ('Paula','Vega','paula.vega@empresa.com','999111012','Docente'),
    ('Ricardo','Castro','ricardo.castro@empresa.com','999111013','Administrativo'),
    ('Gabriela','Ruiz','gabriela.ruiz@empresa.com','999111014','Estudiante'),
    ('Fernando','Silva','fernando.silva@empresa.com','999111015','Docente'),
    ('Daniela','Herrera','daniela.herrera@empresa.com','999111016','Estudiante'),
    ('Mario','Castillo','mario.castillo@empresa.com','999111017','Administrativo'),
    ('Andrea','Paredes','andrea.paredes@empresa.com','999111018','Docente'),
    ('Hector','Reyes','hector.reyes@empresa.com','999111019','Estudiante'),
    ('Monica','Guerrero','monica.guerrero@empresa.com','999111020','Administrativo')
) AS source (Nombre, Apellido, Correo, Celular, TipoUsuario)
ON target.Correo = source.Correo
WHEN NOT MATCHED THEN
    INSERT (Nombre, Apellido, Correo, Celular, TipoUsuario, Activo, FechaCreacion, CreadoPor)
    VALUES (source.Nombre, source.Apellido, source.Correo, source.Celular, source.TipoUsuario, 1, GETDATE(), 'sistema');
GO

-- 4. SOLICITUDES (usando IDs reales de las tablas)
DECLARE @catHardware INT = (SELECT IdCategoria FROM CATEGORIA WHERE Nombre='Hardware');
DECLARE @catSoftware INT = (SELECT IdCategoria FROM CATEGORIA WHERE Nombre='Software');
DECLARE @catRedes   INT = (SELECT IdCategoria FROM CATEGORIA WHERE Nombre='Redes');
DECLARE @catAccesos INT = (SELECT IdCategoria FROM CATEGORIA WHERE Nombre='Accesos');
DECLARE @catCorreo  INT = (SELECT IdCategoria FROM CATEGORIA WHERE Nombre='Correo');

DECLARE @tecCarlos INT = (SELECT IdTecnico FROM TECNICO WHERE Correo='carlos.quispe@empresa.com');
DECLARE @teLucia   INT = (SELECT IdTecnico FROM TECNICO WHERE Correo='lucia.torres@empresa.com');
DECLARE @tecMiguel INT = (SELECT IdTecnico FROM TECNICO WHERE Correo='miguel.chavez@empresa.com');
DECLARE @tecAna    INT = (SELECT IdTecnico FROM TECNICO WHERE Correo='ana.flores@empresa.com');
DECLARE @tecElias  INT = (SELECT IdTecnico FROM TECNICO WHERE Correo='elias.bolanos@empresa.com');

DECLARE @usu1 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='juan.perez@empresa.com');
DECLARE @usu2 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='maria.lopez@empresa.com');
DECLARE @usu3 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='pedro.garcia@empresa.com');
DECLARE @usu4 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='rosa.martinez@empresa.com');
DECLARE @usu5 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='luis.rodriguez@empresa.com');
DECLARE @usu6 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='carmen.diaz@empresa.com');
DECLARE @usu7 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='jose.sanchez@empresa.com');
DECLARE @usu8 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='sofia.ramirez@empresa.com');
DECLARE @usu9 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='diego.torres@empresa.com');
DECLARE @usu10 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='valeria.morales@empresa.com');
DECLARE @usu11 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='andres.ortiz@empresa.com');
DECLARE @usu12 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='paula.vega@empresa.com');
DECLARE @usu13 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='ricardo.castro@empresa.com');
DECLARE @usu14 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='gabriela.ruiz@empresa.com');
DECLARE @usu15 INT = (SELECT IdUsuario FROM USUARIO WHERE Correo='fernando.silva@empresa.com');

IF NOT EXISTS (SELECT 1 FROM SOLICITUD WHERE Titulo = 'PC no enciende')
BEGIN
    INSERT INTO SOLICITUD (IdUsuario, IdTecnico, IdCategoria, Titulo, Descripcion, Estado, Prioridad, FechaRegistro, Observacion, FechaCreacion, CreadoPor)
    VALUES
    (@usu1, @tecCarlos, @catHardware, 'PC no enciende',          'La PC de escritorio no enciende, no hay luz en la fuente.',              'Resuelto',  'Alta',   DATEADD(DAY,-10,GETDATE()), 'Se cambio la fuente de poder',        GETDATE(), 'sistema'),
    (@usu2, @teLucia,   @catSoftware, 'Office no abre',           'Word y Excel no abren, aparece error de licencia.',                       'Pendiente', 'Media',  DATEADD(DAY,-8,GETDATE()),  NULL,                                     GETDATE(), 'sistema'),
    (@usu3, @tecMiguel, @catRedes,   'Sin internet',             'No hay conexion a internet en el laboratorio 3.',                         'Resuelto',  'Alta',   DATEADD(DAY,-6,GETDATE()),  'Se reinicio el switch del laboratorio', GETDATE(), 'sistema'),
    (@usu4, @tecMiguel, @catRedes,   'No puedo acceder al VPN',  'Error de autenticacion al conectar VPN desde casa.',                      'Pendiente', 'Media',  DATEADD(DAY,-4,GETDATE()),  NULL,                                     GETDATE(), 'sistema'),
    (@usu5, @tecAna,    @catCorreo,  'Correo no recibe emails',  'No llegan correos desde ayer, bandeja de entrada vacia.',                 'Resuelto',  'Alta',   DATEADD(DAY,-3,GETDATE()),  'Se libero espacio en el servidor de correo', GETDATE(), 'sistema'),
    (@usu6, @teLucia,   @catSoftware, 'Actualizar antivirus',    'El antivirus no se actualiza automaticamente.',                           'Pendiente', 'Baja',   DATEADD(DAY,-2,GETDATE()),  NULL,                                     GETDATE(), 'sistema'),
    (@usu7, @tecAna,    @catAccesos, 'Restablecer contrasena',   'Olvide mi contrasena de acceso al sistema.',                              'Resuelto',  'Media',  DATEADD(DAY,-1,GETDATE()),  'Se restablecio la contrasena',           GETDATE(), 'sistema'),
    (@usu8, @tecCarlos, @catHardware,'Monitor parpadea',         'El monitor LCD parpadea intermitentemente.',                              'Pendiente', 'Media',  GETDATE(),                   NULL,                                     GETDATE(), 'sistema'),
    (@usu9, @tecElias,  @catHardware,'Teclado no funciona',      'El teclado USB no responde, luces apagadas.',                             'Pendiente', 'Baja',   GETDATE(),                   NULL,                                     GETDATE(), 'sistema'),
    (@usu10,@tecAna,    @catAccesos, 'Crear usuario en el sistema', 'Necesito una cuenta para el nuevo asistente administrativo.',        'Pendiente', 'Media',  GETDATE(),                   NULL,                                     GETDATE(), 'sistema'),
    (@usu11,@tecElias,  @catSoftware,'Instalar AutoCAD',         'Requiero instalacion de AutoCAD en la PC del laboratorio de diseno.',     'Pendiente', 'Baja',   GETDATE(),                   NULL,                                     GETDATE(), 'sistema'),
    (@usu12,@tecCarlos, @catRedes,   'Wifi lento en oficina',    'La senal WiFi es muy debil en la oficina 203.',                          'Pendiente', 'Alta',   GETDATE(),                   NULL,                                     GETDATE(), 'sistema'),
    (@usu13,@teLucia,   @catSoftware,'Error al imprimir',        'La impresora muestra error de driver al imprimir desde cualquier PC.',    'Resuelto',  'Media',  DATEADD(DAY,-5,GETDATE()),  'Se reinstalo el driver de la impresora', GETDATE(), 'sistema'),
    (@usu14,@tecElias,  @catHardware,'Cambiar pasta termica',    'La laptop se sobrecalienta y se apaga sola.',                             'Pendiente', 'Media',  GETDATE(),                   NULL,                                     GETDATE(), 'sistema'),
    (@usu15,@tecMiguel, @catRedes,   'Configurar VPN',           'Necesito configurar VPN para trabajar desde casa.',                       'Pendiente', 'Alta',   GETDATE(),                   NULL,                                     GETDATE(), 'sistema');
END
GO

-- 5. Sincronizar disponibilidad
UPDATE TECNICO SET Disponibilidad = 'Ocupado'
WHERE IdTecnico IN (SELECT IdTecnico FROM SOLICITUD WHERE Estado = 'Pendiente') AND Activo = 1;
UPDATE TECNICO SET Disponibilidad = 'Disponible'
WHERE IdTecnico NOT IN (SELECT IdTecnico FROM SOLICITUD WHERE Estado = 'Pendiente') AND Activo = 1;
GO

PRINT 'Datos de prueba insertados correctamente.';
GO
