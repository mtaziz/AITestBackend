﻿using System;
namespace AITestBackend.Models
{
    public class AppManagement
    {

        //APP 
        public const string connStr = "server=50.62.209.187;user=xdevs;database=ALCCI_DB;port=3306;password=pass123;SslMode=none";

        public const string APIS_Token = "";

        //IBM Chatbot
        public const string WorkspaceID = "799aecc9-dcb3-41db-b85a-36043cf448b9";
        public const string WorkspaceURL = "https://gateway.watsonplatform.net/assistant/api/v1/workspaces/" + WorkspaceID + "/message/";

        public const string UserName = "93ac3419-e3a6-4565-a6ee-6a086ba7d1a8";
        public const string Password = "nYnCFtwdjuAs";
        public const string VersionDate = "2018-07-10";

        //Messages
        public const string MSG_API_Validation_Failure = "Se ha producido un error";
        public const string MSG_SendMessageToAssistantResponse_Succesful = "";

        public const string MSG_GenericExceptionError = "Se ha producido un error en el Servidor";


        #region sps

        #region login
        public const string SP_LoginUser = "sp_loginuser";
        #endregion

        #region parent
        public const string SP_GetParent = "sp_getparent";
        public const string SP_SaveParent = "sp_saveparent";
        public const string SP_UpdateParent = "sp_updateparent";
        #endregion

        #region Ethnic Group
        public const string SP_GetAllEthnicGroup = "sp_get_all_ethnic_group";

        #endregion

        #endregion


        #region Product

        public const string MSG_GetParent_Success = "Encargado Creado Exitosamente!";
        public const string MSG_SaveProduct_Failure = "Error en la creacion del Producto";
        public const string MSG_GetAllProducts_Success = "Carga Exitosa de Productos";
        public const string MSG_GetProduct_Success = "Carga Exitosa del Producto";


        public const string MSG_GetAllEthnicGroup_Success = "Carga de grupos etnicos";

        public const string MSG_GetAllPatients_Success = "Carga de grupos etnicos";

        #endregion
    }
}
