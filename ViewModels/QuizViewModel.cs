using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace TestMakerFreeWebApp.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class QuizViewModel
    {
        #region Constructor
        public QuizViewModel()
        {
        }
        #endregion

        #region Properties
        public int Id;
        public string Title;
        public string Description;
        public string Text;
        public string Notes;
        [DefaultValue(0)]
        public int Type;
        [DefaultValue(0)]
        public int Flags;
        public string UserId;
        [JsonIgnore]
        public int ViewCount;
        public DateTime CreatedDate;
        public DateTime LastModifiedDate;
        #endregion
    }
}