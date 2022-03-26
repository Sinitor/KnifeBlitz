using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlockHealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private Image healthSkull;

    private void Start()
    {
        healthSkull.fillAmount = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            healthBar.fillAmount = healthBar.fillAmount - 0.2f;
            healthSkull.fillAmount = healthSkull.fillAmount + 0.2f;
            if (healthBar.fillAmount <= 0.1 && healthSkull.fillAmount >= 0.9)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
