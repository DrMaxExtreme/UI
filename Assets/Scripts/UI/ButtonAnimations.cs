using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ButtonAnimations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject Button;

    private Color _defaultColor;
    private Color _tempColor;
    private float _duration = 0.7f;
    private int _amplityde = 4;
    private float _animationScaleUp = 1.05f;
    private float _normalScale = 1f;
    private float _animationScaleDown = 0.95f;
    private float _delay = 0.1f;

    private void Start()
    {
        _defaultColor = Button.GetComponent<Graphic>().color;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Button.transform.DOScale(new Vector2(_animationScaleUp, _animationScaleUp), _duration).SetEase(Ease.InOutFlash, _amplityde, _duration);
        _tempColor = Button.GetComponent<Graphic>().color = Color.Lerp(_defaultColor, Color.gray, _duration);
        Button.GetComponent<Graphic>().color = Color.Lerp(_tempColor, _defaultColor, _duration);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Button.transform.DOScale(new Vector2(_animationScaleDown, _animationScaleDown), _duration).SetEase(Ease.OutFlash);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.transform.DOScaleX(_animationScaleUp, _duration).SetEase(Ease.InOutFlash, _amplityde, _duration);
        Button.transform.DOScaleY(_animationScaleUp, _duration).SetEase(Ease.InOutFlash, _amplityde, _duration).SetDelay(_delay);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.transform.DOScaleX(_animationScaleDown, _duration).SetEase(Ease.InOutFlash, _amplityde, _duration);
        Button.transform.DOScaleY(_animationScaleDown, _duration).SetEase(Ease.InOutFlash, _amplityde, _duration).SetDelay(_delay);

        Button.transform.DOScaleX(_normalScale, _duration).SetEase(Ease.OutFlash).SetDelay(_duration);
        Button.transform.DOScaleY(_normalScale, _duration).SetEase(Ease.OutFlash).SetDelay(_duration);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Button.transform.DOScale(new Vector2(_normalScale, _normalScale), _duration).SetEase(Ease.OutFlash);
    }
}
