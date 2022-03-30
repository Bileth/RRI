using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerManager : MonoBehaviour
{
    [SerializeField] Text p1_number;
    [SerializeField] Text p2_number;
    public int maxHealth = 100;
    public int p1_currentHealth, p2_currentHealth;

    public Button p1_attackButton, p1_healButton, p2_attackButton, p2_healButton;

    public Image p1_Image, p2_Image;

    public Sprite p1_HealImage, p1_AttackImage, p1_DmgImage, p1_DeadImage, p1_NormalImage;
    public Sprite p2_HealImage, p2_AttackImage, p2_DmgImage, p2_DeadImage, p2_NormalImage;
    int lastPressed, firstPress;
    private int max, min;
    private float number;
    public HealthBarManager p1_healthBar;
    public HealthBarManager p2_healthBar;
    // Start is called before the first frame update
    void Start()
    {
        max = 40;
        min = 1;
        p1_currentHealth = maxHealth;
        p1_healthBar.SetMaxHealth(maxHealth);
        p2_currentHealth = maxHealth;
        p2_healthBar.SetMaxHealth(maxHealth);
        firstPress = Random.Range(1,3);
        if(firstPress == 1){
            p2_attackButton.interactable = false;
            p2_healButton.interactable = false;
        }
        else if(firstPress == 2){
            p1_attackButton.interactable = false;
            p1_healButton.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(p1_currentHealth <=0){
            SceneManager.LoadScene("P2_WinScreen");
        }
        else if(p2_currentHealth <=0){
            SceneManager.LoadScene("P1_WinScreen");
        }
        if(lastPressed == 2){
            p2_attackButton.interactable = false;
            p2_healButton.interactable = false;
            p1_attackButton.interactable = true;
            p1_healButton.interactable = true;
        }
        else if(lastPressed == 1){
            p1_attackButton.interactable = false;
            p1_healButton.interactable = false;
            p2_attackButton.interactable = true;
            p2_healButton.interactable = true;
        }

        if(p1_currentHealth >= 100){
            p1_healButton.interactable = false;
        }
        if(p2_currentHealth >= 100){
            p2_healButton.interactable = false;
        }
    }

    public int getNumber(){
        return Random.Range(min, max+1);
    }

    public void DealDamage(string playerName){ 
        int damage = getNumber();
        if(playerName.Equals("P1")){
            p1_Image.sprite = p1_AttackImage;
            p2_currentHealth -= damage;
            p2_healthBar.SetHealth(p2_currentHealth);
            p2_number.text = "-" + damage.ToString();
            p2_number.color = Color.red;
            p2_Image.sprite = p2_DmgImage;
            lastPressed = 1;
        }
        else if(playerName.Equals("P2")){
            p2_Image.sprite = p2_AttackImage;
            p1_currentHealth -= damage;
            p1_healthBar.SetHealth(p1_currentHealth);
            p1_number.text = "-" + damage.ToString();
            p1_number.color = Color.red;
            p1_Image.sprite = p1_DmgImage;
            lastPressed = 2;
        }
        
    }

    public void Heal(string playerName){
        int heal = getNumber();

        if(playerName.Equals("P1")){
            p1_currentHealth += heal;
            if(p1_currentHealth >= 100){
                p1_currentHealth = maxHealth;
            }
            p1_healthBar.SetHealth(p1_currentHealth);
            p1_Image.sprite = p1_HealImage;
            p1_number.text = "+" + heal.ToString();
            p1_number.color = Color.green;
            lastPressed = 1;
        }
        else if(playerName.Equals("P2")){
            p2_currentHealth += heal;
            if(p2_currentHealth >= 100){
                p2_currentHealth = maxHealth;
            }
            p2_healthBar.SetHealth(p2_currentHealth);
            p2_Image.sprite = p2_HealImage;
            p2_number.text = "+" + heal.ToString();
            p2_number.color = Color.green;
            lastPressed = 2;
        }
    }
}
