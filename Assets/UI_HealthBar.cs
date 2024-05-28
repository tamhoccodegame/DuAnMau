using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HealthBar : MonoBehaviour
{
    private Health playerHealth;
    private Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<Health>();   
        healthSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = playerHealth.currentHealth / 100;
    }
}
