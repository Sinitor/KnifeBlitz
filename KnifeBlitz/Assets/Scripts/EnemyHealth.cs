using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    private float health = 0f;

    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private Slider healthSlider;

    private void Start()
    {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
    }

    private void Update()
    {
        StartCoroutine(NewLevel());
    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
            healthSlider.value = health;
        }
    }

    private void OnGUI()
    {
        float smooth = Time.deltaTime / 0.3f;
        healthSlider.value = Mathf.Lerp(healthSlider.value, health, smooth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            health -= 10;
        }
    } 

    IEnumerator NewLevel()
    {
        if (health == 0)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
