using Given.Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Given.Utility
{
    public class DiceValue : MonoBehaviour
    {
        public EDiceType DiceType { get; private set; }

        private Image _img;
        private void Awake()
        {
            _img = GetComponent<Image>();
        }

        public void SetType(EDiceType diceType)
        {
            DiceType = diceType;
            _img.sprite = DataManager.Instance.DiceSprites[(int)diceType];
        }
        
        public void SetType(int diceType)
        {
            DiceType = (EDiceType)diceType;
            _img.sprite = DataManager.Instance.DiceSprites[diceType];
        }

        public void SetInvalid()
        {
            _img.sprite = DataManager.Instance.MissingIcon;
        }
    }
}
