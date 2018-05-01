using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace TestMakerFreeWebApp.ViewModels
{
  [JsonObject(MemberSerialization.OptOut)]
  public class QuestionViewModel {

    #region Constructor
    public QuestionViewModel () { }
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