using UnityEngine;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public float timeAfterHit = .5f;

    public RectTransform healthBar;
    public GameObject explosion;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead!");
            if (explosion != null)
            {
                //explosion.SetActive(true);
                explosion.GetComponent<ParticleSystem>().Play();
            }
            Destroy(gameObject, timeAfterHit);
        }
    }
}