namespace PtsApi.Models;

using System.ComponentModel.DataAnnotations;

public class Patient
{
    public long Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string MedicalCondition { get; set; } = string.Empty;
}