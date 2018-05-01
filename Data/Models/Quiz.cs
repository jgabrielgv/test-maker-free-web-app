using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMakerFreeWebApp.Data {
  public class Quiz {
    #region Constructor
    public Quiz () { }
    #endregion
    #region Properties
    [Key]
    [Required]
    public int Id;

    [Required]
    public string Title;
    public string Description;
    public string Text;
    public string Notes;

    [DefaultValue (0)]
    public int Type;

    [DefaultValue (0)]
    public int Flags;

    [Required]
    public string UserId;

    [Required]
    public int ViewCount;

    [Required]
    public DateTime CreatedDate;

    [Required]
    public DateTime LastModifiedDate;
    #endregion
  }
}