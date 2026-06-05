using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HolodosScript : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject textTop;
    [SerializeField] private GameObject textMiddle;
    [SerializeField] private GameObject textBottom;
    [SerializeField] private GameObject dialogueBar;
    [SerializeField] private GameObject textDialogue;
    [SerializeField] private GameObject characterLeft;
    [SerializeField] private GameObject characterRight;
    [SerializeField] private GameObject buttonGood;
    [SerializeField] private GameObject buttonBad;
    [SerializeField] private GameObject muhaImage;
    [SerializeField] private GameObject backgroundImage;
    [SerializeField] private GameObject franklinImage;
    [SerializeField] private Texture2D[] franklinTextures;
    [SerializeField] private Texture2D[] maryTextures;


    [SerializeField] private Texture2D[] backgrounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonGood.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() =>
        {
            GameUtils.Instance.beGood();
        });

        buttonBad.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() =>
        {
            GameUtils.Instance.beBad();
        });

        StartCoroutine(EntrySequence());
    }


    IEnumerator EntrySequence()
    {
        textTop.GetComponent<TMP_Text>().text = "За холодильником было тихое тёплое место.";

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nСтарый чек и три засохших крошки - в мире насекомых монументальные булыжники.";

        textBottom.GetComponent<TMP_Text>().text = "\n\nФранклин сел. Вытянул перевязанную лапку. Выдохнул.";

        GameUtils.Instance.FadeIn(textTop, 1f);

        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);
        GameUtils.Instance.FadeOut(blackScreen, 1f);

        if (GameData.muha == 0) GameData.muha = 1;

        if (GameData.muha == 1)
        {
            StartCoroutine(PlayMarySequence());
        }
        else if (GameData.muha == 2)
        {
            StartCoroutine(PlayDzunSequence());
        }
        else
        {
            StartCoroutine(PlayLinSequence());
        }

        //StartCoroutine(PlayMarySequence());
    }
    IEnumerator PlayMarySequence()
    {
        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        yield return new WaitForSeconds(0.75f);

        characterLeft.GetComponent<RawImage>().texture = franklinTextures[0];

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ой. Тут грязно.");

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мы под холодильником.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я понимаю, где мы. Просто констатирую факт.      \nЯ выросла в другом месте.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);


        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Где же?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);


        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("...");

        yield return new WaitForSeconds(2f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        textDialogue.GetComponent<TextTyper>().StartTyping("В кофейне. ");

        yield return new WaitForSeconds(1f);

        textDialogue.GetComponent<TextTyper>().StartTyping(" Элитной.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        textDialogue.GetComponent<TextTyper>().StartTyping("Пахло кардамоном. Никогда не было пыли.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты там живёшь?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n<i>";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Жила.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(characterRight, 0.5f);
        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(textDialogue, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "\n</i>Холодильник гудел. Мари смотрела на засохшие крошки, будто они её чем-то обидели.\r\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(2.75f);

        GameUtils.Instance.FadeOut(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n<i><color=#a1a1a1>";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("[Жила. Она не живёт там больше. Почему - я не спросил. Может, не надо. Может, на...");

        GameUtils.Instance.FadeIn(characterLeft, 0.5f);

        yield return new WaitForSeconds(4.3f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Знаешь, я бы сейчас выпила раф.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);


        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мы под холодильником");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я понимаю, где мы. Просто говорю.");

        yield return new WaitForSeconds(2.5f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты умеешь варить кофе?");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);


        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Нет.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Жаль.");

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping(" Обычно, когда я с кем-то... мне делают раф.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(characterLeft, 0.75f);
        //GameUtils.Instance.FadeOut(characterRight, 0.75f);
        GameUtils.Instance.FadeOut(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);


        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\nМы же найдём покушать?";

        buttonGood.GetComponentInChildren<TMP_Text>().text = "Найдём что-нибудь";
        buttonBad.GetComponentInChildren<TMP_Text>().text = "Рафа не будет";

        buttonBad.GetComponent<UnityEngine.UI.Button>().interactable = true;
        buttonGood.GetComponent<UnityEngine.UI.Button>().interactable = true;

        buttonGood.SetActive(true);
        buttonBad.SetActive(true);

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.FadeIn(buttonBad, 0.5f);
        GameUtils.Instance.FadeIn(buttonGood, 0.5f);

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => GameData.lastChoice != 0);

        buttonBad.GetComponent<UnityEngine.UI.Button>().interactable = false;
        buttonGood.GetComponent<UnityEngine.UI.Button>().interactable = false;

        GameUtils.Instance.FadeOut(buttonBad, 0.5f);
        GameUtils.Instance.FadeOut(buttonGood, 0.5f);
        GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        buttonGood.SetActive(false);
        buttonBad.SetActive(false);

        yield return new WaitForSeconds(1f);

        if (GameData.lastChoice == 1)
        {
            StartCoroutine(BeGoodMary());
        }
        else
        {
            StartCoroutine(BeBadMary());
        }
    }

    IEnumerator BeGoodMary()
    {
        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterLeft, 0.75f);
        GameUtils.Instance.FadeIn(characterRight, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Когда доберёмся до чердака - найдём что-нибудь вкусное. У меня там есть запасы.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Правда? На твоём чердаке есть запасы?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);


        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ну, немного. На крайний случай.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты такой добрый, Франклин. Как мне повезло.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textDialogue, 1f);
        GameUtils.Instance.FadeOut(dialogueBar, 1f);
        GameUtils.Instance.FadeOut(characterRight, 1f);
        GameUtils.Instance.FadeOut(characterLeft, 1f);

        yield return new WaitForSeconds(1.1f);

        StartCoroutine(RoomEntry());

    }

    IEnumerator BeBadMary()
    {
        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterLeft, 0.75f);
        GameUtils.Instance.FadeIn(characterRight, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мари, мы не в галерее. Никакого рафа не будет.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты прав. Ты всегда прав. Просто... я думала, можно поговорить. Как... друзья?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мы и говорим.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты говоришь, а я слушаю. Это разные вещи.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Всё равно. Нам нужно двигаться к лестинце. Ты же здесь для этого, не так ли?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeIn(blackScreen, 1f);
        GameUtils.Instance.FadeOut(textDialogue, 1f);
        GameUtils.Instance.FadeOut(dialogueBar, 1f);
        GameUtils.Instance.FadeOut(characterRight, 1f);
        GameUtils.Instance.FadeOut(characterLeft, 1f);

        yield return new WaitForSeconds(1.1f);

        //Тут игра с паутинкой (Наверное)

        StartCoroutine(RoomEntry());
    }

    IEnumerator RoomEntry()
    {



        textTop.GetComponent<TMP_Text>().text = "Путь к чердачному лазу лежал через гостиную.";

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nДекоративная деревянная полка с газетами у стены - для маленького паука - лифт до потолка.";

        textBottom.GetComponent<TMP_Text>().text = "\n\nПрямо под ней сидел человек. С газетой в руке, и теми самыми тапками на ногах";

        GameUtils.Instance.FadeIn(textTop, 1f);

        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);

        if (GameData.muha == 1)
        {
            StartCoroutine(RoomMary());
        }
        else if (GameData.muha == 2)
        {
            StartCoroutine(RoomDzun());
        }
        else
        {
            StartCoroutine(RoomLin());
        }
    }

    IEnumerator RoomMary()
    {
        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        backgroundImage.GetComponent<RawImage>().texture = backgrounds[0];

        GameUtils.Instance.FadeIn(characterLeft, 0.75f);
        GameUtils.Instance.FadeIn(characterRight, 0.75f);
        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);
        GameUtils.Instance.FadeOut(blackScreen, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Вон там. Лестница.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Но там человек.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Можно пустить паутину к той полке, и перелететь. Быстро. Он не заметит");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Та полка в метре от человека. Если газета зашелестит... От меня ничего не останется!");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(4.5f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Пройдём по стене. Будет не быстро - из-за лапки, но это безопасно.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Нет, так он точно заметит!");

        yield return new WaitForSeconds(1.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("А полка выглядит достаточно надёжно. Франклин, нужно попробовать!");

        yield return new WaitForSeconds(1.75f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textDialogue, 0.75f);
        GameUtils.Instance.FadeOut(characterRight, 0.75f);
        GameUtils.Instance.FadeOut(characterLeft, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "\n<i> Пауку ничего не оставалось, кроме как согласиться со своей настойчивой спутницей.";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(3f);
        
        GameUtils.Instance.FadeOut(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);
        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);
        GameUtils.Instance.FadeIn(characterLeft, 0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ну хорошо, я доверюсь тебе.    \n Давай попробуем");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.FadeOut(textDialogue, 0.75f);
        GameUtils.Instance.FadeOut(characterRight, 0.75f);
        GameUtils.Instance.FadeOut(dialogueBar, 0.75f);
        GameUtils.Instance.FadeOut(characterLeft, 0.75f);

        // Тут должна быть картика

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\n\n\nФранклин пустил паутину в сторону полки";

        textBottom.GetComponent<TMP_Text>().text = "\n\n\nКонец паутины ухватился за слегка свисающую стопку газет.";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);

        yield return new WaitForSeconds(1f);

        textTop.GetComponent<TMP_Text>().text = "Франклин уверенно потянул за неё, легка выпрыгнув вверх, и устремился к дыре в потолке над полкой.";

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\n\n\n\n\n\nНо после полсекунды управляемого полёта, газета шелестнула...";

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\n\n\nи полетела вниз, потянув за собой паучка.";

        GameUtils.Instance.FadeIn(textTop, 1f);
        GameUtils.Instance.FadeOut(backgroundImage, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        backgroundImage.GetComponent<RawImage>().texture = backgrounds[2];

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(backgroundImage, 1f);
        GameUtils.Instance.FadeOut(franklinImage, 1f);
        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);
        GameUtils.Instance.FadeOut(textTop, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);
        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);
        GameUtils.Instance.FadeIn(characterLeft, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Не такая уж и надёжная!");

        yield return new WaitForSeconds(1.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Хи-хи..");

        yield return new WaitForSeconds(2f);

        GameUtils.Instance.FadeOut(textDialogue, 0.75f);
        GameUtils.Instance.FadeIn(blackScreen, 0.75f);
        GameUtils.Instance.FadeOut(dialogueBar, 0.75f);
        GameUtils.Instance.FadeOut(characterLeft, 0.75f);

        yield return new WaitForSeconds(1f);

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\n\n\nСпустя пару секунд уже менее управляемого полёта, вместе с газетой, франклин очутился на полу";

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\nПод пристальным взглядом человека, и ровно в зоне поражения его газеты.";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);
        GameUtils.Instance.FadeIn(blackScreen, 1f);

        //Запуск игры Бегать второй раз

        // Дальше Лестница
        SceneManager.LoadScene("Ladder"); //!! Это долджно быть только после игры

    }
    IEnumerator RoomDzun()
    {
        yield return new WaitForSeconds(0.75f);
    }
    IEnumerator RoomLin()
    {
        yield return new WaitForSeconds(0.75f);
    }

    IEnumerator PlayDzunSequence()
    {
        yield return new WaitForSeconds(1f);
    }

    IEnumerator PlayLinSequence()
    {
        yield return new WaitForSeconds(1f);
    }
}
