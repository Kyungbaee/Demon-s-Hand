using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DemonsHand;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;
    public Image cardImage;
    public Image[] typeImage;
    public Image[] mainImage;
    public TMP_Text damageText;

    private Color[] typeColors = {
        Color.red,
        Color.black,
        Color.black,
        Color.red,
    };

    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        // update text
        damageText.text = cardData.damageMin.ToString();
        damageText.color = typeColors[(int)cardData.damageType];

        // update type images
        int damageIdx = (int)cardData.damageType, mainIdx = (int)cardData.cardType;
        typeImage[damageIdx].gameObject.SetActive(true);
        typeImage[damageIdx].color = typeColors[damageIdx];
        mainImage[mainIdx].gameObject.SetActive(true);
    }
}
