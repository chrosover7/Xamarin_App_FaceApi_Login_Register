using System;
using System.Collections.Generic;
using System.Text;

namespace FaceLoginApp.Helpers
{
    public static class Constantes
    {
        public static readonly string FaceApiURL = "https://appti.cognitiveservices.azure.com/face/v1.0";
        public static readonly string FaceApiKey = "448b47079cd54e67b40ec531326e1be7";

        public static readonly string FaceGroupID = "sistemas";
        public static readonly string FaceGroupName = "Depto. de Sistemas";
        public static readonly string FaceGroupDescription = "Repositorio de rostros de los empleados de Sistemas";

        public static readonly string NombreBD = "BaseDatosSistemas.db";
    }
}
