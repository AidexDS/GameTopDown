using UnityEngine;
using UnityEngine.VFX;


public class AttributPlayer : MonoBehaviour
{
    
    private int currentHealth;

    
    public int maxHealth;

 
    public HealthBar healthBar;
    

   
    private int xp;

    internal void Start()
    {
        xp = 0;
        currentHealth = maxHealth;
        healthBar.SetmaxHealth(maxHealth);
    }

   
    internal void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Damage take test
        {
            takeDamage(10);

        }
    }

   
    public void takeDamage(int damage)
    {
        currentHealth -= damage;
       
        healthBar.Sethealth(currentHealth);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Item")
        {
            xp++;
            
            if (xp >= 3)
            {
                xp = 0;
                currentHealth = maxHealth;
                healthBar.Sethealth(maxHealth);
            }
            Debug.Log(xp);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("DETEXT");
            takeDamage(10);
        }
    }
}
