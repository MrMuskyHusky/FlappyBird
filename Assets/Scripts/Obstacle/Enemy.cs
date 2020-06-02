using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float curHealth;
    public float maxHealth;

    public GameObject healthCanvas;
    public Image healthBar;
    public AudioSource audioSource;
    void Start()
    {
        maxHealth = curHealth;
    }

    void LateUpdate()
    {
        if (healthBar.fillAmount < 1 && healthBar.fillAmount > 0)
        {
            healthCanvas.SetActive(true);
            healthCanvas.transform.LookAt(Camera.main.transform);
            healthCanvas.transform.Rotate(0, 180, 0);
        }
        else if (healthCanvas.activeSelf == true)
        {
            healthCanvas.SetActive(false);
        }
    }

    public void Damage(float amount)
    {
        curHealth -= amount;
        healthBar.fillAmount = curHealth;
        audioSource.Play();
        if (curHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}