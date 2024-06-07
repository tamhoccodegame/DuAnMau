using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HealthBar : MonoBehaviour
{
    private Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

   

	public void UpdateHealthbar(float health)
    {
		healthSlider.value = health / 100f;
	}
}
