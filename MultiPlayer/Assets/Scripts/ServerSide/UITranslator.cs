using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class UITranslator
{
    public static void TranslateTextToUIPostion(TextMeshProUGUI text, RectTransform desiredSize, GameObject parent)
    {
        text.transform.parent = parent.transform;
        text.GetComponent<RectTransform>().sizeDelta = desiredSize.sizeDelta;
        text.GetComponent<RectTransform>().localScale = desiredSize.localScale;
        text.GetComponent<RectTransform>().position = desiredSize.position;

        text.gameObject.SetActive(true);
    }
}
