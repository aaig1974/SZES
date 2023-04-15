using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SZES.Models;

[Table("azubi")]
public partial class Azubi
{
    [Key]
    [Column("azubiId")]
    public int AzubiId { get; set; }

    [Column("lastname")]
    [StringLength(50)]
    public string Lastname { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    public string Email { get; set; } = null!;
}
