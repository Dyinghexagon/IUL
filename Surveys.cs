using System;
using System.Collections.Generic;
using System.Text;

namespace IUL
{
    public class Surveys
    {
        private Boolean _isGeodetiSurveys;
        private Boolean _isGeologicalSurveysSurveys;
        private Boolean _isEnvironmentalSurveys;
        private Boolean _isMeteorologicalSurveys;
        private Boolean _isGeotechnicalSurveys;
        private Boolean _isArchaeologicalSurveys;
        private Boolean _isInspectionOfTechnicalCondition;
        public Boolean IsGeodetiSurveys
        {
            get { return this._isGeodetiSurveys; }
            set { this._isGeodetiSurveys = value; }

        }
        /// <summary>
        /// Инженерно-геологические изыскания
        /// </summary>
        public Boolean IsGeologicalSurveysSurveys
        {
            get { return this._isGeologicalSurveysSurveys; }
            set { this._isGeologicalSurveysSurveys = value; }

        }
        /// <summary>
        /// Инженерно-экологические изыскания
        /// </summary>
        public Boolean IsEnvironmentalSurveys
        {
            get { return this._isEnvironmentalSurveys; }
            set { this._isEnvironmentalSurveys = value; }

        }
        /// <summary>
        /// Инженерно-гидрометеорологические изыскания
        /// </summary>
        public Boolean IsMeteorologicalSurveys
        {
            get { return this._isMeteorologicalSurveys; }
            set { this._isMeteorologicalSurveys = value; }
        }
        /// <summary>
        /// Инженерно-геотехнические изыскания
        /// </summary>
        public Boolean IsGeotechnicalSurveys
        {
            get { return this._isGeotechnicalSurveys; }
            set { this._isGeotechnicalSurveys = value; }
        }
        /// <summary>
        /// Археологические изыскания
        /// </summary>
        public Boolean IsArchaeologicalSurveys
        {
            get { return this._isArchaeologicalSurveys; }
            set { this._isArchaeologicalSurveys = value; }

        }
        /// <summary>
        /// Техническое обследование здания/сооружения
        /// </summary>
        public Boolean IsInspectionOfTechnicalCondition
        {
            get { return this._isInspectionOfTechnicalCondition; }
            set { this._isInspectionOfTechnicalCondition = value; }

        }
        public Surveys
        (Boolean isGeodetiSurveys, Boolean isGeologicalSurveysSurveys, Boolean isEnvironmentalSurveys,
        Boolean isMeteorologicalSurveys, Boolean isGeotechnicalSurveys, 
        Boolean isArchaeologicalSurveys, Boolean isInspectionOfTechnicalCondition) 
        {
            IsGeodetiSurveys = isGeodetiSurveys;
            IsGeologicalSurveysSurveys = isGeologicalSurveysSurveys;
            IsEnvironmentalSurveys = isEnvironmentalSurveys;
            IsMeteorologicalSurveys = isMeteorologicalSurveys;
            IsGeotechnicalSurveys = isGeotechnicalSurveys;
            IsArchaeologicalSurveys = isArchaeologicalSurveys;
            IsInspectionOfTechnicalCondition = isInspectionOfTechnicalCondition;
        }
        public String[] GetSurveys() 
        {
            String[] nameServeys = new String[]
            {
                "Инженерно - геодезические изыскания",
                "Инженерно - геологические изыскания",
                "Инженерно - экологические изыскания",
                "Инженерно - гидрометеорологические изыскания",
                "Инженерно - геотехнические изыскания",
                "Археологические изыскания",
                "Техническое обсследование здания",
            };
            Dictionary<String, Boolean> surveysDict = new Dictionary<String, Boolean>()
            {
                {nameServeys[0], this._isGeodetiSurveys},
                {nameServeys[1], this._isGeologicalSurveysSurveys},
                {nameServeys[2], this._isEnvironmentalSurveys},
                {nameServeys[3], this._isMeteorologicalSurveys},
                {nameServeys[4], this._isGeotechnicalSurveys},
                {nameServeys[5], this._isArchaeologicalSurveys},
                {nameServeys[6], this._isInspectionOfTechnicalCondition}
            };
            List<String> surveys = new List<string>();
            foreach (var s in surveysDict) 
            {
                if (s.Value) 
                {
                    surveys.Add(s.Key);
                }
            }
            return surveys.ToArray();
        }
    }
}
