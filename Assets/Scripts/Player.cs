using UnityEngine;

public class Player : MonoBehaviour {
    public int coinsCollected;
    private int health;
    public int maxHealth = 100;
    public float knockBack = 100f;
    public HealthBar healthBar;
    void Start() {
        coinsCollected = 0;
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(health);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin")) {
            coinsCollected++;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Enemy")) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(knockBack, 0));
            health -= 10;
            healthBar.SetHealth(health);
        }
    }
}