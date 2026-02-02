using UnityEngine;
public class ParticleManager : MonoBehaviour{
    public ParticleSystem damageParticles;
    public ParticleSystem healParticles;
    public ParticleSystem jumpParticles;

    void Start()
    {
        GameEvents.Instance.OnDamage.AddListener(PlayDamage);
        GameEvents.Instance.OnHeal.AddListener(PlayHeal);
        GameEvents.Instance.OnSpacePressed.AddListener(PlayJump);
    }

    void PlayDamage()
    {
        damageParticles.Play();
    }

    void PlayHeal()
    {
        healParticles.Play();
    }

    void PlayJump()
    {
        jumpParticles.Play();
    }
}