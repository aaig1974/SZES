using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SZES.Models;

[Table("Azubianwesenheit")]
public partial class Azubianwesenheit
{
    [Key]
    [Column("azubanweId")]
    public int AzubanweId { get; set; }

    [Column("anwesenheitId")]
    public int? AnwesenheitId { get; set; }

    [Column("azubieId")]
    public int? AzubieId { get; set; }

    [Column("bereich")]
    [StringLength(50)]
    public string? Bereich { get; set; }
}
