﻿using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Request;

public class UpdateExerciseDto
{
    [Required]
    public string Name { get; set; }

    public string? Description { get; set; }

    [Required]
    public string Picture { get; set; }
}
