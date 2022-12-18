﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.Data.Entities;

public class UserGroup
{
    public Guid Id { get; set; }

    public User? Student { get; set; }
    public User? Teacher { get; set; }
    public Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    public Guid GroupId { get; set; }
    [ForeignKey(nameof(GroupId))]
    public virtual Group? Group { get; set; }

}