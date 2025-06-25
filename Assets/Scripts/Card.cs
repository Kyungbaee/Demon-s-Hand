using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DemonsHand
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public CardType cardType;
        public int damageMin;
        public int damageMax;
        public Sprite cardSprite;
        public DamageType damageType;

        public enum CardType
        {
            ace,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king,
        }

        public enum DamageType
        {
            Heart,
            Spade,
            Clover,
            Diamond
        }
    }
}