CREATE SCHEMA Acces
GO
CREATE TABLE Acces.tbUsuarios(
	Usuar_Id INT IDENTITY(1,1),
	Usuar_Usuario NVARCHAR(50) NOT NULL,
	Usuar_Contrasena NVARCHAR(MAX) NOT NULL,
	Emple_Id INT NOT NULL,
	Roles_Id INT NOT NULL,
	Usuar_Admin BIT NOT NULL,
	Usuar_UltimaSesion DATETIME NOT NULL,
	CONSTRAINT PK_tbUsuarios_Usuar_Id PRIMARY KEY(Usuar_Id),
	CONSTRAINT UQ_tbUsuarios_Usuar_Usuario UNIQUE(Usuar_Usuario),
	--CONSTRAINT FK_tbUsuarios_tbEmpleados_Perso_Id FOREIGN KEY (Perso_Id) REFERENCES Segur.tbEmpleados(Perso_Id),
	--CONSTRAINT FK_tbUsuarios_tbRoles_Roles_Id FOREIGN KEY (Roles_Id) REFERENCES Acces.tbRoles(Roles_Id),

	[Usuar_UsuarioCreacion] [int] NOT NULL,
	[Usuar_FechaCreacion] [datetime] NOT NULL,
	[Usuar_UsuarioModificacion] [int] NULL,
	[Usuar_FechaModificacion] [datetime] NULL,
	[Usuar_Estado] [bit] CONSTRAINT DF_tbUsuarios_Usuar_Estado DEFAULT 1,
	--CONSTRAINT FK_tbUsuarios_tbUsuarios_Usuar_UsuarioCreacion FOREIGN KEY(Usuar_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	--CONSTRAINT FK_tbUsuarios_tbUsuarios_Usuar_UsuarioModificacion FOREIGN KEY(Usuar_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Acces.tbPantallas(
	Panta_Id INT IDENTITY(1,1) NOT NULL,
	Panta_Descripcion NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_tbPantallas_Panta_Id PRIMARY KEY(Panta_Id),
	CONSTRAINT UQ_tbPantallas_Panta_Descripcion UNIQUE(Panta_Descripcion),

	[Panta_UsuarioCreacion] [int] NOT NULL,
	[Panta_FechaCreacion] [datetime] NOT NULL,
	[Panta_UsuarioModificacion] [int] NULL,
	[Panta_FechaModificacion] [datetime] NULL,
	[Panta_Estado] [bit] CONSTRAINT DF_tbPantallas_Panta_Estado DEFAULT 1,
	CONSTRAINT FK_tbPantallas_tbUsuarios_Panta_UsuarioCreacion FOREIGN KEY(Panta_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbPantallas_tbUsuarios_Panta_UsuarioModificacion FOREIGN KEY(Panta_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Acces.tbRoles(
	Roles_Id INT IDENTITY(1,1) NOT NULL,
	Roles_Descripcion NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_tbRoles_Roles_Id PRIMARY KEY(Roles_Id),
	CONSTRAINT UQ_tbRoles_Roles_Descripcion UNIQUE(Roles_Descripcion),

	[Roles_UsuarioCreacion] [int] NOT NULL,
	[Roles_FechaCreacion] [datetime] NOT NULL,
	[Roles_UsuarioModificacion] [int] NULL,
	[Roles_FechaModificacion] [datetime] NULL,
	[Roles_Estado] [bit] CONSTRAINT DF_tbRoles_Roles_Estado DEFAULT 1,
	CONSTRAINT FK_tbRoles_tbUsuarios_Roles_UsuarioCreacion FOREIGN KEY(Roles_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbRoles_tbUsuarios_Roles_UsuarioModificacion FOREIGN KEY(Roles_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Acces.tbPantallasPorRoles(
	Papro_Id INT IDENTITY(1,1) NOT NULL,
	Panta_Id INT NOT NULL,
	Roles_Id INT NOT NULL,
	CONSTRAINT PK_tbPantallasPorRoles_Papro_Id PRIMARY KEY(Papro_Id),
	CONSTRAINT FK_tbPantallasPorRoles_tbPantallas_Panta_Id FOREIGN KEY(Panta_Id) REFERENCES Acces.tbPantallas(Panta_Id),
	CONSTRAINT FK_tbPantallasPorRoles_tbRoles_Roles_Id FOREIGN KEY(Roles_Id) REFERENCES Acces.tbRoles(Roles_Id),
	CONSTRAINT UQ_tbPantallasPorRoles_Panta_Id_Roles_Id UNIQUE(Panta_Id,Roles_Id),

	[Papro_UsuarioCreacion] [int] NOT NULL,
	[Papro_FechaCreacion] [datetime] NOT NULL,
	[Papro_UsuarioModificacion] [int] NULL,
	[Papro_FechaModificacion] [datetime] NULL,
	[Papro_Estado] [bit] CONSTRAINT DF_tbPantallasPorRoles_Papro_Estado DEFAULT 1,
	CONSTRAINT FK_tbPantallasPorRoles_tbUsuarios_Papro_UsuarioCreacion FOREIGN KEY(Papro_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbPantallasPorRoles_tbUsuarios_Papro_UsuarioModificacion FOREIGN KEY(Papro_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
---------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE SCHEMA Gral
GO
CREATE TABLE Gral.tbPaises(
	Paise_Id INT IDENTITY(1,1),
	Paise_Descripcion NVARCHAR(50) NOT NULL,
	Paise_Nacionalidad NVARCHAR(70) NOT NULL,
	CONSTRAINT PK_tbPaises_Paise_Id PRIMARY KEY(Paise_Id),
	
	[Paise_UsuarioCreacion] [int] NOT NULL,
	[Paise_FechaCreacion] [datetime] NOT NULL,
	[Paise_UsuarioModificacion] [int] NULL,
	[Paise_FechaModificacion] [datetime] NULL,
	[Paise_Estado] [bit] CONSTRAINT DF_tbPaises_Paise_Estado DEFAULT 1,
	CONSTRAINT FK_tbPaises_tbUsuarios_Paise_UsuarioCreacion FOREIGN KEY(Paise_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbPaises_tbUsuarios_Paise_UsuarioModificacion FOREIGN KEY(Paise_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
--CREATE TABLE Gral.tbPersonasPorPaises(
--	Pappe_Id INT IDENTITY(1,1),
--	Perso_Id INT NOT NULL,
--	Paise_Id INT NOT NULL
--	CONSTRAINT PK_tbPersonasPorPaises_Pappe_Id PRIMARY KEY(Pappe_Id),
--	CONSTRAINT FK_tbPersonasPorPaises_tbPersonas_Perso_Id FOREIGN KEY(Perso_Id) REFERENCES Gral.tbPersonas(Perso_Id),
--	CONSTRAINT FK_tbPesronasPorPaises_tbPaises_Paise_Id FOREIGN KEY(Paise_Id) REFERENCES Gral.tbPaises(Paise_Id),

--	[Pappe_UsuarioCreacion] [int] NOT NULL,
--	[Pappe_FechaCreacion] [datetime] NOT NULL,
--	[Pappe_UsuarioModificacion] [int] NULL,
--	[Pappe_FechaModificacion] [datetime] NULL,
--	[Pappe_Estado] [bit] CONSTRAINT DF_tbPersonasPorPaises_Pappe_Estado DEFAULT 1,
--	CONSTRAINT FK_tbPersonasPorPaises_tbUsuarios_Pappe_UsuarioCreacion FOREIGN KEY(Pappe_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
--	CONSTRAINT FK_tbPersonasPorPaises_tbUsuarios_Pappe_UsuarioModificacion FOREIGN KEY(Pappe_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
--)
GO
CREATE TABLE Gral.tbDepartamentos(
	[Depar_Id] [char](2) NOT NULL,
	[Depar_Descripcion] NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_tbDepartamentos_Depar_Id PRIMARY KEY(Depar_Id),
	CONSTRAINT UQ_tbDepartamentos_Depar_Descripcion UNIQUE(Depar_Descripcion),
	
	[Depar_UsuarioCreacion] [int] NOT NULL,
	[Depar_FechaCreacion] [datetime] NOT NULL,
	[Depar_UsuarioModificacion] [int] NULL,
	[Depar_FechaModificacion] [datetime] NULL,
	[Depar_Estado] [bit] CONSTRAINT DF_tbDepartamentos_Depar_Estado DEFAULT 1,
	CONSTRAINT FK_tbDepartamentos_tbUsuarios_Depar_UsuarioCreacion FOREIGN KEY(Depar_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbDepartamentos_tbUsuarios_Depar_UsuarioModificacion FOREIGN KEY(Depar_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbMunicipios(
	[Munic_Id] [char](4) NOT NULL,
	[Munic_Descripcion] NVARCHAR(50) NOT NULL,
	[Depar_Id] [char](2) NOT NULL,
	CONSTRAINT PK_tbMunicipios_Munic_Id PRIMARY KEY(Munic_Id),
	CONSTRAINT FK_tbMunicipios_tbDepartamentos_Depar_Id FOREIGN KEY(Depar_Id) REFERENCES Gral.tbDepartamentos(Depar_Id),

	[Munic_UsuarioCreacion] [int] NOT NULL,
	[Munic_FechaCreacion] [datetime] NOT NULL,
	[Munic_UsuarioModificacion] [int] NULL,
	[Munic_FechaModificacion] [datetime] NULL,
	[Munic_Estado] [bit] CONSTRAINT DF_tbMunicipios_Munic_Estado DEFAULT 1,
	CONSTRAINT FK_tbMunicipios_tbUsuarios_Munic_UsuarioCreacion FOREIGN KEY(Munic_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbMunicipios_tbUsuarios_Munic_UsuarioModificacion FOREIGN KEY(Munic_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbEstadosCiviles(
	[Estad_Id] [int] IDENTITY(1,1),
	[Estad_Descripcion] NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_tbEstadosCiviles_Estad_Id PRIMARY KEY(Estad_Id),
	CONSTRAINT UQ_tbEstadosCiviles_Estad_Descripcion UNIQUE(Estad_Descripcion),

	[Estad_UsuarioCreacion] [int] NOT NULL,
	[Estad_FechaCreacion] [datetime] NOT NULL,
	[Estad_UsuarioModificacion] [int] NULL,
	[Estad_FechaModificacion] [datetime] NULL,
	[Estad_Estado] [bit] CONSTRAINT DF_tbEstadosCiviles_Estad_Estado DEFAULT 1,
	CONSTRAINT FK_tbEstadosCiviles_tbUsuarios_Estad_UsuarioCreacion FOREIGN KEY(Estad_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbEstadosCiviles_tbUsuarios_Estad_UsuarioModificacion FOREIGN KEY(Estad_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbTiposIdentificaciones(
	Tiden_Id INT IDENTITY(1,1),
	Tiden_Descripcion NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_tbTiposIdentificaciones_Tiden_Id PRIMARY KEY(Tiden_Id),
	CONSTRAINT UQ_tbTiposIdentificaciones_Tiden_Descripcion UNIQUE(Tiden_Descripcion),

	[Tiden_UsuarioCreacion] [int] NOT NULL,
	[Tiden_FechaCreacion] [datetime] NOT NULL,
	[Tiden_UsuarioModificacion] [int] NULL,
	[Tiden_FechaModificacion] [datetime] NULL,
	[Tiden_Estado] [bit] CONSTRAINT DF_tbTiposIdentificaciones_Tiden_Estado DEFAULT 1,
	CONSTRAINT FK_tbTiposIdentificaciones_tbUsuarios_Tiden_UsuarioCreacion FOREIGN KEY(Tiden_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbTiposIdentificaciones_tbUsuarios_Tiden_UsuarioModificacion FOREIGN KEY(Tiden_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbIdentificaciones(
	Ident_Id INT IDENTITY(1,1),
	Ident_Tipo INT NOT NULL,
	Ident_NumeroIdentificacion NVARCHAR(100) NOT NULL,
	Ident_FechaNacimiento DATE NOT NULL,
	Ident_LugarNacimiento NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_tbIdentificaciones_Ident_Id PRIMARY KEY(Ident_Id),
	CONSTRAINT UQ_tbIdentificaciones_Ident_NumeroIdentificacion UNIQUE(Ident_NumeroIdentificacion),
	CONSTRAINT FK_tbIdentificaciones_tbTiposIdentificaciones_Ident_Tipo FOREIGN KEY(Ident_Tipo) REFERENCES Gral.tbTiposIdentificaciones(Ident_Tipo),

	[Ident_UsuarioCreacion] [int] NOT NULL,
	[Ident_FechaCreacion] [datetime] NOT NULL,
	[Ident_UsuarioModificacion] [int] NULL,
	[Ident_FechaModificacion] [datetime] NULL,
	[Ident_Estado] [bit] CONSTRAINT DF_tbIdentificaciones_Ident_Estado DEFAULT 1,
	CONSTRAINT FK_tbIdentificaciones_tbUsuarios_Ident_UsuarioCreacion FOREIGN KEY(Ident_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbIdentificaciones_tbUsuarios_Ident_UsuarioModificacion FOREIGN KEY(Ident_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbParentescos(
	Paren_Id INT IDENTITY(1,1),
	Paren_Descripcion NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_tbParentescos_Paren_Id PRIMARY KEY(Paren_Id),
	CONSTRAINT UQ_tbParentescos_Paren_Descripcion UNIQUE(Paren_Descripcion),

	[Paren_UsuarioCreacion] [int] NOT NULL,
	[Paren_FechaCreacion] [datetime] NOT NULL,
	[Paren_UsuarioModificacion] [int] NULL,
	[Paren_FechaModificacion] [datetime] NULL,
	[Paren_Estado] [bit] CONSTRAINT DF_tbParentescos_Paren_Estado DEFAULT 1,
	CONSTRAINT FK_tbParentescos_tbUsuarios_Paren_UsuarioCreacion FOREIGN KEY(Paren_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbParentescos_tbUsuarios_Paren_UsuarioModificacion FOREIGN KEY(Paren_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbPersonas(
	Perso_Id INT IDENTITY(1,1) NOT NULL,
	Perso_PrimerNombre NVARCHAR(50) NOT NULL,
	Perso_SegundoNombre NVARCHAR(50),
	Perso_PrimerApellido NVARCHAR(50) NOT NULL,
	Perso_SegundoApellido NVARCHAR(50),
	Perso_FechaNacimiento DATE NOT NULL,
	Perso_Sexo CHAR(1) NOT NULL,
	Ident_Id INT NOT NULL,
	Estci_Id INT NOT NULL,
	Perso_Telefono NVARCHAR(30) NOT NULL,
	Perso_CorreoElectronico NVARCHAR(MAX) NOT NULL,
	Perso_Direccion NVARCHAR(MAX) NOT NULL,
	Munic_Id CHAR(4) NOT NULL,
	Paise_Id INT NOT NULL,

	Poliz_Id INT NOT NULL,
	Paren_Id INT NOT NULL,
	CONSTRAINT PK_tbPersonas_Perso_Id PRIMARY KEY(Perso_Id),
	CONSTRAINT FK_tbPersonas_tbEstadosCiviles_Estci_Id FOREIGN KEY(Estci_Id) REFERENCES Gral.tbEstadosCiviles(Estad_Id),
	CONSTRAINT FK_tbPersonas_tbMunicipios_Munic_Id FOREIGN KEY(Munic_Id) REFERENCES Gral.tbMunicipios(Munic_Id),
	CONSTRAINT FK_tbPersonas_tbPaises_Paise_Id FOREIGN KEY(Paise_Id) REFERENCES Gral.tbPaises(Paise_Id),
	CONSTRAINT FK_tbPersonas_tbIdentificaciones_Ident_Id FOREIGN KEY(Ident_Id) REFERENCES Gral.tbIdentificaciones(Ident_Id),
	CONSTRAINT FK_tbPersonas_tbParentescos_Paren_Id FOREIGN KEY(Paren_Id) REFERENCES Gral.tbParentescos(Paren_Id),
	CONSTRAINT CK_tbPersonas_Perso_Sexo CHECK (Perso_Sexo IN ('M','F')),

	[Perso_UsuarioCreacion] [int] NOT NULL,
	[Perso_FechaCreacion] [datetime] NOT NULL,
	[Perso_UsuarioModificacion] [int] NULL,
	[Perso_FechaModificacion] [datetime] NULL,
	[Perso_Estado] [bit] CONSTRAINT DF_tbPersonas_Perso_Estado DEFAULT 1,
	CONSTRAINT FK_tbPersonas_tbUsuarios_Perso_UsuarioCreacion FOREIGN KEY(Perso_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbPersonas_tbUsuarios_Perso_UsuarioModificacion FOREIGN KEY(Perso_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbInformacionMedica(
	Perso_Id INT NOT NULL,
	Inmed_PesoKgs NUMERIC(5,2) NOT NULL,
	Inmed_EstaturaMtrs NUMERIC(3,2) NOT NULL,
	Inmed_TipoSangre NVARCHAR(3) NOT NULL,
	Inmed_ReaccionesAlergicas INT NOT NULL,
	Inmed_AumentoDisminucion BIT NOT NULL,
	Inmed_AumentoDisminucionPeso NUMERIC(5,2) NOT NULL,
	Inmed_IngiereBebidasAlcoholicas
	CONSTRAINT PK_tbInformacionMedica_Perso_Id PRIMARY KEY(Perso_Id),
	CONSTRAINT FK_tbInformacionMedica_tbPersonas_Perso_Id FOREIGN KEY(Perso_Id) REFERENCES Gral.tbPersonas(Perso_Id),

	[Inmed_UsuarioCreacion] [int] NOT NULL,
	[Inmed_FechaCreacion] [datetime] NOT NULL,
	[Inmed_UsuarioModificacion] [int] NULL,
	[Inmed_FechaModificacion] [datetime] NULL,
	[Inmed_Estado] [bit] CONSTRAINT DF_tbInformacionMedica_Inmed_Estado DEFAULT 1,
	CONSTRAINT FK_tbInformacionMedica_tbUsuarios_Inmed_UsuarioCreacion FOREIGN KEY(Inmed_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbInformacionMedica_tbUsuarios_Inmed_UsuarioModificacion FOREIGN KEY(Inmed_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO

--------------------------------------------------------------------------------------------------------------------------------
GO
CREATE SCHEMA Segur
GO

CREATE TABLE Segur.tbCargos(
	Cargo_Id INT IDENTITY(1,1),
	Cargo_Descripcion NVARCHAR(40),
	CONSTRAINT PK_tbCargos_Cargo_Id PRIMARY KEY(Cargo_Id),
	CONSTRAINT UQ_tbCargos_Cargo_Descripcion UNIQUE(Cargo_Descripcion),

	[Cargo_UsuarioCreacion] [int] NOT NULL,
	[Cargo_FechaCreacion] [datetime] NOT NULL,
	[Cargo_UsuarioModificacion] [int] NULL,
	[Cargo_FechaModificacion] [datetime] NULL,
	[Cargo_Estado] [bit] CONSTRAINT DF_tbCargos_Cargo_Estado DEFAULT 1,
	CONSTRAINT FK_tbCargos_tbUsuarios_Cargo_UsuarioCreacion FOREIGN KEY(Cargo_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbCargos_tbUsuarios_Cargo_UsuarioModificacion FOREIGN KEY(Cargo_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Segur.tbEmpleados(
	Emple_Id INT NOT NULL,
	Cargo_Id INT NOT NULL,
	CONSTRAINT PK_tbEmpleados_Emple_Id PRIMARY KEY(Emple_Id),
	CONSTRAINT FK_tbEmpleados_tbPersonas_Emple_Id FOREIGN KEY(Emple_Id) REFERENCES Gral.tbPersonas(Perso_Id),
	CONSTRAINT FK_tbEmpleados_tbCargos_Cargo_id FOREIGN KEY(Cargo_Id) REFERENCES Segur.tbCargos(Cargo_Id),

	[Emple_UsuarioCreacion] [int] NOT NULL,
	[Emple_FechaCreacion] [datetime] NOT NULL,
	[Emple_UsuarioModificacion] [int] NULL,
	[Emple_FechaModificacion] [datetime] NULL,
	[Emple_Estado] [bit] CONSTRAINT DF_tbEmpleados_Emple_Estado DEFAULT 1,
	CONSTRAINT FK_tbEmpleados_tbUsuarios_Emple_UsuarioCreacion FOREIGN KEY(Emple_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbEmpleados_tbUsuarios_Emple_UsuarioModificacion FOREIGN KEY(Emple_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Segur.tbCoberturas(
	Cober_Id INT IDENTITY(1,1),
	Cober_Descripcion NVARCHAR(40) NOT NULL,
	CONSTRAINT PK_tbCoberturas_Cober_Id PRIMARY KEY(Cober_Id),
	CONSTRAINT UQ_tbCoberturas_Cober_Descripcion UNIQUE(Cober_Descripcion),

	[Cober_UsuarioCreacion] [int] NOT NULL,
	[Cober_FechaCreacion] [datetime] NOT NULL,
	[Cober_UsuarioModificacion] [int] NULL,
	[Cober_FechaModificacion] [datetime] NULL,
	[Cober_Estado] [bit] CONSTRAINT DF_tbCoberturas_Cober_Estado DEFAULT 1,
	CONSTRAINT FK_tbCoberturas_tbUsuarios_Cober_UsuarioCreacion FOREIGN KEY(Cober_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbCoberturas_tbUsuarios_Cober_UsuarioModificacion FOREIGN KEY(Cober_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Segur.tbTiposPlanes(
	Tipos_Id INT IDENTITY(1,1),
	Tipos_Descripcion NVARCHAR(40) NOT NULL,

	--MaximoVitalicio
	Tipos_MaximoVitalicio NUMERIC(10,2) NOT NULL,
	Tipos_SeguroVidaRenovableAnualMasDID NUMERIC(10,2) NOT NULL,
	Tipos_DID BIT NOT NULL,
	Tipos_AsistenciaFuneraria NUMERIC(10,2) NOT NULL,
	Tipos_GastosRepatriacion NUMERIC(10,2) NOT NULL,
	Tipos_GastosFunebresTitular NUMERIC(10,2) NOT NULL,
	Tipos_GastosFunebresDependientes NUMERIC(10,2) NOT NULL,
	Tipos_GastosHogar6rentasmensuales NUMERIC(10,2) NOT NULL,
			
	--EdadMaximaIngreso
	Tipos_EdadMaxIngresoTitularConyuge INT NOT NULL,
	Tipos_EdadMaxIngresoHijos INT NOT NULL,
	
	--Edad Máxima de Permanencia
	Tipos_EdadMaxPermanenciaTitularConyuge INT NOT NULL,
	Tipos_EdadMaxPermanenciaHijos INT NOT NULL,

	--Reducción del Máximo Vitalicio
	Tipos_ReduccionMaximoVitalicio NUMERIC(10,2) NOT NULL,

	--Cuarto y Alimentación
	Tipos_CuartoAlimentacionDentroCA NUMERIC(10,2) NOT NULL,
	Tipos_CuartoAlimentacionFueraCA NUMERIC(10,2) NOT NULL,
	Tipos_LímiteCuartoIntensivoFueraCA NUMERIC(4,2) NOT NULL,

	--Límite de Consulta Externa
	Tipos_LimiteConsultaExternaMedicoGeneral NUMERIC(10,2) NOT NULL,
	Tipos_LimiteConsultaExternaMedicoEspecialista NUMERIC(10,2) NOT NULL,
	Tipos_LimiteConsultaExternaNeurologoCardiologo NUMERIC(10,2) NOT NULL,
	
	--Cobertura por SIDA
	Tipos_CoberturaPorSidaMaximoVitalicio NUMERIC(10,2) NOT NULL,

	--Control de Niño Sano
	Tipos_ControlNinoSano INT NOT NULL,

	--Ambulancia
	Tipos_CentroAmerica NUMERIC(10,2) NOT NULL,
	Tipos_FueraCentroAmerica NUMERIC(10,2) NOT NULL,
	Tipos_AmbulanciaAerea NUMERIC(10,2) NOT NULL,

	-- Periodo de Espera MESES
	Tipos_PeriodoEsperaEnfermedadesEspecificas INT NOT NULL,
	Tipos_PeriodoEsperaEnfermedadesGraves INT NOT NULL,
	Tipos_PeriodoEsperaSIDA INT NOT NULL,
	
	--Maternidad
	Tipos_LimitesMomentoPartoNormal NUMERIC(10,2) NOT NULL,
	Tipos_LimitesMomentoCesarea NUMERIC(10,2) NOT NULL,
	Tipos_LimitesMomentoAbortoLegal NUMERIC(10,2) NOT NULL,
	Tipos_LimitesMomentoSalaCuna NUMERIC(10,2) NOT NULL,

	--Maternidad: Cobertura para recién nacido
	Tipos_LimitesMomentoCuidadoCriticoNeonatal NUMERIC(10,2) NOT NULL,
	Tipos_LimitesMomentoGastosPsiquiatriaConsulaMedicamento NUMERIC(10,2) NOT NULL,

	--Maternidad: Periodo de Espera MESES
	Tipos_PeriodoEsperaCoberturaMaternidad INT NOT NULL,

	--Maternidad: Periodo de Prexistencia MESES
	Tipos_PeriodoDePreexistencia INT NOT NULL,

	--Maternidad: Periodo de Carencia MESES
	Tipos_PeriodoDeCarencia INT NOT NULL,

	--Controles Preventivos: Para personas mayores de 40 años
	Tipos_ControlesPreventivosGinecologoANUAL INT NOT NULL,
	Tipos_ControlesPreventivosProstagicoANUAL INT NOT NULL,
	Tipos_ControlesPreventivosMamografiaANUAL INT NOT NULL,

	----------------------
	Cober_Id INT NOT NULL,

	CONSTRAINT PK_tbTiposPlanes_Tipos_Id PRIMARY KEY(Tipos_Id),
	CONSTRAINT UQ_tbTiposPlanes_Tipos_Descripcion UNIQUE(Tipos_Descripcion),
	CONSTRAINT FK_tbTiposPlanes_tbCoberturas_Cober_Id FOREIGN KEY(Cober_Id) REFERENCES Segur.tbCoberturas(Cober_Id),

	[Tipos_UsuarioCreacion] [int] NOT NULL,
	[Tipos_FechaCreacion] [datetime] NOT NULL,
	[Tipos_UsuarioModificacion] [int] NULL,
	[Tipos_FechaModificacion] [datetime] NULL,
	[Tipos_Estado] [bit] CONSTRAINT DF_tbTiposPlanes_Tipos_Estado DEFAULT 1,
	CONSTRAINT FK_tbTiposPlanes_tbUsuarios_Tipos_UsuarioCreacion FOREIGN KEY(Tipos_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbTiposPlanes_tbUsuarios_Tipos_UsuarioModificacion FOREIGN KEY(Tipos_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
--------------------------------------------------------------------------------------------------------------------------------
GO
CREATE SCHEMA Venta
GO

CREATE TABLE Venta.tbClientes(
	Clien_Id INT NOT NULL,
	CONSTRAINT PK_tbClientes_Clien_Id PRIMARY KEY(Clien_Id),
	CONSTRAINT FK_tbClientes_tbPersonas_Clien_Id FOREIGN KEY(Clien_Id) REFERENCES Gral.tbPersonas(Perso_Id),
)
GO
CREATE TABLE Venta.tbPolizas(
	Poliz_Id INT IDENTITY(1,1),
	Clien_Id INT NOT NULL,
	Tipos_Id INT NOT NULL,
	Emple_Id INT NOT NULL,
	Poliz_TipoPago BIT NOT NULL,
	CONSTRAINT PK_tbPolizas_Poliz_Id PRIMARY KEY(Poliz_Id),
	CONSTRAINT FK_tbPolizas_tbClientes_Clien_Id FOREIGN KEY(Clien_Id) REFERENCES Gral.tbPersonas(Perso_Id),
	CONSTRAINT FK_tbPolizas_tbTiposPlanes_Tipos_Id FOREIGN KEY(Tipos_Id) REFERENCES Segur.tbTiposPlanes(Tipos_Id),
	CONSTRAINT FK_tbPolizas_tbEmpleados_Emple_Id FOREIGN KEY(Emple_Id) REFERENCES Segur.tbEmpleados(Emple_Id),
	CONSTRAINT UQ_tbPolizas_Clien_Id UNIQUE(Clien_Id),

	[Poliz_UsuarioCreacion] [int] NOT NULL,
	[Poliz_FechaCreacion] [datetime] NOT NULL,
	[Poliz_UsuarioModificacion] [int] NULL,
	[Poliz_FechaModificacion] [datetime] NULL,
	[Poliz_Estado] [bit] CONSTRAINT DF_tbPolizas_Poliz_Estado DEFAULT 1,
	CONSTRAINT FK_tbPolizas_tbUsuarios_Poliz_UsuarioCreacion FOREIGN KEY(Poliz_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbPolizas_tbUsuarios_Poliz_UsuarioModificacion FOREIGN KEY(Poliz_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Venta.tbDesembolsos(
	Desem_Id INT IDENTITY(1,1),
	Clien_Id INT NOT NULL,
	CONSTRAINT PK_tbDesembolsos_Desem_Id PRIMARY KEY(Desem_Id),
)