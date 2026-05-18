using System;
using System.Collections; // Это нужно для работы с паузами
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.Rendering.DebugUI;

public class TheGalleryScript : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject chapterTitle;
    [SerializeField] private GameObject galleryImage;
    [SerializeField] private GameObject walkingImage;
    [SerializeField] private GameObject textTop;
    [SerializeField] private GameObject textBottom;
    [SerializeField] private GameObject textMiddle;
    [SerializeField] private GameObject spiderBarBlurred;
    [SerializeField] private GameObject spiderBar;
    [SerializeField] private GameObject muhiBar;
    [SerializeField] private GameObject hint;
    [SerializeField] private GameObject buttonMary;
    [SerializeField] private GameObject buttonDzun;
    [SerializeField] private GameObject buttonLin;
    [SerializeField] private GameObject spiderFell;
    [SerializeField] private GameObject hole;


    void Start()
    {

        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {

        RectTransform rt;

        yield return new WaitForSeconds(5f);

        blackScreen.GetComponent<Animator>().SetTrigger("FadeIn");

        textTop.GetComponent<TMP_Text>().text = "\n";

        yield return new WaitForSeconds(0.75f);

        textTop.GetComponent<TextTyper>().StartTyping("Оей Оей... Всё нормально.\n");

        yield return new WaitForSeconds(2f);

        textTop.GetComponent<TextTyper>().StartTyping("Я просто...");

        yield return new WaitForSeconds(1.75f);

        textTop.GetComponent<TextTyper>().StartTyping(" исследую нижний мир. \n\n\n\n\n\n\n");

        yield return new WaitForSeconds(1.75f);

        textTop.GetComponent<TextTyper>().StartTyping("Добровольно. ");

        yield return new WaitForSeconds(1.5f);

        textTop.GetComponent<TextTyper>().StartTyping("Совершенно добровольно. ");

        textTop.GetComponent<Animator>().SetTrigger("FadeOut");

        textBottom.GetComponent<Animator>().SetTrigger("FadeOut");

        yield return new WaitForSeconds(2f);

        textBottom.GetComponent<TMP_Text>().text = "<color=#ffb790>Франклин: </color>";

        yield return new WaitForSeconds(1f);

        GameUtils.Instance.FadeOut(spiderFell, 0.5f);

        yield return new WaitForSeconds(1f);

        textBottom.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(0.75f);

        textBottom.GetComponent<TextTyper>().StartTyping("Высоко... Придется искать другой путь.");

        yield return new WaitForSeconds(3f);

        textTop.GetComponent<Animator>().enabled = false;
        textBottom.GetComponent<Animator>().enabled = false;
        textMiddle.GetComponent<Animator>().enabled = false;
        hint.GetComponent<Animator>().enabled = false;
        //hint.GetComponent<Animator>().enabled = false;
        blackScreen.GetComponent<Animator>().enabled = false;

        GameUtils.Instance.FadeIn(blackScreen, 0.75f);
        GameUtils.Instance.FadeOut(textBottom, 0.75f);

        yield return new WaitForSeconds(1f);

        hole.SetActive(false);

        yield return new WaitForSeconds(1f);

        textTop.GetComponent<TMP_Text>().text = "Где-то в глубине квартиры ожил человек.\nТот самый, который иногда ходил по \nпотолку<i>(с точки зрения Франклина)</i> и \nпериодически вооружался чем-то\nплоским и очень, очень быстрым\n";



        GameUtils.Instance.FadeIn(textTop, 1.5f);

        yield return new WaitForSeconds(6f);

        textMiddle.GetComponent<TMP_Text>().fontSize = 200;
        textMiddle.GetComponent<TMP_Text>().text = "\n<color=#ff0000ff>Тапком</color>";

        rt = textMiddle.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(-76, -77);

        GameUtils.Instance.FadeIn(textMiddle, 2f);

        yield return new WaitForSeconds(1.5f);
        hint.GetComponent<TMP_Text>().fontSize = 100;

        hint.GetComponent<TMP_Text>().text = "(Space - продолжить)";

        GameUtils.Instance.FadeTo(hint, 1f, 0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(hint, 0.5f);
        yield return new WaitForSeconds(0.5f);

        galleryImage.SetActive(true);

        GameUtils.Instance.FadeOut(textTop, 0.5f);
        GameUtils.Instance.FadeOut(textMiddle, 1.5f);
        GameUtils.Instance.FadeOut(textBottom, 0.5f);
        GameUtils.Instance.FadeOut(blackScreen, 1f);

        yield return new WaitForSeconds(1f);
        //??
        yield return new WaitForSeconds(1.5f);

        textTop.GetComponent<TMP_Text>().text = "Франклин оказывается перед дырой, размером ровно с его тельце, в углу комнаты.";

        textBottom.GetComponent<TMP_Text>().text = "Над ней стрелка, указывающая внутрь, а из дыры идёт слегка тёплый яркий свет.";

        GameUtils.Instance.FadeIn(textTop, 1.2f);

        //textTop.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(3f);

        GameUtils.Instance.FadeIn(textBottom, 1.2f);
        //textBottom.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(1.5f);

        hint.SetActive(true);
        hint.GetComponent<TMP_Text>().fontSize = 140;

        hint.GetComponent<TMP_Text>().text = "(W - Войти)";

        GameUtils.Instance.FadeTo(hint, 1f, 0.75f);

        yield return new WaitUntil(() => Keyboard.current.wKey.wasPressedThisFrame);

        hint.GetComponent<TMP_Text>().color = new Color(206, 238, 253);

        GameUtils.Instance.FadeOut(hint, 0.5f);

        yield return new WaitForSeconds(0.5f);

        //textTop.GetComponent<Animator>().SetTrigger("FadeOut");
        //textBottom.GetComponent<Animator>().SetTrigger("FadeOut");

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);

        yield return new WaitForSeconds(1f);

        GameUtils.Instance.FadeOut(galleryImage, 2f);

        yield return new WaitForSeconds(1.75f);

        textTop.GetComponent<TMP_Text>().text = "Он осторожно выполз из дыры, покидая привычную тьму чердака. И очутился в месте, похожем на бар или клуб.";

        GameUtils.Instance.FadeIn(textTop, 1f);

        yield return new WaitForSeconds(2.5f);
        textMiddle.GetComponent<TMP_Text>().fontSize = 100;

        textMiddle.GetComponent<TMP_Text>().text = "Вокруг была жизнь. Суетливая, жужжащая, немного липкая жизнь.. ";

        rt.anchoredPosition = new Vector2(-76, -461); //текст обратно

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(3f);

        walkingImage.GetComponent<Animator>().SetTrigger("Animate");

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 1f);

        yield return new WaitForSeconds(3f);

        textTop.GetComponent<TMP_Text>().text = "<color=#ffb790>Франклин: </color>";

        GameUtils.Instance.FadeIn(textTop, 0.1f);

        yield return new WaitForSeconds(0.5f);

        textTop.GetComponent<TextTyper>().StartTyping("На чердаке была только знакомая пыль и тишина.     \nА тут... Столько всего нового.");

        yield return new WaitForSeconds(4.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textTop.GetComponent<TMP_Text>().text = "<color=#ffb790>Франклин: </color>";

        //GameUtils.Instance.FadeIn(textTop, 0.1f);

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitForSeconds(3f);

        //hint.GetComponent<TMP_Text>().text = "(Space - продолжить)";

        //GameUtils.Instance.FadeTo(hint, 1f, 0.75f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(hint, 0.5f);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.FadeOut(textTop, 1f);

        yield return new WaitForSeconds(0.5f);

        spiderBarBlurred.GetComponent<Animator>().enabled = true;
        spiderBarBlurred.GetComponent<Animator>().Play("Idle 0");

        spiderBarBlurred.GetComponent<Animator>().SetTrigger("Animate");

        textTop.GetComponent<TMP_Text>().text = "";

        yield return new WaitForSeconds(3.5f);

        textTop.GetComponent<TMP_Text>().text = "<color=#ffb790>Франклин: </color>";

        rt = textTop.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(275, -268);

        GameUtils.Instance.FadeIn(textTop, 0.1f);

        textTop.GetComponent<TextTyper>().StartTyping("Что ж, больше не получится \nжить с самим собой...\n");

        yield return new WaitForSeconds(1.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textTop.GetComponent<TMP_Text>().text = "<color=#ffb790>Франклин: </color>";

        textTop.GetComponent<TextTyper>().StartTyping("Мне нужно получше исследовать \nэтот мир, чтобы понять, \nкак я могу вернуться назад");

        yield return new WaitForSeconds(1.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //buttonBad.SetActive(true);
        //buttonGood.SetActive(true);

        //yield return new WaitForSeconds(2f);

        //GameUtils.Instance.FadeIn(buttonGood, 1f);
        //GameUtils.Instance.FadeIn(buttonBad, 1f);

        //yield return new WaitForSeconds(0.5f);

        rt = textBottom.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(300, -715);

        //textBottom.GetComponent<TMP_Text>().text = "Примечание: Выбор не повлияет на то, что Франклин\n      в глубине души всё равно немного боится тапков и колы.";

        //textBottom.GetComponent<TMP_Text>().fontSize = 64;

        //GameUtils.Instance.FadeTo(textBottom, 1f, 0.85f);

        StartCoroutine(ChoosedCharacter());

    }

    //public void pickGood()
    //{
    //    GameData.character = true;
    //    StartCoroutine(ChoosedCharacter());
    //}
    //public void pickBad()
    //{
    //    GameData.character = false;
    //    StartCoroutine(ChoosedCharacter());
    //}

    IEnumerator ChoosedCharacter()
    {
        //GameUtils.Instance.FadeOut(buttonGood, 1f);
        //GameUtils.Instance.FadeOut(buttonBad, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);
        GameUtils.Instance.FadeOut(textTop, 1f);

        GameUtils.Instance.FadeTo(blackScreen, 1f, 0.35f);

        yield return new WaitForSeconds(1f);

        //yield return new WaitForSeconds(1f);

        RectTransform rt = textBottom.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(-58, -848);
        textBottom.GetComponent<TMP_Text>().fontSize = 100;

        rt = textTop.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(-76, 0);

        //textTop.GetComponent<TMP_Text>().text = "\n\n\n<color=#ffb790>Франклин: </color>";

        //GameUtils.Instance.FadeIn(textTop, 0.5f);
        //yield return new WaitForSeconds(0.5f);

        textBottom.GetComponent<TMP_Text>().fontSize = 100;

        //yield return new WaitForSeconds(4);

        //GameUtils.Instance.FadeTo(hint, 1f, 0.75f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(hint, 0.5f);

        //GameUtils.Instance.FadeOut(textTop, 1f);

        //yield return new WaitForSeconds(1.5f);

        spiderBar.SetActive(true);

        GameUtils.Instance.FadeTo(blackScreen, 1f, 0.35f);
        GameUtils.Instance.FadeOut(spiderBarBlurred, 1f);

        yield return new WaitForSeconds(1f);

        spiderBarBlurred.SetActive(false);

        rt = textMiddle.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(-76, -77);

        textTop.GetComponent<TMP_Text>().text = "Немного порассуждав, Франклин вошёл внутрь. \nЕго встретила довольно приятная атмосфера. \nИнтерьер помещения был... необычный";
        textMiddle.GetComponent<TMP_Text>().text = "Все было не под него, но оно и понятно.\nПауки всегда жили на чердаке, редко их можно было встретить тут.. \"внизу\".";
        textBottom.GetComponent<TMP_Text>().text = "Он прошел чуть дальше и увидел, что за разными столиками сидят <b>три разные мухи</b>.";

        GameUtils.Instance.FadeIn(textTop, 2f);

        yield return new WaitForSeconds(3f);

        GameUtils.Instance.FadeIn(textMiddle, 2f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 2f);
        GameUtils.Instance.FadeOut(textMiddle, 2f);

        GameUtils.Instance.FadeIn(muhiBar, 2f);

        GameUtils.Instance.FadeIn(textBottom, 2f);

        yield return new WaitForSeconds(4f);

        //hint.GetComponent<TMP_Text>().text = "(Space - продолжить)";

        //GameUtils.Instance.FadeTo(hint, 1f, 0.25f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(hint, 0.5f);
        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);
        GameUtils.Instance.FadeOut(blackScreen, 1f);

        buttonDzun.SetActive(true);
        buttonMary.SetActive(true);
        buttonLin.SetActive(true);

        GameUtils.Instance.FadeIn(buttonDzun, 0.8f);
        GameUtils.Instance.FadeIn(buttonMary, 0.8f);
        GameUtils.Instance.FadeIn(buttonLin, 0.8f);

        yield return new WaitUntil(() => GameData.muha != -1);
        //buttonDzun.SetActive(false);
        //buttonMary.SetActive(false);
        //buttonLin.SetActive(false);

        GameUtils.Instance.FadeOut(buttonDzun, 0.8f);
        GameUtils.Instance.FadeOut(buttonMary, 0.8f);
        GameUtils.Instance.FadeOut(buttonLin, 0.8f);

        GameUtils.Instance.FadeIn(blackScreen, 1f);

        yield return new WaitForSeconds(1.2f);

        SceneManager.LoadScene("Muha");
    }

    public void ChooseMary()
    {
        GameData.muha = 1;
    }
    public void ChooseDzun()
    {
        GameData.muha = 2;
    }
    public void ChooseLin()
    {
        GameData.muha = 3;
    }


}
