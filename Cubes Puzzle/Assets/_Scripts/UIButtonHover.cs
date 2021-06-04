using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace _Scripts
{
    public class UIButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public Color hoverColor;

        private Text _text;
        private Color _standard;

        private void Awake()
        {
            _text = GetComponent<Text>();
            _standard = _text.color;
        }


        public void OnPointerEnter(PointerEventData eventData)
        {
            _text.color = hoverColor;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _text.color = _standard;
        }
    }
}
