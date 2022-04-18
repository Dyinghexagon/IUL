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
        /// <summary>
        /// Инженерно-геодезические изыскания
        /// </summary>
        public Boolean IsGeodetiSurveys
        {
            get { return _isGeodetiSurveys; }
            set { _isGeodetiSurveys = value; }

        }
        /// <summary>
        /// Инженерно-геологические изыскания
        /// </summary>
        public Boolean IsGeologicalSurveysSurveys
        {
            get { return _isGeologicalSurveysSurveys; }
            set { _isGeologicalSurveysSurveys = value; }

        }
        /// <summary>
        /// Инженерно-экологические изыскания
        /// </summary>
        public Boolean IsEnvironmentalSurveys
        {
            get { return _isEnvironmentalSurveys; }
            set { _isEnvironmentalSurveys = value; }

        }
        /// <summary>
        /// Инженерно-гидрометеорологические изыскания
        /// </summary>
        public Boolean IsMeteorologicalSurveys
        {
            get { return _isMeteorologicalSurveys; }
            set { _isMeteorologicalSurveys = value; }
        }
        /// <summary>
        /// Инженерно-геотехнические изыскания
        /// </summary>
        public Boolean IsGeotechnicalSurveys
        {
            get { return _isGeotechnicalSurveys; }
            set { _isGeotechnicalSurveys = value; }
        }
        /// <summary>
        /// Археологические изыскания
        /// </summary>
        public Boolean IsArchaeologicalSurveys
        {
            get { return _isArchaeologicalSurveys; }
            set { _isArchaeologicalSurveys = value; }

        }
        /// <summary>
        /// Техническое обследование здания/сооружения
        /// </summary>
        public Boolean IsInspectionOfTechnicalCondition
        {
            get { return _isInspectionOfTechnicalCondition; }
            set { _isInspectionOfTechnicalCondition = value; }

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
                {nameServeys[0], _isGeodetiSurveys},
                {nameServeys[1], _isGeologicalSurveysSurveys},
                {nameServeys[2], _isEnvironmentalSurveys},
                {nameServeys[3], _isMeteorologicalSurveys},
                {nameServeys[4], _isGeotechnicalSurveys},
                {nameServeys[5], _isArchaeologicalSurveys},
                {nameServeys[6], _isInspectionOfTechnicalCondition}
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
