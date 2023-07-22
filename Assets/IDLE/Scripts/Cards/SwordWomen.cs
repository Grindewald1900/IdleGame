using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordWomen : BaseCard
{    
    void Start()
    {
        initCardInfo();
    }

    void Update()
    {

    }

// set common values for a specific type of card
    private initCardInfo()
    {     
        cardName = "SwordsWomen";
        cardCost = 2;
        // TODO: Need Localization
        cardDescription = "Need Localization";
        // cardImage = Resources.Load<Sprite>("CardImages/SwordsWomen");
        cardAttackType = cardAttackType.PHYSICAL;
        cardTargetType = cardTargetType.FRONT_ROW;
        physicalDamageMultiplier = 5;
        spiritualDamageMultiplier = 0;
        magicDamageMultiplier = 0;
        healthMultiplier = 20;
        armorMultiplier = 4;
        magicResistMultiplier = 2;
        spiritualResistMultiplier = 1;
        speedMultiplier = 1;
    }
}