using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameCanvas : Bolt.GlobalEventListener
{
    public GameObject canvas;
    public TextMeshProUGUI scorePopupTemplate;
    public override void OnEvent(ScoreEvent evnt)
    {
        //print(evnt.Message);
        TextMeshProUGUI scorePopupClone = Instantiate(scorePopupTemplate);
        scorePopupClone.text = evnt.Message;
        scorePopupClone.gameObject.SetActive(true);
        UITranslator.TranslateTextToUIPostion(scorePopupClone, scorePopupTemplate.GetComponent<RectTransform>(), canvas);
        Destroy(scorePopupClone.gameObject, 4f);
    }
}
