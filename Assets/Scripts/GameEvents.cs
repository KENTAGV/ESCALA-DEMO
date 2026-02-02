using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    public UnityEvent OnDamage;
    public UnityEvent OnHeal;
    public UnityEvent OnSpacePressed;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // MÉTODOS QUE LLAMAN LOS BOTONES / INPUT
    public void Damage()
    {
        OnDamage.Invoke();
    }

    public void Heal()
    {
        OnHeal.Invoke();
    }

    public void SpacePressed()
    {
        OnSpacePressed.Invoke();
    }
}