using UnityEngine;
using UnityEngine.UI;

public class RedHealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private Image healthSkull;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            healthBar.fillAmount = healthBar.fillAmount + 0.2f;
            healthSkull.fillAmount = healthSkull.fillAmount - 0.2f;
            Destroy(gameObject);
        }
    }
}
