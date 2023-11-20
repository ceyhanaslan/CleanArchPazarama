using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CreditSystemPazarama.Domain.Entity;

public class LetterOfCredit
{
    [Required]
    [DisplayName("Başvuru Tutarı")]
    public decimal creditAmount { get; set; }
    
    [Required]
    [DisplayName("Kredi Vade")]
    public decimal creditPlan { get; set; }

    [DisplayName("Başvuru Tarihi")]
    public DateTime creditDate { get; set; }
    
    
}