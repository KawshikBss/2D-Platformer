using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image healthFill;
    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        healthFill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health) {
        slider.value = health;
        healthFill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
