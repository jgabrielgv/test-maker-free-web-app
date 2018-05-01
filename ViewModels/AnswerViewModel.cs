using System;
using Newtonsoft.Json;
using System.ComponentModel;

namespace TestMakerFreeWebApp.ViewModels
{
    [JsonObject (MemberSerialization.OptOut)]
    public class AnswerViewModel {

        #region Constructor
        public AnswerViewModel () { }
        #endregion

        #region Properties
        public int Id;
        public int QuizId;
        public int QuestionId;
        public string Text;
        public string Notes;
        [DefaultValue (0)]
        public int Type;
        [DefaultValue (0)]
        public int Flags;
        [DefaultValue (0)]
        public int Value;
        [JsonIgnore]
        public DateTime CreatedDate;
        public DateTime LastModifiedDate;
        #endregion
    }
}