using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace IUL
{
    class Project
    {
        private string _id;
        private string _name;
        private bool _capitalOrLinear;
        private bool _isGeodetiSurveys;
        private bool _isGeologicalSurveysSurveys;
        private bool _isEnvironmentalSurveys;
        private bool _isMeteorologicalSurveys;
        private bool _isGeotechnicalSurveys;
        private bool _isArchaeologicalSurveys;
        private bool _isInspectionOfTechnicalCondition;
        private string _nameCustomer;
        private int _idGIP;
        private int _idNkont;
        private string _path;
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }

        }
        public bool CapitalOrLinear
        {
            get { return this._capitalOrLinear; }
            set { this._capitalOrLinear = value; }

        }
        /// <summary>
        /// Инженерно-геодезические изыскания
        /// </summary>
        public bool IsGeodetiSurveys
        {
            get { return this._isGeodetiSurveys; }
            set { this._isGeodetiSurveys = value; }

        }
        /// <summary>
        /// Инженерно-геологические изыскания
        /// </summary>
        public bool IsGeologicalSurveysSurveys
        {
            get { return this._isGeologicalSurveysSurveys; }
            set { this._isGeologicalSurveysSurveys = value; }

        }
        /// <summary>
        /// Инженерно-экологические изыскания
        /// </summary>
        public bool IsEnvironmentalSurveys
        {
            get { return this._isEnvironmentalSurveys; }
            set { this._isEnvironmentalSurveys = value; }

        }
        /// <summary>
        /// Инженерно-гидрометеорологические изыскания
        /// </summary>
        public bool IsMeteorologicalSurveys
        {
            get { return this._isMeteorologicalSurveys; }
            set { this._isMeteorologicalSurveys = value; }
        }
        /// <summary>
        /// Инженерно-геотехнические изыскания
        /// </summary>
        public bool IsGeotechnicalSurveys
        {
            get { return this._isGeotechnicalSurveys; }
            set { this._isGeotechnicalSurveys = value; }
        }
        /// <summary>
        /// Археологические изыскания
        /// </summary>
        public bool IsArchaeologicalSurveys
        {
            get { return this._isArchaeologicalSurveys; }
            set { this._isArchaeologicalSurveys = value; }

        }
        /// <summary>
        /// Техническое обследование здания/сооружения
        /// </summary>
        public bool IsInspectionOfTechnicalCondition
        {
            get { return this._isInspectionOfTechnicalCondition; }
            set { this._isInspectionOfTechnicalCondition = value; }

        }
        public string NameCustomer
        {
            get { return this._nameCustomer; }
            set { this._nameCustomer = value; }

        }
        public int IdGIP
        {
            get { return this._idGIP; }
            set { this._idGIP = value; }

        }
        public int IdNkont
        {
            get { return this._idNkont; }
            set { this._idNkont = value; }

        }
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }

        }

        public bool InsertNewProject()
        {
            string query = "USE [IUL];" +
                           "INSERT INTO [IUL].[dbo].[PROJECTS]([PROJECT_ID]" +
                           ",[PROJECT_NAME]" +
                           ",[PROJECT_CAPITAL_OR_LINEAR]" +
                           ",[PROJECT_GEODETI_SURVEYS]" +
                           ",[PROJECT_GEOLOGICAL SURVEYS_SURVEYS]" +
                           ",[PROJECT_ENVIRONMENTAL_SURVEYS]" +
                           ",[PROJECT_METEOROLOGICAL_SURVEYS]" +
                           ",[PROJECT_GEOTECHNICAL_SURVEYS]" +
                           ",[PROJECT_ARCHAEOLOGICAL_SURVEYS]" +
                           ",[PROJECT_INSPECTION_OF_TECHNICAL_CONDITION]" +
                           ",[PROJECT_CUSTOMER]" +
                           ",[PROJECT_GIP_ID]" +
                           ",[PROJECT_N_KONTR_ID]" +
                           ",[PROJECT_PATH_FOLDER]) " +
                           "VALUES(@id, @name, " +
                           "@capitalOrLinear, @isGeodetiSurveys," +
                           "@isGeologicalSurveysSurveys, @isEnvironmentalSurveys," +
                           "@isMeteorologicalSurveys, @isGeotechnicalSurveys, " +
                           "@isArchaeologicalSurveys, @isInspectionOfTechnicalCondition, " +
                           "@nameCustomer, @idGIP, " +
                           "@idNkont, @path);";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = this._id;
                command.Parameters.Add("@name", SqlDbType.Text).Value = this._name;
                command.Parameters.Add("@capitalOrLinear", SqlDbType.Bit).Value = this._capitalOrLinear;
                command.Parameters.Add("@isGeodetiSurveys", SqlDbType.Bit).Value = this._isGeodetiSurveys;
                command.Parameters.Add("@isGeologicalSurveysSurveys", SqlDbType.Bit).Value =
                    this._isGeologicalSurveysSurveys;
                command.Parameters.Add("@isEnvironmentalSurveys", SqlDbType.Bit).Value = this._isEnvironmentalSurveys;
                command.Parameters.Add("@isMeteorologicalSurveys", SqlDbType.Bit).Value = this._isMeteorologicalSurveys;
                command.Parameters.Add("@isGeotechnicalSurveys", SqlDbType.Bit).Value = this._isGeotechnicalSurveys;
                command.Parameters.Add("@isArchaeologicalSurveys", SqlDbType.Bit).Value = this._isArchaeologicalSurveys;
                command.Parameters.Add("@isInspectionOfTechnicalCondition", SqlDbType.Bit).Value =
                    this._isInspectionOfTechnicalCondition;
                command.Parameters.Add("@nameCustomer", SqlDbType.Text).Value = this._nameCustomer;
                command.Parameters.Add("@idGIP", SqlDbType.Int).Value = this._idGIP;
                command.Parameters.Add("@idNkont", SqlDbType.Int).Value = this._idNkont;
                command.Parameters.Add("@path", SqlDbType.Text).Value = this._path;
                command.ExecuteNonQuery();
            }

            return true;
        }
    }
}
