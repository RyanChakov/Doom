using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoulDeath : vp_DamageHandler
{
    public Animator animGoul;
    public int kills;
    public override void Damage(vp_DamageInfo damageInfo)
    {
        if (CurrentHealth > 0)
        {


            base.Damage(damageInfo);
            animGoul.Play("getHit1", 0, 0.25f);
        }
      
    
        
    }
    public override void Die()
    {
        print("waht");
        kills++;
        MaxHealth = kills;

        if (!enabled || !vp_Utility.IsActive(gameObject))
            return;

        if (m_Audio != null)
        {
            m_Audio.pitch = Time.timeScale;
            m_Audio.PlayOneShot(DeathSound);
        }
    }


}
