using System;
using System.Collections.Generic;

namespace DoAnWeb.Model;

public partial class Skill
{
    public int IdSkill { get; set; }

    public string NameSkill { get; set; } = null!;

    public virtual ICollection<SkillDetail> SkillDetails { get; set; } = new List<SkillDetail>();
}
