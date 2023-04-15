using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SZES.Models;

[Table("Anwesenheit")]
public partial class Anwesenheit
{
    [Key]
    [Column("anwensenId")]
    public int AnwensenId { get; set; }

    [Column("datum", TypeName = "date")]
    public DateTime? Datum { get; set; }

    [Column("logintime", TypeName = "date")]
    public DateTime? Logintime { get; set; }

    [Column("logouttime", TypeName = "date")]
    public DateTime? Logouttime { get; set; }
}
