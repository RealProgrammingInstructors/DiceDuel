using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Given.Reusable
{
    public class SliderText : MonoBehaviour
    {
        private enum ESliderType
        {
            Percentage,
            Number,
            NumberWithMax,
            Hidden
        }

        [SerializeField] private ESliderType sliderType;
        [SerializeField] private Slider slider;
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private bool inverse;
        private float _maxValue;
        private float _currentValue;
    

        public void UpdateMax(float value)
        {
            _maxValue = value;
            UpdateCurrent(_currentValue);
        }

        public void UpdateCurrent(float value)
        {
            _currentValue = value;
        
            float percent = _currentValue / _maxValue;
            if(inverse) percent = 1 - percent;
            slider.value = percent;

            switch (sliderType)
            {
                case ESliderType.Percentage:
                    text.text = ((int)(percent * 100)) + "%";
                    break;
                case ESliderType.Number:
                    text.text = _currentValue.ToString(CultureInfo.InvariantCulture);
                    break;
                case ESliderType.NumberWithMax:
                    text.text = _currentValue.ToString(CultureInfo.InvariantCulture) + "/" + _maxValue.ToString(CultureInfo.InvariantCulture);
                    break;
                case ESliderType.Hidden:
                    text?.gameObject.SetActive(false);
                    break;
            }

        }

    }
}
