using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerUpgradable 
{
    private List<SkillType> unlockedSkills = new List<SkillType>();
    public enum SkillType
    {
        None,
        MaxHealth,
        MaxDamage,
    }

    private bool CanUnlock(SkillType skillType)
    {
        return !unlockedSkills.Contains(skillType);
    }

    public void TryUnlock(SkillType skillType)
    {
        if(CanUnlock(skillType))
        {
            Unlock(skillType);
        }
    }

    private void Unlock(SkillType skillType)
    {
        unlockedSkills.Add(skillType);
    }

}
