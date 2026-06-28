using UnityEngine;
using TMPro;

public class DamagedPopup : MonoBehaviour
{
    private RectTransform rectTransform;
    private TMP_Text tmpComponent;

    private Vector3 initPosition;

    private readonly float lifeTime = .3f;
    private readonly float moveSpeed = 3f;
    private readonly float scaleSpeed = .02f;
    private readonly float alphaSpeed = .03f;

    private void Awake()
    {
        rectTransform = transform.GetComponent<RectTransform>();
        tmpComponent = transform.GetComponent<TMP_Text>();

        initPosition = rectTransform.localPosition;
    }

    private void Update()
    {
        rectTransform.localPosition += new Vector3(0, moveSpeed);
        transform.localScale -= new Vector3(scaleSpeed, scaleSpeed);
        tmpComponent.alpha -= alphaSpeed;
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        CancelInvoke(nameof(HideObject));
        Invoke(nameof(HideObject), lifeTime);
    }

    private void OnDisable()
    {
        rectTransform.localPosition = initPosition;
        transform.localScale = new Vector3(1, 1, 1);
        tmpComponent.alpha = 1;

        CancelInvoke(nameof(HideObject));
    }
}
