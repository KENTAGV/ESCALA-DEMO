using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameActionsController : MonoBehaviour
{
    [Header("Stats")]
    public int health = 100;
    public int score = 1000;
    public int speed = 0;
    public int sprint = 0;

    [Header("UI Buttons")]
    public Button damageButton;
    public Button healingButton;
    public Button spaceButton;

    [Header("UI Text (TextMeshPro)")]
    public TMP_Text healthText;
    public TMP_Text scoreText;
    public TMP_Text speedText;
    public TMP_Text sprintText;

    [Header("Colors")]
    public Color damageColor = Color.red;
    public Color healingColor = Color.green;
    public Color spaceColor = Color.cyan;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip actionSound;

    [Header("Particles")]
    public ParticleSystem particles;

    void Start()
    {
        // Click izquierdo solamente
        damageButton.onClick.AddListener(OnDamage);
        healingButton.onClick.AddListener(OnHealing);
        spaceButton.onClick.AddListener(OnSpacePressed);

        UpdateUI();
    }

    // -------- SPACE BUTTON (CLICK) --------
    void OnSpacePressed()
    {
        speed++;

        if (speed % 5 == 0)
            sprint++;

        ChangeButtonColor(spaceButton, spaceColor);
        PlayEffects();
        UpdateUI();
    }

    // -------- DAMAGE --------
    void OnDamage()
    {
        health -= 10;
        score -= 50;

        ChangeButtonColor(damageButton, damageColor);
        PlayEffects();
        UpdateUI();
    }

    // -------- HEALING --------
    void OnHealing()
    {
        health += 10;
        score += 50;

        ChangeButtonColor(healingButton, healingColor);
        PlayEffects();
        UpdateUI();
    }

    // -------- UI --------
    void UpdateUI()
    {
        healthText.text = $"Health = {health}";
        scoreText.text = $"Score = {score}";
        speedText.text = $"Speed = {speed}";
        sprintText.text = $"Sprint = {sprint}";
    }

    // -------- UTILITIES --------
    void ChangeButtonColor(Button button, Color color)
    {
        ColorBlock cb = button.colors;
        cb.normalColor = color;
        cb.highlightedColor = color;
        cb.pressedColor = color;
        button.colors = cb;
    }

    void PlayEffects()
    {
        if (audioSource && actionSound)
            audioSource.PlayOneShot(actionSound);

        if (particles)
            particles.Play();
    }
}
