using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonAnimations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject Button;

    private float _duration = 0.7f;
    private int _amplityde = 4;
    private float _animationScaleUp = 1.05f;
    private float _animationScaleDown = 0.95f;
    private float _delay = 0.1f;

    public void OnPointerClick(PointerEventData eventData)
    {
        Button.transform.DOScale(new Vector2(_animationScaleUp, _animationScaleUp), _duration).SetEase(Ease.InOutFlash, _amplityde, _duration);
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
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Button.transform.DOScale(new Vector2(1, 1), _duration).SetEase(Ease.OutFlash);
    }
}
