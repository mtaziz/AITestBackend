﻿using System;
namespace AITestBackend.Models
{
    public class AppManagement
    {

        //APP 
        public const string emailUser = "goediguti@gmail.com";
        public const string emailPass = "Kevin2015.";

        //APP 
        public const string connStr = "server=50.62.209.187;user=xdevs;database=ALCCI_DB;port=3306;password=pass123;SslMode=none";

        public const string APIS_Token = "";

        //IBM Speech To Text
        public const string WorkspaceIDST = "799aecc9-dcb3-41db-b85a-36043cf448b9";
        public const string WorkspaceURLST = "https://stream.watsonplatform.net/speech-to-text/api/v1/recognize/";

        public const string UserNameST = "7ce55b15-49e3-4f6d-ba80-4b0d26920ce3";
        public const string PasswordST = "phDTyV3VeLmd ";
        public const string VersionDateST = "2018-07-10";



        //IBM Chatbot
        public const string WorkspaceID = "ea6ea568-a6b3-47e6-a22b-372d5801c8c4";
        public const string WorkspaceURL = "https://gateway.watsonplatform.net/assistant/api/v1/workspaces/" + WorkspaceID + "/message/";

        public const string UserName = "41db3a02-c26c-4d69-9907-00686bdd837e";
        public const string Password = "8CQXYinm4Otu";
        public const string VersionDate = "2018-07-10";

        //Messages
        public const string MSG_API_Validation_Failure = "Se ha producido un error";
        public const string MSG_SendMessageToAssistantResponse_Succesful = "";

        public const string MSG_GenericExceptionError = "Se ha producido un error en el Servidor";


        #region sps

        #region login
        public const string SP_LoginUser = "sp_login";
        #endregion

        #region parent
        public const string SP_GetParent = "sp_getparent";
        public const string SP_SaveParent = "sp_insert_user";
        public const string SP_UpdateParent = "sp_updateparent";
        #endregion

        #region Ethnic Group
        public const string SP_GetAllEthnicGroup = "sp_get_all_ethnic_group";

        #endregion

        #region Patients
        public static string SP_GetAllPatients = "sp_get_all_patient";
        public static string SP_InsertPatients = "sp_insert_patient";
        public static string SP_GetAllPatientCases = "sp_get_all_patient_case";
        



        public static string SP_InsertPatientsTreatmentDeseases = "sp_insertupdatetreatment";
        public static string SP_GetAllTreatmentDeseases = "sp_get_all_treatment_deseases";

        public static string SP_GetPatient = "sp_get_patient";

        public static string SP_Save_Patient_Attachments = "sp_save_patient_attachments";
        public static string SP_GetAll_Attachments = "sp_get_all_attachments";
        public static string SP_Delete_Attachments = "sp_delete_attachment";

        public static string SP_GetAll_Histories = "sp_get_all_patient_history";

        #endregion

        #endregion


        #region Messages

        #region Parent

        public const string MSG_SaveParent_Success = "Encargado Creado Exitosamente!";
        public const string MSG_SaveParent_FailureDefault = "Error en la creación del Encargado";
        public const string MSG_SaveParent_FailureEmail = "Correo duplicado, no se puede registrar el Encargado";
        public const string MSG_SaveParent_FailureIdentification = "Identificación duplicada, no se puede registrar el Encargado";
        public const string MSG_GetParent_Success = "Encargado Creado Exitosamente!";
        public const string MSG_SaveProduct_Failure = "Error en la creacion del Producto";
        public const string MSG_GetAllProducts_Success = "Carga Exitosa de Productos";
        public const string MSG_GetProduct_Success = "Carga Exitosa del Producto";
      


        public const string MSG_GetAllEthnicGroup_Success = "Carga de grupos etnicos";

        public const string MSG_GetAllPatients_Success = "Consulta de todos los pacientes";
        public const string MSG_SavePatients_Success = "Guardar paciente";
        public static string MSG_GetPatient_Success = "Consulta de paciente";
        #endregion


        #region Login

        public const string MSG_Login_Success = "Logueo Exitoso";
        public const string MSG_Login_FailureDefault = "Error en el Logueo, favor intente mas tarde";
        public const string MSG_Login_Failure1 = "Usuario no existe ó es incorecto";
        public const string MSG_Login_Failure2 = "Contraseña incorrecta";

        #endregion


        #region Treatment

        public const string MSG_SaveTreatment_Success = "Registro Actualizado / Creado Exitosamente!";
        public const string MSG_SaveTreatment_Failure = "Error en la Actualización / Creación del Registro";
        public const string MSG_SaveTreatment_Duplicate = "El paciente ha sido registrado anteriormente.";
        public const string MSG_GetAllTreatments_Success = "Carga Exitosa de Tratamientos";


        #endregion


        #region Attachments

        public const string MSG_SaveAttachment_Success = "Registro insertado Exitosamente!";
        public const string MSG_SaveAttachment_FailureDefault = "Error en la ingreso del Antecedente";
        public const string MSG_SaveAttachment_Failure20 = "Tiene mas de 20 archivos para el mismo paciente, no se puede ingresar el registro";
        public const string MSG_SaveTreatment_MaxPatients = "Ha excedido la cantidad máxima de pacientes(5)";
        public const string MSG_GetAllAttachments_Success = "Consulta de Antecedentes Exitosa!";
        public const string MSG_DeleteAttachment_Success = "Registro borrado Exitosamente!";
        public const string MSG_DeleteAttachment_Failure = "Error en el borrado del Antecedente";
        public const string MSG_GetAllHistories_Success = "Consulta de Historiales Exitosa!";
        #endregion

        #endregion
    }
}
