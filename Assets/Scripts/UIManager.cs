using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI sprintText;

    public Button damageButton;
    public Button healButton;
    public Button spaceButton;

    public ParticleSystem particles;

    public void UpdateHealth(int value)
    {
        healthText.text = "Health = " + value;
    }

    public void UpdateScore(int value)
    {
        scoreText.text = "Score = " + value;
    }

    public void UpdateSpeed(int value)
    {
        speedText.text = "Speed = " + value;
    }

    public void UpdateSprint(int value)
    {
        sprintText.text = "Sprint = " + value;
    }

    public void ChangeButtonColor(Button button, Color color)
    {
        button.image.color = color;
    }

    public void PlayParticles()
    {
        particles.Play();
    }
}
