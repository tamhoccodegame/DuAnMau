using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthSlider; // Thanh máu UI

    private float currentHealth;

    public void UpdateHealthbar(float newHealth)
    {
        currentHealth = newHealth;
        healthSlider.value = newHealth; // Giả sử Slider có giá trị từ 0 -> maxHealth
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

}