using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Texts")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI sprintText;

    [Header("Buttons")]
    public Button damageButton;
    public Button healButton;
    public Button spaceButton;

    // VALORES DEL JUEGO
    private int health = 100;
    private int score = 1000;
    private int speed = 0;
    private int sprint = 0;

    void Start()
    {
        UpdateTexts();

        // Suscribirse a eventos
        GameEvents.Instance.OnDamage.AddListener(OnDamage);
        GameEvents.Instance.OnHeal.AddListener(OnHeal);
        GameEvents.Instance.OnSpacePressed.AddListener(OnSpacePressed);
    }

    void OnDamage()
    {
        health -= 10;
        score -= 100;

        damageButton.image.color = Color.red;

        UpdateTexts();
    }

    void OnHeal()
    {
        health += 10;
        score += 100;

        healButton.image.color = Color.green;

        UpdateTexts();
    }

    void OnSpacePressed()
    {
        speed++;

        if (speed % 5 == 0)
        {
            sprint++;
        }

        spaceButton.image.color = Color.yellow;

        UpdateTexts();
    }

    void UpdateTexts()
    {
        healthText.text = $"Health = {health}";
        scoreText.text  = $"Score = {score}";
        speedText.text  = $"Speed = {speed}";
        sprintText.text = $"Sprint = {sprint}";
    }
}