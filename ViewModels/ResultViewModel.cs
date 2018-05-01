using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;

namespace TestMakerFreeWebApp.ViewModels {

    [JsonObject (MemberSerialization.OptOut)]
    public class ResultViewModel {

        #region Constructor
        public ResultViewModel () { }
        #endregion

        #region Properties
        public int Id;
        public int QuizId;
        public string Text;
        public string Notes;
        [DefaultValue (0)]
        public int Type;
        [DefaultValue (0)]
        public int Flags;
        [JsonIgnore]
        public DateTime CreatedDate;
        public DateTime LastModifiedDate;
        #endregion
    }
}