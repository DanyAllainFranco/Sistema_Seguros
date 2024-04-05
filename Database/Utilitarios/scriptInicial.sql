CREATE SCHEMA Acces
GO
CREATE TABLE Acces.tbUsuarios(
	Usuar_Id INT IDENTITY(1,1),
	Usuar_Usuario NVARCHAR(50) NOT NULL,
	Usuar_Contrasena NVARCHAR(MAX) NOT NULL,
	Emple_Id INT NOT NULL,
	Roles_Id INT NOT NULL,
	Usuar_Admin BIT NOT NULL,
	Usuar_UltimaSesion DATETIME NULL,
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
	Tiden_Id INT NOT NULL,
	Ident_NumeroIdentificacion NVARCHAR(100) NOT NULL,
	Ident_FechaNacimiento DATE NOT NULL,
	Ident_LugarNacimiento NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_tbIdentificaciones_Ident_Id PRIMARY KEY(Ident_Id),
	CONSTRAINT UQ_tbIdentificaciones_Ident_NumeroIdentificacion UNIQUE(Ident_NumeroIdentificacion),
	CONSTRAINT FK_tbIdentificaciones_tbTiposIdentificaciones_Ident_Tipo FOREIGN KEY(Tiden_Id) REFERENCES Gral.tbTiposIdentificaciones(Tiden_Id),

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
	Perso_Sexo CHAR(1) NOT NULL,
	Ident_Id INT NOT NULL,

	Estci_Id INT NULL,
	Perso_Telefono NVARCHAR(30) NULL,
	Perso_CorreoElectronico NVARCHAR(MAX) NULL,
	Perso_Direccion NVARCHAR(MAX) NULL,
	Munic_Id CHAR(4) NULL,
	Paise_Id INT NULL,

	Poliz_Id INT NOT NULL,
	Paren_Id INT NOT NULL,
	CONSTRAINT PK_tbPersonas_Perso_Id PRIMARY KEY(Perso_Id),
	CONSTRAINT FK_tbPersonas_tbIdentificaciones_Ident_Id FOREIGN KEY(Ident_Id) REFERENCES Gral.tbIdentificaciones(Ident_Id),
	CONSTRAINT FK_tbPersonas_tbParentescos_Paren_Id FOREIGN KEY(Paren_Id) REFERENCES Gral.tbParentescos(Paren_Id),
	CONSTRAINT FK_tbPersonas_tbMunicipios_Munic_Id FOREIGN KEY(Munic_Id) REFERENCES Gral.tbMunicipios(Munic_Id),
	CONSTRAINT FK_tbPersonas_tbPaises_Paise_Id FOREIGN KEY(Paise_Id) REFERENCES Gral.tbPaises(Paise_Id),
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
CREATE TABLE Gral.tbFrecuencias(
	Frecu_Id INT IDENTITY(1,1), 
	Frecu_Descripcion NVARCHAR(40) NOT NULL,
	CONSTRAINT PK_tbFrecuencias_Frecu_Id PRIMARY KEY(Frecu_Id),
	CONSTRAINT UQ_tbFrecuencias_Frecu_Descripcion UNIQUE(Frecu_Descripcion),

	[Frecu_UsuarioCreacion] [int] NOT NULL,
	[Frecu_FechaCreacion] [datetime] NOT NULL,
	[Frecu_UsuarioModificacion] [int] NULL,
	[Frecu_FechaModificacion] [datetime] NULL,
	[Frecu_Estado] [bit] CONSTRAINT DF_tbFrecuencias_Frecu_Estado DEFAULT 1,
	CONSTRAINT FK_tbFrecuencias_tbUsuarios_Frecu_UsuarioCreacion FOREIGN KEY(Frecu_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbFrecuencias_tbUsuarios_Frecu_UsuarioModificacion FOREIGN KEY(Frecu_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbTipoArticuloMedico(
	Tarme_Id INT IDENTITY(1,1),
	Tarme_Tipo INT NOT NULL, --1 = alcohol, 2 = drugs, 3 = smoke
	Tarme_Descripcion NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_tbTipoBebidaAlcoholica_Tbeal_Id PRIMARY KEY(Tarme_Id),
	CONSTRAINT UQ_tbTipoBebidaAlcoholica_Tbeal_Descripcion UNIQUE(Tarme_Descripcion),

	[Tarme_UsuarioCreacion] [int] NOT NULL,
	[Tarme_FechaCreacion] [datetime] NOT NULL,
	[Tarme_UsuarioModificacion] [int] NULL,
	[Tarme_FechaModificacion] [datetime] NULL,
	[Tarme_Estado] [bit] CONSTRAINT DF_tbTipoBebidaAlcoholica_Tarme_Estado DEFAULT 1,
	CONSTRAINT FK_tbTipoBebidaAlcoholica_tbUsuarios_Tarme_UsuarioCreacion FOREIGN KEY(Tarme_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbTipoBebidaAlcoholica_tbUsuarios_Tarme_UsuarioModificacion FOREIGN KEY(Tarme_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Gral.tbEnfermedades(
	Enfer_Id INT IDENTITY(1,1),
	Enfer_Descripcion NVARCHAR(60) NOT NULL,
	CONSTRAINT PK_tbEnfermedades_Enfer_Id PRIMARY KEY(Enfer_Id),
	CONSTRAINT UQ_tbEnfermedades_Enfer_Descripcion UNIQUE(Enfer_Descripcion),

	[Enfer_UsuarioCreacion] [int] NOT NULL,
	[Enfer_FechaCreacion] [datetime] NOT NULL,
	[Enfer_UsuarioModificacion] [int] NULL,
	[Enfer_FechaModificacion] [datetime] NULL,
	[Enfer_Estado] [bit] CONSTRAINT DF_tbEnfermedades_Enfer_Estado DEFAULT 1,
	CONSTRAINT FK_tbEnfermedades_tbUsuarios_Enfer_UsuarioCreacion FOREIGN KEY(Enfer_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbEnfermedades_tbUsuarios_Enfer_UsuarioModificacion FOREIGN KEY(Enfer_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
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
	Inmed_IngiereBebidasAlcoholicas BIT NOT NULL,
	Inmed_TipoAlcohol INT NOT NULL,
	Inmed_IngiereCantidad INT NOT NULL,
	Inmed_IngiereFrecuencia INT NOT NULL,
	Inmed_DrogasEstimulantes BIT NOT NULL,
	Inmed_TipoDrogasEstimulantes INT NOT NULL,
	Inmed_DrogasEstimulantesCantidad INT NOT NULL,
	Inmed_DrogasEstimulantesFrecuencia INT NOT NULL,
	Inmed_Fumar BIT NOT NULL,
	Inmed_TipoFumar INT NOT NULL,
	Inmed_FumarCantidad INT NOT NULL,
	Inmed_FumarFrecuencia INT NOT NULL,
	Inmed_Enfermedad1 BIT NOT NULL,
	Inmed_Enfermedad2 BIT NOT NULL,
	Inmed_Enfermedad3 BIT NOT NULL,
	Inmed_Enfermedad4 BIT NOT NULL,
	Inmed_Enfermedad5 BIT NOT NULL,
	Inmed_Enfermedad6 BIT NOT NULL,
	Inmed_Enfermedad7 BIT NOT NULL,
	Inmed_Enfermedad8 BIT NOT NULL,
	Inmed_Enfermedad9 BIT NOT NULL,
	CONSTRAINT PK_tbInformacionMedica_Perso_Id PRIMARY KEY(Perso_Id),
	CONSTRAINT FK_tbInformacionMedica_tbPersonas_Perso_Id FOREIGN KEY(Perso_Id) REFERENCES Gral.tbPersonas(Perso_Id),
	CONSTRAINT FK_tbInformacionMedica_tbTipoArticuloMedico_Inmed_TipoAlcohol FOREIGN KEY(Inmed_TipoAlcohol) REFERENCES Gral.tbTipoArticuloMedico(Tarme_Id),
	CONSTRAINT FK_tbInformacionMedica_tbFrecuencias_Inmed_IngiereFrecuencia FOREIGN KEY(Inmed_IngiereFrecuencia) REFERENCES Gral.tbFrecuencias(Frecu_Id),
	CONSTRAINT FK_tbInformacionMedica_tbTipoArticuloMedico_Inmed_TipoDrogas FOREIGN KEY(Inmed_TipoDrogasEstimulantes) REFERENCES Gral.tbTipoArticuloMedico(Tarme_Id),
	CONSTRAINT FK_tbInformacionMedica_tbFrecuencias_Inmed_DrogasEstimulantesFrecuencia FOREIGN KEY(Inmed_DrogasEstimulantesFrecuencia) REFERENCES Gral.tbFrecuencias(Frecu_Id),
	CONSTRAINT FK_tbInformacionMedica_tbTipoArticuloMedico_Inmed_TipoFumar FOREIGN KEY(Inmed_TipoFumar) REFERENCES Gral.tbTipoArticuloMedico(Tarme_Id),
	CONSTRAINT FK_tbInformacionMedica_tbFrecuencias_Inmed_FumarFrecuencia FOREIGN KEY(Inmed_DrogasEstimulantesFrecuencia) REFERENCES Gral.tbFrecuencias(Frecu_Id),

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
ALTER TABLE Segur.tbTiposPlanes
ADD Tipos_DeducibleAnual NUMERIC(10,2) NOT NULL
CREATE TABLE Segur.tbTiposPlanes(
	Tipos_Id INT IDENTITY(1,1),
	Tipos_Descripcion NVARCHAR(40) NOT NULL,

	--Deducible
	Tipos_Deducible NUMERIC(10,2) NOT NULL,

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

	Tipos_CostoPlan NUMERIC(10,2) NOT NULL,

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
GO
CREATE TABLE Segur.tbUnidades(
	Unida_Id INT IDENTITY(1,1),
	Unida_Descripcion NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_tbUnidades_Unida_Id PRIMARY KEY(Unida_Id),
	CONSTRAINT UQ_tbUnidades_Unida_Descripcion UNIQUE(Unida_Descripcion),

	[Unida_UsuarioCreacion] [int] NOT NULL,
	[Unida_FechaCreacion] [datetime] NOT NULL,
	[Unida_UsuarioModificacion] [int] NULL,
	[Unida_FechaModificacion] [datetime] NULL,
	[Unida_Estado] [bit] CONSTRAINT DF_tbUnidades_Unida_Estado DEFAULT 1,
	CONSTRAINT FK_tbUnidades_tbUsuarios_Unida_UsuarioCreacion FOREIGN KEY(Unida_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbUnidades_tbUsuarios_Unida_UsuarioModificacion FOREIGN KEY(Unida_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO

--------------------------------------------------------------------------------------------------------------------------------
GO
CREATE SCHEMA Venta
GO

CREATE TABLE Venta.tbPolizas(
	Poliz_Id INT IDENTITY(1,1),
	Clien_Id INT NOT NULL,
	Tipos_Id INT NOT NULL,
	Emple_Id INT NOT NULL,
	Poliz_Cuotas INT NOT NULL,
	Poliz_TipoPago BIT NOT NULL,
	Poliz_EstadoCuotasPoliza BIT NOT NULL,
	CONSTRAINT PK_tbPolizas_Poliz_Id PRIMARY KEY(Poliz_Id),
	CONSTRAINT FK_tbPolizas_tbPersonas_Clien_Id FOREIGN KEY(Clien_Id) REFERENCES Gral.tbPersonas(Perso_Id),
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
CREATE TABLE Segur.tbInformeMedico(
	Infor_Id INT IDENTITY(1,1),
	Infor_Diagnostico NVARCHAR(MAX) NOT NULL,
	Infor_TratamientoRealizado NVARCHAR(MAX) NOT NULL,
	Infor_TratamientoProgramado NVARCHAR(MAX) NOT NULL,
	Infor_OtrosTratamientos NVARCHAR(MAX) NOT NULL,

	Infor_DocumentoAdelante NVARCHAR(MAX) NOT NULL,
	Infor_DocumentoAtras NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_tbInformeMedico_Infor_Id PRIMARY KEY(Infor_Id),

	[Infor_UsuarioCreacion] [int] NOT NULL,
	[Infor_FechaCreacion] [datetime] NOT NULL,
	[Infor_UsuarioModificacion] [int] NULL,
	[Infor_FechaModificacion] [datetime] NULL,
	[Infor_Estado] [bit] CONSTRAINT DF_tbInformeMedico_Infor_Estado DEFAULT 1,
	CONSTRAINT FK_tbInformeMedico_tbUsuarios_Infor_UsuarioCreacion FOREIGN KEY(Infor_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbInformeMedico_tbUsuarios_Infor_UsuarioModificacion FOREIGN KEY(Infor_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),

)
GO
CREATE TABLE Segur.tbCausaAtencionMedica(
	Catme_Id INT IDENTITY(1,1),
	Catme_Descripcion CHAR(2) NOT NULL,
	Infor_Id INT NOT NULL,
	CONSTRAINT PK_tbCausaAtencionMedica_Catme_Id PRIMARY KEY(Catme_Id),
	CONSTRAINT FK_tbCausaAtencionMedica_Infor_Id FOREIGN KEY(Infor_Id) REFERENCES Segur.tbInformeMedico(Infor_Id),
	CONSTRAINT CK_tbCausaAtencionMedica_Catme_Descripcion CHECK (Catme_Descripcion IN ('Em', 'En', 'Ac')),

	[Catme_UsuarioCreacion] [int] NOT NULL,
	[Catme_FechaCreacion] [datetime] NOT NULL,
	[Catme_UsuarioModificacion] [int] NULL,
	[Catme_FechaModificacion] [datetime] NULL,
	[Catme_Estado] [bit] CONSTRAINT DF_tbCausaAtencionMedica_Catme_Estado DEFAULT 1,
	CONSTRAINT FK_tbCausaAtencionMedica_tbUsuarios_Catme_UsuarioCreacion FOREIGN KEY(Catme_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbCausaAtencionMedica_tbUsuarios_Catme_UsuarioModificacion FOREIGN KEY(Catme_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
DROP TABLE Venta.tbDesembolsos
CREATE TABLE Venta.tbDesembolsos(
	Desem_Id INT IDENTITY(1,1),
	Recla_Id INT NOT NULL,
	Desem_TotalAcreditar NUMERIC(10,2)
	CONSTRAINT PK_tbDesembolsos_Desem_Id PRIMARY KEY(Desem_Id),
	CONSTRAINT FK_tbDesembolsos_tbReclamos_Recla_Id FOREIGN KEY(Recla_Id) REFERENCES Gral.tbPersonas(Perso_Id),
	CONSTRAINT FK_tbDesembolsos_tbInformeMedico FOREIGN KEY(Infor_Id) REFERENCES Segur.tbInformeMedico(Infor_Id),

	[Desem_UsuarioCreacion] [int] NOT NULL,
	[Desem_FechaCreacion] [datetime] NOT NULL,
	[Desem_UsuarioModificacion] [int] NULL,
	[Desem_FechaModificacion] [datetime] NULL,
	[Desem_Estado] [bit] CONSTRAINT DF_tbDesembolsos_Desem_Estado DEFAULT 1,
	CONSTRAINT FK_tbDesembolsos_tbUsuarios_Desem_UsuarioCreacion FOREIGN KEY(Desem_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbDesembolsos_tbUsuarios_Desem_UsuarioModificacion FOREIGN KEY(Desem_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Venta.tbQuejas(
	Queja_Id INT IDENTITY(1,1),
	Clien_Id INT NOT NULL,
	Queja_Descripcion NVARCHAR(200) NOT NULL,
	CONSTRAINT PK_tbQuejas_Queja_Id PRIMARY KEY(Queja_Id),

	[Queja_UsuarioCreacion] [int] NOT NULL,
	[Queja_FechaCreacion] [datetime] NOT NULL,
	[Queja_UsuarioModificacion] [int] NULL,
	[Queja_FechaModificacion] [datetime] NULL,
	[Queja_Estado] [bit] CONSTRAINT DF_tbQuejas_Queja_Estado DEFAULT 1,
	CONSTRAINT FK_tbQuejas_tbUsuarios_Queja_UsuarioCreacion FOREIGN KEY(Queja_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbQuejas_tbUsuarios_Queja_UsuarioModificacion FOREIGN KEY(Queja_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
CREATE TABLE Segur.tbReclamos(
	Recla_Id INT IDENTITY(1,1),
	Clien_Id INT NOT NULL,
	Infor_Id INT NOT NULL,
	Recla_TotalFactura NUMERIC(10,2) NOT NULL,
	CONSTRAINT PK_tbReclamos_Recla_Id PRIMARY KEY(Recla_Id),
	CONSTRAINT FK_tbReclamos_tbPersonas_Clien_Id FOREIGN KEY(Clien_Id) REFERENCES Gral.tbPersonas(Perso_Id),
	CONSTRAINT FK_tbReclamos_tbInformeMedico FOREIGN KEY(Infor_Id) REFERENCES Segur.tbInformeMedico(Infor_Id),

	[Recla_UsuarioCreacion] [int] NOT NULL,
	[Recla_FechaCreacion] [datetime] NOT NULL,
	[Recla_UsuarioModificacion] [int] NULL,
	[Recla_FechaModificacion] [datetime] NULL,
	[Recla_Estado] [bit] CONSTRAINT DF_tbReclamos_Recla_Estado DEFAULT 1,
	CONSTRAINT FK_tbReclamos_tbUsuarios_Recla_UsuarioCreacion FOREIGN KEY(Recla_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbReclamos_tbUsuarios_Recla_UsuarioModificacion FOREIGN KEY(Recla_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)

CREATE TABLE Segur.tbFacturaMedicaEncabezado(
	Faenca_Id INT IDENTITY(1,1),
	Faenca_Codigo NVARCHAR(20) NOT NULL,
	Clien_Id INT NOT NULL,
	Faenca_HospitalClinica NVARCHAR(50) NOT NULL,
	Faenca_FechaImpresion DATE NOT NULL,
	Recla_Id INT NOT NULL,

	Factu_DocumentoAdelante NVARCHAR(MAX) NOT NULL,
	Factu_DocumentoAtras NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_tbFacturaMedicaEncabezado_Faenca_Id PRIMARY KEY(Faenca_Id),
	CONSTRAINT FK_tbFacturaMedicaEncabezado_tbPersonas_Clien_Id FOREIGN KEY(Clien_Id) REFERENCES Gral.tbPersonas(Perso_Id),
	CONSTRAINT FK_tbFacturaMedicaEncabezado_tbDesembolsos_Desem_Id FOREIGN KEY(Recla_Id) REFERENCES Venta.tbDesembolsos(Desem_Id),

	[Faenca_UsuarioCreacion] [int] NOT NULL,
	[Faenca_FechaCreacion] [datetime] NOT NULL,
	[Faenca_UsuarioModificacion] [int] NULL,
	[Faenca_FechaModificacion] [datetime] NULL,
	[Faenca_Estado] [bit] CONSTRAINT DF_tbFacturaMedicaEncabezado_Faenca_Estado DEFAULT 1,
	CONSTRAINT FK_tbFacturaMedicaEncabezado_tbUsuarios_Faenca_UsuarioCreacion FOREIGN KEY(Faenca_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbFacturaMedicaEncabezado_tbUsuarios_Faenca_UsuarioModificacion FOREIGN KEY(Faenca_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
CREATE TABLE Segur.tbFacturaMedicaDetalle(
	Fadet_Id INT IDENTITY(1,1),
	Faenca_Id INT NOT NULL,
	Fadet_ProductoServicio BIT NOT NULL,
	Fadet_Descripcion NVARCHAR(100) NOT NULL,
	Fadet_Cantidad INT NOT NULL,
	Unida_Id INT NOT NULL,
	Fadet_Precio NUMERIC(10,2) NOT NULL
	CONSTRAINT PK_tbFacturaMedicaDetalle_Fadet_Id PRIMARY KEY(Fadet_Id),
	CONSTRAINT FK_tbFacturaMedicaDetalle_tbFacturaMedicaEncabezado_Faenca_Id FOREIGN KEY(Faenca_Id) REFERENCES Segur.tbFacturaMedicaEncabezado(Faenca_Id),
	CONSTRAINT FK_tbFacturaMedicaDetalle_tbUnidades_Unida_Id FOREIGN KEY(Unida_Id) REFERENCES Segur.tbUnidades(Unida_Id),

	[Fadet_UsuarioCreacion] [int] NOT NULL,
	[Fadet_FechaCreacion] [datetime] NOT NULL,
	[Fadet_UsuarioModificacion] [int] NULL,
	[Fadet_FechaModificacion] [datetime] NULL,
	[Fadet_Estado] [bit] CONSTRAINT DF_tbFacturaMedicaDetalle_Fadet_Estado DEFAULT 1,
	CONSTRAINT FK_tbFacturaMedicaDetalle_tbUsuarios_Fadet_UsuarioCreacion FOREIGN KEY(Fadet_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbFacturaMedicaDetalle_tbUsuarios_Fadet_UsuarioModificacion FOREIGN KEY(Fadet_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)
GO
ALTER TABLE Segur.tbPrescripciones
ADD CONSTRAINT FK_tbPrescripciones_tbReclamos_Recla_Id FOREIGN KEY(Recla_Id) REFERENCES Segur.tbReclamos(Recla_Id)
CREATE TABLE Segur.tbPrescripciones(
	Presc_Id INT IDENTITY(1,1),
	Recla_Id INT NOT NULL,

	Presc_DocumentoAdelante NVARCHAR(MAX) NOT NULL,
	Presc_DocumentoAtras NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_tbPrescripciones_Presc_Id PRIMARY KEY(Presc_Id),
	CONSTRAINT FK_tbPrescripciones_tbDesembolsos_Desem_Id FOREIGN KEY(Desem_Id) REFERENCES Venta.tbDesembolsos(Desem_Id),

	[Presc_UsuarioCreacion] [int] NOT NULL,
	[Presc_FechaCreacion] [datetime] NOT NULL,
	[Presc_UsuarioModificacion] [int] NULL,
	[Presc_FechaModificacion] [datetime] NULL,
	[Presc_Estado] [bit] CONSTRAINT DF_tbPrescripciones_Presc_Estado DEFAULT 1,
	CONSTRAINT FK_tbPrescripciones_tbUsuarios_Presc_UsuarioCreacion FOREIGN KEY(Presc_UsuarioCreacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
	CONSTRAINT FK_tbPrescripciones_tbUsuarios_Presc_UsuarioModificacion FOREIGN KEY(Presc_UsuarioModificacion) REFERENCES Acces.tbUsuarios(Usuar_Id),
)

GO
