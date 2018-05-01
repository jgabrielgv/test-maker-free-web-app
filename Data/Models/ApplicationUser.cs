using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMakerFreeWebApp.Data {
  public class ApplicationUser {

    #region Constructor
    public ApplicationUser () { }
    #endregion

    #region Properties
    [Key]
    [Required]
    public string Id;
    [Required]
    [MaxLength (128)]
    public string UserName;
    [Required]
    public string Email;
    public string DisplayName;
    public string Notes;
    [Required]
    public int Type;
    [Required]
    public int Flags;
    [Required]
    public DateTime CreatedDate;
    [Required]
    public DateTime LastModifiedDate;
    #endregion
  }
}