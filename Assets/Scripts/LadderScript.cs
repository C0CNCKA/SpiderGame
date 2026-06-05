using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LadderScript : MonoBehaviour
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

        if (GameData.muha == 0) GameData.muha = 1;

        if (GameData.muha == 1)
        {
            StartCoroutine(LadderMary());
        }
        else if (GameData.muha == 2)
        {
            StartCoroutine(LadderDzun());
        }
        else
        {
            StartCoroutine(LadderLin());
        }

        //StartCoroutine(LadderMary());
    }

    IEnumerator LadderMary()
    {
        backgroundImage.GetComponent<RawImage>().texture = backgrounds[0];

        textTop.GetComponent<TMP_Text>().text = "Они добрались до лестницы-полки.";
         
        textMiddle.GetComponent<TMP_Text>().text = "\n\n\n\n\n\n\n\nНа одной ступени - кружка с карандашами. На другой - кактус.";
        
        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\n\n\nЧердачный лаз прямо над верхней ступенькой.";

        GameUtils.Instance.FadeIn(textTop, 1f);

        yield return new WaitForSeconds(1f);

        GameUtils.Instance.FadeOut(blackScreen, 3f);

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2f);

        GameUtils.Instance.FadeOut(blackScreen, 0f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);

        yield return new WaitForSeconds(1f);

        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        yield return new WaitForSeconds(0.75f);

        characterLeft.GetComponent<RawImage>().texture = franklinTextures[0];

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Вот он.");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("О. Чердак. Там пыльно, наверное...   \nНикогда не поднималась на чердак.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Зато там мой дом.");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Хорошо. Когда есть дом...");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n<i><color=#a1a1a1>";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeOut(characterRight, 0.5f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("[У неё нет дома? Галерея - временное.");

        yield return new WaitForSeconds(2.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping(" Она идёт на чердак не потому что хочет помочь мне. Ей просто больше некуда.]");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TMP_Text>().text = "</i><color=#ffb790>        Франклин:</color>\n<i><color=#a1a1a1>";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("[Это не она мне помогает - это я ей.");

        yield return new WaitForSeconds(2.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping(" ...Только сейчас понял?]");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textDialogue, 0.5f);
        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(characterRight, 0.5f);

        yield return new WaitForSeconds(0.6f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "\nОни начали подниматься. Мари перелетала со ступени на ступень. Франклин - медленно, нога за ногой.";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);
        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(characterRight, 0.5f);

        yield return new WaitForSeconds(2.75f);

        GameUtils.Instance.FadeOut(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты жутко медленный.");

        GameUtils.Instance.FadeIn(characterLeft, 0.5f);

        yield return new WaitForSeconds(2f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Лапка.\n");

        yield return new WaitForSeconds(1f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Она всё ещё болит.");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я знаю. Просто не повторяй это десять раз подряд.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);


        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n<i><color=#a1a1a1>";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("[Ну а какого ответа она ещё ожидала..]");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textBottom.GetComponent<TMP_Text>().text = "";

        GameUtils.Instance.FadeOut(dialogueBar, 0.75f);
        GameUtils.Instance.FadeIn(blackScreen, 1f);
        GameUtils.Instance.FadeOut(textDialogue, 0.75f);
        GameUtils.Instance.FadeOut(characterLeft, 0.75f);
        GameUtils.Instance.FadeOut(characterRight, 0.75f);

        yield return new WaitForSeconds(1f);

        StartCoroutine(FinalMary());

    }

    IEnumerator LadderDzun()
    {
        yield return new WaitForSeconds(0.75f);
    }

    IEnumerator LadderLin()
    {
        yield return new WaitForSeconds(0.75f);
    }
    IEnumerator FinalMary() {
        textMiddle.GetComponent<TMP_Text>().text = "Франклин поднимался по лестнице,\nведущей на чердак";

        textMiddle.GetComponent<TMP_Text>().fontSize = 120;

        GameUtils.Instance.FadeIn(textMiddle, 1f);
         
        yield return new WaitForSeconds(3f);

        GameUtils.Instance.FadeOut(textMiddle, 1f);

        yield return new WaitForSeconds(1.2f);

        

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nВот и всё. История подощла к концу";

        textBottom.GetComponent<TMP_Text>().text = "\n\n\nПаучок, найдя спутника, вернулся домой.";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);

        yield return new WaitForSeconds(1f);

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nНо мысль не давала покоя";

        GameUtils.Instance.FadeIn(textMiddle, 1f);
         
        yield return new WaitForSeconds(2f);

        GameUtils.Instance.FadeOut(textMiddle, 1f);

        yield return new WaitForSeconds(1f);

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nОн остановился, повернулся к Мари.";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(2f);

        GameUtils.Instance.FadeOut(textMiddle, 0.75f);

        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        yield return new WaitForSeconds(0.75f);

        textMiddle.GetComponent<TMP_Text>().fontSize = 80;

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        backgroundImage.GetComponent<RawImage>().texture = backgrounds[1];

        //characterLeft.GetComponent<RawImage>().texture = franklinTextures[0];

        GameUtils.Instance.FadeOut(blackScreen, 1f);

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мари. Ты идёшь на чердак не потому что хотела мне помочь.");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        //GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Галерея. ");

        yield return new WaitForSeconds(1.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Тебя выгоняют. Я прав?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты умнее, чем выглядишь.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Спасибо.. Наверное");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я знаю, что ты не та, за кого себя выдаёшь. Знаю, что полка была не случайностью, и что ты пользуешься мной.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(characterRight, 0.5f);
        GameUtils.Instance.FadeOut(textDialogue, 0.5f);
        GameUtils.Instance.FadeOut(dialogueBar, 0.75f);
        GameUtils.Instance.FadeIn(blackScreen, 1f);

        yield return new WaitForSeconds(1f);

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nМари открыла рот, хотела что-то сказать в ответ";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(2f);

        textBottom.GetComponent<TMP_Text>().text = "\n\nНо внимание Франклина резко сместилось с неё на шаги.. Быстро приближающиеся шаги.";

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(0.75f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textMiddle, 0.75f);

        yield return new WaitForSeconds(0.7f);

        GameUtils.Instance.FadeOut(textBottom, 0.75f);

        yield return new WaitForSeconds(0.75f);

        if (GameData.karma >= 1)
        {
            StartCoroutine(Positive());
        }
        else
        {
            StartCoroutine(Negative());
        }
    }

    IEnumerator Positive()
    {
        GameData.final = 1;

        //textMiddle.GetComponent<TMP_Text>().color = new Color(227, 255, 227);

        textMiddle.GetComponent<TMP_Text>().text = "<color=#e2ffe2>\n\n\nКак бы не повернулась судьба, Франклину не всё равно на других, даже когда ситуация требует иного поступка";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textMiddle, 0.75f);

        yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.FadeIn(characterLeft, 0.5f);
        GameUtils.Instance.FadeIn(characterRight, 0.5f);

        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Лезь первой, я прикрою!");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты точно идиот, Франклин");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        yield return new WaitForSeconds(0.5f);

        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(characterRight, 0.5f);
        GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.5f);

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\nМари долго стояла и смотрела на него. ";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1f);

        textBottom.GetComponent<TMP_Text>().text = "\n\n\nДостаточно долго, чтобы шаги приблизились опасно близко..";

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textBottom, 0.75f);
        GameUtils.Instance.FadeOut(textMiddle, 0.75f);

        yield return new WaitForSeconds(1.75f);

        //Запускаем игру Бегать
        SceneManager.LoadScene("Final"); //!! Это долджно быть только после игры
    }

    IEnumerator Negative()
    {
        GameData.final = -1;


        //textMiddle.GetComponent<TMP_Text>().color = new Color(255, 227, 227);

        textMiddle.GetComponent<TMP_Text>().text = "<color=#ffe2e2>\n\n\nДля Франклина ответы отказались нужнее, чем спасение чей-то жизни";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textMiddle, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textMiddle.GetComponent<TMP_Text>().color = Color.white;

        GameUtils.Instance.FadeIn(characterLeft, 0.5f);
        GameUtils.Instance.FadeIn(characterRight, 0.5f);
        GameUtils.Instance.FadeOut(blackScreen, 0.75f);
        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Сначала ответь.");

        yield return new WaitForSeconds(1.5f);
        
        textDialogue.GetComponent<TextTyper>().StartTyping(" Ты уговаривала меня забраться на полку, намерено?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("А если да?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Тогда ты Лезешь первой.");

        yield return new WaitForSeconds(1.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мне не нужно, чтобы ты была за спиной.");

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты боишься, что предам.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Уже предала.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textMiddle.GetComponent<TMP_Text>().text = "\n\n\n";

        //GameUtils.Instance.FadeIn(textMiddle, 1f);

        //yield return new WaitForSeconds(1f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(textMiddle, 0.75f);

        //yield return new WaitForSeconds(0.75f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я думала - не доберёшься, найду другой путь. Одна.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Почему тогда ты всё равно со мной?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я не умею по другому");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Лезь. Потом поговорим.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //Запускаем игру Бегать

        SceneManager.LoadScene("Final"); //!! Это долджно быть только после игры
    }
}
