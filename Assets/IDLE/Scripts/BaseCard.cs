using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCard : MonoBehaviour
{
    /* 
    Variables starts with card indicate these values are visible to users
    Otherwise, they are not visible to users, and only used for internal
    */
    public string cardName;
    public string cardDescription;
    public int cardCost;
    public Sprite cardImage;
    public int cardPhysicalDamage;
    public int cardSpiritualDamage;
    public int cardMagicDamage;
    public int cardHealth;
    public int cardLevel;
    public int cardPower;
    public int cardStar;
    public int cardArmor;
    public int cardMagicResist;
    public int cardSpiritualResist;
    public int cardSpeed;
    // Card position from 1 to 5
    public int cardPriority;
    // Mana, physical, spiritual 
    public int cardAttackType;
    // Random, front, back, all, highest atk, highest health,
    public int cardTargetType;
    public int physicalDamageMultiplier;
    public int spiritualDamageMultiplier;
    public int magicDamageMultiplier;
    public int healthMultiplier;
    public int armorMultiplier;
    public int magicResistMultiplier;
    public int spiritualResistMultiplier;

    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
